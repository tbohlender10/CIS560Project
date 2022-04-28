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

        private void uxWins_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            ShowWins();
            for(int i = 0; i < 16; i++)
            {
                label1.Text += (i + 1) + ". " + model.SchoolWins[i] + "\n";
            }
            for (int i = 16; i < 32; i++)
            {
                label2.Text += (i + 1) + ". " + model.SchoolWins[i] + "\n";
            }
            for (int i = 32; i < 48; i++)
            {
                label3.Text += (i + 1) + ". " + model.SchoolWins[i] + "\n";
            }
            for (int i = 48; i < 64; i++)
            {
                label4.Text += (i + 1) + ". " + model.SchoolWins[i] + "\n";
            }
        }

        private void uxPPG_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            ShowWins();
            for (int i = 0; i < 5; i++)
            {
                label1.Text += (i + 1) + ". " + model.AllPPG[i] + "\n\n";
            }
            for (int i = 5; i < 10; i++)
            {
                label3.Text += (i + 1) + ". " + model.AllPPG[i] + "\n\n";
            }
        }

        private void uxPointDiff_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            ShowWins();
            for (int i = 0; i < 8 && i < model.AllPointDiff.Count; i++)
            {
                label1.Text += " Margin of " + model.AllPointDiff[i] + "\n\n";
            }
            for (int i = 8; i < 16 && i < model.AllPointDiff.Count; i++)
            {
                label2.Text += " Margin of " + model.AllPointDiff[i] + "\n\n";
            }
            for (int i = 16; i < 24 && i < model.AllPointDiff.Count; i++)
            {
                label3.Text += " Margin of " + model.AllPointDiff[i] + "\n\n";
            }
            for (int i = 24; i < model.AllPointDiff.Count; i++)
            {
                label4.Text += " Margin of " + model.AllPointDiff[i] + "\n\n";
            }
        }

        private void uxUpsets_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            ShowWins();
            for (int i = 0; i < 8 && i < model.AllUpsets.Count; i++)
            {
                label1.Text += (i + 1) + ". " + model.AllUpsets[i] + "\n\n";
            }
            for (int i = 8; i < 16 && i < model.AllUpsets.Count; i++)
            {
                label3.Text += (i + 1) + ". " + model.AllUpsets[i] + "\n\n";
            }
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
