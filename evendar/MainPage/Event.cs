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
namespace evendar.MainPage
{
    public partial class Event : Form
    {
        public static string uname = "";
        public static bool b = false;
        public Event()
        {
            InitializeComponent();
        }

        private void labelMainPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new EventPage();
            form.ShowDialog(this);
            this.Close();
        }

        private void richTxtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void Event_Load(object sender, EventArgs e)
        {
            labelEventName.Text = EventPage.eventName;
            labelInterestedIn.Text = DataBase.SearchEventNumber(EventPage.eventName)[0];
            labelUsername.Text = DataBase.SearchEventOwner(EventPage.eventName)[0];
            labelCategory.Text = DataBase.SearchEventCategory(EventPage.eventName)[0];
            richTxtDescription.Text = DataBase.getDescription(EventPage.eventName)[0];
            txtStartDate.Text = DataBase.StartDate(EventPage.eventName);
            txtEndDate.Text=DataBase.EndDate(EventPage.eventName);
            txtStartTime.Text=DataBase.StartTime(EventPage.eventName);
            txtEndDate.Text= DataBase.EndDate(EventPage.eventName);
            txtLocation.Text=DataBase.Location(EventPage.eventName);
            uname = labelUsername.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            if(FormLogin.username == labelUsername.Text)
            {
                b = true;
                      
            }
            else
            {
                b=false;
            }
            this.Hide();
            Form form = new ProfilePage();
            form.ShowDialog(this);
            this.Close();
        }

        private void labelEventName_Click(object sender, EventArgs e)
        {

        }

        private void labelCategory_Click(object sender, EventArgs e)
        {

        }

        private void labelInterestedIn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                DataBase.addInterestInEvent(labelEventName.Text);
                button1.Visible = false;
                button2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DataBase.removeEventInterestedin(EventPage.eventName);
                button2.Visible = false;
                button1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
