using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.DataDelegates
{
    public class UpdateSchoolRegion : DataDelegate
    {
        public int SchoolID;

        public int RegionID;

        public UpdateSchoolRegion(int schoolID, int regionID)
           : base("Basketball.UpdateSchoolRegion")
        {
            SchoolID = schoolID;
            RegionID = regionID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SchoolID", SchoolID);
            command.Parameters.AddWithValue("RegionID", RegionID);
        }
    }
}
