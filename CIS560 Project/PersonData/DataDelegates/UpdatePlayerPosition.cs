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
    public class UpdatePlayerPosition : DataDelegate
    {

        public string School;

        public string PlayerName;

        public string Position;

        public UpdatePlayerPosition(string school, string name, string position)
          : base("Basketball.UpdatePlayerPosition")
        {
            School = school;
            PlayerName = name;
            Position = position;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("School", School);
            command.Parameters.AddWithValue("PlayerName", PlayerName);
            command.Parameters.AddWithValue("Position", Position);
        }
    }
}
