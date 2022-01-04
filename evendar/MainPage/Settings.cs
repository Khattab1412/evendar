using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evendar.Accounts;
using evendar.DB;
namespace evendar.MainPage
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FormChangePassword();
            form.ShowDialog(this);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnSaveEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("You Must Enter a email");
                return;
            }
            try
            {
                if (DataBase.checkEmail(txtEmail.Text)==true)
                {
                    labelWarnging.Visible = true;
                      return;
                }
                else
                {
                    labelWarnging.Visible=false;
                    DataBase.changeEmail(FormLogin.username, txtEmail.Text);
                      MessageBox.Show("Your email've being changed.");
                    panel1.Visible=false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new addEvent();
            form.ShowDialog(this);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new EventPage();
            form.ShowDialog(this);
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninterest_Click(object sender, EventArgs e)
        {

        }
    }
}
