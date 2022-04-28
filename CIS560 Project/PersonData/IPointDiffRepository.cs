using System.Collections.Generic;
using System.ComponentModel;
using PersonData.Models;

namespace PersonData
{
   public interface IPointDiffRepository
   {
        List<PointDiff> RetrieveAllPointDiff();
   }
}
