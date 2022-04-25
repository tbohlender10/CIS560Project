﻿using PersonData;
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

        public List<School> Schools;

        public Model()
        {
            PlayerRepo = new SqlPlayerRepository(connectionString);
            SchoolRepo = new SqlSchoolRepository(connectionString);
            GameRepo = new SqlGameRepository(connectionString);
            Schools = SchoolRepo.RetrieveSchools();
        }
    }
}
