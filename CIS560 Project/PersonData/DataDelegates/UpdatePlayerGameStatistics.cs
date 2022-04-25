using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.DataDelegates
{
    public class UpdatePlayerGameStatistics : DataDelegate
    {
        public int GameID;

        public int PlayerID;

        public int SchoolID;

        public UpdatePlayerGameStatistics(int gameID, int playerID, int schoolID)
                  : base("Basketball.UpdatePlayerGameStatistics")
        {
            GameID = gameID;
            PlayerID = playerID;
            SchoolID = schoolID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameID", GameID);
            command.Parameters.AddWithValue("PlayerID", PlayerID);
            command.Parameters.AddWithValue("SchoolID", SchoolID);
        }
    }
}
