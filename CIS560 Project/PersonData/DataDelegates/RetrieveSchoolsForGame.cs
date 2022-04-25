using DataAccess;
using PersonData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.DataDelegates
{
    public class RetrieveSchoolsForGame : DataReaderDelegate<BindingList<School>>
    {
        public int GameID;

        public RetrieveSchoolsForGame(int gameID)
            : base("Basketball.RetrieveSchoolsForGame")
        {
            GameID = gameID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameID", GameID);
        }

        public override BindingList<School> Translate(SqlCommand command, IDataRowReader reader)
        {
            BindingList<School> schools = new BindingList<School>();

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
