using System.Collections.Generic;
using PersonData.Models;

namespace PersonData
{
   public interface ISchoolRepository
   {
        List<School> RetrieveSchools();

        School GetSchool(int schoolID);
   }
}
