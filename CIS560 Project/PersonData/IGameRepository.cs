using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IGameRepository
   {
        List<Game> RetrieveAllGames();

        List<Game> FetchGamesForSchool(string school);
   }
}
