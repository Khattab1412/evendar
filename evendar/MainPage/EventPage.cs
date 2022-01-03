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
/// <summary>
/// Every label's Click event is handled by this event handler
/// </summary>
/// <param name="sender">The label that was clicked</param>
/// <param name="e"></param>
namespace evendar.MainPage
{
    public partial class EventPage : Form
    {
        public Label[] labelName = new Label[5];
        Panel[] panel = new Panel[5];
        public static bool b=false;
        public static string eventName = "";
        int count = DataBase.getPublicEventsCount();
        public EventPage()
        {
            InitializeComponent();
        }

        private void EventPage_Load(object sender, EventArgs e)
        {


            string[] str = new string[count];
                string[] interstedIn = new string[count];
                string[] category = new string[count];

            for (int i = 0; i < count; i++)
            {
                
                str[i] = DataBase.getUsername1()[i];
                interstedIn[i] = DataBase.interestedInEvent()[i];
                category[i] = DataBase.getPublicCategory()[i];
            }
            addToPanel(str, interstedIn, category,count, panel1);
            addToComboBox(comboBox1);
        }


        public void addToPanel(string[] eventName, string[] interstedIn, string[] category,int Count,Panel panel1)
        {
            int x = 0;
            int y = 0;
            int delta = 10;
            panel1.Controls.Clear();

            for (int i = 0; i < Count; i++)
            {
                panel[i] = new Panel();
                labelName[i] = new Label();
                labelName[i].AutoSize = true;
                labelName[i].Location = new Point(40, y + 33);
                labelName[i].ForeColor = Color.DimGray;
                labelName[i].Font = new Font(labelName[i].Font, FontStyle.Bold);
                labelName[i].Text = eventName[i];
                // Create InteristedIn label
                Label labelInteristedIn = new Label();
                labelInteristedIn.AutoSize = true;
                labelInteristedIn.Location = new Point(0 + 130, y + labelName[i].Height + 40);
                labelInteristedIn.Text = interstedIn[i];
                // Create Categories label
                Label labelCategories = new Label();
                labelCategories.AutoSize = true;
                labelCategories.Location = new Point(0, y + labelName[i].Height + labelInteristedIn.Height + 30);
                labelCategories.Text = category[i];
                // Add controls
                panel[i].Size = new Size(300, 140);
                panel[i].Controls.Add(labelName[i]);
                panel[i].Controls.Add(labelInteristedIn);
                panel[i].Controls.Add(labelCategories);
                panel[i].BorderStyle = BorderStyle.None;
                panel[i].BackColor =Color.FromArgb(21, 50, 66);
                panel[i].Location = new Point(0);
                panel1.Controls.Add(panel[i]);
                labelName[i].Click += new EventHandler(labelName_Click);
            }
        }
        private void labelName_Click(object sender, EventArgs e)
        {
            int ans=0;
            for (int i=0;i< count; i++)
            {
                if (labelName[i].Capture)
                    ans= i;
            }
             b = true;
             eventName = labelName[ans].Text;
            this.Hide();
            Form form = new Event();
            form.ShowDialog(this);
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
        }

 
     private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Settings();
            form.ShowDialog(this);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {       
                
            if (txtSearch.Text == string.Empty)
            {
                return;
                
            }
            try
            {

                string[] eventName = new string[1];
                string[] interestedInEvent = new string[1];
                string[] category = new string[1];


                    interestedInEvent[0] = DataBase.SearchEventNumber(txtSearch.Text)[0];
                    category[0] = DataBase.SearchEventCategory(txtSearch.Text)[0];
                    eventName[0] = DataBase.SearchEvents(txtSearch.Text)[0];
                addToPanel(eventName, interestedInEvent, category, 1, panel1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            b = false;
            this.Hide();
            Form form = new ProfilePage();
            form.ShowDialog(this);
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                return;
            }
                try
            {                         
                    panel1.Controls.Clear();
                    int count = DataBase.getPublicEventsCategoryCount(comboBox1.Text);
                    string[] eventName = new string[count];
                    string[] interstedIn = new string[count];
                    string [] category=new string[count];
                    for (int i = 0; i < count; i++)
                    {
                        eventName[i] = DataBase.getEventsByCategory(comboBox1.Text)[i];
                        interstedIn[i] = DataBase.SearchEventNumberByCats(comboBox1.Text)[i];
                        category[i] = comboBox1.Text;
                    }                    
                    addToPanel(eventName,interstedIn,category,count, panel1);
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void addToComboBox(ComboBox comboBox1)
        {
            comboBox1.Items.Add("Games");
            comboBox1.Items.Add("Animals");
            comboBox1.Items.Add("Chemistry");
            comboBox1.Items.Add("Sports");
            comboBox1.Items.Add("Gym");
            comboBox1.Items.Add("Anime");
            comboBox1.Items.Add("Painting");
            comboBox1.Items.Add("Food");
            comboBox1.Items.Add("Lanuages");
            comboBox1.Items.Add("Nature");
            comboBox1.Items.Add("Fashion");
            comboBox1.Items.Add("Streaming");
            comboBox1.Items.Add("Culture");
            comboBox1.Items.Add("Religion");
            comboBox1.Items.Add("Coffee");
            comboBox1.Items.Add("Cars");
            comboBox1.Items.Add("Math");
            comboBox1.Items.Add("Travel");
            comboBox1.Items.Add("Series");
            comboBox1.Items.Add("Books");
            comboBox1.Items.Add("Motocycles");
            comboBox1.Items.Add("Makeup");
            comboBox1.Items.Add("Chess");
            comboBox1.Items.Add("Art");
            comboBox1.Items.Add("Tech");
            comboBox1.Items.Add("History");
            comboBox1.Items.Add("Movies");
            comboBox1.Items.Add("eSports");
            comboBox1.Items.Add("Science Fiction");
            comboBox1.Items.Add("Physics");
            comboBox1.Items.Add("Fantasy");
            comboBox1.Items.Add("Planes");
            comboBox1.Items.Add("Pets");
            comboBox1.Items.Add("Military");
            comboBox1.Items.Add("science");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = DataBase.eventsByInterestcount(FormLogin.username);
            string[] eventName = new string[count];
            string[] interstedIn = new string[count];
            string[] category = new string[count];
            for (int i = 0; i < count; i++)
            {
                eventName[i] = DataBase.eventsByInterest(FormLogin.username)[i];
                interstedIn[i] = DataBase.interestedInEventByInterest(FormLogin.username)[i];
                category[i] = DataBase.CategoryByInterest(FormLogin.username)[i];
            }
            addToPanel(eventName, interstedIn, category, count,panel1);
        }
    }
}
