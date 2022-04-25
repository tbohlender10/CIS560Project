﻿using PersonData.Models;
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
    public partial class Games : Form
    {
        Form parent;
        private bool close;
        Model model;
        public Games(Form f, Model m)
        {
            InitializeComponent();
            close = true;
            parent = f;
            model = m;
            
            uxSelectGame.DataSource = model.GameRepo.RetrieveAllGames();

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
            uxSelectTeam.Enabled = true;
            uxViewGame.Enabled = true;
            uxUpdateGame.Enabled = true;

            uxSelectTeam.DataSource = model.GameRepo.RetrieveSchoolsForGame(((Game)uxSelectGame.SelectedItem).GameID);
        }

        private void uxSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxSelectPlayer.Enabled = true;
        }

        private void uxSelectPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxEditPlayer.Enabled = true;
            uxViewPlayer.Enabled = true;
        }

        private void uxEditPlayer_Click(object sender, EventArgs e)
        {
            showUpdatePlayer();
            uxCurrPlayerLabel.Text = "Selected Player: " + uxSelectPlayer.Text;
            uxCurrGameLabel.Text = "Selected Game: " + uxSelectGame.Text;
        }
        private void uxViewPlayer_Click(object sender, EventArgs e)
        {
            showViewPlayer();
            uxCurrPlayerLabel.Text = "Selected Player: " + uxSelectPlayer.Text;
            uxCurrGameLabel.Text = "Selected Game: " + uxSelectGame.Text;
            uxPlayerStats.Text = "Points: N/A\nFGM: N/A\nFGA: N/A\nRebounds: N/A\nMinutes: N/A";
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
            //SQL Magic idk
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
           
        }
    }
}
