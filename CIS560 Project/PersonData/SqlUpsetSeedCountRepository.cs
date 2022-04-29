using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlUpsetSeedCountRepository : IUpsetSeedCountRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlUpsetSeedCountRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }


      public List<UpsetCount> CountAllUpsets()
      {
         var d = new CountUpsets();
         return executor.ExecuteReader(d);
      }

    }
}
