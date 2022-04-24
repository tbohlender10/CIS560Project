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
    public partial class Tourney : Form
    {
        Form parent;
        private bool close;
        Model model;
        public Tourney(Form f, Model m)
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            label3.Text = "";
            label5.Text = "";

            parent = f;
            close = true;
            model = m;
        }

        private void ShowMenu()
        {
            close = true;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            uxBack.Show();
            uxPointDiff.Show();
            uxPPG.Show();
            uxWins.Show();
            uxUpsets.Show();
        }

        private void ShowWins()
        {
            close = false;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            label1.Show();
            label2.Show();
            label4.Show();
            label3.Show();
            uxBack.Show();
        }

        private void ShowSmallQueries()
        {
            close = false;
            foreach (Control c in this.Controls)
            {
                c.Hide();
            }
            label5.Show();
            uxBack.Show();
        }

        private void uxWins_Click(object sender, EventArgs e)
        {
            ShowWins();
            label1.Text = "1.\n2.\n3.\n...";
            label2.Text = "17.\n18.\n19.\n...";
            label3.Text = "33.\n34.\n35.\n...";
            label4.Text = "49.\n50.\n51.\n...";
        }

        private void uxPPG_Click(object sender, EventArgs e)
        {
            ShowWins();
            label1.Text = "Region 1:";
            label2.Text = "Region 2:";
            label3.Text = "Region 3:";
            label4.Text = "Region 4:";

        }

        private void uxPointDiff_Click(object sender, EventArgs e)
        {
            ShowSmallQueries();
            label5.Text = "1.\n2.\n3.\n4.\n5.";
        }

        private void uxUpsets_Click(object sender, EventArgs e)
        {
            ShowSmallQueries();
            label5.Text = "1.\n2.\n3.\n4.\n5.";
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
                ShowMenu();
            }
        }

        private void Tourney_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }
    }
}
