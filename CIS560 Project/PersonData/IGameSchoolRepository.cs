using System;
using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IGameSchoolRepository
   {
        bool UpdateGameScore(int gameID, int schoolID, int score);

        GameSchool RetrieveHomeSchoolForGame(int gameID);

        GameSchool RetrieveGuestSchoolForGame(int gameID);
    }
}
