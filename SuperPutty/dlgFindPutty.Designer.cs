namespace SuperPutty
{
    partial class dlgFindPutty
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgFindPutty));
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonBrowsePutty = new System.Windows.Forms.Button();
			this.buttonBrowsePscp = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPuttyLocation = new System.Windows.Forms.TextBox();
			this.textBoxPscpLocation = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.textBoxMinttyLocation = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonBrowseMintty = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			resources.ApplyResources(this.buttonOk, "buttonOk");
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonBrowsePutty
			// 
			resources.ApplyResources(this.buttonBrowsePutty, "buttonBrowsePutty");
			this.buttonBrowsePutty.Name = "buttonBrowsePutty";
			this.buttonBrowsePutty.UseVisualStyleBackColor = true;
			this.buttonBrowsePutty.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// buttonBrowsePscp
			// 
			resources.ApplyResources(this.buttonBrowsePscp, "buttonBrowsePscp");
			this.buttonBrowsePscp.Name = "buttonBrowsePscp";
			this.buttonBrowsePscp.UseVisualStyleBackColor = true;
			this.buttonBrowsePscp.Click += new System.EventHandler(this.buttonBrowsePscp_Click);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// textBoxPuttyLocation
			// 
			resources.ApplyResources(this.textBoxPuttyLocation, "textBoxPuttyLocation");
			this.textBoxPuttyLocation.Name = "textBoxPuttyLocation";
			// 
			// textBoxPscpLocation
			// 
			resources.ApplyResources(this.textBoxPscpLocation, "textBoxPscpLocation");
			this.textBoxPscpLocation.Name = "textBoxPscpLocation";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
			// 
			// richTextBox1
			// 
			resources.ApplyResources(this.richTextBox1, "richTextBox1");
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			// 
			// textBoxMinttyLocation
			// 
			resources.ApplyResources(this.textBoxMinttyLocation, "textBoxMinttyLocation");
			this.textBoxMinttyLocation.Name = "textBoxMinttyLocation";
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// buttonBrowseMintty
			// 
			resources.ApplyResources(this.buttonBrowseMintty, "buttonBrowseMintty");
			this.buttonBrowseMintty.Name = "buttonBrowseMintty";
			this.buttonBrowseMintty.UseVisualStyleBackColor = true;
			this.buttonBrowseMintty.Click += new System.EventHandler(this.buttonBrowseMintty_Click);
			// 
			// dlgFindPutty
			// 
			this.AcceptButton = this.buttonOk;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxMinttyLocation);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonBrowseMintty);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.textBoxPscpLocation);
			this.Controls.Add(this.textBoxPuttyLocation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonBrowsePscp);
			this.Controls.Add(this.buttonBrowsePutty);
			this.Controls.Add(this.buttonOk);
			this.Name = "dlgFindPutty";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonBrowsePutty;
        private System.Windows.Forms.Button buttonBrowsePscp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPuttyLocation;
        private System.Windows.Forms.TextBox textBoxPscpLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxMinttyLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBrowseMintty;
    }
}