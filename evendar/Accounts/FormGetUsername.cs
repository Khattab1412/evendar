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
    public partial class FormGetUsername : Form
    {
        public FormGetUsername()
        {
            InitializeComponent();
        }

        private void FormGetUsername_Load(object sender, EventArgs e)
        {
            try
            { 
                txtUsername.Text = DataBase.getUsername(FormCheckEmail.email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new FormLogin();
            form.ShowDialog(this);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new EventPage();
            form.ShowDialog(this);
            this.Close();
        }
    }
}
