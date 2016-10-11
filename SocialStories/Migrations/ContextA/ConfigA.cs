namespace SocialStories.Migrations.ContextA
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigA : DbMigrationsConfiguration<SocialStories.Models.ApplicationDbContext>
    {
        public ConfigA()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ContextA";
        }

        protected override void Seed(SocialStories.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
