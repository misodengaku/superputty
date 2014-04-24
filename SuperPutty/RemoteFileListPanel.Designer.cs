namespace SuperPutty
{
    partial class RemoteFileListPanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteFileListPanel));
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderPerms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.largeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
			this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripContainer2.ContentPanel.SuspendLayout();
			this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer2.SuspendLayout();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Fuchsia;
			this.imageList2.Images.SetKeyName(0, "Open.bmp");
			this.imageList2.Images.SetKeyName(1, "File.bmp");
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "folder.png");
			this.imageList1.Images.SetKeyName(1, "page.png");
			// 
			// toolStripContainer2
			// 
			resources.ApplyResources(this.toolStripContainer2, "toolStripContainer2");
			// 
			// toolStripContainer2.BottomToolStripPanel
			// 
			resources.ApplyResources(this.toolStripContainer2.BottomToolStripPanel, "toolStripContainer2.BottomToolStripPanel");
			this.toolStripContainer2.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer2.ContentPanel
			// 
			resources.ApplyResources(this.toolStripContainer2.ContentPanel, "toolStripContainer2.ContentPanel");
			this.toolStripContainer2.ContentPanel.Controls.Add(this.toolStripContainer1);
			// 
			// toolStripContainer2.LeftToolStripPanel
			// 
			resources.ApplyResources(this.toolStripContainer2.LeftToolStripPanel, "toolStripContainer2.LeftToolStripPanel");
			this.toolStripContainer2.LeftToolStripPanelVisible = false;
			this.toolStripContainer2.Name = "toolStripContainer2";
			// 
			// toolStripContainer2.RightToolStripPanel
			// 
			resources.ApplyResources(this.toolStripContainer2.RightToolStripPanel, "toolStripContainer2.RightToolStripPanel");
			this.toolStripContainer2.RightToolStripPanelVisible = false;
			// 
			// toolStripContainer2.TopToolStripPanel
			// 
			resources.ApplyResources(this.toolStripContainer2.TopToolStripPanel, "toolStripContainer2.TopToolStripPanel");
			this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip1);
			// 
			// toolStripContainer1
			// 
			resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			resources.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
			this.toolStripContainer1.ContentPanel.Controls.Add(this.listView1);
			// 
			// toolStripContainer1.LeftToolStripPanel
			// 
			resources.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
			this.toolStripContainer1.LeftToolStripPanelVisible = false;
			this.toolStripContainer1.Name = "toolStripContainer1";
			// 
			// toolStripContainer1.RightToolStripPanel
			// 
			resources.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
			// 
			// listView1
			// 
			resources.ApplyResources(this.listView1, "listView1");
			this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listView1.AllowColumnReorder = true;
			this.listView1.AllowDrop = true;
			this.listView1.AutoArrange = false;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderDate,
            this.columnHeaderSize,
            this.columnHeaderOwner,
            this.columnHeaderGroup,
            this.columnHeaderPerms});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.LargeImageList = this.imageList2;
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.Click += new System.EventHandler(this.listView1_DoubleClick);
			this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
			this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
			this.listView1.DragOver += new System.Windows.Forms.DragEventHandler(this.listView1_DragOver);
			this.listView1.DragLeave += new System.EventHandler(this.listView1_DragLeave);
			this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
			this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
			// 
			// columnHeaderName
			// 
			resources.ApplyResources(this.columnHeaderName, "columnHeaderName");
			// 
			// columnHeaderDate
			// 
			resources.ApplyResources(this.columnHeaderDate, "columnHeaderDate");
			// 
			// columnHeaderSize
			// 
			resources.ApplyResources(this.columnHeaderSize, "columnHeaderSize");
			// 
			// columnHeaderOwner
			// 
			resources.ApplyResources(this.columnHeaderOwner, "columnHeaderOwner");
			// 
			// columnHeaderGroup
			// 
			resources.ApplyResources(this.columnHeaderGroup, "columnHeaderGroup");
			// 
			// columnHeaderPerms
			// 
			resources.ApplyResources(this.columnHeaderPerms, "columnHeaderPerms");
			// 
			// toolStrip1
			// 
			resources.ApplyResources(this.toolStrip1, "toolStrip1");
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripButton1});
			this.toolStrip1.Name = "toolStrip1";
			// 
			// toolStripSplitButton1
			// 
			resources.ApplyResources(this.toolStripSplitButton1, "toolStripSplitButton1");
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.largeIconsToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.listToolStripMenuItem});
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			// 
			// detailsToolStripMenuItem
			// 
			resources.ApplyResources(this.detailsToolStripMenuItem, "detailsToolStripMenuItem");
			this.detailsToolStripMenuItem.Checked = true;
			this.detailsToolStripMenuItem.CheckOnClick = true;
			this.detailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
			this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
			// 
			// smallIconsToolStripMenuItem
			// 
			resources.ApplyResources(this.smallIconsToolStripMenuItem, "smallIconsToolStripMenuItem");
			this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
			this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
			// 
			// largeIconsToolStripMenuItem
			// 
			resources.ApplyResources(this.largeIconsToolStripMenuItem, "largeIconsToolStripMenuItem");
			this.largeIconsToolStripMenuItem.Name = "largeIconsToolStripMenuItem";
			this.largeIconsToolStripMenuItem.Click += new System.EventHandler(this.largeIconsToolStripMenuItem_Click);
			// 
			// tileToolStripMenuItem
			// 
			resources.ApplyResources(this.tileToolStripMenuItem, "tileToolStripMenuItem");
			this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
			this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
			// 
			// listToolStripMenuItem
			// 
			resources.ApplyResources(this.listToolStripMenuItem, "listToolStripMenuItem");
			this.listToolStripMenuItem.Name = "listToolStripMenuItem";
			this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
			// 
			// toolStripSplitButton2
			// 
			resources.ApplyResources(this.toolStripSplitButton2, "toolStripSplitButton2");
			this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.nameToolStripMenuItem,
            this.sizeToolStripMenuItem,
            this.dateToolStripMenuItem});
			this.toolStripSplitButton2.Name = "toolStripSplitButton2";
			// 
			// typeToolStripMenuItem
			// 
			resources.ApplyResources(this.typeToolStripMenuItem, "typeToolStripMenuItem");
			this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
			// 
			// nameToolStripMenuItem
			// 
			resources.ApplyResources(this.nameToolStripMenuItem, "nameToolStripMenuItem");
			this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
			// 
			// sizeToolStripMenuItem
			// 
			resources.ApplyResources(this.sizeToolStripMenuItem, "sizeToolStripMenuItem");
			this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
			// 
			// dateToolStripMenuItem
			// 
			resources.ApplyResources(this.dateToolStripMenuItem, "dateToolStripMenuItem");
			this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
			// 
			// toolStripButton1
			// 
			resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// RemoteFileListPanel
			// 
			resources.ApplyResources(this, "$this");
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolStripContainer2);
			this.Name = "RemoteFileListPanel";
			this.TabText = "Remote File Listing";
			this.toolStripContainer2.ContentPanel.ResumeLayout(false);
			this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer2.TopToolStripPanel.PerformLayout();
			this.toolStripContainer2.ResumeLayout(false);
			this.toolStripContainer2.PerformLayout();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderOwner;
        private System.Windows.Forms.ColumnHeader columnHeaderGroup;
        private System.Windows.Forms.ColumnHeader columnHeaderPerms;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}