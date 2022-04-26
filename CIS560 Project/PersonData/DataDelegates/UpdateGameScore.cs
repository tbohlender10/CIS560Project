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
        public int SchoolID;
        public DateTimeOffset Time;
        public int TeamTypeID;
        public int Score;

        public UpdateGameScore(int schoolID, DateTimeOffset time, int teamTypeID, int score)
           : base("Basketball.UpdateGameScore")
        {
            SchoolID = schoolID;
            Time = time;
            TeamTypeID = teamTypeID;
            Score = score;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("SchoolID", SchoolID);
            command.Parameters.AddWithValue("DateTimeInfo", Time);
            command.Parameters.AddWithValue("TeamTypeID", TeamTypeID);
            command.Parameters.AddWithValue("Score", Score);
        }
    }
}
