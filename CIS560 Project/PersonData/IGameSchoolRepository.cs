using System;
using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IGameSchoolRepository
   {
        GameSchool RetrieveHomeSchoolForGame(int gameID);

        GameSchool RetrieveGuestSchoolForGame(int gameID);
    }
}
