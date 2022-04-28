using System;

namespace PersonData.Models
{

   public class Upsets
   {
        public string HighSeedName { get; }

        public int HighSeed { get; }

        public string LowSeedName { get; }

        public int LowSeed { get; }

        public int SeedDifference { get; }
      
        public Upsets(string highName, int highSeed, string lowName, int lowSeed, int seedDiff)
        {
            HighSeedName = highName;
            HighSeed = highSeed;
            LowSeedName = lowName;
            LowSeed = lowSeed;
            SeedDifference = seedDiff;
        }

        public override string ToString()
        {
            return HighSeed + " " + HighSeedName + " upset " + LowSeed + " " + LowSeedName;
        }
    }
}
