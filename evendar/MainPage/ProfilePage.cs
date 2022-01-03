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

namespace evendar.MainPage
{
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            
            
            EventPage.addToComboBox(comboBox1);
            //Event.b if true means he is the woner of the publioc event false he is not the woner
            if (Event.b==false)
            {
                labelUsername.Text = Event.uname;
                btnPrivate.Visible = false;
                btnPublic.Visible = false;
                
                //show Event.Username page with public and private buttons invisible and unallowed to use

            }
            if (EventPage.b == false||Event.b==true)
            {
                labelUsername.Text = FormLogin.username;
                //show FormLogin.Username page with the details in the form               
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {          
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnPrivate_Click(object sender, EventArgs e)
        {

        }

        private void btnPublic_Click(object sender, EventArgs e)
        {

        }
    }
}
