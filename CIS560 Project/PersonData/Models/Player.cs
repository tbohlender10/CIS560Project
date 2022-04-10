using System;

namespace PersonData.Models
{
   public class Player
   {
        public int PlayerID { get; }

        public string Name { get; }
        
        public string Grade { get; }

      public Player(int playerID, string name, string grade)
      {
            PlayerID = playerID;
            Name = name;
            Grade = grade;
      }
   }
}
