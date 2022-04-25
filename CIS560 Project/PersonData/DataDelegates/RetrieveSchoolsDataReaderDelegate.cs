using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using DataAccess;
using PersonData.Models;

namespace PersonData.DataDelegates
{
   internal class RetrieveSchoolsDataReaderDelegate : DataReaderDelegate<List<School>>
    {
        public RetrieveSchoolsDataReaderDelegate()
            : base("Basketball.RetrieveSchools")
        {
        }

        public override List<School> Translate(SqlCommand command, IDataRowReader reader)
        {
            var schools = new List<School>();

            while (reader.Read())
            {
                schools.Add(new School(
                    reader.GetInt32("SchoolID"),
                    reader.GetString("Name"),
                    reader.GetString("Coach"),
                    reader.GetInt32("Seed"),
                    reader.GetInt32("RegionID")));
            }

            return schools;
        }
    }
}