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
            throw new NotImplementedException();
        }
    }
}
