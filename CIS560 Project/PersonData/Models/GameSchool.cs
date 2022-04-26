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

        public string SchoolName { get; }

        public int Score { get; }

        public int TeamTypeID { get; }

        public GameSchool(int gameID, int schoolID, string schoolName, int score, int teamTypeID)
        {
            GameID = gameID;
            SchoolID = schoolID;
            SchoolName = schoolName;
            Score = score;
            TeamTypeID = teamTypeID;
        }

        public override string ToString()
        {
            return SchoolName;
        }
    }
}
