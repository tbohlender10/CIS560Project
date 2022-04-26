using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.DataDelegates
{
    public class UpdatePlayerGameStatistics : DataDelegate
    {
        public int GameID;

        public int PlayerID;

        public int SchoolID;

        public int Points;

        public int ThreePoints;

        public int FGM;

        public int FGA;

        public int Rebounds;

        public int Minutes;

        public UpdatePlayerGameStatistics(int gameID, int playerID, int schoolID, int points, int threePoints, int fgm, int fga, int rebounds, int minutes)
                  : base("Basketball.UpdatePlayerGameStatistics")
        {
            GameID = gameID;
            PlayerID = playerID;
            SchoolID = schoolID;
            Points = points;
            ThreePoints = threePoints;
            FGM = fgm;
            FGA = fga;
            Rebounds = rebounds;
            Minutes = minutes;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("GameID", GameID);
            command.Parameters.AddWithValue("PlayerID", PlayerID);
            command.Parameters.AddWithValue("SchoolID", SchoolID);
            command.Parameters.AddWithValue("Points", Points);
            command.Parameters.AddWithValue("ThreePoints", ThreePoints);
            command.Parameters.AddWithValue("FGM", FGM);
            command.Parameters.AddWithValue("FGA", FGA);
            command.Parameters.AddWithValue("Rebounds", Rebounds);
            command.Parameters.AddWithValue("Minutes", Minutes);
        }
    }
}
