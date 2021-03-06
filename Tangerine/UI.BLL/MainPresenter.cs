﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Aga.Controls.Tree;
using Mono.Cecil;
using Tangerine.BLL;
using Tangerine.BLL.Hooks;
using Tangerine.BLL.Tasks;
using Tangerine.Common;
using Tangerine.Devices;
using Tangerine.Properties;

namespace Tangerine.UI.BLL
{
    internal class MainPresenter
    {
        private readonly IMainView m_view;

        private XAP m_xap;
        private List<MethodHook> m_hooks;
        private AssemblyTreeModel m_treeModel;

        internal MainPresenter(IMainView view)
        {
            m_view = view;
        }

        internal void LoadApplication(string path)
        {
            Cleanup();

            m_xap = new XAP(path);
            m_hooks = new List<MethodHook>();

            var context = TaskScheduler.FromCurrentSynchronizationContext();

            Task.Factory.StartNew(() => 
                {
                    m_xap.Parse();
                    foreach (var xapAssembly in m_xap.Assemblies)
                    {
                        FillAssemblyMethods(xapAssembly);
                    }
                    ResetButton("deploy");
                    m_view.SetManifestInformation(m_xap);

                    UnsubscribeTreeModelEvents();
                    m_treeModel = new AssemblyTreeModel();
                    var rootNode = new Node(m_xap.Title);
                    m_treeModel.Nodes.Add(rootNode);

                    foreach (var assembly in m_xap.Assemblies)
                    {
                        var assemblyNode = new AssemblyNode(new FileInfo(assembly.AssemblyPath).Name);
                        rootNode.Nodes.Add(assemblyNode);
                        ProcessAssemblyNodeToTree(assemblyNode, assembly);
                    }

                    m_view.SetTreeModel(m_treeModel);
                    m_view.SetExpanded(rootNode);

                    Thread.Sleep(50);

                    SubscribeTreeModelEvents();
                }
            ).ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        HandleError(t.Exception.InnerException);
                    }
                }, 
                context
            );
        }

        private void OnTreeModelStructureChanged(object sender, TreePathEventArgs e)
        {
            var rootNode = m_treeModel.Root.Nodes.ElementAt(0);
            m_view.SetExpanded(rootNode);
            if (m_treeModel.FilterIO || m_treeModel.FilterNet || m_treeModel.FilterSecurity) {
                ExpandAll(rootNode);
            }
            
        }

        private void ExpandAll(Node rootNode)
        {
            var path = m_treeModel.GetPath(rootNode);
            var children = m_treeModel.GetChildren(path);
            foreach (Node child in children) {
                m_view.SetExpanded(child);
                ExpandAll(child);
            }
        }

        private void SubscribeTreeModelEvents()
        {
            m_treeModel.StructureChanged += OnTreeModelStructureChanged;
        }

        private void UnsubscribeTreeModelEvents()
        {
            if (m_treeModel != null)
                m_treeModel.StructureChanged -= OnTreeModelStructureChanged;
        }

        private void HandleError(Exception exception)
        {
            var targetInvocationException = exception as TargetInvocationException;
            if (targetInvocationException != null)
            {
                m_view.ShowError(ExceptionHelper.GetRealExceptionWithStackTrace(targetInvocationException));
            }
            else
            {
                m_view.ShowError(exception);
            }
            m_view.ResetButton("run");
        }

        private void ProcessAssemblyNodeToTree(Node assemblyNode, XAPAssembly assembly)
        {
            foreach (TypeDefinition typeDefinition in assembly.AssemblyDefinition.MainModule.Types)
            {
                if (typeDefinition.Name.StartsWith("<Module>")
                    || typeDefinition.Name.StartsWith("<PrivateImplementationDetails>")
                    || typeDefinition.Name.StartsWith("__StaticArrayInitTypeSize"))
                {
                    continue;
                }

                var typeNode = new TypeNode(typeDefinition.Name);
                if (typeDefinition.BaseType.FullName.Equals("System.Windows.Navigation.UriMapperBase"))
                    typeNode.URIAndFileHandlerIcon = Resources.link;
                assemblyNode.Nodes.Add(typeNode);
                ProcessTypeNodeToTree(typeNode, typeDefinition);
            }
        }

        private void ProcessTypeNodeToTree(Node typeNode, TypeDefinition type)
        {
            if (type.IsEnum)
            {
                foreach (FieldDefinition enumItem in type.Fields)
                {
                    if (enumItem.IsSpecialName)
                        continue;
                    var enumItemNode = new EnumNode(enumItem.Name);
                    typeNode.Nodes.Add(enumItemNode);
                }
                return;
            }

            // constructors
            foreach (MethodDefinition ctor in type.Constructors)
            {
                var methodNode = MethodNodeFactory.CreateNode(ctor);
                typeNode.Nodes.Add(methodNode);
            }
            // properties
            foreach (PropertyDefinition property in type.Properties)
            {
                var propertyNode = PropertyNodeFactory.CreateNode(property);
                typeNode.Nodes.Add(propertyNode);
            }
            // methods
            foreach (MethodDefinition method in type.Methods)
            {
                if (!method.IsGetter && !method.IsSetter)
                {
                    var methodNode = MethodNodeFactory.CreateNode(method);
                    typeNode.Nodes.Add(methodNode);
                }
            }
        }

        private void FillAssemblyMethods(XAPAssembly xapAssembly)
        {
            foreach (var method in xapAssembly.GetMethods())
            {
                var hook = new MethodHook(method)
                {
                    LogMethodName = true,
                    LogParameterValues = true,
                    LogReturnValues = true
                };
                m_hooks.Add(hook);
            }
        }

        private void AddOutputText(string text)
        {
            m_view.AddOutputText(text);
        }

        private void ResetButton(string target)
        {
            m_view.ResetButton(target);
        }

        internal void AddMethodHook()
        {
            string selectedMethod = m_view.ShowSearchForm(m_hooks.Select(h => h.ToString()));
            if (selectedMethod != null)
            {
                MethodHook hook = m_hooks.First(h => h.ToString() == selectedMethod);
                m_view.AddMethod(hook);
            }
        }

        internal void Deploy(DeviceType device)
        {
            if (m_xap == null)
            {
                throw new InvalidOperationException("Target application is not selected.");
            }

            var hookProvider = new HookProvider(
                m_view.GetLogMethodNames(),
                m_view.GetLogParameterValues(),
                m_view.GetLogReturnValues(),
                m_view.GetHooks()
                );

            PatchTask patchTask = new PatchTask(
                m_xap,
                hookProvider,
                device,
                AddOutputText,
                ResetButton
                );

            var context = TaskScheduler.FromCurrentSynchronizationContext();

            Task.Factory.StartNew(patchTask.Run)
                .ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        HandleError(t.Exception.InnerException);
                    }
                },
                context
                );
        }

        internal void EditMethodHook()
        {
            m_view.ShowEditHookForm(m_view.GetSelectedHook());
        }

        internal void Cleanup()
        {
            if (m_xap == null)
            {
                return;
            }

            string instrumentedXAPPath = Path.Combine(m_xap.GetPath(), PatchTask.InstrumentedXAPFolder);
            if (Directory.Exists(instrumentedXAPPath))
            {
                Directory.Delete(instrumentedXAPPath, true);
            }

            string instrumentedPath = Path.Combine(m_xap.GetPath(), PatchTask.InstrumentedFilesFolder);
            if (Directory.Exists(instrumentedPath))
            {
                Directory.Delete(instrumentedPath, true);
            }
        }
    }
}
