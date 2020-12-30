using System;
using System.IO;

using Iran.CountryDivisions.AspNet.Data.Models;

using Microsoft.EntityFrameworkCore;


namespace Rahnavard724.Core.Data.DatabaseContext
{
    public class LocationsDbContext : DbContext
    {
        private static AppDomain _appDomain = System.AppDomain.CurrentDomain;
        private static string _basePath = _appDomain.RelativeSearchPath ?? _appDomain.BaseDirectory;
        public LocationsDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Data Source=" + Path.Combine(_basePath, "Data/DataBase", "locations.db"));
            //optionBuilder.UseSqlServer(@"Server=.\MSSQLSERVER2017;Database=api_rahnavard;User Id=api_rahnavard;password=Xil8w85#;Trusted_Connection=False;MultipleActiveResultSets=true;");
        }

        public  DbSet<Ostan> Ostans { get; set; }
        public  DbSet<Shahrestan> Shahrestans { get; set; }
        public  DbSet<Bakhsh> Bakhshs { get; set; }
        public  DbSet<Shahr> Shahrs { get; set; }
        public  DbSet<Dehestan> Dehestans { get; set; }
        public  DbSet<Abadi> Abadis { get; set; }
 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
