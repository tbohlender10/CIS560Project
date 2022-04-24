using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IGameRepository
   {
        IList<Game> RetrieveAllGames();
   }
}
