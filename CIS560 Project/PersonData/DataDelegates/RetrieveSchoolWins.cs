using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using DataAccess;
using PersonData.Models;

namespace PersonData.DataDelegates
{
   internal class RetrieveSchoolWins : DataReaderDelegate<List<SchoolWins>>
    {
        public RetrieveSchoolWins()
            : base("Basketball.FetchSchoolsWithNumberOfWins")
        {
        }

        public override List<SchoolWins> Translate(SqlCommand command, IDataRowReader reader)
        {
            var schools = new List<SchoolWins>();

            while (reader.Read())
            {
                schools.Add(new SchoolWins(
                    reader.GetInt32("SchoolID"),
                    reader.GetString("School"),
                    reader.GetInt32("Wins")));
            }

            return schools;
        }
    }
}