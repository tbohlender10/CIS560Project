using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlGameSchoolRepository : IGameSchoolRepository
   {
        private readonly SqlCommandExecutor executor;

        public SqlGameSchoolRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public GameSchool RetrieveGuestSchoolForGame(int gameID)
        {
            var d = new RetrieveGuestSchoolForGame(gameID);
            return executor.ExecuteReader(d);
        }

        public GameSchool RetrieveHomeSchoolForGame(int gameID)
        {
            var d = new RetrieveHomeSchoolForGame(gameID);
            return executor.ExecuteReader(d);
        }

        public bool UpdateGameScore(int schoolID, DateTimeOffset dateTimeInfo, int teamTypeID, int score)
        {
            var d = new UpdateGameScore(schoolID, dateTimeInfo, teamTypeID, score);
            executor.ExecuteNonQuery(d);
            return true;
        }
    }
}
