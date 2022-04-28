using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using DataAccess;
using PersonData.Models;

namespace PersonData.DataDelegates
{
   internal class RetrievePointDiff : DataReaderDelegate<List<PointDiff>>
    {
        public RetrievePointDiff()
            : base("Basketball.FetchPointDiff")
        {
        }

        public override List<PointDiff> Translate(SqlCommand command, IDataRowReader reader)
        {
            var pointDiff = new List<PointDiff>();

            while (reader.Read())
            {
                pointDiff.Add(new PointDiff(
                    reader.GetInt32("NumberOfGames"),
                    reader.GetInt32("PointsDifferential")
                    ));
            }

            return pointDiff;
        }
    }
}