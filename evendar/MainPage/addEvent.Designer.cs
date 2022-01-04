namespace evendar.MainPage
{
    partial class addEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addEvent));
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.desc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.sdate = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.edate = new System.Windows.Forms.DateTimePicker();
            this.yes = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.stime = new System.Windows.Forms.DateTimePicker();
            this.etime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.Gray;
            this.txtLocation.Location = new System.Drawing.Point(251, 143);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(249, 27);
            this.txtLocation.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(732, 13);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.Color.Gray;
            this.desc.Location = new System.Drawing.Point(249, 450);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(249, 120);
            this.desc.TabIndex = 53;
            this.desc.Text = "";
            this.desc.TextChanged += new System.EventHandler(this.richTxtDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(139, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 54;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(144, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 55;
            this.label2.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(134, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 31);
            this.label5.TabIndex = 58;
            this.label5.Text = "End Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(126, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 31);
            this.label6.TabIndex = 59;
            this.label6.Text = "Start Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(136, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 31);
            this.label7.TabIndex = 60;
            this.label7.Text = "End Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(131, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 31);
            this.label8.TabIndex = 61;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.BlueViolet;
            this.label9.Location = new System.Drawing.Point(130, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 28);
            this.label9.TabIndex = 62;
            this.label9.Text = "description";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.Gray;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(251, 86);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(249, 28);
            this.comboBoxCategory.TabIndex = 63;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // sdate
            // 
            this.sdate.Location = new System.Drawing.Point(251, 206);
            this.sdate.Name = "sdate";
            this.sdate.Size = new System.Drawing.Size(250, 27);
            this.sdate.TabIndex = 65;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.checkBox1.Location = new System.Drawing.Point(427, 576);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 24);
            this.checkBox1.TabIndex = 66;
            this.checkBox1.Text = "Public";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.Indigo;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.ForeColor = System.Drawing.Color.Gray;
            this.btnAddEvent.Location = new System.Drawing.Point(316, 631);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(102, 35);
            this.btnAddEvent.TabIndex = 67;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // edate
            // 
            this.edate.Location = new System.Drawing.Point(249, 264);
            this.edate.Name = "edate";
            this.edate.Size = new System.Drawing.Size(250, 27);
            this.edate.TabIndex = 68;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yes.ForeColor = System.Drawing.Color.BlueViolet;
            this.yes.Location = new System.Drawing.Point(103, 29);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(137, 31);
            this.yes.TabIndex = 70;
            this.yes.Text = "Event Name";
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.Gray;
            this.textName.Location = new System.Drawing.Point(249, 29);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(249, 27);
            this.textName.TabIndex = 69;
            // 
            // stime
            // 
            this.stime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.stime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stime.Location = new System.Drawing.Point(251, 320);
            this.stime.Name = "stime";
            this.stime.Size = new System.Drawing.Size(250, 27);
            this.stime.TabIndex = 71;
            // 
            // etime
            // 
            this.etime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.etime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.etime.Location = new System.Drawing.Point(249, 375);
            this.etime.Name = "etime";
            this.etime.Size = new System.Drawing.Size(250, 27);
            this.etime.TabIndex = 72;
            // 
            // addEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(774, 690);
            this.Controls.Add(this.etime);
            this.Controls.Add(this.stime);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.edate);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sdate);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtLocation);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addEvent";
            this.Text = "addEvent";
            this.Load += new System.EventHandler(this.addEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtLocation;
        private PictureBox pictureBox3;
        private RichTextBox desc;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxCategory;
        private DateTimePicker sdate;
        private CheckBox checkBox1;
        private Button btnAddEvent;
        private DateTimePicker edate;
        private Label yes;
        private TextBox textName;
        private DateTimePicker stime;
        private DateTimePicker etime;
    }
}