using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlPlayerRepository : IPlayerRepository
   {
      private readonly SqlCommandExecutor executor;

      public SqlPlayerRepository(string connectionString)
      {
         executor = new SqlCommandExecutor(connectionString);
      }

        public Player FetchPlayer(int playerID)
      {
         var d = new FetchPlayerDataReaderDelegate(playerID);
         return executor.ExecuteReader(d);
      }

      public IReadOnlyList<Player> RetrievePlayersForSchool(int schoolID)
      {
         return executor.ExecuteReader(new RetrievePlayersForSchoolDataReaderDelegate(schoolID));
      }

        public bool UpdatePlayerGrade(string school, string playerName, string grade)
        {
            var d = new UpdatePlayerGrade(school, playerName, grade);
            executor.ExecuteNonQuery(d);
            return true;
        }

        public bool UpdatePlayerName(string school, string playerName, int number)
        {
            var d = new UpdatePlayerName(school, playerName, number);
            executor.ExecuteNonQuery(d);
            return true;
        }

        public bool UpdatePlayerNumber(string school, string playerName, int number)
        {
            var d = new UpdatePlayerNumber(school, playerName, number);
            executor.ExecuteNonQuery(d);
            return true;
        }

        public bool UpdatePlayerPosition(string school, string playerName, string position)
        {
            var d = new UpdatePlayerPosition(school, playerName, position);
            executor.ExecuteNonQuery(d);
            return true;
        }
    }
}
