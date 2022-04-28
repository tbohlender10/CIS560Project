using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;
using System.ComponentModel;

namespace PersonData
{
   public class SqlGameRepository : IGameRepository
   {
          private readonly SqlCommandExecutor executor;

          public SqlGameRepository(string connectionString)
          {
             executor = new SqlCommandExecutor(connectionString);
          }

        public BindingList<School> RetrieveSchoolsForGame(int gameID)
        {
            var d = new RetrieveSchoolsForGame(gameID);
            return executor.ExecuteReader(d);
        }

        public BindingList<Game> RetrieveAllGames()
        {
            var d = new RetrieveAllGamesDataReaderDelegate();
            return executor.ExecuteReader(d);
        }

        public bool DeleteGameStats(int gameID)
        {
            var d = new DeleteGameStatistics(gameID);
            executor.ExecuteNonQuery(d);
            return true;
        }

        public bool InsertGameSchoolStatistics(int gameID, int schoolID, int teamTypeID, int score)
        {
            var d = new InsertGameSchoolStatistics(gameID, schoolID, teamTypeID, score);
            executor.ExecuteNonQuery(d);
            return true;
        }
    }
}
