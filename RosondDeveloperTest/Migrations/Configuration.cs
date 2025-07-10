namespace RosondDeveloperTest.Migrations
{
    using RosondDeveloperTest.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RosondDeveloperTest.Data.RosondDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RosondDeveloperTest.Data.RosondDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var Provinces = new List<Province>
            {
                new Province { ProvinceName = "Gauteng", },
                new Province { ProvinceName = "EasternCape", },
                new Province { ProvinceName = "Limpopo", },
               
            };
            Provinces.ForEach(s => context.Provinces.AddOrUpdate(p => p.ProvinceName, s));
            context.SaveChanges();

            var Cities = new List<City>
            {
                new City {CityName = ""}
            }
        }
    }
}
