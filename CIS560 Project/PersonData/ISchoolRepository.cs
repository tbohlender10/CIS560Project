using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface ISchoolRepository
   {
      IReadOnlyList<Address> RetrieveAdresses(int personId);

      void SaveAddress(int personId, Game addressType, string line1, string line2, string city, string stateCode, string zipCode);
   }
}
