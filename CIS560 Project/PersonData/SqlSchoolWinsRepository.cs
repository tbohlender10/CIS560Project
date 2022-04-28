using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlSchoolWinsRepository : ISchoolWinsRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlSchoolWinsRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }

      public School GetSchool(int schoolID)
      {
         var d = new GetSchoolDataReaderDelegate(schoolID);
         return executor.ExecuteReader(d);
      }

      public List<SchoolWins> RetrieveAllSchoolWins()
      {
         var d = new RetrieveSchoolWins();
         return executor.ExecuteReader(d);
      }

    }
}
