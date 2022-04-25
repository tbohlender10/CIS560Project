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
    public class RetrieveAllGamesDataReaderDelegate : DataReaderDelegate<List<Game>>
    {
        public RetrieveAllGamesDataReaderDelegate()
            : base("Basketball.RetrieveAllGames")
        {
        }

        public override List<Game> Translate(SqlCommand command, IDataRowReader reader)
        {
            var games = new List<Game>();

            while (reader.Read())
            {
                games.Add(new Game(
                    reader.GetInt32("GameID"),
                    reader.GetDateTimeOffset("DateTimeInfo"),
                    reader.GetInt32("RoundID")));
            }

            return games;
        }
    }
}
