namespace PersonData.Models
{
    public class PlayerSeasonStatistics
    {
        public int PlayerSeasonStatisticsID { get; }

        public int PlayerID { get; }

        public int PPG { get; }

        public int ThreePoints { get; }

        public int FGM { get; }

        public int FGA { get; }

        public int Rebounds { get; }

        public int Minutes { get; }

        public PlayerSeasonStatistics(int playerSeasonStatisticsID, int playerID, int ppg, int threePoints,
            int fgm, int fga, int rebounds, int minutes)
        {
            PlayerSeasonStatisticsID = playerSeasonStatisticsID;
            PlayerID = playerID;
            ThreePoints = threePoints;
            PPG = ppg;
            FGM = fgm;
            FGA = fga;
            Rebounds = rebounds;
            Minutes = minutes;
        }
    }
}
