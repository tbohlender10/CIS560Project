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
    public partial class Stats : Form
    {
        bool close = true;
        Form parent;
        Model model;
        public Stats(Form f, Model m)
        {
            InitializeComponent();
            model = m;
            uxSelectTeam.DataSource = new string[]
            {
                //Temp data
                "item 1",
                "item 2",
                "item 3"
            };

            uxSelectPlayer.DataSource = new string[]
            {
                //Temp data
                "item 1",
                "item 2",
                "item 3"
            };

            uxRegion.DataSource = new string[]
            {
                "East",
                "West",
                "South",
                "Midwest"
            };

            uxGrade.DataSource = new string[]
            {
                "Freshman",
                "Sophomore",
                "Junior",
                "Senior"
            };
            uxInfo.Text = "";
            parent = f;
        }

        private void showMenu()
        {
            close = true;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            uxPlayerLabel.Show();
            uxTeamLabel.Show();
            uxSelectPlayer.Show();
            uxSelectTeam.Show();
            uxViewTeam.Show();
            uxViewPlayer.Show();
            uxUpdatePlayer.Show();
            uxUpdateTeam.Show();
            uxBack.Show();

        }

        private void showViewStats()
        {
            close = false;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            uxInfo.Show();
            uxBack.Show();
        }

        private void showUpdateTeam()
        {
            close = false;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            uxName.Show();
            uxNameLabel.Show();
            uxSeed.Show();
            uxSeedLabel.Show();
            uxRegion.Show();
            uxRegionLabel.Show();
            uxBack.Show();
            uxSave.Show();

            uxNameLabel.Text = "Coach:";


        }

        private void showUpdatePlayer()
        {
            close = false;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }

            uxName.Show();
            uxNameLabel.Show();
            uxGrade.Show();
            uxGradeLabel.Show();
            uxBack.Show();
            uxSave.Show();

            uxNameLabel.Text = "Player Name:";
            uxRegionLabel.Text = "Grade:";
        }

        private void uxSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxSelectPlayer.Enabled = true;
            uxViewTeam.Enabled = true;
            uxUpdateTeam.Enabled = true;

        }

        private void uxSelectPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
           uxUpdatePlayer.Enabled = true;
            uxViewPlayer.Enabled = true;
        }

        private void uxViewTeam_Click(object sender, EventArgs e)
        {
            showViewStats();
            uxInfo.Text = "School: " + uxSelectTeam.Text + "\nGames Won: N/A\nSeed: N/A\nCoach: N/A\nRegion: N/A";
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

        private void uxUpdateTeam_Click(object sender, EventArgs e)
        {
            showUpdateTeam();
        }

        private void uxViewPlayer_Click(object sender, EventArgs e)
        {
            showViewStats();
            uxInfo.Text = "Player: " + uxSelectPlayer.Text + "\nPlays for: " + uxSelectTeam.Text + "\nGrade: N/A";
        }

        private void uxUpdatePlayer_Click(object sender, EventArgs e)
        {
            showUpdatePlayer();
            uxName.Text = uxSelectPlayer.SelectedItem.ToString();

        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            //SQL Magic idk
            uxBack_Click(sender, e);
        }

        private void Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }
    }
}
