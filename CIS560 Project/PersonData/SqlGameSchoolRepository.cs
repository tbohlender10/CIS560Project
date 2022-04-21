﻿using System.Collections.Generic;
using DataAccess;
using PersonData.Models;
using PersonData.DataDelegates;
using System;

namespace PersonData
{
   public class SqlGameSchoolRepository : IGameSchoolRepository
   {
        private readonly SqlCommandExecutor executor;

        public SqlGameSchoolRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        
    }
}