using PersonData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_Project
{
    public class Model
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=master;Integrated Security=SSPI;";

        private SqlPlayerRepository PlayerRepo;

        private SqlSchoolRepository SchoolRepo;

        public Model()
        {
            PlayerRepo = new SqlPlayerRepository(connectionString);
            SchoolRepo = new SqlSchoolRepository(connectionString);

            var d = SchoolRepo.GetSchool(1);

            MessageBox.Show(d.Name);
        }
    }
}
