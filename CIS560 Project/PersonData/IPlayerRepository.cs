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
      Player FetchPerson(int personId);

      /// <summary>
      /// Gets the person with the given <paramref name="personId"/> if it exists.
      /// </summary>
      /// <param name="email">Email of the person to get.</param>
      /// <returns>
      /// An instance of <see cref="Player"/> containing the information of the requested person
      /// if one exists with with the provided <paramref name="email"/>.
      /// If one is not found, <c>null</c> is returned.
      /// </returns>
      Player GetPerson(string email);

      /// <summary>
      /// Creates a new person in the repository.
      /// </summary>
      /// <param name="firstName">First name of the person to create.</param>
      /// <param name="lastName">Last name of the person to create.</param>
      /// <param name="email">Email of the person to create.</param>
      /// <returns>
      /// The resulting instance of <see cref="Player"/>.
      /// </returns>
      Player CreatePerson(string firstName, string lastName, string email);
   }
}
