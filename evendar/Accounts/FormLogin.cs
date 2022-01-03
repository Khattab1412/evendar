using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using evendar.DB;
using evendar.Accounts;
using evendar.MainPage;
using MaterialSkin;
using MaterialSkin.Controls;
namespace evendar
{
    public partial class FormLogin : Form
    {
        public static string username = "";
        public FormLogin()
        {
            InitializeComponent();
            
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("please enter your Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            try
            {
                string log = DataBase.login(txtUsername.Text, txtPassword.Text);
                if (log == txtPassword.Text)
                {
                    username = txtUsername.Text;
                    this.Hide();
                    Form form = new EventPage();
                    form.ShowDialog(this);
                    this.Close();
                }
            }
            catch
            {
                labelWrong.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new formRegistration();
            form.ShowDialog(this);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            labelWrong.Visible = false;
            txtUsername.Clear();
        }

        private void labelForgotAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FormPasswordOrUsername();
            form.ShowDialog(this);
            this.Close();
        }

        private void labelWrong_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
            txtUsername.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.Clear();
        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text== "Username")
            {
                txtUsername.ForeColor = Color.Black;
                txtUsername.Clear();
            }
        }
        private void txtPassword_MouseClick_1(object sender, MouseEventArgs e)
        {

            txtPassword.ForeColor = Color.Black;
            txtPassword.Clear();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
