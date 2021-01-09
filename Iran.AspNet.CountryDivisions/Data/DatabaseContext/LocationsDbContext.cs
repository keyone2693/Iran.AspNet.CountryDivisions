using System;
using System.IO;
using System.Reflection;
using Iran.AspNet.CountryDivisions.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Iran.AspNet.CountryDivisions.Data.DatabaseContext
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
            optionBuilder.UseSqlite("Data Source=" + Path.Combine(_basePath, @"Data\DataBase", "locations.db"));
        }

        public  DbSet<Ostan> Ostans { get; set; }
        public  DbSet<Shahrestan> Shahrestans { get; set; }
        public  DbSet<Bakhsh> Bakhshs { get; set; }
        public  DbSet<Shahr> Shahrs { get; set; }
        public  DbSet<Dehestan> Dehestans { get; set; }
        public  DbSet<Abadi> Abadis { get; set; }
        public  DbSet<Keshvar> Keshvars { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
