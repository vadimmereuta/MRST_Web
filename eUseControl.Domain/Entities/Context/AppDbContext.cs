﻿using System.Data.Entity;
using eUseControl.Domain.Entities;
using eUseControl.Domain.Entities.Models;

namespace eUseControl.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=DefaultConnection") {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MealItem> MealItems { get; set; }
        public DbSet<Workout> Workouts { get; set; }

    }


}

