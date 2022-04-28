using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlPPGRepository : IPPGRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlPPGRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }

      public List<PPG> RetrieveAllPPG()
      {
         var d = new RetrievePPG();
         return executor.ExecuteReader(d);
      }

    }
}
