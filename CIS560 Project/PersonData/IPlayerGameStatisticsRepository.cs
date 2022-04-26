using System;
using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IPlayerGameStatisticsRepository
   {
        PlayerGameStatistics GetPlayerGameStatisticsForPlayerGame(int gameID, int playerID);

        bool InsertPlayerGameStatistics(DateTimeOffset dti, string school, string playerName, int points, int threePoints, int fgm, int fga, int rebounds, int minutes);

        bool UpdatePlayerGameStatistics(int gameID, int playerID, int schoolID, int points, int threePoints, int fgm, int fga, int rebounds, int minutes);
   }
}
