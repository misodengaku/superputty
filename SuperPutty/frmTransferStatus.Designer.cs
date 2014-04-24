namespace SuperPutty
{
    partial class frmTransferStatus
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferStatus));
			this.button1 = new System.Windows.Forms.Button();
			this.progressBarCurrentFile = new System.Windows.Forms.ProgressBar();
			this.progressBarOverall = new System.Windows.Forms.ProgressBar();
			this.labelCurrentFile = new System.Windows.Forms.Label();
			this.labelOverall = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.labelOverallPct = new System.Windows.Forms.Label();
			this.labelCurrentPercent = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// progressBarCurrentFile
			// 
			resources.ApplyResources(this.progressBarCurrentFile, "progressBarCurrentFile");
			this.progressBarCurrentFile.Name = "progressBarCurrentFile";
			this.progressBarCurrentFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// progressBarOverall
			// 
			resources.ApplyResources(this.progressBarOverall, "progressBarOverall");
			this.progressBarOverall.Name = "progressBarOverall";
			this.progressBarOverall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			// 
			// labelCurrentFile
			// 
			resources.ApplyResources(this.labelCurrentFile, "labelCurrentFile");
			this.labelCurrentFile.BackColor = System.Drawing.SystemColors.Control;
			this.labelCurrentFile.Name = "labelCurrentFile";
			// 
			// labelOverall
			// 
			resources.ApplyResources(this.labelOverall, "labelOverall");
			this.labelOverall.BackColor = System.Drawing.SystemColors.Control;
			this.labelOverall.Name = "labelOverall";
			// 
			// checkBox1
			// 
			resources.ApplyResources(this.checkBox1, "checkBox1");
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// labelOverallPct
			// 
			resources.ApplyResources(this.labelOverallPct, "labelOverallPct");
			this.labelOverallPct.BackColor = System.Drawing.SystemColors.Control;
			this.labelOverallPct.Name = "labelOverallPct";
			// 
			// labelCurrentPercent
			// 
			resources.ApplyResources(this.labelCurrentPercent, "labelCurrentPercent");
			this.labelCurrentPercent.BackColor = System.Drawing.SystemColors.Control;
			this.labelCurrentPercent.Name = "labelCurrentPercent";
			// 
			// frmTransferStatus
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelCurrentPercent);
			this.Controls.Add(this.labelOverallPct);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.labelOverall);
			this.Controls.Add(this.labelCurrentFile);
			this.Controls.Add(this.progressBarOverall);
			this.Controls.Add(this.progressBarCurrentFile);
			this.Controls.Add(this.button1);
			this.Name = "frmTransferStatus";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBarCurrentFile;
        private System.Windows.Forms.ProgressBar progressBarOverall;
        private System.Windows.Forms.Label labelCurrentFile;
        private System.Windows.Forms.Label labelOverall;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelOverallPct;
        private System.Windows.Forms.Label labelCurrentPercent;
    }
}