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
using evendar.MainPage;
namespace evendar.Accounts
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            labelEasyPassword.Visible = false;
            labelNoMatch.Visible = false;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string email = FormCheckEmail.email;
            if (txtConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("You Must Enter a Password");
                return;
            }
            else if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                //labelNoMatch.Visible = true;
                return;
            }
            else if (txtConfirmPassword.Text.Length < 8)
            {
                labelEasyPassword.Visible = true;
                return;
            }
            try
            {
                DataBase.changePass(email, txtNewPassword.Text);
                MessageBox.Show("Your Pasword Have being Changed Successfully!");
                this.Hide();
                Form form = new EventPage();
                form.ShowDialog(this);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FormChangePassword_Load(object sender, EventArgs e)
        {


        }

        private void labelEasyPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
