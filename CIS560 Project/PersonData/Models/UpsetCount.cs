using System;

namespace PersonData.Models
{

   public class UpsetCount
   {
        public int SeedDifference { get; }


        public int NumberOfGames { get; }

        public UpsetCount(int seedDiff, int numGames)
        {
            SeedDifference = seedDiff;
            NumberOfGames = numGames;
        }

        public override string ToString()
        {
            return "Number of upsets with a " + SeedDifference + " seed difference: " + NumberOfGames;
        }
    }
}
