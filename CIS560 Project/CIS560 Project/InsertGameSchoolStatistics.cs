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
    public partial class InsertGameSchoolStatistics : Form
    {

        private Model model;

        private Form Parent;

        private Game Game;

        private School Home;

        private School Guest;

        private int HomeScore;

        private int GuestScore;

        private BindingList<School> SchoolsHome;

        private BindingList<School> SchoolsGuest;

        public InsertGameSchoolStatistics(Model m, Form parent, Game g, GameSchool home, GameSchool guest)
        {
            InitializeComponent();
            Parent = parent;

            model = m;
            Game = g;

            SchoolsHome = new BindingList<School>();
            SchoolsGuest = new BindingList<School>();

            

            HomeScore = home.Score;
            GuestScore = guest.Score;

            uxHomeScore.Value = HomeScore;
            uxGuestScore.Value = GuestScore;

            foreach(School s in model.Schools)
            {
                SchoolsHome.Add(s);
                SchoolsGuest.Add(s);
            }

            foreach (School s in SchoolsHome)
            {
                if (s.SchoolID == home.SchoolID)
                {
                    Home = s;
                }
            }

            foreach (School s in SchoolsGuest)
            {
                if (s.SchoolID == guest.SchoolID)
                {
                    Guest = s;
                }
            }

            uxSelectHomeTeam.DataSource = SchoolsHome;
            uxSelectGuestTeam.DataSource = SchoolsGuest;

            uxSelectHomeTeam.SelectedItem = Home;
            uxSelectGuestTeam.SelectedItem = Guest;
        }

        private void uxSelectHomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Home = ((School)uxSelectHomeTeam.SelectedItem);
        }

        private void uxHomeScore_ValueChanged(object sender, EventArgs e)
        {
            HomeScore = (int)uxHomeScore.Value;
        }

        private void uxGuestScore_ValueChanged(object sender, EventArgs e)
        {
            GuestScore = (int)uxGuestScore.Value;
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {
            Parent.Enabled = true;
            this.Close();
        }

        private void uxSaveButton_Click(object sender, EventArgs e)
        {
            if(uxHomeScore.Value == uxGuestScore.Value)
            {
                MessageBox.Show("Cannot insert same scores!");
            }
            else if (uxSelectHomeTeam.Text.Equals(uxSelectGuestTeam.Text))
            {

                MessageBox.Show("Cannot have the same school for Home and Guest teams!");
            }
            else if (((School)uxSelectHomeTeam.SelectedItem).Seed > ((School)uxSelectGuestTeam.SelectedItem).Seed)
            {
                MessageBox.Show("Team with a higher seed should be the Home team!");
            }
            else if(model.GameRepo.InsertGameSchoolStatistics(Game.GameID, Home.SchoolID, 1, HomeScore) &&
            model.GameRepo.InsertGameSchoolStatistics(Game.GameID, Guest.SchoolID, 2, GuestScore))
            {
                MessageBox.Show("New game data saved!");

                Parent.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("New game data not saved!");

                Parent.Enabled = true;
                this.Close();
            }
        }

        private void Games_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Enabled = true;
        }

        private void uxSelectGuestTeam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Guest = ((School)uxSelectGuestTeam.SelectedItem);
        }

        private void InsertGameSchoolStatistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Enabled = true;
        }
    }
}
