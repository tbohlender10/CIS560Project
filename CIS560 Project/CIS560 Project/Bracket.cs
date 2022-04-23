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

            foreach (ComboBox control in this.Controls.OfType<ComboBox>().OrderBy(c => c.TabIndex))
            {
                BindingList<School> list;

                if (Model.DictionaryOfSchools.TryGetValue(control.TabIndex, out list))
                {
                    control.DataSource = list;
                }
                else
                {
                    throw new Exception("Could not assign values to data source of the control with tab index" + control.TabIndex.ToString());
                }
                i += 3;
            }
        }

        private void uxComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uxComboBox1.DataSource != null && uxComboBox2.DataSource != null && uxComboBox1.SelectedIndex >= 0 && uxComboBox2.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex97.Clear();

                Model.SchoolsTabIndex97.Add(((BindingList<School>)uxComboBox1.DataSource)[uxComboBox1.SelectedIndex]);
                Model.SchoolsTabIndex97.Add(((BindingList<School>)uxComboBox2.DataSource)[uxComboBox2.SelectedIndex]);

                uxComboBox33.SelectedItem = ((BindingList<School>)uxComboBox33.DataSource)[uxComboBox1.SelectedIndex];
            }
        }

        private void uxComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox1.DataSource != null && uxComboBox2.DataSource != null && uxComboBox1.SelectedIndex >= 0 && uxComboBox2.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex97.Clear();

                Model.SchoolsTabIndex97.Add(((BindingList<School>)uxComboBox1.DataSource)[uxComboBox1.SelectedIndex]);
                Model.SchoolsTabIndex97.Add(((BindingList<School>)uxComboBox2.DataSource)[uxComboBox2.SelectedIndex]);
            }
        }

        private void uxComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox3.DataSource != null && uxComboBox4.DataSource != null && uxComboBox3.SelectedIndex >= 0 && uxComboBox4.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex100.Clear();

                Model.SchoolsTabIndex100.Add(((BindingList<School>)uxComboBox3.DataSource)[uxComboBox3.SelectedIndex]);
                Model.SchoolsTabIndex100.Add(((BindingList<School>)uxComboBox4.DataSource)[uxComboBox4.SelectedIndex]);
            }
        }

        private void uxComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox3.DataSource != null && uxComboBox4.DataSource != null && uxComboBox3.SelectedIndex >= 0 && uxComboBox4.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex100.Clear();

                Model.SchoolsTabIndex100.Add(((BindingList<School>)uxComboBox3.DataSource)[uxComboBox3.SelectedIndex]);
                Model.SchoolsTabIndex100.Add(((BindingList<School>)uxComboBox4.DataSource)[uxComboBox4.SelectedIndex]);
            }
        }

        private void uxComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox5.DataSource != null && uxComboBox6.DataSource != null && uxComboBox5.SelectedIndex >= 0 && uxComboBox6.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex103.Clear();

                Model.SchoolsTabIndex103.Add(((BindingList<School>)uxComboBox5.DataSource)[uxComboBox5.SelectedIndex]);
                Model.SchoolsTabIndex103.Add(((BindingList<School>)uxComboBox6.DataSource)[uxComboBox6.SelectedIndex]);
            }
        }

        private void uxComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox5.DataSource != null && uxComboBox6.DataSource != null && uxComboBox5.SelectedIndex >= 0 && uxComboBox6.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex103.Clear();

                Model.SchoolsTabIndex103.Add(((BindingList<School>)uxComboBox5.DataSource)[uxComboBox5.SelectedIndex]);
                Model.SchoolsTabIndex103.Add(((BindingList<School>)uxComboBox6.DataSource)[uxComboBox6.SelectedIndex]);
            }
        }

        private void uxComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox7.DataSource != null && uxComboBox8.DataSource != null && uxComboBox7.SelectedIndex >= 0 && uxComboBox8.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex106.Clear();

                Model.SchoolsTabIndex106.Add(((BindingList<School>)uxComboBox7.DataSource)[uxComboBox7.SelectedIndex]);
                Model.SchoolsTabIndex106.Add(((BindingList<School>)uxComboBox8.DataSource)[uxComboBox8.SelectedIndex]);
            }
        }

        private void uxComboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox7.DataSource != null && uxComboBox8.DataSource != null && uxComboBox7.SelectedIndex >= 0 && uxComboBox8.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex106.Clear();

                Model.SchoolsTabIndex106.Add(((BindingList<School>)uxComboBox7.DataSource)[uxComboBox7.SelectedIndex]);
                Model.SchoolsTabIndex106.Add(((BindingList<School>)uxComboBox8.DataSource)[uxComboBox8.SelectedIndex]);
            }
        }

        private void uxComboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox9.DataSource != null && uxComboBox10.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex109.Clear();

                Model.SchoolsTabIndex109.Add(((BindingList<School>)uxComboBox9.DataSource)[uxComboBox9.SelectedIndex]);
                Model.SchoolsTabIndex109.Add(((BindingList<School>)uxComboBox10.DataSource)[uxComboBox10.SelectedIndex]);
            }
        }

        private void uxComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox9.DataSource != null && uxComboBox10.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex109.Clear();

                Model.SchoolsTabIndex109.Add(((BindingList<School>)uxComboBox9.DataSource)[uxComboBox9.SelectedIndex]);
                Model.SchoolsTabIndex109.Add(((BindingList<School>)uxComboBox10.DataSource)[uxComboBox10.SelectedIndex]);
            }
        }

        private void uxComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox11.DataSource != null && uxComboBox12.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex112.Clear();

                Model.SchoolsTabIndex112.Add(((BindingList<School>)uxComboBox11.DataSource)[uxComboBox11.SelectedIndex]);
                Model.SchoolsTabIndex112.Add(((BindingList<School>)uxComboBox12.DataSource)[uxComboBox12.SelectedIndex]);
            }
        }

        private void uxComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox11.DataSource != null && uxComboBox12.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex112.Clear();

                Model.SchoolsTabIndex112.Add(((BindingList<School>)uxComboBox11.DataSource)[uxComboBox11.SelectedIndex]);
                Model.SchoolsTabIndex112.Add(((BindingList<School>)uxComboBox12.DataSource)[uxComboBox12.SelectedIndex]);
            }
        }

        private void uxComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox13.DataSource != null && uxComboBox14.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex115.Clear();

                Model.SchoolsTabIndex115.Add(((BindingList<School>)uxComboBox13.DataSource)[uxComboBox13.SelectedIndex]);
                Model.SchoolsTabIndex115.Add(((BindingList<School>)uxComboBox14.DataSource)[uxComboBox14.SelectedIndex]);
            }
        }

        private void uxComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox13.DataSource != null && uxComboBox14.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex115.Clear();

                Model.SchoolsTabIndex115.Add(((BindingList<School>)uxComboBox13.DataSource)[uxComboBox13.SelectedIndex]);
                Model.SchoolsTabIndex115.Add(((BindingList<School>)uxComboBox14.DataSource)[uxComboBox14.SelectedIndex]);
            }
        }

        private void uxComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox15.DataSource != null && uxComboBox16.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex118.Clear();

                Model.SchoolsTabIndex118.Add(((BindingList<School>)uxComboBox15.DataSource)[uxComboBox15.SelectedIndex]);
                Model.SchoolsTabIndex118.Add(((BindingList<School>)uxComboBox16.DataSource)[uxComboBox16.SelectedIndex]);
            }
        }

        private void uxComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox15.DataSource != null && uxComboBox16.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex118.Clear();

                Model.SchoolsTabIndex118.Add(((BindingList<School>)uxComboBox15.DataSource)[uxComboBox15.SelectedIndex]);
                Model.SchoolsTabIndex118.Add(((BindingList<School>)uxComboBox16.DataSource)[uxComboBox16.SelectedIndex]);
            }
        }

        private void uxComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox17.DataSource != null && uxComboBox18.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex121.Clear();

                Model.SchoolsTabIndex121.Add(((BindingList<School>)uxComboBox17.DataSource)[uxComboBox17.SelectedIndex]);
                Model.SchoolsTabIndex121.Add(((BindingList<School>)uxComboBox18.DataSource)[uxComboBox18.SelectedIndex]);
            }
        }

        private void uxComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox17.DataSource != null && uxComboBox18.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex121.Clear();

                Model.SchoolsTabIndex121.Add(((BindingList<School>)uxComboBox17.DataSource)[uxComboBox17.SelectedIndex]);
                Model.SchoolsTabIndex121.Add(((BindingList<School>)uxComboBox18.DataSource)[uxComboBox18.SelectedIndex]);
            }
        }

        private void uxComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox19.DataSource != null && uxComboBox20.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex124.Clear();

                Model.SchoolsTabIndex124.Add(((BindingList<School>)uxComboBox19.DataSource)[uxComboBox19.SelectedIndex]);
                Model.SchoolsTabIndex124.Add(((BindingList<School>)uxComboBox20.DataSource)[uxComboBox20.SelectedIndex]);
            }
        }

        private void uxComboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox19.DataSource != null && uxComboBox20.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex124.Clear();

                Model.SchoolsTabIndex124.Add(((BindingList<School>)uxComboBox19.DataSource)[uxComboBox19.SelectedIndex]);
                Model.SchoolsTabIndex124.Add(((BindingList<School>)uxComboBox20.DataSource)[uxComboBox20.SelectedIndex]);
            }
        }

        private void uxComboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox21.DataSource != null && uxComboBox22.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex127.Clear();

                Model.SchoolsTabIndex127.Add(((BindingList<School>)uxComboBox21.DataSource)[uxComboBox21.SelectedIndex]);
                Model.SchoolsTabIndex127.Add(((BindingList<School>)uxComboBox22.DataSource)[uxComboBox22.SelectedIndex]);
            }
        }

        private void uxComboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox21.DataSource != null && uxComboBox22.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex127.Clear();

                Model.SchoolsTabIndex127.Add(((BindingList<School>)uxComboBox21.DataSource)[uxComboBox21.SelectedIndex]);
                Model.SchoolsTabIndex127.Add(((BindingList<School>)uxComboBox22.DataSource)[uxComboBox22.SelectedIndex]);
            }
        }

        private void uxComboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox23.DataSource != null && uxComboBox24.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex130.Clear();

                Model.SchoolsTabIndex130.Add(((BindingList<School>)uxComboBox23.DataSource)[uxComboBox23.SelectedIndex]);
                Model.SchoolsTabIndex130.Add(((BindingList<School>)uxComboBox24.DataSource)[uxComboBox24.SelectedIndex]);
            }
        }

        private void uxComboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox23.DataSource != null && uxComboBox24.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex130.Clear();

                Model.SchoolsTabIndex130.Add(((BindingList<School>)uxComboBox23.DataSource)[uxComboBox23.SelectedIndex]);
                Model.SchoolsTabIndex130.Add(((BindingList<School>)uxComboBox24.DataSource)[uxComboBox24.SelectedIndex]);
            }
        }

        private void uxComboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox25.DataSource != null && uxComboBox26.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex133.Clear();

                Model.SchoolsTabIndex133.Add(((BindingList<School>)uxComboBox25.DataSource)[uxComboBox25.SelectedIndex]);
                Model.SchoolsTabIndex133.Add(((BindingList<School>)uxComboBox26.DataSource)[uxComboBox26.SelectedIndex]);
            }
        }

        private void uxComboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox25.DataSource != null && uxComboBox26.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex133.Clear();

                Model.SchoolsTabIndex133.Add(((BindingList<School>)uxComboBox25.DataSource)[uxComboBox25.SelectedIndex]);
                Model.SchoolsTabIndex133.Add(((BindingList<School>)uxComboBox26.DataSource)[uxComboBox26.SelectedIndex]);
            }
        }

        private void uxComboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox27.DataSource != null && uxComboBox28.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex136.Clear();

                Model.SchoolsTabIndex136.Add(((BindingList<School>)uxComboBox27.DataSource)[uxComboBox27.SelectedIndex]);
                Model.SchoolsTabIndex136.Add(((BindingList<School>)uxComboBox28.DataSource)[uxComboBox28.SelectedIndex]);
            }
        }

        private void uxComboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox27.DataSource != null && uxComboBox28.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex136.Clear();

                Model.SchoolsTabIndex136.Add(((BindingList<School>)uxComboBox27.DataSource)[uxComboBox27.SelectedIndex]);
                Model.SchoolsTabIndex136.Add(((BindingList<School>)uxComboBox28.DataSource)[uxComboBox28.SelectedIndex]);
            }
        }

        private void uxComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox29.DataSource != null && uxComboBox30.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex139.Clear();

                Model.SchoolsTabIndex139.Add(((BindingList<School>)uxComboBox29.DataSource)[uxComboBox29.SelectedIndex]);
                Model.SchoolsTabIndex139.Add(((BindingList<School>)uxComboBox30.DataSource)[uxComboBox30.SelectedIndex]);
            }
        }

        private void uxComboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox29.DataSource != null && uxComboBox30.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex139.Clear();

                Model.SchoolsTabIndex139.Add(((BindingList<School>)uxComboBox29.DataSource)[uxComboBox29.SelectedIndex]);
                Model.SchoolsTabIndex139.Add(((BindingList<School>)uxComboBox30.DataSource)[uxComboBox30.SelectedIndex]);
            }
        }

        private void uxComboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox31.DataSource != null && uxComboBox32.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex142.Clear();

                Model.SchoolsTabIndex142.Add(((BindingList<School>)uxComboBox31.DataSource)[uxComboBox31.SelectedIndex]);
                Model.SchoolsTabIndex142.Add(((BindingList<School>)uxComboBox32.DataSource)[uxComboBox32.SelectedIndex]);
            }
        }

        private void uxComboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox31.DataSource != null && uxComboBox32.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex142.Clear();

                Model.SchoolsTabIndex142.Add(((BindingList<School>)uxComboBox31.DataSource)[uxComboBox31.SelectedIndex]);
                Model.SchoolsTabIndex142.Add(((BindingList<School>)uxComboBox32.DataSource)[uxComboBox32.SelectedIndex]);
            }
        }

        private void uxCombBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox33.DataSource != null && uxComboBox34.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex145.Clear();

                Model.SchoolsTabIndex145.Add(((BindingList<School>)uxComboBox33.DataSource)[uxComboBox33.SelectedIndex]);
                Model.SchoolsTabIndex145.Add(((BindingList<School>)uxComboBox34.DataSource)[uxComboBox34.SelectedIndex]);
            }
        }

        private void uxComboBox34_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox33.DataSource != null && uxComboBox34.DataSource != null && uxComboBox33.SelectedIndex >= 0 && uxComboBox34.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex145.Clear();

                Model.SchoolsTabIndex145.Add(((BindingList<School>)uxComboBox33.DataSource)[uxComboBox33.SelectedIndex]);
                Model.SchoolsTabIndex145.Add(((BindingList<School>)uxComboBox34.DataSource)[uxComboBox34.SelectedIndex]);
            }
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

        private void uxComboBox63_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxStats_Click(object sender, EventArgs e)
        {
            Form newForm = new Stats(this);
            this.Enabled = false;
            newForm.Show();
            //this.Close();
        }

        private void uxTourney_Click(object sender, EventArgs e)
        {
            
        }

        private void uxGames_Click(object sender, EventArgs e)
        {
            Form newForm = new Games(this);
            this.Enabled = false;
            newForm.Show();
        }
    }
}
