using PersonData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_Project
{
    public partial class UpdateGameStats : Form
    {
        private Model Model;

        private Game SelectedGame;

        private Form Parent;

        private GameSchool Home;

        private GameSchool Guest;

        private int HomeScore;

        private int GuestScore;

        public UpdateGameStats(Model m, Game game, Form parent)
        {
            InitializeComponent();
            Model = m;
            SelectedGame = game;
            Parent = parent;

            Home = Model.GameSchoolRepo.RetrieveHomeSchoolForGame(SelectedGame.GameID);
            Guest = Model.GameSchoolRepo.RetrieveGuestSchoolForGame(SelectedGame.GameID);

            uxHomeSchoolLabel.Text = "Home School: " + Home.ToString();
            uxGuestSchoolLabel.Text = "Guest School: " + Guest.ToString();

            if(Home.Score == -1)
            {
                uxHomeScore.Value = 0;
            }
            else
            {
                uxHomeScore.Value = Home.Score;
            }

            if(Guest.Score == -1)
            {
                uxHomeScore.Value = 0;
            }
            else
            {
                uxGuestScore.Value = Guest.Score;
            }
            
            

            HomeScore = Home.Score;
            GuestScore = Guest.Score;
        }

        private void UpdateGameStats_Closing(object sender, FormClosingEventArgs e)
        {
            Parent.Enabled = true;
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Parent.Enabled = true;
            this.Close();
        }

        private void uxSaveButton_Click(object sender, EventArgs e)
        {
            if(HomeScore > 0 && GuestScore > 0)
            {
                if (Model.GameSchoolRepo.UpdateGameScore(SelectedGame.GameID, Guest.SchoolID, GuestScore)
                    && Model.GameSchoolRepo.UpdateGameScore(SelectedGame.GameID, Home.SchoolID, HomeScore))
                {
                    Parent.Enabled = true;
                    this.Close();
                    MessageBox.Show("Game Score Updated!");
                }
            }
            else
            {
                MessageBox.Show("Invalid scores! Change the scores before updating!");
            }
        }

        private void uxHomeScore_ValueChanged(object sender, EventArgs e)
        {
            HomeScore = (int)uxHomeScore.Value;
        }

        private void uxGuestScore_ValueChanged(object sender, EventArgs e)
        {
            GuestScore = (int)uxGuestScore.Value;
        }
    }
}
