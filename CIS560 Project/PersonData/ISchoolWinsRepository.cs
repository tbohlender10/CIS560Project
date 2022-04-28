using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface ISchoolWinsRepository
   {
        List<SchoolWins> RetrieveAllSchoolWins();

        School GetSchool(int schoolID);

   }
}
