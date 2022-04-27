using PersonData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
    public class InsertGameSchoolStatistics : DataDelegate
    {
        public int GameID;
        public int SchoolID;
        public int TeamTypeID;
        public int Score;

        public InsertGameSchoolStatistics(int gameID, int schoolID, int teamTypeID, int score)
           : base("Basketball.InsertGameSchoolStatistics")
        {
            GameID = gameID;
            SchoolID = schoolID;
            TeamTypeID = teamTypeID;
            Score = score;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameID", GameID);
            command.Parameters.AddWithValue("SchoolID", SchoolID);
            command.Parameters.AddWithValue("TeamTypeID", TeamTypeID);
            command.Parameters.AddWithValue("Score", Score);
        }
    }
}