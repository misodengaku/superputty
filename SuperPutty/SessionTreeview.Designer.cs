namespace SuperPutty
{
    partial class SessionTreeview
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionTreeview));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.contextMenuStripAddTreeItem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.fileBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.contextMenuStripAddTreeItem.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			resources.ApplyResources(this.treeView1, "treeView1");
			this.treeView1.AllowDrop = true;
			this.treeView1.ContextMenuStrip = this.contextMenuStripAddTreeItem;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.Name = "treeView1";
			this.treeView1.ShowLines = false;
			this.treeView1.ShowPlusMinus = false;
			this.treeView1.ShowRootLines = false;
			this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
			// 
			// contextMenuStripAddTreeItem
			// 
			resources.ApplyResources(this.contextMenuStripAddTreeItem, "contextMenuStripAddTreeItem");
			this.contextMenuStripAddTreeItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.connectToolStripMenuItem,
            this.toolStripSeparator2,
            this.fileBrowserToolStripMenuItem});
			this.contextMenuStripAddTreeItem.Name = "contextMenuStripAddTreeItem";
			this.contextMenuStripAddTreeItem.ShowImageMargin = false;
			// 
			// newSessionToolStripMenuItem
			// 
			resources.ApplyResources(this.newSessionToolStripMenuItem, "newSessionToolStripMenuItem");
			this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
			this.newSessionToolStripMenuItem.Click += new System.EventHandler(this.CreateOrEditSessionToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.CreateOrEditSessionToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			// 
			// connectToolStripMenuItem
			// 
			resources.ApplyResources(this.connectToolStripMenuItem, "connectToolStripMenuItem");
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			// 
			// fileBrowserToolStripMenuItem
			// 
			resources.ApplyResources(this.fileBrowserToolStripMenuItem, "fileBrowserToolStripMenuItem");
			this.fileBrowserToolStripMenuItem.Name = "fileBrowserToolStripMenuItem";
			this.fileBrowserToolStripMenuItem.Click += new System.EventHandler(this.fileBrowserToolStripMenuItem_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "folder.png");
			this.imageList1.Images.SetKeyName(1, "computer.png");
			// 
			// SessionTreeview
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.treeView1);
			this.Name = "SessionTreeview";
			this.ShowIcon = false;
			this.TabText = "Sessions";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SessionTreeviewFormClosed);
			this.contextMenuStripAddTreeItem.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAddTreeItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fileBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}