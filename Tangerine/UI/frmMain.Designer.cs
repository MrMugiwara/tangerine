﻿namespace Tangerine.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xDEMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTargetApp = new System.Windows.Forms.Panel();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.lblTargetApp = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabStatic = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.trvAssemblies = new Aga.Controls.Tree.TreeViewAdv();
            this.nodeTextBox1 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.nodeIcon1 = new Aga.Controls.Tree.NodeControls.NodeIcon();
            this.nodeIcon2 = new Aga.Controls.Tree.NodeControls.NodeIcon();
            this.nodeIcon3 = new Aga.Controls.Tree.NodeControls.NodeIcon();
            this.pnlCapabilities = new System.Windows.Forms.Panel();
            this.tbxCapabilities = new System.Windows.Forms.TextBox();
            this.lblCapabilities = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.tabDynamic = new System.Windows.Forms.TabPage();
            this.chbLogReturnValues = new System.Windows.Forms.CheckBox();
            this.chbLogParameters = new System.Windows.Forms.CheckBox();
            this.chbLogMethods = new System.Windows.Forms.CheckBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnAddHook = new System.Windows.Forms.Button();
            this.btnEditHook = new System.Windows.Forms.Button();
            this.btnRemoveHook = new System.Windows.Forms.Button();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.lblGlobalHooks = new System.Windows.Forms.Label();
            this.lblMethodHooks = new System.Windows.Forms.Label();
            this.lbMethods = new System.Windows.Forms.ListBox();
            this.nodeIcon4 = new Aga.Controls.Tree.NodeControls.NodeIcon();
            this.menu.SuspendLayout();
            this.pnlTargetApp.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabStatic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlCapabilities.SuspendLayout();
            this.tabDynamic.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(884, 24);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExit);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xDEMonitorToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // xDEMonitorToolStripMenuItem
            // 
            this.xDEMonitorToolStripMenuItem.Name = "xDEMonitorToolStripMenuItem";
            this.xDEMonitorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.xDEMonitorToolStripMenuItem.Text = "XDE Monitor";
            this.xDEMonitorToolStripMenuItem.Click += new System.EventHandler(this.OnToolsXDEMonitor_Clicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlTargetApp
            // 
            this.pnlTargetApp.Controls.Add(this.txtFilePath);
            this.pnlTargetApp.Controls.Add(this.btnBrowseFolder);
            this.pnlTargetApp.Controls.Add(this.btnBrowseFile);
            this.pnlTargetApp.Controls.Add(this.lblTargetApp);
            this.pnlTargetApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTargetApp.Location = new System.Drawing.Point(0, 24);
            this.pnlTargetApp.Name = "pnlTargetApp";
            this.pnlTargetApp.Size = new System.Drawing.Size(884, 39);
            this.pnlTargetApp.TabIndex = 10;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilePath.Location = new System.Drawing.Point(105, 10);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(610, 20);
            this.txtFilePath.TabIndex = 16;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFolder.Location = new System.Drawing.Point(800, 8);
            this.btnBrowseFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(77, 23);
            this.btnBrowseFolder.TabIndex = 15;
            this.btnBrowseFolder.Text = "Open folder";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFile.Location = new System.Drawing.Point(719, 8);
            this.btnBrowseFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(77, 23);
            this.btnBrowseFile.TabIndex = 15;
            this.btnBrowseFile.Text = "Open XAP";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // lblTargetApp
            // 
            this.lblTargetApp.AutoSize = true;
            this.lblTargetApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetApp.Location = new System.Drawing.Point(6, 13);
            this.lblTargetApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetApp.Name = "lblTargetApp";
            this.lblTargetApp.Size = new System.Drawing.Size(95, 13);
            this.lblTargetApp.TabIndex = 14;
            this.lblTargetApp.Text = "Target application:";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabStatic);
            this.tabControlMain.Controls.Add(this.tabDynamic);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 63);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(884, 499);
            this.tabControlMain.TabIndex = 11;
            // 
            // tabStatic
            // 
            this.tabStatic.Controls.Add(this.splitContainer);
            this.tabStatic.Location = new System.Drawing.Point(4, 22);
            this.tabStatic.Name = "tabStatic";
            this.tabStatic.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatic.Size = new System.Drawing.Size(876, 473);
            this.tabStatic.TabIndex = 0;
            this.tabStatic.Text = "Static analysis";
            this.tabStatic.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.trvAssemblies);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlCapabilities);
            this.splitContainer.Panel2.Controls.Add(this.lblCapabilities);
            this.splitContainer.Panel2.Controls.Add(this.lblAuthor);
            this.splitContainer.Panel2.Controls.Add(this.lblVersion);
            this.splitContainer.Panel2.Controls.Add(this.lblTitle);
            this.splitContainer.Panel2.Controls.Add(this.lblProductId);
            this.splitContainer.Size = new System.Drawing.Size(870, 467);
            this.splitContainer.SplitterDistance = 338;
            this.splitContainer.TabIndex = 0;
            // 
            // trvAssemblies
            // 
            this.trvAssemblies.BackColor = System.Drawing.SystemColors.Window;
            this.trvAssemblies.Cursor = System.Windows.Forms.Cursors.Default;
            this.trvAssemblies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvAssemblies.DragDropMarkColor = System.Drawing.Color.Black;
            this.trvAssemblies.LineColor = System.Drawing.SystemColors.ControlDark;
            this.trvAssemblies.Location = new System.Drawing.Point(0, 0);
            this.trvAssemblies.Model = null;
            this.trvAssemblies.Name = "trvAssemblies";
            this.trvAssemblies.NodeControls.Add(this.nodeIcon4);
            this.trvAssemblies.NodeControls.Add(this.nodeTextBox1);
            this.trvAssemblies.NodeControls.Add(this.nodeIcon1);
            this.trvAssemblies.NodeControls.Add(this.nodeIcon2);
            this.trvAssemblies.NodeControls.Add(this.nodeIcon3);
            this.trvAssemblies.SelectedNode = null;
            this.trvAssemblies.Size = new System.Drawing.Size(338, 467);
            this.trvAssemblies.TabIndex = 2;
            this.trvAssemblies.Text = "treeViewAdv1";
            this.trvAssemblies.NodeMouseDoubleClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this.trvAssemblies_NodeMouseDoubleClick);
            // 
            // nodeTextBox1
            // 
            this.nodeTextBox1.DataPropertyName = "Text";
            // 
            // nodeIcon1
            // 
            this.nodeIcon1.DataPropertyName = "IOIcon";
            // 
            // nodeIcon2
            // 
            this.nodeIcon2.DataPropertyName = "NetIcon";
            // 
            // nodeIcon3
            // 
            this.nodeIcon3.DataPropertyName = "SecurityIcon";
            // 
            // pnlCapabilities
            // 
            this.pnlCapabilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCapabilities.Controls.Add(this.tbxCapabilities);
            this.pnlCapabilities.Location = new System.Drawing.Point(15, 158);
            this.pnlCapabilities.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCapabilities.Name = "pnlCapabilities";
            this.pnlCapabilities.Size = new System.Drawing.Size(509, 305);
            this.pnlCapabilities.TabIndex = 7;
            // 
            // tbxCapabilities
            // 
            this.tbxCapabilities.BackColor = System.Drawing.SystemColors.Window;
            this.tbxCapabilities.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxCapabilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCapabilities.Location = new System.Drawing.Point(0, 0);
            this.tbxCapabilities.Margin = new System.Windows.Forms.Padding(2);
            this.tbxCapabilities.Multiline = true;
            this.tbxCapabilities.Name = "tbxCapabilities";
            this.tbxCapabilities.ReadOnly = true;
            this.tbxCapabilities.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbxCapabilities.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxCapabilities.Size = new System.Drawing.Size(509, 305);
            this.tbxCapabilities.TabIndex = 15;
            // 
            // lblCapabilities
            // 
            this.lblCapabilities.AutoSize = true;
            this.lblCapabilities.Location = new System.Drawing.Point(12, 131);
            this.lblCapabilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapabilities.Name = "lblCapabilities";
            this.lblCapabilities.Size = new System.Drawing.Size(63, 13);
            this.lblCapabilities.TabIndex = 5;
            this.lblCapabilities.Text = "Capabilities:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 103);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 74);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 45);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(12, 18);
            this.lblProductId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(61, 13);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Product ID:";
            // 
            // tabDynamic
            // 
            this.tabDynamic.Controls.Add(this.chbLogReturnValues);
            this.tabDynamic.Controls.Add(this.chbLogParameters);
            this.tabDynamic.Controls.Add(this.chbLogMethods);
            this.tabDynamic.Controls.Add(this.txtOutput);
            this.tabDynamic.Controls.Add(this.btnAddHook);
            this.tabDynamic.Controls.Add(this.btnEditHook);
            this.tabDynamic.Controls.Add(this.btnRemoveHook);
            this.tabDynamic.Controls.Add(this.btnDeploy);
            this.tabDynamic.Controls.Add(this.lblGlobalHooks);
            this.tabDynamic.Controls.Add(this.lblMethodHooks);
            this.tabDynamic.Controls.Add(this.lbMethods);
            this.tabDynamic.Location = new System.Drawing.Point(4, 22);
            this.tabDynamic.Name = "tabDynamic";
            this.tabDynamic.Padding = new System.Windows.Forms.Padding(3);
            this.tabDynamic.Size = new System.Drawing.Size(876, 473);
            this.tabDynamic.TabIndex = 1;
            this.tabDynamic.Text = "Dynamic analysis";
            this.tabDynamic.UseVisualStyleBackColor = true;
            // 
            // chbLogReturnValues
            // 
            this.chbLogReturnValues.AutoSize = true;
            this.chbLogReturnValues.Enabled = false;
            this.chbLogReturnValues.Location = new System.Drawing.Point(8, 63);
            this.chbLogReturnValues.Margin = new System.Windows.Forms.Padding(2);
            this.chbLogReturnValues.Name = "chbLogReturnValues";
            this.chbLogReturnValues.Size = new System.Drawing.Size(107, 17);
            this.chbLogReturnValues.TabIndex = 24;
            this.chbLogReturnValues.Text = "Log return values";
            this.chbLogReturnValues.UseVisualStyleBackColor = true;
            // 
            // chbLogParameters
            // 
            this.chbLogParameters.AutoSize = true;
            this.chbLogParameters.Enabled = false;
            this.chbLogParameters.Location = new System.Drawing.Point(8, 42);
            this.chbLogParameters.Margin = new System.Windows.Forms.Padding(2);
            this.chbLogParameters.Name = "chbLogParameters";
            this.chbLogParameters.Size = new System.Drawing.Size(127, 17);
            this.chbLogParameters.TabIndex = 24;
            this.chbLogParameters.Text = "Log parameter values";
            this.chbLogParameters.UseVisualStyleBackColor = true;
            // 
            // chbLogMethods
            // 
            this.chbLogMethods.AutoSize = true;
            this.chbLogMethods.Location = new System.Drawing.Point(8, 21);
            this.chbLogMethods.Margin = new System.Windows.Forms.Padding(2);
            this.chbLogMethods.Name = "chbLogMethods";
            this.chbLogMethods.Size = new System.Drawing.Size(115, 17);
            this.chbLogMethods.TabIndex = 23;
            this.chbLogMethods.Text = "Log method names";
            this.chbLogMethods.UseVisualStyleBackColor = true;
            this.chbLogMethods.CheckedChanged += new System.EventHandler(this.chbLogMethods_CheckedChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOutput.Location = new System.Drawing.Point(5, 182);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(868, 256);
            this.txtOutput.TabIndex = 14;
            // 
            // btnAddHook
            // 
            this.btnAddHook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddHook.Enabled = false;
            this.btnAddHook.Location = new System.Drawing.Point(668, 144);
            this.btnAddHook.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddHook.Name = "btnAddHook";
            this.btnAddHook.Size = new System.Drawing.Size(66, 23);
            this.btnAddHook.TabIndex = 16;
            this.btnAddHook.Text = "Add...";
            this.btnAddHook.UseVisualStyleBackColor = true;
            this.btnAddHook.Click += new System.EventHandler(this.btnAddMethod_Click);
            // 
            // btnEditHook
            // 
            this.btnEditHook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditHook.Enabled = false;
            this.btnEditHook.Location = new System.Drawing.Point(736, 144);
            this.btnEditHook.Margin = new System.Windows.Forms.Padding(1);
            this.btnEditHook.Name = "btnEditHook";
            this.btnEditHook.Size = new System.Drawing.Size(66, 23);
            this.btnEditHook.TabIndex = 16;
            this.btnEditHook.Text = "Edit...";
            this.btnEditHook.UseVisualStyleBackColor = true;
            this.btnEditHook.Click += new System.EventHandler(this.btnEditHook_Click);
            // 
            // btnRemoveHook
            // 
            this.btnRemoveHook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveHook.Enabled = false;
            this.btnRemoveHook.Location = new System.Drawing.Point(804, 144);
            this.btnRemoveHook.Margin = new System.Windows.Forms.Padding(1);
            this.btnRemoveHook.Name = "btnRemoveHook";
            this.btnRemoveHook.Size = new System.Drawing.Size(66, 23);
            this.btnRemoveHook.TabIndex = 17;
            this.btnRemoveHook.Text = "Remove";
            this.btnRemoveHook.UseVisualStyleBackColor = true;
            this.btnRemoveHook.Click += new System.EventHandler(this.btnRemoveHook_Click);
            // 
            // btnDeploy
            // 
            this.btnDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeploy.Enabled = false;
            this.btnDeploy.Location = new System.Drawing.Point(803, 443);
            this.btnDeploy.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(66, 23);
            this.btnDeploy.TabIndex = 19;
            this.btnDeploy.Text = "Deploy";
            this.btnDeploy.UseVisualStyleBackColor = true;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // lblGlobalHooks
            // 
            this.lblGlobalHooks.AutoSize = true;
            this.lblGlobalHooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlobalHooks.Location = new System.Drawing.Point(5, 4);
            this.lblGlobalHooks.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGlobalHooks.Name = "lblGlobalHooks";
            this.lblGlobalHooks.Size = new System.Drawing.Size(69, 13);
            this.lblGlobalHooks.TabIndex = 22;
            this.lblGlobalHooks.Text = "Global hooks";
            // 
            // lblMethodHooks
            // 
            this.lblMethodHooks.AutoSize = true;
            this.lblMethodHooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodHooks.Location = new System.Drawing.Point(188, 6);
            this.lblMethodHooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMethodHooks.Name = "lblMethodHooks";
            this.lblMethodHooks.Size = new System.Drawing.Size(75, 13);
            this.lblMethodHooks.TabIndex = 22;
            this.lblMethodHooks.Text = "Method hooks";
            // 
            // lbMethods
            // 
            this.lbMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMethods.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbMethods.FormattingEnabled = true;
            this.lbMethods.Location = new System.Drawing.Point(192, 21);
            this.lbMethods.Margin = new System.Windows.Forms.Padding(2);
            this.lbMethods.Name = "lbMethods";
            this.lbMethods.Size = new System.Drawing.Size(678, 121);
            this.lbMethods.TabIndex = 20;
            this.lbMethods.SelectedIndexChanged += new System.EventHandler(this.lbMethods_SelectedIndexChanged);
            // 
            // nodeIcon4
            // 
            this.nodeIcon4.DataPropertyName = "Icon";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pnlTargetApp);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tangerine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnlTargetApp.ResumeLayout(false);
            this.pnlTargetApp.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabStatic.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlCapabilities.ResumeLayout(false);
            this.pnlCapabilities.PerformLayout();
            this.tabDynamic.ResumeLayout(false);
            this.tabDynamic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xDEMonitorToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTargetApp;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label lblTargetApp;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabStatic;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabPage tabDynamic;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEditHook;
        private System.Windows.Forms.Button btnRemoveHook;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.Label lblMethodHooks;
        private System.Windows.Forms.ListBox lbMethods;
        private System.Windows.Forms.Label lblGlobalHooks;
        private System.Windows.Forms.CheckBox chbLogParameters;
        private System.Windows.Forms.CheckBox chbLogMethods;
        private System.Windows.Forms.Button btnAddHook;
        private System.Windows.Forms.Label lblCapabilities;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Panel pnlCapabilities;
        private System.Windows.Forms.TextBox tbxCapabilities;
        private Aga.Controls.Tree.TreeViewAdv trvAssemblies;
        private Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox1;
        private Aga.Controls.Tree.NodeControls.NodeIcon nodeIcon1;
        private Aga.Controls.Tree.NodeControls.NodeIcon nodeIcon2;
        private Aga.Controls.Tree.NodeControls.NodeIcon nodeIcon3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.CheckBox chbLogReturnValues;
        private Aga.Controls.Tree.NodeControls.NodeIcon nodeIcon4;

    }
}

