namespace SuperPutty
{
    partial class dlgLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgLogin));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.textBoxPasssword = new System.Windows.Forms.TextBox();
			this.checkBoxRemember = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
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
			// button1
			// 
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxUsername
			// 
			resources.ApplyResources(this.textBoxUsername, "textBoxUsername");
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBoxPasssword
			// 
			resources.ApplyResources(this.textBoxPasssword, "textBoxPasssword");
			this.textBoxPasssword.Name = "textBoxPasssword";
			this.textBoxPasssword.UseSystemPasswordChar = true;
			this.textBoxPasssword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// checkBoxRemember
			// 
			resources.ApplyResources(this.checkBoxRemember, "checkBoxRemember");
			this.checkBoxRemember.Name = "checkBoxRemember";
			this.checkBoxRemember.UseVisualStyleBackColor = true;
			this.checkBoxRemember.CheckedChanged += new System.EventHandler(this.checkBoxRemember_CheckedChanged);
			// 
			// dlgLogin
			// 
			this.AcceptButton = this.button1;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkBoxRemember);
			this.Controls.Add(this.textBoxPasssword);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "dlgLogin";
			this.Shown += new System.EventHandler(this.dlgLogin_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPasssword;
        private System.Windows.Forms.CheckBox checkBoxRemember;
    }
}