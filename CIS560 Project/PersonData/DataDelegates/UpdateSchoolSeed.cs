using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.DataDelegates
{
    public class UpdateSchoolSeed : DataDelegate
    {
        public int SchoolID;

        public int Seed;

        public UpdateSchoolSeed(int schoolID, int seed)
           : base("Basketball.UpdateSchoolSeed")
        {
            SchoolID = schoolID;
            Seed = seed;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SchoolID", SchoolID);
            command.Parameters.AddWithValue("Seed", Seed);
        }
    }
}
