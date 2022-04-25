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
    public class UpdatePlayerGrade : DataDelegate
    {
        public string PlayerName;

        public string School;

        public string Grade;

        public UpdatePlayerGrade(string school, string name, string grade)
           : base("Basketball.UpdatePlayerGrade")
        {
            School = school;
            PlayerName = name;
            Grade = grade;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("School", School);
            command.Parameters.AddWithValue("PlayerName", PlayerName);
            command.Parameters.AddWithValue("Grade", Grade);
        }
    }
}
