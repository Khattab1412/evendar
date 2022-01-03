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
    public partial class FormInterestedIn : Form
    {
        public string username = formRegistration.username;
        public FormInterestedIn()
        {
            InitializeComponent();
        }

        private void FormInterestedIn_Load(object sender, EventArgs e)
        {
            if (DataBase.checkInterest(username, btnAnime.Text)==true)
            {
                btnAnime.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnEsports.Text) == true)
            {
                btnEsports.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnAnimals.Text) == true)
            {
                btnAnimals.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnChemistry.Text) == true)
            {
                btnChemistry.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnSports.Text) == true)
            {
                btnSports.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnGym.Text) == true)
            {
                btnGym.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnLanguages.Text) == true)
            {
                btnLanguages.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnStreaming.Text) == true)
            {
                btnStreaming.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnNature.Text) == true)
            {
                btnNature.BackColor = Color.FromArgb(238, 189, 245);
            }
            if  (DataBase.checkInterest(username, btnFashion.Text) == true)
            {
                btnFashion.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnCulture.Text) == true)
            {
                btnCulture.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnReligion.Text) == true)
            {
                btnReligion.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnCoffee.Text) == true)
            {
                btnCoffee.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnCars.Text) == true)
            {
                btnCars.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnMath.Text) == true)
            {
                btnMath.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnTravel.Text) == true)
            {
                btnTravel.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnSeries.Text) == true)
            {
                btnSeries.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnBooks.Text) == true)
            {
                btnBooks.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnMotorcycles.Text) == true)
            {
                btnMotorcycles.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnMakeup.Text) == true)
            {
                btnMakeup.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnChess.Text) == true)
            {
                btnChess.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnPhysics.Text) == true)
            {
                btnPhysics.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnFantasy.Text) == true)
            {
                btnFantasy.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnPlanes.Text) == true)
            {
                btnPlanes.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnPets.Text) == true)
            {
                btnPets.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnMilitary.Text) == true)
            {
                btnMilitary.BackColor = Color.FromArgb(238, 189, 245);
            }
            if (DataBase.checkInterest(username, btnScience.Text) == true)
            {
                btnScience.BackColor = Color.FromArgb(238, 189, 245);
            }

        }
        private void btnGames_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnGames.Text) == false)
                {
                    DataBase.addInterest(username, btnGames.Text);
                    btnGames.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnGames.Text) == true)
                {
                    DataBase.deleteInterest(username, btnGames.Text);
                    btnGames.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAnimals_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnAnimals.Text) == false)
                {
                    DataBase.addInterest(username, btnAnimals.Text);
                    btnAnimals.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnAnimals.Text) == true)
                {
                    DataBase.deleteInterest(username, btnAnimals.Text);
                    btnAnimals.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




            private void btnGym_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnGym.Text) == false)
                    {
                        DataBase.addInterest(username, btnGym.Text);
                        btnGym.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnGym.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnGym.Text);
                        btnGym.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void btnFood_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnFood.Text) == false)
                    {
                        DataBase.addInterest(username, btnFood.Text);
                        btnFood.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnFood.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnFood.Text);
                        btnFood.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }




 


            private void btnNature_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnNature.Text) == false)
                    {
                        DataBase.addInterest(username, btnNature.Text);
                        btnNature.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnNature.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnNature.Text);
                        btnNature.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnFashion_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnFashion.Text) == false)
                    {
                        DataBase.addInterest(username, btnFashion.Text);
                        btnFashion.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnFashion.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnFashion.Text);
                        btnFashion.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            private void btnStreaming_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnStreaming.Text) == false)
                    {
                        DataBase.addInterest(username, btnStreaming.Text);
                        btnStreaming.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnStreaming.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnStreaming.Text);
                        btnStreaming.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnCulture_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnCulture.Text) == false)
                    {
                        DataBase.addInterest(username, btnCulture.Text);
                    btnCulture.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnCulture.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnCulture.Text);
                        btnCulture.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
 
            private void btnReligion_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnReligion.Text) == false)
                    {
                        DataBase.addInterest(username, btnReligion.Text);
                    btnReligion.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnReligion.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnReligion.Text);
                    btnReligion.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

  


   

            private void btnCars_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnCars.Text) == false)
                    {
                        DataBase.addInterest(username, btnCars.Text);
                    btnCars.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnCars.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnCars.Text);
                    btnCars.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            private void btnMath_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnMath.Text) == false)
                    {
                        DataBase.addInterest(username, btnMath.Text);
                        btnMath.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnMath.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnMath.Text);
                        btnMath.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void btnTravel_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnTravel.Text) == false)
                    {
                        DataBase.addInterest(username, btnTravel.Text);
                    btnTravel.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnTravel.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnTravel.Text);
                    btnTravel.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnSeries_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnSeries.Text) == false)
                    {
                        DataBase.addInterest(username, btnSeries.Text);
                    btnSeries.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnSeries.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnSeries.Text);
                    btnSeries.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            private void btnBooks_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnBooks.Text) == false)
                    {
                        DataBase.addInterest(username, btnBooks.Text);
                        btnBooks.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnBooks.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnBooks.Text);
                        btnBooks.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnMotorcycles_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnMotorcycles.Text) == false)
                    {
                        DataBase.addInterest(username, btnMotorcycles.Text);
                        btnMotorcycles.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnMotorcycles.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnMotorcycles.Text);
                        btnMotorcycles.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnMakeup_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnMakeup.Text) == false)
                    {
                        DataBase.addInterest(username, btnMakeup.Text);
                    btnMakeup.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnMakeup.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnMakeup.Text);
                    btnMakeup.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void btnChess_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnChess.Text) == false)
                    {
                        DataBase.addInterest(username, btnChess.Text);
                    btnChess.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnChess.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnChess.Text);
                    btnChess.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnArt_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnArt.Text) == false)
                    {
                        DataBase.addInterest(username, btnArt.Text);
                    btnArt.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnArt.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnArt.Text);
                    btnArt.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnTechnologies_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnTechnologies.Text) == false)
                    {
                        DataBase.addInterest(username, btnTechnologies.Text);
                    btnTechnologies.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnTechnologies.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnTechnologies.Text);
                    btnTechnologies.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnHistory_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnHistory.Text) == false)
                    {
                        DataBase.addInterest(username, btnHistory.Text);
                    btnHistory.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnHistory.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnHistory.Text);
                    btnHistory.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnMovies_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnMovies.Text) == false)
                    {
                        DataBase.addInterest(username, btnMovies.Text);
                    btnMovies.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnMovies.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnMovies.Text);
                    btnMovies.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }







            private void btnPhysics_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnPhysics.Text) == false)
                    {
                        DataBase.addInterest(username, btnPhysics.Text);
                    btnPhysics.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnPhysics.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnPhysics.Text);
                    btnPhysics.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            private void btnFantasy_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnFantasy.Text) == false)
                    {
                        DataBase.addInterest(username, btnFantasy.Text);
                        btnFantasy.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnFantasy.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnFantasy.Text);
                         btnFantasy.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


 

            private void btnPets_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnPets.Text) == false)
                    {
                        DataBase.addInterest(username, btnPets.Text);
                    btnPets.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnPets.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnPets.Text);
                    btnPets.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void btnMilitary_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnMilitary.Text) == false)
                    {
                        DataBase.addInterest(username, btnMilitary.Text);
                    btnMilitary.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnMilitary.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnMilitary.Text);
                    btnMilitary.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
 


            private void btnScience_Click(object sender, EventArgs e)
            {
                try
                {
                    if (DataBase.checkInterest(username, btnScience.Text) == false)
                    {
                        DataBase.addInterest(username, btnScience.Text);
                    btnScience.BackColor = Color.FromArgb(238, 189, 245);
                    }
                    else if (DataBase.checkInterest(username, btnScience.Text) == true)
                    {
                        DataBase.deleteInterest(username, btnScience.Text);
                    btnScience.BackColor = Color.FromArgb(116, 0, 173);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void btnChemistry_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnChemistry.Text) == false)
                {
                    DataBase.addInterest(username, btnChemistry.Text);
                    btnChemistry.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnChemistry.Text) == true)
                {
                    DataBase.deleteInterest(username, btnChemistry.Text);
                    btnChemistry.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSports_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnSports.Text) == false)
                {
                    DataBase.addInterest(username, btnSports.Text);
                    btnSports.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnSports.Text) == true)
                {
                    DataBase.deleteInterest(username, btnSports.Text);
                    btnSports.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnime_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnAnime.Text) == false)
                {
                    DataBase.addInterest(username, btnAnime.Text);
                    btnAnime.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnAnime.Text) == true)
                {
                    DataBase.deleteInterest(username, btnAnime.Text);
                    btnAnime.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPainting_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnPainting.Text) == false)
                {
                    DataBase.addInterest(username, btnPainting.Text);
                    btnPainting.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnPainting.Text) == true)
                {
                    DataBase.deleteInterest(username, btnPainting.Text);
                    btnPainting.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnLanguages.Text) == false)
                {
                    DataBase.addInterest(username, btnLanguages.Text);
                    btnLanguages.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnLanguages.Text) == true)
                {
                    DataBase.deleteInterest(username, btnLanguages.Text);
                    btnLanguages.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnCoffee.Text) == false)
                {
                    DataBase.addInterest(username, btnCoffee.Text);
                    btnCoffee.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnCoffee.Text) == true)
                {
                    DataBase.deleteInterest(username, btnCoffee.Text);
                    btnCoffee.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeries_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnSeries.Text) == false)
                {
                    DataBase.addInterest(username, btnSeries.Text);
                    btnSeries.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnSeries.Text) == true)
                {
                    DataBase.deleteInterest(username, btnSeries.Text);
                    btnSeries.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMovies_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnMovies.Text) == false)
                {
                    DataBase.addInterest(username, btnMovies.Text);
                    btnMovies.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnMovies.Text) == true)
                {
                    DataBase.deleteInterest(username, btnMovies.Text);
                    btnMovies.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEsports_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnEsports.Text) == false)
                {
                    DataBase.addInterest(username, btnEsports.Text);
                    btnEsports.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnEsports.Text) == true)
                {
                    DataBase.deleteInterest(username, btnEsports.Text);
                    btnEsports.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSciencefiction_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnSciencefiction.Text) == false)
                {
                    DataBase.addInterest(username, btnSciencefiction.Text);
                    btnSciencefiction.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnSciencefiction.Text) == true)
                {
                    DataBase.deleteInterest(username, btnSciencefiction.Text);
                    btnSciencefiction.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlanes_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DataBase.checkInterest(username, btnPlanes.Text) == false)
                {
                    DataBase.addInterest(username, btnPlanes.Text);
                    btnPlanes.BackColor = Color.FromArgb(238, 189, 245);
                }
                else if (DataBase.checkInterest(username, btnPlanes.Text) == true)
                {
                    DataBase.deleteInterest(username, btnPlanes.Text);
                    btnPlanes.BackColor = Color.FromArgb(116, 0, 173);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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
    }
}
