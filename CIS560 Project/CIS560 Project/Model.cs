using PersonData;
using PersonData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_Project
{
    public class Model
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560Project;Integrated Security=SSPI;";

        public SqlPlayerRepository PlayerRepo;

        public SqlSchoolRepository SchoolRepo;

        public SqlGameRepository GameRepo;

        public SqlPlayerGameStatisticsRepository PlayerGameStatisticsRepo;

        public SqlGameSchoolRepository GameSchoolRepo;

        public List<School> Schools;

        public SqlSchoolWinsRepository WinsRepo;

        public SqlPPGRepository PPGRepo;

        public SqlPointDiffRepository PointDiffRepo;

        public SqlUpsetRepository UpsetRepo;

        public SqlUpsetSeedCountRepository UpsetCountRepo;

        public List<SchoolWins> SchoolWins;

        public List<PPG> AllPPG;

        public List<PointDiff> AllPointDiff;

        public List<Upsets> AllUpsets;

        public List<UpsetCount> CountUpsets;

        public Model()
        {
            PlayerRepo = new SqlPlayerRepository(connectionString);
            SchoolRepo = new SqlSchoolRepository(connectionString);
            GameRepo = new SqlGameRepository(connectionString);
            PlayerGameStatisticsRepo = new SqlPlayerGameStatisticsRepository(connectionString);
            GameSchoolRepo = new SqlGameSchoolRepository(connectionString);
            WinsRepo = new SqlSchoolWinsRepository(connectionString);
            PPGRepo = new SqlPPGRepository(connectionString);
            PointDiffRepo = new SqlPointDiffRepository(connectionString);
            UpsetRepo = new SqlUpsetRepository(connectionString);
            UpsetCountRepo = new SqlUpsetSeedCountRepository(connectionString);

            Schools = SchoolRepo.RetrieveSchools();
            SchoolWins = WinsRepo.RetrieveAllSchoolWins();
            AllPPG = PPGRepo.RetrieveAllPPG();
            AllPointDiff = PointDiffRepo.RetrieveAllPointDiff();
            AllUpsets = UpsetRepo.RetrieveAllUpsets();
            CountUpsets = UpsetCountRepo.CountAllUpsets();
        }
    }
}
