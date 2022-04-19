using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class FetchPlayerDataReaderDelegate : DataReaderDelegate<Player>
   {
      private readonly int PlayerID;

      public FetchPlayerDataReaderDelegate(int playerID)
         : base("Basketball.FetchPlayer")
      {
         PlayerID = playerID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("PlayerID", PlayerID);
      }

      public override Player Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            throw new RecordNotFoundException(PlayerID.ToString());

         return new Player(PlayerID,
            reader.GetInt32("SchoolID"),
            reader.GetString("[Name]"),
            reader.GetString("Grade"));
      }
   }
}