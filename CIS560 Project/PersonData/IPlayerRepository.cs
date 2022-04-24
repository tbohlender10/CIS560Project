using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface IPlayerRepository
   {
        /// <summary>
        /// Gets all the players in the database for a certain school.
        /// </summary>
        /// <param name="schoolID"></param>
        /// <returns></returns>
        IReadOnlyList<Player> RetrievePlayersForSchool(int schoolID);

        /// <summary>
        /// Fetches the person with the given <paramref name="personId"/> if it exists.
        /// </summary>
        /// <param name="personId">Identifier of the person to fetch.</param>
        /// <returns>
        /// An instance of <see cref="Player"/> containing the information of the requested person.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="personId"/> does not exist.
        /// </exception>
        Player FetchPlayer(int personID);

        bool CreateNewPlayer(string school, string playerName, int number, string grade, string position);

        bool UpdatePlayerNumber(string playerName, string school, int number);

        bool UpdatePlayerGrade(string playerName, string school, string grade);

        bool UpdatePlayerPosition(string playerName, string school, string position);

        bool UpdatePlayerName(string playerName, string school, int number);

      
   }
}
