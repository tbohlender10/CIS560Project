using System;

namespace PersonData.Models
{

   public class PointDiff
   {
        public int PointDifference { get; }

        public int NumGames{ get; }

      
        public PointDiff(int numGames, int pointDiff)
        {
            PointDifference = pointDiff;
            NumGames = numGames;
        }

        public override string ToString()
        {
            return PointDifference + ": " + NumGames + " games";
        }
    }
}
