using PersonData;
using PersonData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_Project
{
    public class Model
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560Project;Integrated Security=SSPI;";

        public SqlPlayerRepository PlayerRepo;

        public SqlSchoolRepository SchoolRepo;

        public SqlGameRepository GameRepo;

        public List<School> Schools;

        public Dictionary<int, BindingList<School>> DictionaryOfSchools;

        //West Schools Lists

        public BindingList<School> SchoolsTabIndex1;

        public BindingList<School> SchoolsTabIndex4;

        public BindingList<School> SchoolsTabIndex7;

        public BindingList<School> SchoolsTabIndex10;

        public BindingList<School> SchoolsTabIndex13;

        public BindingList<School> SchoolsTabIndex16;

        public BindingList<School> SchoolsTabIndex19;

        public BindingList<School> SchoolsTabIndex22;

        public BindingList<School> SchoolsTabIndex97;

        public BindingList<School> SchoolsTabIndex100;

        public BindingList<School> SchoolsTabIndex103;

        public BindingList<School> SchoolsTabIndex106;

        public BindingList<School> SchoolsTabIndex145;

        public BindingList<School> SchoolsTabIndex148;

        public BindingList<School> SchoolsTabIndex169;

        //East Schools Lists

        public BindingList<School> SchoolsTabIndex25;

        public BindingList<School> SchoolsTabIndex28;

        public BindingList<School> SchoolsTabIndex31;

        public BindingList<School> SchoolsTabIndex34;

        public BindingList<School> SchoolsTabIndex37;

        public BindingList<School> SchoolsTabIndex40;

        public BindingList<School> SchoolsTabIndex43;

        public BindingList<School> SchoolsTabIndex46;

        public BindingList<School> SchoolsTabIndex109;

        public BindingList<School> SchoolsTabIndex112;

        public BindingList<School> SchoolsTabIndex115;

        public BindingList<School> SchoolsTabIndex118;

        public BindingList<School> SchoolsTabIndex151;

        public BindingList<School> SchoolsTabIndex154;

        public BindingList<School> SchoolsTabIndex172;

        //South Schools Lists

        public BindingList<School> SchoolsTabIndex49;

        public BindingList<School> SchoolsTabIndex52;

        public BindingList<School> SchoolsTabIndex55;

        public BindingList<School> SchoolsTabIndex58;

        public BindingList<School> SchoolsTabIndex61;

        public BindingList<School> SchoolsTabIndex64;

        public BindingList<School> SchoolsTabIndex67;

        public BindingList<School> SchoolsTabIndex70;

        public BindingList<School> SchoolsTabIndex121;

        public BindingList<School> SchoolsTabIndex124;

        public BindingList<School> SchoolsTabIndex127;

        public BindingList<School> SchoolsTabIndex130;

        public BindingList<School> SchoolsTabIndex157;

        public BindingList<School> SchoolsTabIndex160;

        public BindingList<School> SchoolsTabIndex175;

        //Midwest Schools Lists

        public BindingList<School> SchoolsTabIndex73;

        public BindingList<School> SchoolsTabIndex76;

        public BindingList<School> SchoolsTabIndex79;

        public BindingList<School> SchoolsTabIndex82;

        public BindingList<School> SchoolsTabIndex85;

        public BindingList<School> SchoolsTabIndex88;

        public BindingList<School> SchoolsTabIndex91;

        public BindingList<School> SchoolsTabIndex94;

        public BindingList<School> SchoolsTabIndex133;

        public BindingList<School> SchoolsTabIndex136;

        public BindingList<School> SchoolsTabIndex139;

        public BindingList<School> SchoolsTabIndex142;

        public BindingList<School> SchoolsTabIndex163;

        public BindingList<School> SchoolsTabIndex166;

        public BindingList<School> SchoolsTabIndex178;

        //Final 4

        public BindingList<School> SchoolsTabIndex181;

        public BindingList<School> SchoolsTabIndex184;

        //Championship

        public BindingList<School> SchoolsTabIndex187;


        public Model()
        {
            PlayerRepo = new SqlPlayerRepository(connectionString);
            SchoolRepo = new SqlSchoolRepository(connectionString);
            GameRepo = new SqlGameRepository(connectionString);
            Schools = SchoolRepo.RetrieveSchools();
            DictionaryOfSchools = new Dictionary<int, BindingList<School>>();

            SchoolsTabIndex1 = GetListForTwoSchools("Gonzaga", "Georgia State");

            DictionaryOfSchools.Add(1, SchoolsTabIndex1);

            SchoolsTabIndex4 = GetListForTwoSchools("Boise State", "Memphis");

            DictionaryOfSchools.Add(4, SchoolsTabIndex4);

            SchoolsTabIndex7 = GetListForTwoSchools("Connecticut", "New Mexico State");

            DictionaryOfSchools.Add(7, SchoolsTabIndex7);

            SchoolsTabIndex10 = GetListForTwoSchools("Arkansas", "Vermont");

            DictionaryOfSchools.Add(10, SchoolsTabIndex10);

            SchoolsTabIndex13 = GetListForTwoSchools("Alabama", "Notre Dame");

            DictionaryOfSchools.Add(13, SchoolsTabIndex13);

            SchoolsTabIndex16 = GetListForTwoSchools("Texas Tech", "Montana State");

            DictionaryOfSchools.Add(16, SchoolsTabIndex16);

            SchoolsTabIndex19 = GetListForTwoSchools("Michigan State", "Davidson");

            DictionaryOfSchools.Add(19, SchoolsTabIndex19);

            SchoolsTabIndex22 = GetListForTwoSchools("Duke", "Cal State Fullerton");

            DictionaryOfSchools.Add(22, SchoolsTabIndex22);

            //East Schools Lists

            SchoolsTabIndex25 = GetListForTwoSchools("Baylor", "Norfolk State");

            DictionaryOfSchools.Add(25, SchoolsTabIndex25);

            SchoolsTabIndex28 = GetListForTwoSchools("North Carolina", "Marquette");

            DictionaryOfSchools.Add(28, SchoolsTabIndex28);

            SchoolsTabIndex31 = GetListForTwoSchools("Saint Mary's", "Indiana");

            DictionaryOfSchools.Add(31, SchoolsTabIndex31);

            SchoolsTabIndex34 = GetListForTwoSchools("UCLA", "Akron");

            DictionaryOfSchools.Add(34, SchoolsTabIndex34);

            SchoolsTabIndex37 = GetListForTwoSchools("Texas", "Virginia Tech");

            DictionaryOfSchools.Add(37, SchoolsTabIndex37);

            SchoolsTabIndex40 = GetListForTwoSchools("Purdue", "Yale");

            DictionaryOfSchools.Add(40, SchoolsTabIndex40);

            SchoolsTabIndex43 = GetListForTwoSchools("Murray State", "San Francisco");

            DictionaryOfSchools.Add(43, SchoolsTabIndex43);

            SchoolsTabIndex46 = GetListForTwoSchools("Kentucky", "Saint Peter's");

            DictionaryOfSchools.Add(46, SchoolsTabIndex46);

            //South Schools Lists

            SchoolsTabIndex49 = GetListForTwoSchools("Arizona", "Wright State");

            DictionaryOfSchools.Add(49, SchoolsTabIndex49);

            SchoolsTabIndex52 = GetListForTwoSchools("Seton Hall", "TCU");

            DictionaryOfSchools.Add(52, SchoolsTabIndex52);

            SchoolsTabIndex55 = GetListForTwoSchools("Houston", "UAB");

            DictionaryOfSchools.Add(55, SchoolsTabIndex55);

            SchoolsTabIndex58 = GetListForTwoSchools("Illinois", "Chattanooga");

            DictionaryOfSchools.Add(58, SchoolsTabIndex58);

            SchoolsTabIndex61 = GetListForTwoSchools("Colorado State", "Michigan");

            DictionaryOfSchools.Add(61, SchoolsTabIndex61);

            SchoolsTabIndex64 = GetListForTwoSchools("Tennessee", "Longwood");

            DictionaryOfSchools.Add(64, SchoolsTabIndex64);

            SchoolsTabIndex67 = GetListForTwoSchools("Ohio State", "Loyola Chicago");

            DictionaryOfSchools.Add(67, SchoolsTabIndex67);

            SchoolsTabIndex70 = GetListForTwoSchools("Villanova", "Delaware");

            DictionaryOfSchools.Add(70, SchoolsTabIndex70);

            //Midwest Schools Lists

            SchoolsTabIndex73 = GetListForTwoSchools("Kansas", "Texas Southern");

            DictionaryOfSchools.Add(73, SchoolsTabIndex73);

            SchoolsTabIndex76 = GetListForTwoSchools("San Diego State", "Creighton");

            DictionaryOfSchools.Add(76, SchoolsTabIndex76);

            SchoolsTabIndex79 = GetListForTwoSchools("Iowa", "Richmond");

            DictionaryOfSchools.Add(79, SchoolsTabIndex79);

            SchoolsTabIndex82 = GetListForTwoSchools("Providence", "South Dakota State");

            DictionaryOfSchools.Add(82, SchoolsTabIndex82);

            SchoolsTabIndex85 = GetListForTwoSchools("LSU", "Iowa State");

            DictionaryOfSchools.Add(85, SchoolsTabIndex85);

            SchoolsTabIndex88 = GetListForTwoSchools("Wisconsin", "Colgate");

            DictionaryOfSchools.Add(88, SchoolsTabIndex88);

            SchoolsTabIndex91 = GetListForTwoSchools("USC", "Miami (FL)");

            DictionaryOfSchools.Add(91, SchoolsTabIndex91);

            SchoolsTabIndex94 = GetListForTwoSchools("Auburn", "Jacksonville State");

            DictionaryOfSchools.Add(94, SchoolsTabIndex94);

            SchoolsTabIndex97 = new BindingList<School>();

            DictionaryOfSchools.Add(97, SchoolsTabIndex97);

            SchoolsTabIndex100 = new BindingList<School>();

            DictionaryOfSchools.Add(100, SchoolsTabIndex100);

            SchoolsTabIndex103 = new BindingList<School>();

            DictionaryOfSchools.Add(103, SchoolsTabIndex103);

            SchoolsTabIndex106 = new BindingList<School>();

            DictionaryOfSchools.Add(106, SchoolsTabIndex106);

            SchoolsTabIndex145 = new BindingList<School>();

            DictionaryOfSchools.Add(145, SchoolsTabIndex145);

            SchoolsTabIndex148 = new BindingList<School>();

            DictionaryOfSchools.Add(148, SchoolsTabIndex148);

            SchoolsTabIndex169 = new BindingList<School>();

            DictionaryOfSchools.Add(169, SchoolsTabIndex169);

            SchoolsTabIndex109 = new BindingList<School>();

            DictionaryOfSchools.Add(109, SchoolsTabIndex109);

            SchoolsTabIndex112 = new BindingList<School>();

            DictionaryOfSchools.Add(112, SchoolsTabIndex112);

            SchoolsTabIndex115 = new BindingList<School>();

            DictionaryOfSchools.Add(115, SchoolsTabIndex115);

            SchoolsTabIndex118 = new BindingList<School>();

            DictionaryOfSchools.Add(118, SchoolsTabIndex118);

            SchoolsTabIndex151 = new BindingList<School>();

            DictionaryOfSchools.Add(151, SchoolsTabIndex151);

            SchoolsTabIndex154 = new BindingList<School>();

            DictionaryOfSchools.Add(154, SchoolsTabIndex154);

            SchoolsTabIndex172 = new BindingList<School>();

            DictionaryOfSchools.Add(172, SchoolsTabIndex172);

            SchoolsTabIndex121 = new BindingList<School>();

            DictionaryOfSchools.Add(121, SchoolsTabIndex121);

            SchoolsTabIndex124 = new BindingList<School>();

            DictionaryOfSchools.Add(124, SchoolsTabIndex124);

            SchoolsTabIndex127 = new BindingList<School>();

            DictionaryOfSchools.Add(127, SchoolsTabIndex127);

            SchoolsTabIndex130 = new BindingList<School>();

            DictionaryOfSchools.Add(130, SchoolsTabIndex130);

            SchoolsTabIndex157 = new BindingList<School>();

            DictionaryOfSchools.Add(157, SchoolsTabIndex157);

            SchoolsTabIndex160 = new BindingList<School>();

            DictionaryOfSchools.Add(160, SchoolsTabIndex160);

            SchoolsTabIndex175 = new BindingList<School>();

            DictionaryOfSchools.Add(175, SchoolsTabIndex175);

            SchoolsTabIndex133 = new BindingList<School>();

            DictionaryOfSchools.Add(133, SchoolsTabIndex133);

            SchoolsTabIndex136 = new BindingList<School>();

            DictionaryOfSchools.Add(136, SchoolsTabIndex136);

            SchoolsTabIndex139 = new BindingList<School>();

            DictionaryOfSchools.Add(139, SchoolsTabIndex139);

            SchoolsTabIndex142 = new BindingList<School>();

            DictionaryOfSchools.Add(142, SchoolsTabIndex142);

            SchoolsTabIndex163 = new BindingList<School>();

            DictionaryOfSchools.Add(163, SchoolsTabIndex163);

            SchoolsTabIndex166 = new BindingList<School>();

            DictionaryOfSchools.Add(166, SchoolsTabIndex166);

            SchoolsTabIndex178 = new BindingList<School>();

            DictionaryOfSchools.Add(178, SchoolsTabIndex178);

            SchoolsTabIndex181 = new BindingList<School>();

            DictionaryOfSchools.Add(181, SchoolsTabIndex181);

            SchoolsTabIndex184 = new BindingList<School>();

            DictionaryOfSchools.Add(184, SchoolsTabIndex184);

            SchoolsTabIndex187 = new BindingList<School>();

            DictionaryOfSchools.Add(187, SchoolsTabIndex187);
        }

        public BindingList<School> GetListForTwoSchools(string schoolOne, string schoolTwo)
        {
            BindingList<School> schools = new BindingList<School>();

            foreach (School s in Schools)
            {
                if (s.Name == schoolOne || s.Name == schoolTwo)
                {
                    schools.Add(s);
                }
            }

            return schools;
        }
    }
}
