namespace evendar.MainPage
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.flowPanelEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPublic = new System.Windows.Forms.Button();
            this.btnPrivate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelEvents
            // 
            this.flowPanelEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.flowPanelEvents.Location = new System.Drawing.Point(132, 249);
            this.flowPanelEvents.Name = "flowPanelEvents";
            this.flowPanelEvents.Size = new System.Drawing.Size(520, 732);
            this.flowPanelEvents.TabIndex = 1;
            this.flowPanelEvents.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelEvents_Paint);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelUsername.Location = new System.Drawing.Point(339, 36);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(142, 38);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(775, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(677, 909);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Go To Main Page";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.panel4.Controls.Add(this.btnPublic);
            this.panel4.Controls.Add(this.btnPrivate);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Location = new System.Drawing.Point(132, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 130);
            this.panel4.TabIndex = 47;
            // 
            // btnPublic
            // 
            this.btnPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnPublic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPublic.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPublic.Location = new System.Drawing.Point(203, 84);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Size = new System.Drawing.Size(110, 29);
            this.btnPublic.TabIndex = 10;
            this.btnPublic.Text = "Public";
            this.btnPublic.UseVisualStyleBackColor = false;
            this.btnPublic.Click += new System.EventHandler(this.btnPublic_Click);
            // 
            // btnPrivate
            // 
            this.btnPrivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnPrivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrivate.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnPrivate.Location = new System.Drawing.Point(61, 84);
            this.btnPrivate.Name = "btnPrivate";
            this.btnPrivate.Size = new System.Drawing.Size(110, 29);
            this.btnPrivate.TabIndex = 9;
            this.btnPrivate.Text = "Private";
            this.btnPrivate.UseVisualStyleBackColor = false;
            this.btnPrivate.Click += new System.EventHandler(this.btnPrivate_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(61, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSearch.Location = new System.Drawing.Point(344, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Go";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(132, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 1);
            this.panel2.TabIndex = 48;
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(810, 938);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowPanelEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilePage";
            this.Text = "ProfilePage";
            this.Load += new System.EventHandler(this.ProfilePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelUsername;
        private FlowLayoutPanel flowPanelEvents;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel4;
        private TextBox textBox1;
        private Button btnSearch;
        private ComboBox comboBox1;
        private Panel panel2;
        private Button btnPublic;
        private Button btnPrivate;
    }
}