namespace PersonData.Models
{
    public class PlayerGameStatistics
    {
        public int PlayerGameStatisticsID { get; }

        public int GameID { get; }

        public int SchoolID { get; }

        public int PlayerID { get; }

        public int Points { get; }

        public int ThreePoints { get; }

        public int FGM { get; }

        public int FGA { get; }

        public int Rebounds { get; }

        public int Minutes { get; }

        public PlayerGameStatistics(int playerGameStatisticsID, int gameID, int schoolID, int playerID, int points,
            int threePoints, int fgm, int fga, int rebounds, int minutes)
        {
            PlayerGameStatisticsID = playerGameStatisticsID;
            GameID = gameID;
            SchoolID = schoolID;
            PlayerID = playerID;
            Points = points;
            ThreePoints = threePoints;
            FGM = fgm;
            FGA = fga;
            Rebounds = rebounds;
            Minutes = minutes;
        }
    }
}
