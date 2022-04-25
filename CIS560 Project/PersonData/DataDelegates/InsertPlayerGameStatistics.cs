using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData.DataDelegates
{
    public class InsertPlayerGameStatistics : DataDelegate
    {
        public DateTimeOffset DateTimeInfo;

        public string School;

        public string PlayerName;

        public int Points;

        public int ThreePoints;

        public int FGM;

        public int FGA;

        public int Rebounds;

        public int Minutes;

        public InsertPlayerGameStatistics(DateTimeOffset dti, string school, string name, int points, int threePoints, int fgm, int fga, int rebounds, int minutes)
          : base("Basketball.InsertPlayerGameStatistics")
        {
            DateTimeInfo = dti;
            School = school;
            PlayerName = name;
            Points = points;
            ThreePoints = threePoints;
            FGM = fgm;
            FGA = fga;
            Rebounds = rebounds;
            Minutes = minutes;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("DateTimeInfo", DateTimeInfo);
            command.Parameters.AddWithValue("School", School);
            command.Parameters.AddWithValue("Name", PlayerName);
            command.Parameters.AddWithValue("Points", Points);
            command.Parameters.AddWithValue("ThreePoints", ThreePoints);
            command.Parameters.AddWithValue("FGM", FGM);
            command.Parameters.AddWithValue("FGA", FGA);
            command.Parameters.AddWithValue("Rebounds", Rebounds);
            command.Parameters.AddWithValue("Minutes", Minutes);
        }
    }
}
