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
    public class UpdatePlayerNumber : DataDelegate
    {

        public string School;

        public string PlayerName;

        public int Number;


        public UpdatePlayerNumber(string school, string name, int number)
          : base("Basketball.UpdatePlayerNumber")
        {
            School = school;
            PlayerName = name;
            Number = number;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("School", School);
            command.Parameters.AddWithValue("PlayerName", PlayerName);
            command.Parameters.AddWithValue("Number", Number);
        }
    }
}
