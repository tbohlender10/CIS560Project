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

        public bool CreateNewPlayer(string school, string playerName, int number, string grade, string position)
        {
            throw new NotImplementedException();
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

        public bool UpdatePlayerGrade(string playerName, string school, string grade)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePlayerName(string playerName, string school, int number)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePlayerNumber(string playerName, string school, int number)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePlayerPosition(string playerName, string school, string position)
        {
            throw new NotImplementedException();
        }
    }
}
