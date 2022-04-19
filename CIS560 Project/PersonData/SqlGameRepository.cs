using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlGameRepository : IGameRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlGameRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }

        public IReadOnlyList<Game> RetrieveGamesForPlayer(int playerID)
        {
            var d = new RetrieveSchoolsDataReaderDelegate();
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Game> RetrieveGamesForSchool(int schoolID)
        {
            var d = new RetrieveSchoolsDataReaderDelegate();
            return executor.ExecuteReader(d);
        }
    }
}
