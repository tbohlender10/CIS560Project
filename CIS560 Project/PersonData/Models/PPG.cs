using System;

namespace PersonData.Models
{

   public class PPG
   {
        public int PlayerID { get; }

        public string SchoolName { get; }

        public string PlayerName { get; }

        public int TotalPoints { get; }

        public int GameCount { get; }

        public decimal PointsPerGame { get; }

      
        public PPG(int playerID, string schoolName, string playerName, int totalPoints, int gameCount, decimal ppg)
        {
            PlayerID = playerID;
            SchoolName = schoolName;
            PlayerName = playerName;
            TotalPoints = totalPoints;
            GameCount = gameCount;
            PointsPerGame = ppg;
        }

        public override string ToString()
        {
            return PlayerName + ": " + String.Format("{0:0.0}", PointsPerGame) + " PPG";
        }
    }
}
