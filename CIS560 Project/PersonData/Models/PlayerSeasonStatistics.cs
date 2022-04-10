namespace PersonData.Models
{
    public class PlayerSeasonStatistics
    {
        public int PlayerSeasonStatisticsID { get; }

        public int PlayerID { get; }

        public int PointsPerGame { get; }

        public int ThreePoints { get; }

        public int FGM { get; }

        public int FGA { get; }

        public int Rebounds { get; }

        public int Minutes { get; }

        public PlayerSeasonStatistics(int playerSeasonStatisticsID, int playerID, int pointsPerGame,
            int fgm, int fga, int rebounds, int minutes)
        {
            PlayerSeasonStatisticsID = playerSeasonStatisticsID;
            PlayerID = playerID;
            PointsPerGame = pointsPerGame;
            FGM = fgm;
            FGA = fga;
            Rebounds = rebounds;
            Minutes = minutes;
        }
    }
}
