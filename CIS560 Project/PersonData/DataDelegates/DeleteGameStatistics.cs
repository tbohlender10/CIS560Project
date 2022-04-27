using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.DataDelegates
{
    public class DeleteGameStatistics : DataDelegate
    {
        public int GameID;

        public DeleteGameStatistics(int gameID)
           : base("Basketball.DeleteGameStatistics")
        {
            GameID = gameID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameID", GameID);
        }
    }
}
