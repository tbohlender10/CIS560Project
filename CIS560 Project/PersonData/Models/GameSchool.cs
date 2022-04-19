using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.Models
{
    public class GameSchool
    {
        int GameID { get; }

        int SchoolID { get; }

        int TeamTypeID { get; }

        public GameSchool(int gameID, int schoolID, int teamTypeID)
        {
            GameID = gameID;
            SchoolID = schoolID;
            TeamTypeID = teamTypeID;
        }
    }
}
