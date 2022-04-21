using PersonData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class FetchPlayerSeasonStatisticsDataReaderDelegate : DataReaderDelegate<PlayerSeasonStatistics>
   {
          public readonly int PlayerID;

          public FetchPlayerSeasonStatisticsDataReaderDelegate(int playerID)
             : base("Basketball.FetchPlayerSeasonStatistics")
          {
                PlayerID = playerID;
          }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("PlayerID", PlayerID);
        }

        public override PlayerSeasonStatistics Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(PlayerID.ToString());

            return new PlayerSeasonStatistics(
                reader.GetInt32("PlayerSeasonStatisticsID"),
                PlayerID,
                reader.GetInt32("PPG"),
                reader.GetInt32("3Pt"),
                reader.GetInt32("FGM"),
                reader.GetInt32("FGA"),
                reader.GetInt32("Rebounds"),
                reader.GetInt32("Minutes"));
        }
    }
}