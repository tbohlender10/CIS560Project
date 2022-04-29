using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using DataAccess;
using PersonData.Models;

namespace PersonData.DataDelegates
{
   internal class CountUpsets : DataReaderDelegate<List<UpsetCount>>
    {
        public CountUpsets()
            : base("Basketball.CountUpsetsBySeed")
        {
        }

        public override List<UpsetCount> Translate(SqlCommand command, IDataRowReader reader)
        {
            var upsets = new List<UpsetCount>();

            while (reader.Read())
            {
                upsets.Add(new UpsetCount(
                    reader.GetInt32("SeedDifferential"),
                    reader.GetInt32("NumberOfGamesWithSeedDifferential")
                    ));
            }

            return upsets;
        }
    }
}