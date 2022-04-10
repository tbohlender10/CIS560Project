using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface ISchoolRepository
   {
        IReadOnlyList<School> RetrieveSchools();

        School GetSchool(int schoolID);
   }
}
