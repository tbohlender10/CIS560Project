using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IPlayerSeasonStatisticsRepository
   {
        PlayerSeasonStatistics GetPlayerGameStatisticsForPlayer(int playerID);

        IReadOnlyList<PlayerSeasonStatistics> RetrievePlayerGameStatisticsForSchool(int schoolID);
    }
}
