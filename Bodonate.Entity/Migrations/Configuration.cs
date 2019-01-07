namespace Bodonate.Entity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Bodonate.Entity.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<Bodonate.Entity.DbContext.BodonateDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Bodonate.Entity.DbContext.BodonateDbContext context)
        {
          
            //  This  method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
