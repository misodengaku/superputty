namespace SuperPutty
{
    partial class dlgEditSession
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dlgEditSession));
			this.textBoxSessionName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxHostname = new System.Windows.Forms.TextBox();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonSerial = new System.Windows.Forms.RadioButton();
			this.radioButtonSSH = new System.Windows.Forms.RadioButton();
			this.radioButtonRlogin = new System.Windows.Forms.RadioButton();
			this.radioButtonTelnet = new System.Windows.Forms.RadioButton();
			this.radioButtonRaw = new System.Windows.Forms.RadioButton();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxPuttyProfile = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxSessionName
			// 
			resources.ApplyResources(this.textBoxSessionName, "textBoxSessionName");
			this.textBoxSessionName.Name = "textBoxSessionName";
			this.textBoxSessionName.TextChanged += new System.EventHandler(this.sessionForm_TextChanged);
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
			// textBoxHostname
			// 
			resources.ApplyResources(this.textBoxHostname, "textBoxHostname");
			this.textBoxHostname.Name = "textBoxHostname";
			this.textBoxHostname.TextChanged += new System.EventHandler(this.sessionForm_TextChanged);
			// 
			// textBoxPort
			// 
			resources.ApplyResources(this.textBoxPort, "textBoxPort");
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.TextChanged += new System.EventHandler(this.sessionForm_TextChanged);
			// 
			// label3
			// 
			resources.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			// 
			// groupBox1
			// 
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Controls.Add(this.radioButtonSerial);
			this.groupBox1.Controls.Add(this.radioButtonSSH);
			this.groupBox1.Controls.Add(this.radioButtonRlogin);
			this.groupBox1.Controls.Add(this.radioButtonTelnet);
			this.groupBox1.Controls.Add(this.radioButtonRaw);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// radioButtonSerial
			// 
			resources.ApplyResources(this.radioButtonSerial, "radioButtonSerial");
			this.radioButtonSerial.Name = "radioButtonSerial";
			this.radioButtonSerial.Tag = SuperPutty.ConnectionProtocol.Serial;
			this.radioButtonSerial.UseVisualStyleBackColor = true;
			// 
			// radioButtonSSH
			// 
			resources.ApplyResources(this.radioButtonSSH, "radioButtonSSH");
			this.radioButtonSSH.Checked = true;
			this.radioButtonSSH.Name = "radioButtonSSH";
			this.radioButtonSSH.TabStop = true;
			this.radioButtonSSH.Tag = SuperPutty.ConnectionProtocol.SSH;
			this.radioButtonSSH.UseVisualStyleBackColor = true;
			// 
			// radioButtonRlogin
			// 
			resources.ApplyResources(this.radioButtonRlogin, "radioButtonRlogin");
			this.radioButtonRlogin.Name = "radioButtonRlogin";
			this.radioButtonRlogin.Tag = SuperPutty.ConnectionProtocol.Rlogin;
			this.radioButtonRlogin.UseVisualStyleBackColor = true;
			// 
			// radioButtonTelnet
			// 
			resources.ApplyResources(this.radioButtonTelnet, "radioButtonTelnet");
			this.radioButtonTelnet.Name = "radioButtonTelnet";
			this.radioButtonTelnet.Tag = SuperPutty.ConnectionProtocol.Telnet;
			this.radioButtonTelnet.UseVisualStyleBackColor = true;
			// 
			// radioButtonRaw
			// 
			resources.ApplyResources(this.radioButtonRaw, "radioButtonRaw");
			this.radioButtonRaw.Name = "radioButtonRaw";
			this.radioButtonRaw.Tag = SuperPutty.ConnectionProtocol.Raw;
			this.radioButtonRaw.UseVisualStyleBackColor = true;
			// 
			// buttonSave
			// 
			resources.ApplyResources(this.buttonSave, "buttonSave");
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// label4
			// 
			resources.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			// 
			// comboBoxPuttyProfile
			// 
			resources.ApplyResources(this.comboBoxPuttyProfile, "comboBoxPuttyProfile");
			this.comboBoxPuttyProfile.FormattingEnabled = true;
			this.comboBoxPuttyProfile.Name = "comboBoxPuttyProfile";
			this.comboBoxPuttyProfile.TextChanged += new System.EventHandler(this.sessionForm_TextChanged);
			// 
			// groupBox2
			// 
			resources.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.textBoxSessionName);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBoxHostname);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.textBoxPort);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			// 
			// label5
			// 
			resources.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			// 
			// textBoxUsername
			// 
			resources.ApplyResources(this.textBoxUsername, "textBoxUsername");
			this.textBoxUsername.Name = "textBoxUsername";
			// 
			// dlgEditSession
			// 
			this.AcceptButton = this.buttonSave;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBoxPuttyProfile);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Name = "dlgEditSession";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSessionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSerial;
        private System.Windows.Forms.RadioButton radioButtonSSH;
        private System.Windows.Forms.RadioButton radioButtonRlogin;
        private System.Windows.Forms.RadioButton radioButtonTelnet;
        private System.Windows.Forms.RadioButton radioButtonRaw;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPuttyProfile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}