using DataAccess;
using PersonData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.DataDelegates
{
    public class FetchPlayerGameStatisticsForPlayerGame : DataReaderDelegate<PlayerGameStatistics>
    {
        public int GameID;

        public int PlayerID;

        public FetchPlayerGameStatisticsForPlayerGame(int gameID, int playerID)
         : base("Basketball.FetchPlayerGameStatisticsForPlayerGame")
        {
            GameID = gameID;
            PlayerID = playerID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameID", GameID);
            command.Parameters.AddWithValue("PlayerID", PlayerID);
        }

        public override PlayerGameStatistics Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(PlayerID.ToString());

            return new PlayerGameStatistics(
                reader.GetInt32("PlayerGameStatisticsID"),
                GameID,
                reader.GetInt32("SchoolID"),
                PlayerID,
                reader.GetInt32("Points"),
                reader.GetInt32("3PT"),
                reader.GetInt32("FGM"),
                reader.GetInt32("FGA"),
                reader.GetInt32("Rebounds"),
                reader.GetInt32("Minutes"));
        }
    }
}
