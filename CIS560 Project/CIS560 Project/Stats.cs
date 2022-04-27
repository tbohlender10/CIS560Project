using PersonData.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CIS560_Project
{
    public partial class Stats : Form
    {
        bool close = true;
        Form parent;
        Model model;
        int schoolID = 0;
        int prevSchoolID = -1;

        bool team = true;

        Player currPlayer;
        School currSchool;

        BindingList<String> players;
        public Stats(Form f, Model m)
        {
            InitializeComponent();
            string[] allTeams = new string[64];
            int iterator = 0;
            players = new BindingList<string>();
            foreach (School s in m.Schools)
            {
                allTeams[iterator] = s.Name;
                iterator++;
            }
            uxSelectTeam.DataSource = allTeams;


            uxPosition.DataSource = new string[]
            {
                "Forward",
                "Guard"
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
            team = true;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            uxName.Show();
            uxNameLabel.Show();
            uxBack.Show();
            uxSaveName.Show();

            uxNameLabel.Text = "Coach:";


        }

        private void showUpdatePlayer()
        {
            close = false;
            team = false;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }

            uxName.Show();
            uxNameLabel.Show();
            uxGrade.Show();
            uxGradeLabel.Show();
            uxBack.Show();
            uxSaveGrade.Show();
            uxSaveName.Show();
            uxPosition.Show();
            uxPositionLabel.Show();
            uxSavePosition.Show();
            uxNumber.Show();
            uxNumberLabel.Show();
            uxSaveNumber.Show();

            uxNameLabel.Text = "Player Name:";
        }

        private void uxSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxSelectPlayer.Enabled = true;
            uxViewTeam.Enabled = true;
            uxUpdateTeam.Enabled = true;
            BindingSource bs = new BindingSource();

            foreach (School s in model.Schools)
            {
                if (s.Name.Equals(uxSelectTeam.Text))
                {
                    schoolID = s.SchoolID;
                    break;
                }
            }
            currSchool = model.SchoolRepo.GetSchool(schoolID);
            bs.DataSource = players;
            uxSelectPlayer.DataSource = bs;
            foreach (Player p in model.PlayerRepo.RetrievePlayersForSchool(schoolID))
            {
                players.Add(p.Name);
            }

            if (prevSchoolID != -1)
            {
                foreach (Player p in model.PlayerRepo.RetrievePlayersForSchool(prevSchoolID))
                {
                    players.Remove(p.Name);
                }
            }
            prevSchoolID = schoolID;
            uxSelectPlayer_SelectedIndexChanged(sender, e);

        }

        private void uxSelectPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxUpdatePlayer.Enabled = true;
            uxViewPlayer.Enabled = true;
            currSchool = model.SchoolRepo.GetSchool(schoolID);
            int playerID = 0;
            foreach (Player p in model.PlayerRepo.RetrievePlayersForSchool(schoolID))
            {
                if (p.Name.Equals(uxSelectPlayer.Text))
                {
                    playerID = p.PlayerID;
                    break;
                }
            }
            currPlayer = model.PlayerRepo.FetchPlayer(playerID);

        }

        private void uxViewTeam_Click(object sender, EventArgs e)
        {
            showViewStats();

            PersonData.Models.Region region = (PersonData.Models.Region)currSchool.RegionId;
            uxInfo.Text = "School: " + uxSelectTeam.Text + "\n\nGames Won: N/A\n\nSeed: " + currSchool.Seed + "\n\nCoach: " + currSchool.Coach + "\n\nRegion: " + region.ToString();

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
            team = true;
            currSchool = model.SchoolRepo.GetSchool(schoolID);
            uxName.Text = currSchool.Coach;
        }

        private void uxViewPlayer_Click(object sender, EventArgs e)
        {
            showViewStats();
            uxInfo.Text = "Player: " + currPlayer.Name + "\n\nPlays for: " + currSchool.Name + "\n\nGrade: " + currPlayer.Grade + "\n\nNumber: " + currPlayer.Number + "\n\nPosition: " + currPlayer.Position;
        }

        private void uxUpdatePlayer_Click(object sender, EventArgs e)
        {
            showUpdatePlayer();
            team = false;
            uxName.Text = currPlayer.Name;
            uxGrade.SelectedItem = currPlayer.Grade;
            uxNumber.Value = currPlayer.Number;
            uxPosition.SelectedItem = currPlayer.Position;

        }


        private Player GetPlayer(int id)
        {
            int playerID = 0;
            foreach (Player p in model.PlayerRepo.RetrievePlayersForSchool(id))
            {
                if (p.Name.Equals(uxSelectPlayer.Text))
                {
                    playerID = p.PlayerID;
                    break;
                }
            }
            currPlayer = model.PlayerRepo.FetchPlayer(playerID);
            return currPlayer;
        }

        private void Save(object sender, EventArgs e)
        {
            //players.Clear();
            //uxSelectTeam_SelectedIndexChanged(sender, e);
            players.Remove(currPlayer.Name);
            players.Remove(uxName.Text);
            players.Add(uxName.Text);
            uxSelectTeam.Text = currSchool.Name;
            uxSelectPlayer.SelectedItem = uxName.Text;
            uxSelectPlayer_SelectedIndexChanged(sender, e);
        }


        private void Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }

        private void uxSelectPlayer_DataSourceChanged(object sender, EventArgs e)
        {
            uxSelectPlayer.Enabled = true;
        }

        private void uxSaveNumber_Click(object sender, EventArgs e)
        {
            try
            {
                model.PlayerRepo.UpdatePlayerNumber(currSchool.Name, currPlayer.Name, (int)uxNumber.Value);
            }
            catch
            {
                MessageBox.Show("Someone on this team already has this number, try a different number");
            }
            //uxSelectTeam_SelectedIndexChanged(sender, e);
            Save(sender, e);

        }

        private void uxSaveName_Click(object sender, EventArgs e)
        {

            if (team)
            {
                //Team stuff
                model.SchoolRepo.UpdateSchoolCoach(currSchool.SchoolID, uxName.Text);
                uxSelectTeam_SelectedIndexChanged(sender, e);
            }
            else
            {
                model.PlayerRepo.UpdatePlayerName(currSchool.Name, uxName.Text, currPlayer.Number);
                //uxSelectTeam_SelectedIndexChanged(sender, e);
                Save(sender, e);
            }

        }

        private void uxSaveGrade_Click(object sender, EventArgs e)
        {
            model.PlayerRepo.UpdatePlayerGrade(currSchool.Name, currPlayer.Name, uxGrade.Text.ToString());
            //uxSelectTeam_SelectedIndexChanged(sender, e);
            Save(sender, e);

        }

        private void uxSavePosition_Click(object sender, EventArgs e)
        {
            model.PlayerRepo.UpdatePlayerPosition(currSchool.Name, currPlayer.Name, uxPosition.Text);
            //uxSelectTeam_SelectedIndexChanged(sender, e);
            Save(sender, e);

        }
    }
}
