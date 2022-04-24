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
            if (uxComboBox9.DataSource != null && uxComboBox10.DataSource != null && uxComboBox9.SelectedIndex >= 0 && uxComboBox10.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex109.Clear();

                Model.SchoolsTabIndex109.Add(((BindingList<School>)uxComboBox9.DataSource)[uxComboBox9.SelectedIndex]);
                Model.SchoolsTabIndex109.Add(((BindingList<School>)uxComboBox10.DataSource)[uxComboBox10.SelectedIndex]);
            }
        }

        private void uxComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox9.DataSource != null && uxComboBox10.DataSource != null && uxComboBox9.SelectedIndex >= 0 && uxComboBox10.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex109.Clear();

                Model.SchoolsTabIndex109.Add(((BindingList<School>)uxComboBox9.DataSource)[uxComboBox9.SelectedIndex]);
                Model.SchoolsTabIndex109.Add(((BindingList<School>)uxComboBox10.DataSource)[uxComboBox10.SelectedIndex]);
            }
        }

        private void uxComboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox11.DataSource != null && uxComboBox12.DataSource != null && uxComboBox11.SelectedIndex >= 0 && uxComboBox12.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex112.Clear();

                Model.SchoolsTabIndex112.Add(((BindingList<School>)uxComboBox11.DataSource)[uxComboBox11.SelectedIndex]);
                Model.SchoolsTabIndex112.Add(((BindingList<School>)uxComboBox12.DataSource)[uxComboBox12.SelectedIndex]);
            }
        }

        private void uxComboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox11.DataSource != null && uxComboBox12.DataSource != null && uxComboBox11.SelectedIndex >= 0 && uxComboBox12.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex112.Clear();

                Model.SchoolsTabIndex112.Add(((BindingList<School>)uxComboBox11.DataSource)[uxComboBox11.SelectedIndex]);
                Model.SchoolsTabIndex112.Add(((BindingList<School>)uxComboBox12.DataSource)[uxComboBox12.SelectedIndex]);
            }
        }

        private void uxComboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox13.DataSource != null && uxComboBox14.DataSource != null && uxComboBox13.SelectedIndex >= 0 && uxComboBox14.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex115.Clear();

                Model.SchoolsTabIndex115.Add(((BindingList<School>)uxComboBox13.DataSource)[uxComboBox13.SelectedIndex]);
                Model.SchoolsTabIndex115.Add(((BindingList<School>)uxComboBox14.DataSource)[uxComboBox14.SelectedIndex]);
            }
        }

        private void uxComboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox13.DataSource != null && uxComboBox14.DataSource != null && uxComboBox13.SelectedIndex >= 0 && uxComboBox14.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex115.Clear();

                Model.SchoolsTabIndex115.Add(((BindingList<School>)uxComboBox13.DataSource)[uxComboBox13.SelectedIndex]);
                Model.SchoolsTabIndex115.Add(((BindingList<School>)uxComboBox14.DataSource)[uxComboBox14.SelectedIndex]);
            }
        }

        private void uxComboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox15.DataSource != null && uxComboBox16.DataSource != null && uxComboBox15.SelectedIndex >= 0 && uxComboBox16.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex118.Clear();

                Model.SchoolsTabIndex118.Add(((BindingList<School>)uxComboBox15.DataSource)[uxComboBox15.SelectedIndex]);
                Model.SchoolsTabIndex118.Add(((BindingList<School>)uxComboBox16.DataSource)[uxComboBox16.SelectedIndex]);
            }
        }

        private void uxComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox15.DataSource != null && uxComboBox16.DataSource != null && uxComboBox15.SelectedIndex >= 0 && uxComboBox16.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex118.Clear();

                Model.SchoolsTabIndex118.Add(((BindingList<School>)uxComboBox15.DataSource)[uxComboBox15.SelectedIndex]);
                Model.SchoolsTabIndex118.Add(((BindingList<School>)uxComboBox16.DataSource)[uxComboBox16.SelectedIndex]);
            }
        }

        private void uxComboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox17.DataSource != null && uxComboBox18.DataSource != null && uxComboBox17.SelectedIndex >= 0 && uxComboBox18.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex121.Clear();

                Model.SchoolsTabIndex121.Add(((BindingList<School>)uxComboBox17.DataSource)[uxComboBox17.SelectedIndex]);
                Model.SchoolsTabIndex121.Add(((BindingList<School>)uxComboBox18.DataSource)[uxComboBox18.SelectedIndex]);
            }
        }

        private void uxComboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox17.DataSource != null && uxComboBox18.DataSource != null && uxComboBox17.SelectedIndex >= 0 && uxComboBox18.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex121.Clear();

                Model.SchoolsTabIndex121.Add(((BindingList<School>)uxComboBox17.DataSource)[uxComboBox17.SelectedIndex]);
                Model.SchoolsTabIndex121.Add(((BindingList<School>)uxComboBox18.DataSource)[uxComboBox18.SelectedIndex]);
            }
        }

        private void uxComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox19.DataSource != null && uxComboBox20.DataSource != null && uxComboBox19.SelectedIndex >= 0 && uxComboBox20.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex124.Clear();

                Model.SchoolsTabIndex124.Add(((BindingList<School>)uxComboBox19.DataSource)[uxComboBox19.SelectedIndex]);
                Model.SchoolsTabIndex124.Add(((BindingList<School>)uxComboBox20.DataSource)[uxComboBox20.SelectedIndex]);
            }
        }

        private void uxComboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox19.DataSource != null && uxComboBox20.DataSource != null && uxComboBox19.SelectedIndex >= 0 && uxComboBox20.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex124.Clear();

                Model.SchoolsTabIndex124.Add(((BindingList<School>)uxComboBox19.DataSource)[uxComboBox19.SelectedIndex]);
                Model.SchoolsTabIndex124.Add(((BindingList<School>)uxComboBox20.DataSource)[uxComboBox20.SelectedIndex]);
            }
        }

        private void uxComboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox21.DataSource != null && uxComboBox22.DataSource != null && uxComboBox21.SelectedIndex >= 0 && uxComboBox22.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex127.Clear();

                Model.SchoolsTabIndex127.Add(((BindingList<School>)uxComboBox21.DataSource)[uxComboBox21.SelectedIndex]);
                Model.SchoolsTabIndex127.Add(((BindingList<School>)uxComboBox22.DataSource)[uxComboBox22.SelectedIndex]);
            }
        }

        private void uxComboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox21.DataSource != null && uxComboBox22.DataSource != null && uxComboBox21.SelectedIndex >= 0 && uxComboBox22.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex127.Clear();

                Model.SchoolsTabIndex127.Add(((BindingList<School>)uxComboBox21.DataSource)[uxComboBox21.SelectedIndex]);
                Model.SchoolsTabIndex127.Add(((BindingList<School>)uxComboBox22.DataSource)[uxComboBox22.SelectedIndex]);
            }
        }

        private void uxComboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox23.DataSource != null && uxComboBox24.DataSource != null && uxComboBox23.SelectedIndex >= 0 && uxComboBox24.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex130.Clear();

                Model.SchoolsTabIndex130.Add(((BindingList<School>)uxComboBox23.DataSource)[uxComboBox23.SelectedIndex]);
                Model.SchoolsTabIndex130.Add(((BindingList<School>)uxComboBox24.DataSource)[uxComboBox24.SelectedIndex]);
            }
        }

        private void uxComboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox23.DataSource != null && uxComboBox24.DataSource != null && uxComboBox23.SelectedIndex >= 0 && uxComboBox24.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex130.Clear();

                Model.SchoolsTabIndex130.Add(((BindingList<School>)uxComboBox23.DataSource)[uxComboBox23.SelectedIndex]);
                Model.SchoolsTabIndex130.Add(((BindingList<School>)uxComboBox24.DataSource)[uxComboBox24.SelectedIndex]);
            }
        }

        private void uxComboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox25.DataSource != null && uxComboBox26.DataSource != null && uxComboBox25.SelectedIndex >= 0 && uxComboBox26.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex133.Clear();

                Model.SchoolsTabIndex133.Add(((BindingList<School>)uxComboBox25.DataSource)[uxComboBox25.SelectedIndex]);
                Model.SchoolsTabIndex133.Add(((BindingList<School>)uxComboBox26.DataSource)[uxComboBox26.SelectedIndex]);
            }
        }

        private void uxComboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox25.DataSource != null && uxComboBox26.DataSource != null && uxComboBox25.SelectedIndex >= 0 && uxComboBox26.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex133.Clear();

                Model.SchoolsTabIndex133.Add(((BindingList<School>)uxComboBox25.DataSource)[uxComboBox25.SelectedIndex]);
                Model.SchoolsTabIndex133.Add(((BindingList<School>)uxComboBox26.DataSource)[uxComboBox26.SelectedIndex]);
            }
        }

        private void uxComboBox27_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox27.DataSource != null && uxComboBox28.DataSource != null && uxComboBox27.SelectedIndex >= 0 && uxComboBox28.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex136.Clear();

                Model.SchoolsTabIndex136.Add(((BindingList<School>)uxComboBox27.DataSource)[uxComboBox27.SelectedIndex]);
                Model.SchoolsTabIndex136.Add(((BindingList<School>)uxComboBox28.DataSource)[uxComboBox28.SelectedIndex]);
            }
        }

        private void uxComboBox28_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox27.DataSource != null && uxComboBox28.DataSource != null && uxComboBox27.SelectedIndex >= 0 && uxComboBox28.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex136.Clear();

                Model.SchoolsTabIndex136.Add(((BindingList<School>)uxComboBox27.DataSource)[uxComboBox27.SelectedIndex]);
                Model.SchoolsTabIndex136.Add(((BindingList<School>)uxComboBox28.DataSource)[uxComboBox28.SelectedIndex]);
            }
        }

        private void uxComboBox29_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox29.DataSource != null && uxComboBox30.DataSource != null && uxComboBox29.SelectedIndex >= 0 && uxComboBox30.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex139.Clear();

                Model.SchoolsTabIndex139.Add(((BindingList<School>)uxComboBox29.DataSource)[uxComboBox29.SelectedIndex]);
                Model.SchoolsTabIndex139.Add(((BindingList<School>)uxComboBox30.DataSource)[uxComboBox30.SelectedIndex]);
            }
        }

        private void uxComboBox30_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox29.DataSource != null && uxComboBox30.DataSource != null && uxComboBox29.SelectedIndex >= 0 && uxComboBox30.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex139.Clear();

                Model.SchoolsTabIndex139.Add(((BindingList<School>)uxComboBox29.DataSource)[uxComboBox29.SelectedIndex]);
                Model.SchoolsTabIndex139.Add(((BindingList<School>)uxComboBox30.DataSource)[uxComboBox30.SelectedIndex]);
            }
        }

        private void uxComboBox31_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox31.DataSource != null && uxComboBox32.DataSource != null && uxComboBox31.SelectedIndex >= 0 && uxComboBox32.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex142.Clear();

                Model.SchoolsTabIndex142.Add(((BindingList<School>)uxComboBox31.DataSource)[uxComboBox31.SelectedIndex]);
                Model.SchoolsTabIndex142.Add(((BindingList<School>)uxComboBox32.DataSource)[uxComboBox32.SelectedIndex]);
            }
        }

        private void uxComboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox31.DataSource != null && uxComboBox32.DataSource != null && uxComboBox31.SelectedIndex >= 0 && uxComboBox32.SelectedIndex >= 0)
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
            if (uxComboBox35.DataSource != null && uxComboBox36.DataSource != null && uxComboBox35.SelectedIndex >= 0 && uxComboBox36.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex148.Clear();

                Model.SchoolsTabIndex148.Add(((BindingList<School>)uxComboBox35.DataSource)[uxComboBox35.SelectedIndex]);
                Model.SchoolsTabIndex148.Add(((BindingList<School>)uxComboBox36.DataSource)[uxComboBox36.SelectedIndex]);
            }
        }

        private void uxComboBox36_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox35.DataSource != null && uxComboBox36.DataSource != null && uxComboBox35.SelectedIndex >= 0 && uxComboBox36.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex148.Clear();

                Model.SchoolsTabIndex148.Add(((BindingList<School>)uxComboBox35.DataSource)[uxComboBox35.SelectedIndex]);
                Model.SchoolsTabIndex148.Add(((BindingList<School>)uxComboBox36.DataSource)[uxComboBox36.SelectedIndex]);
            }
        }

        private void uxComboBox37_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox37.DataSource != null && uxComboBox38.DataSource != null && uxComboBox37.SelectedIndex >= 0 && uxComboBox38.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex151.Clear();

                Model.SchoolsTabIndex151.Add(((BindingList<School>)uxComboBox37.DataSource)[uxComboBox37.SelectedIndex]);
                Model.SchoolsTabIndex151.Add(((BindingList<School>)uxComboBox38.DataSource)[uxComboBox38.SelectedIndex]);
            }
        }

        private void uxComboBox38_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox37.DataSource != null && uxComboBox38.DataSource != null && uxComboBox37.SelectedIndex >= 0 && uxComboBox38.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex151.Clear();

                Model.SchoolsTabIndex151.Add(((BindingList<School>)uxComboBox37.DataSource)[uxComboBox37.SelectedIndex]);
                Model.SchoolsTabIndex151.Add(((BindingList<School>)uxComboBox38.DataSource)[uxComboBox38.SelectedIndex]);
            }
        }

        private void uxComboBox39_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox39.DataSource != null && uxComboBox40.DataSource != null && uxComboBox39.SelectedIndex >= 0 && uxComboBox40.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex154.Clear();

                Model.SchoolsTabIndex154.Add(((BindingList<School>)uxComboBox39.DataSource)[uxComboBox39.SelectedIndex]);
                Model.SchoolsTabIndex154.Add(((BindingList<School>)uxComboBox40.DataSource)[uxComboBox40.SelectedIndex]);
            }
        }

        private void uxComboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox39.DataSource != null && uxComboBox40.DataSource != null && uxComboBox39.SelectedIndex >= 0 && uxComboBox40.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex154.Clear();

                Model.SchoolsTabIndex154.Add(((BindingList<School>)uxComboBox39.DataSource)[uxComboBox39.SelectedIndex]);
                Model.SchoolsTabIndex154.Add(((BindingList<School>)uxComboBox40.DataSource)[uxComboBox40.SelectedIndex]);
            }
        }

        private void uxComboBox41_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox41.DataSource != null && uxComboBox42.DataSource != null && uxComboBox41.SelectedIndex >= 0 && uxComboBox42.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex157.Clear();

                Model.SchoolsTabIndex157.Add(((BindingList<School>)uxComboBox41.DataSource)[uxComboBox41.SelectedIndex]);
                Model.SchoolsTabIndex157.Add(((BindingList<School>)uxComboBox42.DataSource)[uxComboBox42.SelectedIndex]);
            }
        }

        private void uxComboBox42_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox41.DataSource != null && uxComboBox42.DataSource != null && uxComboBox41.SelectedIndex >= 0 && uxComboBox42.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex157.Clear();

                Model.SchoolsTabIndex157.Add(((BindingList<School>)uxComboBox41.DataSource)[uxComboBox41.SelectedIndex]);
                Model.SchoolsTabIndex157.Add(((BindingList<School>)uxComboBox42.DataSource)[uxComboBox42.SelectedIndex]);
            }
        }

        private void uxComboBox43_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox43.DataSource != null && uxComboBox44.DataSource != null && uxComboBox43.SelectedIndex >= 0 && uxComboBox44.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex160.Clear();

                Model.SchoolsTabIndex160.Add(((BindingList<School>)uxComboBox43.DataSource)[uxComboBox43.SelectedIndex]);
                Model.SchoolsTabIndex160.Add(((BindingList<School>)uxComboBox44.DataSource)[uxComboBox44.SelectedIndex]);
            }
        }

        private void uxComboBox44_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox43.DataSource != null && uxComboBox44.DataSource != null && uxComboBox43.SelectedIndex >= 0 && uxComboBox44.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex160.Clear();

                Model.SchoolsTabIndex160.Add(((BindingList<School>)uxComboBox43.DataSource)[uxComboBox43.SelectedIndex]);
                Model.SchoolsTabIndex160.Add(((BindingList<School>)uxComboBox44.DataSource)[uxComboBox44.SelectedIndex]);
            }
        }

        private void uxComboBox45_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox45.DataSource != null && uxComboBox46.DataSource != null && uxComboBox45.SelectedIndex >= 0 && uxComboBox46.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex163.Clear();

                Model.SchoolsTabIndex163.Add(((BindingList<School>)uxComboBox45.DataSource)[uxComboBox45.SelectedIndex]);
                Model.SchoolsTabIndex163.Add(((BindingList<School>)uxComboBox46.DataSource)[uxComboBox46.SelectedIndex]);
            }
        }

        private void uxComboBox46_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox45.DataSource != null && uxComboBox46.DataSource != null && uxComboBox45.SelectedIndex >= 0 && uxComboBox46.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex163.Clear();

                Model.SchoolsTabIndex163.Add(((BindingList<School>)uxComboBox45.DataSource)[uxComboBox45.SelectedIndex]);
                Model.SchoolsTabIndex163.Add(((BindingList<School>)uxComboBox46.DataSource)[uxComboBox46.SelectedIndex]);
            }
        }

        private void uxComboBox47_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox47.DataSource != null && uxComboBox48.DataSource != null && uxComboBox47.SelectedIndex >= 0 && uxComboBox48.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex166.Clear();

                Model.SchoolsTabIndex166.Add(((BindingList<School>)uxComboBox47.DataSource)[uxComboBox47.SelectedIndex]);
                Model.SchoolsTabIndex166.Add(((BindingList<School>)uxComboBox48.DataSource)[uxComboBox48.SelectedIndex]);
            }
        }

        private void uxComboBox48_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox47.DataSource != null && uxComboBox48.DataSource != null && uxComboBox47.SelectedIndex >= 0 && uxComboBox48.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex166.Clear();

                Model.SchoolsTabIndex166.Add(((BindingList<School>)uxComboBox47.DataSource)[uxComboBox47.SelectedIndex]);
                Model.SchoolsTabIndex166.Add(((BindingList<School>)uxComboBox48.DataSource)[uxComboBox48.SelectedIndex]);
            }
        }

        private void uxComboBox49_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox49.DataSource != null && uxComboBox50.DataSource != null && uxComboBox49.SelectedIndex >= 0 && uxComboBox50.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex169.Clear();

                Model.SchoolsTabIndex169.Add(((BindingList<School>)uxComboBox49.DataSource)[uxComboBox49.SelectedIndex]);
                Model.SchoolsTabIndex169.Add(((BindingList<School>)uxComboBox50.DataSource)[uxComboBox50.SelectedIndex]);
            }
        }

        private void uxComboBox50_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox49.DataSource != null && uxComboBox50.DataSource != null && uxComboBox49.SelectedIndex >= 0 && uxComboBox50.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex169.Clear();

                Model.SchoolsTabIndex169.Add(((BindingList<School>)uxComboBox49.DataSource)[uxComboBox49.SelectedIndex]);
                Model.SchoolsTabIndex169.Add(((BindingList<School>)uxComboBox50.DataSource)[uxComboBox50.SelectedIndex]);
            }
        }

        private void uxComboBox51_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox51.DataSource != null && uxComboBox52.DataSource != null && uxComboBox51.SelectedIndex >= 0 && uxComboBox52.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex172.Clear();

                Model.SchoolsTabIndex172.Add(((BindingList<School>)uxComboBox51.DataSource)[uxComboBox51.SelectedIndex]);
                Model.SchoolsTabIndex172.Add(((BindingList<School>)uxComboBox52.DataSource)[uxComboBox52.SelectedIndex]);
            }
        }

        private void uxComboBox52_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox51.DataSource != null && uxComboBox52.DataSource != null && uxComboBox51.SelectedIndex >= 0 && uxComboBox52.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex172.Clear();

                Model.SchoolsTabIndex172.Add(((BindingList<School>)uxComboBox51.DataSource)[uxComboBox51.SelectedIndex]);
                Model.SchoolsTabIndex172.Add(((BindingList<School>)uxComboBox52.DataSource)[uxComboBox52.SelectedIndex]);
            }
        }

        private void uxComboBox53_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox53.DataSource != null && uxComboBox54.DataSource != null && uxComboBox53.SelectedIndex >= 0 && uxComboBox54.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex175.Clear();

                Model.SchoolsTabIndex175.Add(((BindingList<School>)uxComboBox53.DataSource)[uxComboBox53.SelectedIndex]);
                Model.SchoolsTabIndex175.Add(((BindingList<School>)uxComboBox54.DataSource)[uxComboBox54.SelectedIndex]);
            }
        }

        private void uxComboBox54_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox53.DataSource != null && uxComboBox54.DataSource != null && uxComboBox53.SelectedIndex >= 0 && uxComboBox54.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex175.Clear();

                Model.SchoolsTabIndex175.Add(((BindingList<School>)uxComboBox53.DataSource)[uxComboBox53.SelectedIndex]);
                Model.SchoolsTabIndex175.Add(((BindingList<School>)uxComboBox54.DataSource)[uxComboBox54.SelectedIndex]);
            }
        }

        private void uxComboBox55_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox55.DataSource != null && uxComboBox56.DataSource != null && uxComboBox55.SelectedIndex >= 0 && uxComboBox56.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex178.Clear();

                Model.SchoolsTabIndex178.Add(((BindingList<School>)uxComboBox55.DataSource)[uxComboBox55.SelectedIndex]);
                Model.SchoolsTabIndex178.Add(((BindingList<School>)uxComboBox56.DataSource)[uxComboBox56.SelectedIndex]);
            }
        }

        private void uxComboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox55.DataSource != null && uxComboBox56.DataSource != null && uxComboBox55.SelectedIndex >= 0 && uxComboBox56.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex178.Clear();

                Model.SchoolsTabIndex178.Add(((BindingList<School>)uxComboBox55.DataSource)[uxComboBox55.SelectedIndex]);
                Model.SchoolsTabIndex178.Add(((BindingList<School>)uxComboBox56.DataSource)[uxComboBox56.SelectedIndex]);
            }
        }

        private void uxComboBox57_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox57.DataSource != null && uxComboBox58.DataSource != null && uxComboBox57.SelectedIndex >= 0 && uxComboBox58.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex181.Clear();

                Model.SchoolsTabIndex181.Add(((BindingList<School>)uxComboBox57.DataSource)[uxComboBox57.SelectedIndex]);
                Model.SchoolsTabIndex181.Add(((BindingList<School>)uxComboBox58.DataSource)[uxComboBox58.SelectedIndex]);
            }
        }

        private void uxComboBox58_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox57.DataSource != null && uxComboBox58.DataSource != null && uxComboBox57.SelectedIndex >= 0 && uxComboBox58.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex181.Clear();

                Model.SchoolsTabIndex181.Add(((BindingList<School>)uxComboBox57.DataSource)[uxComboBox57.SelectedIndex]);
                Model.SchoolsTabIndex181.Add(((BindingList<School>)uxComboBox58.DataSource)[uxComboBox58.SelectedIndex]);
            }
        }

        private void uxComboBox59_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox59.DataSource != null && uxComboBox60.DataSource != null && uxComboBox59.SelectedIndex >= 0 && uxComboBox60.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex184.Clear();

                Model.SchoolsTabIndex184.Add(((BindingList<School>)uxComboBox59.DataSource)[uxComboBox59.SelectedIndex]);
                Model.SchoolsTabIndex184.Add(((BindingList<School>)uxComboBox60.DataSource)[uxComboBox60.SelectedIndex]);
            }
        }

        private void uxComboBox60_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox59.DataSource != null && uxComboBox60.DataSource != null && uxComboBox59.SelectedIndex >= 0 && uxComboBox60.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex184.Clear();

                Model.SchoolsTabIndex184.Add(((BindingList<School>)uxComboBox59.DataSource)[uxComboBox59.SelectedIndex]);
                Model.SchoolsTabIndex184.Add(((BindingList<School>)uxComboBox60.DataSource)[uxComboBox60.SelectedIndex]);
            }
        }

        private void uxComboBox61_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox61.DataSource != null && uxComboBox62.DataSource != null && uxComboBox61.SelectedIndex >= 0 && uxComboBox62.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex187.Clear();

                Model.SchoolsTabIndex187.Add(((BindingList<School>)uxComboBox61.DataSource)[uxComboBox61.SelectedIndex]);
                Model.SchoolsTabIndex187.Add(((BindingList<School>)uxComboBox62.DataSource)[uxComboBox62.SelectedIndex]);
            }
        }

        private void uxComboBox62_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxComboBox61.DataSource != null && uxComboBox62.DataSource != null && uxComboBox61.SelectedIndex >= 0 && uxComboBox62.SelectedIndex >= 0)
            {
                Model.SchoolsTabIndex187.Clear();

                Model.SchoolsTabIndex187.Add(((BindingList<School>)uxComboBox61.DataSource)[uxComboBox61.SelectedIndex]);
                Model.SchoolsTabIndex187.Add(((BindingList<School>)uxComboBox62.DataSource)[uxComboBox62.SelectedIndex]);
            }
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
