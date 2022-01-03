using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evendar.Accounts
{
    public partial class FormPasswordOrUsername : Form
    {
        public static bool b=false;
        public FormPasswordOrUsername()
        {
            InitializeComponent();
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

        private void btnUsername_Click(object sender, EventArgs e)
        {
            b = true;
            this.Hide();
            Form form = new FormCheckEmail();
            form.ShowDialog(this);
            this.Close();
        }

        private void btmPassword_Click(object sender, EventArgs e)
        {
            b = false;
            this.Hide();
            Form form = new FormCheckEmail();
            form.ShowDialog(this);
            this.Close();
        }

        private void FormPasswordOrUsername_Load(object sender, EventArgs e)
        {
             
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
