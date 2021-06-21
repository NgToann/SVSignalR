﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SVSignalR.Shared;
using SVSignalR.Shared.Models;

namespace SVSignalR.Server.Data
{
    public class SVSignalRContext : DbContext
    {
        public SVSignalRContext(DbContextOptions<SVSignalRContext> options) : base(options)
        { }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<WorkerModel> Workers { get; set; }
        public DbSet<CovidPlanModel> CovidPlanList { get; set; }
    }
}