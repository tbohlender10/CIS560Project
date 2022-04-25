using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonData.Models;

namespace CIS560_Project
{
    public partial class Stats : Form
    {
        bool close = true;
        Form parent;
        Model model;
        int schoolID = 0;

        public Stats(Form f, Model m)
        {
            InitializeComponent();
            string[] allTeams = new string[64];
            int iterator = 0;
            foreach (School s in m.Schools)
            {
                allTeams[iterator] = s.Name;
                iterator++;
            }
            uxSelectTeam.DataSource = allTeams;


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
            model = m;
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

            string[] playersOnTeam = new string[30];
            int iterator = 0;

            foreach (School s in model.Schools)
            {
                if (s.Name.Equals(uxSelectTeam.Text))
                {
                    schoolID = s.SchoolID;
                    break;
                }
            }
            foreach (Player p in model.PlayerRepo.RetrievePlayersForSchool(schoolID))
            {
                playersOnTeam[iterator] = p.Name;
                iterator++;
            }
            uxSelectPlayer.SuspendLayout();

        }

        private void uxSelectPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxUpdatePlayer.Enabled = true;
            uxViewPlayer.Enabled = true;
        }

        private void uxViewTeam_Click(object sender, EventArgs e)
        {
            showViewStats();


            School currSchool = model.SchoolRepo.GetSchool(schoolID);
            PersonData.Models.Region region = (PersonData.Models.Region)currSchool.RegionId;
            uxInfo.Text = "School: " + uxSelectTeam.Text + "\nGames Won: N/A\nSeed: " + currSchool.Seed + "\nCoach: " + currSchool.Coach + "\nRegion: " + region.ToString();

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
            School currSchool = model.SchoolRepo.GetSchool(schoolID);
            uxName.Text = currSchool.Coach;
            uxSeed.Value = currSchool.Seed;
            uxRegion.SelectedIndex = currSchool.RegionId - 1;
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

        private void uxSelectPlayer_DataSourceChanged(object sender, EventArgs e)
        {
            uxSelectPlayer.Enabled = true;
        }
    }
}
