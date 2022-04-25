using System.Collections.Generic;
using System.ComponentModel;
using PersonData.Models;

namespace PersonData
{
   public interface IGameRepository
   {
        BindingList<Game> RetrieveAllGames();

        BindingList<School> RetrieveSchoolsForGame(int gameID);
   }
}
