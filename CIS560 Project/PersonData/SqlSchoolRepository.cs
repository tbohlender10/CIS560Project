using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlSchoolRepository : ISchoolRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlSchoolRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }

      public School GetSchool(int schoolID)
      {
         var d = new GetSchoolDataReaderDelegate(schoolID);
         return executor.ExecuteReader(d);
      }

      public List<School> RetrieveSchools()
      {
         var d = new RetrieveSchoolsDataReaderDelegate();
         return executor.ExecuteReader(d);
      }

        public bool UpdateSchoolCoach(int schoolID, string coach)
        {
            var d = new UpdateSchoolCoach(schoolID, coach);
            executor.ExecuteNonQuery(d);
            return true;
        }
        public bool UpdateSchoolSeed(int schoolID, int seed)
        {
            var d = new UpdateSchoolSeed(schoolID, seed);
            executor.ExecuteNonQuery(d);
            return true;
        }

        public bool UpdateSchoolRegion(int schoolID, int RegionID)
        {
            var d = new UpdateSchoolRegion(schoolID, RegionID);
            executor.ExecuteNonQuery(d);
            return true;
        }
    }
}
