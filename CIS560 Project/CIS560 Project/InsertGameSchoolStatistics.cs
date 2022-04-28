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

        public InsertGameSchoolStatistics(Model m, Form parent, Game g)
        {
            InitializeComponent();
            Parent = parent;

            model = m;
            Game = g;

            SchoolsHome = new BindingList<School>();
            SchoolsGuest = new BindingList<School>();

            foreach(School s in model.Schools)
            {
                SchoolsHome.Add(s);
                SchoolsGuest.Add(s);
            }

            uxSelectHomeTeam.DataSource = SchoolsHome;
            uxSelectGuestTeam.DataSource = SchoolsGuest;
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
            if(model.GameRepo.InsertGameSchoolStatistics(Game.GameID, Home.SchoolID, 1, HomeScore) &&
            model.GameRepo.InsertGameSchoolStatistics(Game.GameID, Guest.SchoolID, 2, GuestScore))
            {
                MessageBox.Show("New game data saved!");
               
            }
            else
            {
                MessageBox.Show("New game data not saved!");
            }

            Parent.Enabled = true;
            this.Close();
        }

        private void Games_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Enabled = true;
        }

        private void uxSelectGuestTeam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Guest = ((School)uxSelectGuestTeam.SelectedItem);
        }
    }
}
