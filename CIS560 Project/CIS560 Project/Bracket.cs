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

        public Bracket(Model m)
        {
            InitializeComponent();

            Model = m;

            //Possibly could use this loop to easily connect to SQL?
            foreach (ComboBox control in this.Controls.OfType<ComboBox>().OrderBy(c => c.TabIndex))
            {
                control.DataSource = new string[]
                    {
                        "",
                        "Team 1",
                        "Team 2"
                    };
            }
        }

        private void uxComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxCombBox33_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox35_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox51_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox52_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox53_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox54_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox55_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox60_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox61_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxComboBox62_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            Form newForm = new Games(this);
            this.Enabled = false;
            newForm.Show();
        }
    }
}
