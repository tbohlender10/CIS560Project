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

        public override string ToString()
        {
            string round;
            if (RoundID == 1)
            {
                round = "First Round";
            }
            else if(RoundID == 2)
            {
                round = "Second Round";
            }
            else if (RoundID == 3)
            {
                round = "Sweet 16";
            }
            else if (RoundID == 4)
            {
                round = "Elite 8";
            }
            else if (RoundID == 5)
            {
                round = "Final 4";
            }
            else if (RoundID == 6)
            {
                round = "National Championship";
            }
            else
            {
                round = "ERROR";
            }

            return DateTimeInfo.ToString("MM/dd/yy hh:mm") + " pm" + " -- " + round;
        }
    }
}
