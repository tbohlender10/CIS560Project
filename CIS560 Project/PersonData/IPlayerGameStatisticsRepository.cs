using System;
using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IPlayerGameStatisticsRepository
   {
        PlayerGameStatistics GetPlayerGameStatisticsForGame(int gameID);

        PlayerGameStatistics GetPlayerGameStatisticsForPlayer(int playerID);

        IReadOnlyList<PlayerGameStatistics> RetrievePlayerGameStatisticsForSchool(int schoolID);

        PlayerGameStatistics GetPlayerGameStatisticsForPlayerGame(int gameID, int playerID);

        bool InsertPlayerGameStatistics(DateTimeOffset dti, string school, string playerName, int points, int threePoints, int fgm, int fga, int rebounds, int minutes);
   }
}
