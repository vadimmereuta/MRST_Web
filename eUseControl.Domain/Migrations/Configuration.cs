namespace eUseControl.Domain.Migrations
{
    using eUseControl.Domain.Entities.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eUseControl.Domain.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(eUseControl.Domain.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            if (!context.FoodItems.Any())
            {
                context.FoodItems.AddRange(new List<FoodItem>
                {
                    new FoodItem { Name = "Orez", Calories = 130, Protein = 2.5f, Carbs = 28, Fat = 0.3f },
                    new FoodItem { Name = "Piept de pui", Calories = 165, Protein = 31, Carbs = 0, Fat = 3.6f },
                    new FoodItem { Name = "Banana", Calories = 89, Protein = 1.1f, Carbs = 23, Fat = 0.3f }
                });
            }

        }
    }
}
