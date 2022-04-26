using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.Models
{
    public class GameSchool
    {
        public int GameID { get; }

        public int SchoolID { get; }

        public int Score { get; }

        public int TeamTypeID { get; }

        public GameSchool(int gameID, int schoolID, int score, int teamTypeID)
        {
            GameID = gameID;
            SchoolID = schoolID;
            Score = score;
            TeamTypeID = teamTypeID;
        }
    }
}
