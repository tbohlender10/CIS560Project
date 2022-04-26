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
        public int GameID;
        public int SchoolID;
        public int Score;

        public UpdateGameScore(int gameID, int schoolID, int score)
           : base("Basketball.UpdateGameScore")
        {
            GameID = gameID;
            SchoolID = schoolID;
            Score = score;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameID", GameID);
            command.Parameters.AddWithValue("SchoolID", SchoolID);
            command.Parameters.AddWithValue("Score", Score);
        }
    }
}
