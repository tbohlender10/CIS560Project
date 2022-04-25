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

        public bool UpdateGameScore(string schoolName, DateTimeOffset dateTimeInfo, TeamType teamType, int score)
        {
            var d = new UpdateGameScore(schoolName, dateTimeInfo, teamType, score);
            executor.ExecuteNonQuery(d);
            return true;
        }
    }
}
