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
         var d = new GetSchoolDataDelegate(schoolID);
         executor.ExecuteNonQuery(d);
      }

      public IReadOnlyList<School> RetrieveSchools();
      {
         var d = new RetrieveSchoolsDataDelegate();
         return executor.ExecuteReader(d);
      }
   }
}
