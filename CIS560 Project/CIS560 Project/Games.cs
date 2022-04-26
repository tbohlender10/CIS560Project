using PersonData.Models;
using System;
using PersonData;
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
    public partial class Games : Form
    {
        Form parent;
        private bool close;
        Model model;
        private BindingList<School> schools;
        private BindingList<Player> players;
        private int Points = -1;
        private int ThreePoints = -1;
        private int FGM = -1;
        private int FGA = -1;
        private int Rebounds = -1;
        private int Minutes = -1;

        public Games(Form f, Model m)
        {
            InitializeComponent();
            close = true;
            parent = f;
            model = m;

            uxSelectGame.DataSource = model.GameRepo.RetrieveAllGames();

            schools = new BindingList<School>();
            players = new BindingList<Player>();

            uxSelectTeam.DataSource = schools;
            uxSelectPlayer.DataSource = players;

            uxCurrPlayerLabel.Text = "";
            uxPlayerStats.Text = "";
        }

        private void showMenu()
        {
            close = true;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            uxGameLabel.Show();
            uxTeamLabel.Show();
            uxPlayerLabel.Show();
            uxSelectGame.Show();
            uxSelectTeam.Show();
            uxSelectPlayer.Show();
            uxEditPlayer.Show();

            uxViewPlayer.Show();
            uxViewGame.Show();
            uxUpdateGame.Show();
            uxBack.Show();
        }

        private void showUpdatePlayer()
        {
            close = false;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            uxCurrPlayerLabel.Show();
            uxCurrGameLabel.Show();
            uxPoints.Show();
            uxPointsLabel.Show();
            uxThreePoints.Show();
            uxThreePointsLabel.Show();
            uxFGM.Show();
            uxFGMLabel.Show();
            uxFGA.Show();
            uxFGALabel.Show();
            uxRebounds.Show();
            uxReboundsLabel.Show();
            uxMinutes.Show();
            uxMinutesLabel.Show();
            uxBack.Show();
            uxSave.Show();

        }

        private void showViewPlayer()
        {
            close = false;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            uxCurrPlayerLabel.Show();
            uxCurrGameLabel.Show();
            uxPlayerStats.Show();
            uxBack.Show();
        }

        private void uxSelectGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxSelectGame.SelectedItem != null)
            {
                uxSelectTeam.Enabled = true;
                uxViewGame.Enabled = true;
                uxUpdateGame.Enabled = true;

                ((BindingList<School>)uxSelectTeam.DataSource).Clear();

                foreach (School s in model.GameRepo.RetrieveSchoolsForGame(((Game)uxSelectGame.SelectedItem).GameID))
                {
                    ((BindingList<School>)uxSelectTeam.DataSource).Add(s);
                }
            }
        }

        private void uxSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxSelectTeam.SelectedItem != null)
            {
                uxSelectPlayer.Enabled = true;

                ((BindingList<Player>)uxSelectPlayer.DataSource).Clear();

                foreach (Player p in model.PlayerRepo.RetrievePlayersForSchool(((School)uxSelectTeam.SelectedItem).SchoolID))
                {
                    ((BindingList<Player>)uxSelectPlayer.DataSource).Add(p);
                }
            }
        }

        private void uxSelectPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxSelectPlayer.SelectedItem != null)
            {
                uxEditPlayer.Enabled = true;
                uxViewPlayer.Enabled = true;
            }
        }

        private void uxEditPlayer_Click(object sender, EventArgs e)
        {
            showUpdatePlayer();
            uxCurrPlayerLabel.Text = "Selected Player: " + uxSelectPlayer.Text;
            uxCurrGameLabel.Text = "Selected Game: " + uxSelectGame.Text;
        }
        private void uxViewPlayer_Click(object sender, EventArgs e)
        {
            Player p = ((Player)uxSelectPlayer.SelectedItem);
            Game g = ((Game)uxSelectGame.SelectedItem);
            PlayerGameStatistics pgs = model.PlayerGameStatisticsRepo.GetPlayerGameStatisticsForPlayerGame(g.GameID, p.PlayerID);

            showViewPlayer();
            uxCurrPlayerLabel.Text = "Selected Player: " + uxSelectPlayer.Text;
            uxCurrGameLabel.Text = "Selected Game: " + uxSelectGame.Text;
            uxPlayerStats.Text = "Points: " + pgs.Points.ToString() + "\n" + "3Points: " + pgs.ThreePoints.ToString() + "\n" + "FGM: " + pgs.FGM.ToString() + "\n" + "FGA: " + pgs.FGA.ToString() + "\n" + "Rebounds: " + pgs.Rebounds.ToString() + "\n" + "Minutes: " + pgs.Minutes.ToString();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            if (close)
            {
                parent.Enabled = true;
                this.Close();
            }
            else
            {
                showMenu();
            }
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            Game g = ((Game)uxSelectGame.SelectedItem);
            Player p = ((Player)uxSelectPlayer.SelectedItem);
            School s = ((School)uxSelectTeam.SelectedItem);
            if (g != null && p != null && s != null && Points != -1 && ThreePoints != -1 && FGM != -1 && FGA != -1 && Rebounds != -1 && Minutes != -1)
            {
                model.PlayerGameStatisticsRepo.UpdatePlayerGameStatistics(g.GameID, p.PlayerID, s.SchoolID, Points, ThreePoints, FGM, FGA, Rebounds, Minutes); ;
            }
            else
            {
                MessageBox.Show("You must enter in all statistics to make an update!");
            }
            Points = -1;
            ThreePoints = -1;
            FGM = -1;
            FGA = -1;
            Rebounds = -1;
            Minutes = -1;
            uxBack_Click(sender, e);
        }

        private void Games_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }

        private void uxViewGame_Click(object sender, EventArgs e)
        {
            showViewPlayer();
            uxCurrPlayerLabel.Text = "";
            uxCurrGameLabel.Text = "Selected Game: " + uxSelectGame.Text;
            uxPlayerStats.Text = "Team 1 Points: N/A\nTeam 2 Points: N/A\nWinning Team: N/A";
        }

        private void uxUpdateGame_Click(object sender, EventArgs e)
        {
            UpdateGameStats form = new UpdateGameStats(model, ((Game)uxSelectGame.SelectedItem), this);
            this.Enabled = false;
            form.Show();
        }

        private void uxPoints_ValueChanged(object sender, EventArgs e)
        {
            Points = (int)uxPoints.Value;
        }

        private void uxFGM_ValueChanged(object sender, EventArgs e)
        {
            FGM = (int)uxFGM.Value;
        }

        private void uxFGA_ValueChanged(object sender, EventArgs e)
        {
            FGA = (int)uxFGA.Value;
        }

        private void uxRebounds_ValueChanged(object sender, EventArgs e)
        {
            Rebounds = (int)uxRebounds.Value;
        }

        private void uxMinutes_ValueChanged(object sender, EventArgs e)
        {
            Minutes = (int)uxMinutes.Value;
        }

        private void uxThreePoints_ValueChanged(object sender, EventArgs e)
        {
            ThreePoints = (int)uxThreePoints.Value;
        }
    }
}
