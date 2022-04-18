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
   }
}
