using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using DataAccess;
using PersonData.Models;

namespace PersonData.DataDelegates
{
   internal class RetrievePPG : DataReaderDelegate<List<PPG>>
    {
        public RetrievePPG()
            : base("Basketball.FetchTopPPG")
        {
        }

        public override List<PPG> Translate(SqlCommand command, IDataRowReader reader)
        {
            var ppg = new List<PPG>();

            while (reader.Read())
            {
                ppg.Add(new PPG(
                    reader.GetInt32("PlayerID"),
                    reader.GetString("SchoolName"),
                    reader.GetString("PlayerName"),
                    reader.GetInt32("TotalPoints"),
                    reader.GetInt32("GameCount"),
                    reader.GetValue<decimal>("PPG")));
            }

            return ppg;
        }
    }
}