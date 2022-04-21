using PersonData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_Project
{
    public class Controller
    {
        private Model Model;

        public Controller(Model m)
        {
            Model = m;
        }

        public List<School> GetListForTwoSchools(string schoolOne, string schoolTwo)
        {
            List<School> schools = new List<School>();

            foreach(School s in Model.Schools)
            {
                if(s.Name == schoolOne || s.Name == schoolTwo)
                {
                    schools.Add(s);
                }
            }

            return schools;
        }
    }
}
