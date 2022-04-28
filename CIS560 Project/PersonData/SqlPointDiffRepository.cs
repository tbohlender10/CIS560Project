using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlPointDiffRepository : IPointDiffRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlPointDiffRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }

        public List<PointDiff> RetrieveAllPointDiff()
        {
            var d = new RetrievePointDiff();
            return executor.ExecuteReader(d);
        }

    }
}
