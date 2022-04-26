using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.DataDelegates
{
    public class UpdateSchoolCoach : DataDelegate
    {
        public int SchoolID;

        public string Coach;

        public UpdateSchoolCoach(int schoolID, string coach)
           : base("Basketball.UpdateSchoolCoach")
        {
            SchoolID = schoolID;
            Coach = coach;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SchoolID", SchoolID);
            command.Parameters.AddWithValue("Coach", Coach);
        }
    }
}
