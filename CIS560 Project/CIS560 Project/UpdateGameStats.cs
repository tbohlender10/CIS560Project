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

        private BindingList<School> Schools;

        private Player SelectedPlayer;

        public UpdateGameStats(Model m, Game game, BindingList<School> schools, Player player)
        {
            InitializeComponent();
            Model = m;
            SelectedGame = game;
            Schools = schools;
            SelectedPlayer = player;

            //uxHomeSchoolLabel.Text = "Home School: " + homeSchool.ToString();
            //uxGuestSchoolLabel.Text = "Guest School: " + guestSchool.ToString();

            //uxHomeScore.Value = whatever;
            //uxGuestScore.Value = whatever;
        }

        private void uxBackButton_Click(object sender, EventArgs e)
        {

        }

        private void uxSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void uxHomeScore_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uxGuestScore_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
