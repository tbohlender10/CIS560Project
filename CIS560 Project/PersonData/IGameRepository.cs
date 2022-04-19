using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IGameRepository
   {
      IReadOnlyList<Game> RetrieveGamesForSchool(int schoolID);
   }
}
