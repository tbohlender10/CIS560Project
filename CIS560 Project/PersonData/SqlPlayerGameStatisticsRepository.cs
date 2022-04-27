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

        public PlayerGameStatistics GetPlayerGameStatisticsForPlayerGame(int gameID, int playerID)
        {
            var d = new FetchPlayerGameStatisticsForPlayerGame(gameID, playerID);
            return executor.ExecuteReader(d);
        }

        public bool InsertPlayerGameStatistics(DateTimeOffset dti, string school, string playerName, int points, int threePoints, int fgm, int fga, int rebounds, int minutes)
        {
            var d = new InsertPlayerGameStatistics(dti, school, playerName, points, threePoints, fgm, fga, rebounds, minutes);
            executor.ExecuteNonQuery(d);
            return true;
        }

        public bool UpdatePlayerGameStatistics(int gameID, int playerID, int schoolID, int points, int threePoints, int fgm, int fga, int rebounds, int minutes)
        {
            var d = new UpdatePlayerGameStatistics(gameID, playerID, schoolID, points, threePoints, fgm, fga, rebounds, minutes);
            executor.ExecuteNonQuery(d);
            return true;
        
        }

        public bool DeletePlayerGameStatistics(int gameID, int playerID, int schoolID)
        {
            var d = new DeletePlayerGameStatistics(gameID, playerID, schoolID);
            executor.ExecuteNonQuery(d);
            return true;
        }
    }
}
