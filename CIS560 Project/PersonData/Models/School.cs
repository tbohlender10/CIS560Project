using System;

namespace PersonData.Models
{

   public class School
   {
        public int SchoolID { get; }

        public string Name { get; }

        public string Coach { get; }

        public int Seed { get; }

        public int RegionId { get; }
      
        internal School(int schoolID, string name, string coach, 
            int seed, int regionId)
        {
            SchoolID = schoolID;
            Name = name;
            Coach = coach;
            Seed = seed;
            RegionId = regionId;
        }
   }
}
