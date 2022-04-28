using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlUpsetRepository : IUpsetRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlUpsetRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }


      public List<Upsets> RetrieveAllUpsets()
      {
         var d = new RetrieveUpsets();
         return executor.ExecuteReader(d);
      }

    }
}
