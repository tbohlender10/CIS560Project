using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlPlayerSeasonStatisticsRepository : IPlayerSeasonStatisticsRepository
   {
        private readonly SqlCommandExecutor executor;

        public SqlPlayerSeasonStatisticsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public PlayerSeasonStatistics GetPlayerGameStatisticsForPlayer(int playerID)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<PlayerSeasonStatistics> RetrievePlayerGameStatisticsForSchool(int schoolID)
        {
            throw new NotImplementedException();
        }
    }
}
