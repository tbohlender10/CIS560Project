using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlPlayerGameStatisticsRepository : IPlayerGameStatisticsRepository
   {
        private readonly SqlCommandExecutor executor;

        public SqlPlayerGameStatisticsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public PlayerGameStatistics GetPlayerGameStatisticsForGame(int gameID)
        {
            throw new NotImplementedException();
        }

        public PlayerGameStatistics GetPlayerGameStatisticsForPlayer(int playerID)
        {
            throw new NotImplementedException();
        }

        public PlayerGameStatistics GetPlayerGameStatisticsForPlayerGame(int gameID, int playerID)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<PlayerGameStatistics> RetrievePlayerGameStatisticsForSchool(int schoolID)
        {
            throw new NotImplementedException();
        }
    }
}
