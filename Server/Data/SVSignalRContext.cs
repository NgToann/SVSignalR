using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SVSignalR.Shared;
using SVSignalR.Shared.Models;
using SVSignalR.Shared.Models.MasterSchedule;

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
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<SizeRunModel> SizeRun { get; set; }
        public DbSet<OutsoleSupplierModel> OutsoleSuppliers { get; set; }
        public DbSet<OutsoleWHCheckModel> OutsoleMaterialCheckingList { get; set; }


    }
}
