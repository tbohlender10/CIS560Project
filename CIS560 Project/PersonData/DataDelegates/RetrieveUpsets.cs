using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using DataAccess;
using PersonData.Models;

namespace PersonData.DataDelegates
{
   internal class RetrieveUpsets : DataReaderDelegate<List<Upsets>>
    {
        public RetrieveUpsets()
            : base("Basketball.FetchUpsetsBySeed")
        {
        }

        public override List<Upsets> Translate(SqlCommand command, IDataRowReader reader)
        {
            var upsets = new List<Upsets>();

            while (reader.Read())
            {
                upsets.Add(new Upsets(
                    reader.GetString("HighSeedName"),
                    reader.GetInt32("HighSeed"),
                    reader.GetString("LowSeedName"),
                    reader.GetInt32("LowSeed"),
                    reader.GetInt32("SeedDifferential")
                    ));
            }

            return upsets;
        }
    }
}