using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IGameSchoolRepository
   {
        bool UpdateGameScore(string schoolName, int gameID, TeamType teamType, int score);
   }
}
