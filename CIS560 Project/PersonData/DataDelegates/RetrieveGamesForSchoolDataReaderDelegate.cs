using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using DataAccess;
using PersonData.Models;

namespace PersonData.DataDelegates
{
   internal class RetrieveGamesForSchoolDataReaderDelegate : DataReaderDelegate<BindingList<Game>>
    {

        public readonly string School;

        public RetrieveGamesForSchoolDataReaderDelegate(string school)
            : base("Basketball.RetrieveGamesForSchool")
        {
            School = school;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("School", School); 
        }

        public override BindingList<Game> Translate(SqlCommand command, IDataRowReader reader)
        {
            var games = new BindingList<Game>();

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