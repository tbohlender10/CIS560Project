using System;
namespace PersonData.Models
{
   public class Game
    {
        public int GameID { get; }

        public DateTimeOffset DateTimeInfo { get; }

        public int RoundID { get; }

        public Game(int gameID, DateTimeOffset dateTimeInfo, int roundID)
        {
            GameID = gameID;
            DateTimeInfo = dateTimeInfo;
            RoundID = roundID;
        }
    }
}
