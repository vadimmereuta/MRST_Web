namespace eUseControl.Domain.Migrations
{
    using eUseControl.Domain.Entities.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eUseControl.Domain.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            if (!context.Users.Any(u => u.Username == "admin"))
            {
                context.Users.Add(new User
                {
                    Username = "admin",
                    Email = "admin@email.com",
                    Password = "admin123", // (hash în caz real)
                    Role = "Admin"
                });
                context.SaveChanges();
            }
        }
    }
}
