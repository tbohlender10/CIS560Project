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
    public class RetrieveGuestSchoolForGame : DataReaderDelegate<GameSchool>
    {
        private int GameID;

        public RetrieveGuestSchoolForGame(int gameID)
             : base("Basketball.RetrieveGuestSchoolForGame")
        {
            GameID = gameID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameID", GameID);
        }

        public override GameSchool Translate(SqlCommand command, IDataRowReader reader)
        {
            try
            {
                if (!reader.Read())
                    throw new RecordNotFoundException(GameID.ToString());

                return new GameSchool(
                    reader.GetInt32("GameID"),
                    reader.GetInt32("SchoolID"),
                    reader.GetString("Name"),
                    reader.GetInt32("Score"),
                    reader.GetInt32("TeamTypeID"));
            }
            catch (RecordNotFoundException)
            {
                return new GameSchool(-1, -1, "" ,-1, -1);
            }
            
        }
    }
}
