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
    public partial class Bracket : Form
    {
        Model Model;

        Controller Controller;

        public Bracket(Model model, Controller controller)
        {
            InitializeComponent();

            Model = model;

            Controller = controller;

            int i = 0;
        }

        private void uxStats_Click(object sender, EventArgs e)
        {
            Form newForm = new Stats(this, Model);
            this.Enabled = false;
            newForm.Show();
            //this.Close();
        }

        private void uxTourney_Click(object sender, EventArgs e)
        {
            Form newForm = new Tourney(this, Model);
            this.Enabled = false;
            newForm.Show();
        }

        private void uxGames_Click(object sender, EventArgs e)
        {
            Form newForm = new Games(this, Model);
            this.Enabled = false;
            newForm.Show();
        }
    }
}
