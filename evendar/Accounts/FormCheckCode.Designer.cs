namespace evendar.Accounts
{
    partial class FormCheckCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckCode));
            this.labelLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSignUp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.labelEnterCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.labelLogin.Location = new System.Drawing.Point(267, 656);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(56, 20);
            this.labelLogin.TabIndex = 28;
            this.labelLogin.Text = " -Login";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(78, 656);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Already Have an Account?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(62, 597);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 1);
            this.panel3.TabIndex = 27;
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.labelSignUp.Location = new System.Drawing.Point(260, 617);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(105, 20);
            this.labelSignUp.TabIndex = 25;
            this.labelSignUp.Text = " -Sign up now!";
            this.labelSignUp.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(86, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Don\'t Have an Account?";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.labelWrong.ForeColor = System.Drawing.Color.Red;
            this.labelWrong.Location = new System.Drawing.Point(154, 226);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(107, 20);
            this.labelWrong.TabIndex = 24;
            this.labelWrong.Text = "Code is Wrong";
            this.labelWrong.Visible = false;
            // 
            // labelEnterCode
            // 
            this.labelEnterCode.AutoSize = true;
            this.labelEnterCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEnterCode.Location = new System.Drawing.Point(37, 351);
            this.labelEnterCode.Name = "labelEnterCode";
            this.labelEnterCode.Size = new System.Drawing.Size(137, 20);
            this.labelEnterCode.TabIndex = 23;
            this.labelEnterCode.Text = "Enter 9 Digits Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(186, 348);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(212, 27);
            this.txtCode.TabIndex = 22;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(0)))), ((int)(((byte)(173)))));
            this.btnConfirm.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnConfirm.Location = new System.Drawing.Point(168, 466);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 43);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::evendar.Properties.Resources.settings;
            this.pictureBox6.Location = new System.Drawing.Point(177, 13);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(97, 93);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 48;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(429, -2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FormCheckCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(457, 755);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.labelEnterCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckCode";
            this.Load += new System.EventHandler(this.FormCheckCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label labelLogin;
        public Label label4;
        private Panel panel3;
        private Label labelSignUp;
        private Label label3;
        private Label labelWrong;
        private Label labelEnterCode;
        private TextBox txtCode;
        private Button btnConfirm;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
    }
}