using PersonData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
    public class CreatePlayerDataDelegate : DataDelegate
    {
        public string Name;
        public string School;
        public int Number;
        public string Grade;
        public string Position;

        public CreatePlayerDataDelegate(string name, string school, int number, string grade, string position)
           : base("Basketball.CreateNewPlayer")
        {
            Name = name;
            School = school;
            Number = number;
            Grade = grade;
            Position = position;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("School", School);
            command.Parameters.AddWithValue("PlayerName", Name);
            command.Parameters.AddWithValue("Number", Number);
            command.Parameters.AddWithValue("Grade", Grade);
            command.Parameters.AddWithValue("Position", Position);
        }
    }
}