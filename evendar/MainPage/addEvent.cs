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
namespace evendar.MainPage
{
    public partial class addEvent : Form
    {
        public addEvent()
        {
            InitializeComponent();
        }

        private void addEvent_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Add("Games");
            comboBoxCategory.Items.Add("Animals");
            comboBoxCategory.Items.Add("Chemistry");
            comboBoxCategory.Items.Add("Sports");
            comboBoxCategory.Items.Add("Gym");
            comboBoxCategory.Items.Add("Anime");
            comboBoxCategory.Items.Add("Painting");
            comboBoxCategory.Items.Add("Food");
            comboBoxCategory.Items.Add("Lanuages");
            comboBoxCategory.Items.Add("Nature");
            comboBoxCategory.Items.Add("Fashion");
            comboBoxCategory.Items.Add("Streaming");
            comboBoxCategory.Items.Add("Culture");
            comboBoxCategory.Items.Add("Religion");
            comboBoxCategory.Items.Add("Coffee");
            comboBoxCategory.Items.Add("Cars");
            comboBoxCategory.Items.Add("Math");
            comboBoxCategory.Items.Add("Travel");
            comboBoxCategory.Items.Add("Series");
            comboBoxCategory.Items.Add("Books");
            comboBoxCategory.Items.Add("Motocycles");
            comboBoxCategory.Items.Add("Makeup");
            comboBoxCategory.Items.Add("Chess");
            comboBoxCategory.Items.Add("Art");
            comboBoxCategory.Items.Add("Tech");
            comboBoxCategory.Items.Add("History");
            comboBoxCategory.Items.Add("Movies");
            comboBoxCategory.Items.Add("eSports");
            comboBoxCategory.Items.Add("Science Fiction");
            comboBoxCategory.Items.Add("Physics");
            comboBoxCategory.Items.Add("Fantasy");
            comboBoxCategory.Items.Add("Planes");
            comboBoxCategory.Items.Add("Pets");
            comboBoxCategory.Items.Add("Military");
            comboBoxCategory.Items.Add("science");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void richTxtDescription_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            DataBase.addEvent(desc.Text, sdate.Value, edate.Value, textName.Text, txtLocation.Text, checkBox1.Checked, stime.Value, etime.Value, FormLogin.username, comboBoxCategory.Text);
        }
    }
}
