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
using evendar.Accounts;
using evendar.MainPage;
namespace evendar
{
    public partial class formRegistration : Form
    {
        public static string username=""; 
        public formRegistration()
        {
            InitializeComponent();
        }

        private void formRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text)&& string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtEmail.Text)&& string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Fields Are Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("please enter your Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("please enter your Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("please enter your email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }


            
            try
            {

                if (DataBase.checkUsername(txtUsername.Text) == true)
                {
                    MessageBox.Show("This Username is Unavilabe");
                    txtUsername.Focus();
                    return;
                }
                if (DataBase.checkEmail(txtEmail.Text) == true)
                {
                    MessageBox.Show("This email is Unavilabe");
                    txtEmail.Focus();
                    return;
                }
                username = txtUsername.Text;
                DataBase.register(txtUsername.Text, txtPassword.Text,txtName.Text,txtEmail.Text);
                this.Hide();
                Form form = new FormInterestedIn();
                form.ShowDialog(this);
                this.Close();
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FormLogin();
            form.ShowDialog(this);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.ForeColor = Color.Black;
            txtName.Clear();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
            txtUsername.Clear();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            txtPassword.Clear();
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            txtEmail.ForeColor = Color.Black;
            txtEmail.Clear();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
