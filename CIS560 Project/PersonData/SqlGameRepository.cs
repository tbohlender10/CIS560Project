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

        public IList<Game> RetrieveAllGames()
        {
            throw new NotImplementedException();
        }
    }
}
