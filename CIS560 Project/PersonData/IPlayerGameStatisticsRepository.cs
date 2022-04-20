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
   }
}
