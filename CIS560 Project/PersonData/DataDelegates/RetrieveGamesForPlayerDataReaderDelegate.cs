using DataAccess;
using PersonData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class RetrieveGamesForPlayerDataReaderDelegate : DataReaderDelegate<IReadOnlyList<Game>>
   {
      private readonly int PlayerID;

      public RetrieveGamesForPlayerDataReaderDelegate(int playerID)
         : base("Basketball.RetrieveGamesForPlayerDataReaderDelegate") //stored procedure
      {
         PlayerID = playerID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("PlayerID", PlayerID);
      }
      public override IReadOnlyList<Game> Translate(SqlCommand command, IDataRowReader reader)
      {
         var games = new List<Game>();

         while (reader.Read())
         {
                games.Add(new Game(
                reader.GetInt32("GameID"),
                reader.GetString("DateTime"),
                reader.GetInt32("RoundID")));
         }

         return games;
      }
   }
}