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
    public class UpdateGameScore : DataDelegate
    {
        public string School;
        public DateTimeOffset Time;
        public TeamType TeamType;
        public int Score;

        public UpdateGameScore(string school, DateTimeOffset time, TeamType teamType, int score)
           : base("Basketball.UpdateGameScore")
        {
            School = school;
            Time = time;
            TeamType = teamType;
            Score = score;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("School", School);
            command.Parameters.AddWithValue("DateTimeInfo", Time);
            command.Parameters.AddWithValue("TeamType", TeamType);
            command.Parameters.AddWithValue("Score", Score);
        }
    }
}
