using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using PersonData.Models;

namespace PersonData.DataDelegates
{
   internal class RetrieveGamesForSchoolDataReaderDelegate : DataReaderDelegate<IReadOnlyList<Game>>
    {

        public readonly int SchoolID;

        public RetrieveGamesForSchoolDataReaderDelegate(int schoolID)
            : base("Basketball.RetrieveGamesForSchool")
        {
            SchoolID = schoolID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SchoolID", SchoolID); 
        }

        public override IReadOnlyList<Game> Translate(SqlCommand command, IDataRowReader reader)
        {
            var games = new List<Game>();

            while (reader.Read())
            {
                games.Add(new Game(
                    reader.GetInt32("GameID"),
                    reader.GetDateTimeOffset("DateTimeInfo"),
                    reader.GetInt32("RoundID"))
                    );
            }

            return games;
        }
    }
}