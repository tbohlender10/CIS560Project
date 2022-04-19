namespace PersonData.Models
{
   public class Game
    {
        public int GameID { get; }

        public string DateTimeInfo { get; }

        public int RoundID { get; }

        public Game(int gameID, string dateTimeInfo, int roundID)
        {
            GameID = gameID;
            DateTimeInfo = dateTimeInfo;
            RoundID = roundID;
        }
    }
}
