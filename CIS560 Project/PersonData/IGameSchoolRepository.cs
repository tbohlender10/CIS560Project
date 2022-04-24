using System;
using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IGameSchoolRepository
   {
        bool UpdateGameScore(string schoolName, DateTimeOffset dateTimeInfo, TeamType teamType, int score);
   }
}
