using DataAccess;
using PersonData.Models;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class GetSchoolDataDelegate : DataReaderDelegate<School>
   {
      private readonly int SchoolID;

      public GetSchoolDataDelegate(int schoolID)
         : base("Basketball.GetSchool")
      {
         SchoolID = schoolID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("SchoolID", SchoolID);
      }

      public override School Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            return null;

         return new School(
                SchoolID,
                reader.GetString("[Name]"),
                reader.GetString("Coach"),
                reader.GetInt32("Seed"),
                reader.GetInt32("RegionID"),
                reader.GetInt32("NCAATitles"));
      }
   }
}