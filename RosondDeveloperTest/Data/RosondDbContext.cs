using RosondDeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Data
{
    public class RosondDbContext:DbContext
    {


        //public RosondDbContext(DbContextOptions<RosondDbContext> options):base(options)
        //{

        //}

        public DbSet<Branch> Branches { get; set; }


        public DbSet<City> Cities { get; set; }


        public DbSet<Client> Clients { get; set; }


        public DbSet<Driver> Drivers { get; set; }

        public DbSet<BranchSupplierLink> BranchSupplierLinks { get; set; }


        public DbSet<Province> Provinces { get; set; }


        public DbSet<Supplier> Suppliers { get; set; }


        public DbSet<Vehicle> Vehicles { get; set; }


    }
}