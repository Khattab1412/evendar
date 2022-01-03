using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evendar.DB;
namespace evendar.Accounts
{
    public partial class FormCheckCode : Form
    {    
        public string codo = FormCheckEmail.code;
        public bool bol = FormPasswordOrUsername.b;
        public FormCheckCode()
        {
            InitializeComponent();
        }

        private void FormCheckCode_Load(object sender, EventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new formRegistration();
            form.ShowDialog(this);
            this.Close();
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FormLogin();
            form.ShowDialog(this);
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("please enter The Code First", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
                return;
            }
            try
            {
                if (txtCode.Text==codo)
                {
                    if(bol==true)
                    {
                        this.Hide();
                        Form form = new FormGetUsername();
                        form.ShowDialog(this);
                        this.Close();
                    }  
                    else
                    {
                        this.Hide();
                        Form form = new FormChangePassword();
                        form.ShowDialog(this);
                        this.Close();
                    }
                }
                else
                {
                    labelWrong.Visible = true;
                    txtCode.Clear();
                    txtCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
