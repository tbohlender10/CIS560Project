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

        public List<Game> FetchGamesForSchool(string school)
        {
            var d = new RetrieveGamesForSchoolDataReaderDelegate(school);
            return executor.ExecuteReader(d);
        }

        public List<Game> RetrieveAllGames()
        {
            var d = new RetrieveAllGamesDataReaderDelegate();
            return executor.ExecuteReader(d);
        }
    }
}
