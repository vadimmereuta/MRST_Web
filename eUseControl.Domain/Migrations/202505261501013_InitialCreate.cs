namespace eUseControl.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Calories = c.Int(nullable: false),
                        Protein = c.Single(nullable: false),
                        Carbs = c.Single(nullable: false),
                        Fat = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MealItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MealId = c.Int(nullable: false),
                        FoodItemId = c.Int(nullable: false),
                        Quantity = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FoodItems", t => t.FoodItemId, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.MealId, cascadeDelete: true)
                .Index(t => t.MealId)
                .Index(t => t.FoodItemId);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meals", "UserId", "dbo.Users");
            DropForeignKey("dbo.MealItems", "MealId", "dbo.Meals");
            DropForeignKey("dbo.MealItems", "FoodItemId", "dbo.FoodItems");
            DropIndex("dbo.Meals", new[] { "UserId" });
            DropIndex("dbo.MealItems", new[] { "FoodItemId" });
            DropIndex("dbo.MealItems", new[] { "MealId" });
            DropTable("dbo.Users");
            DropTable("dbo.Meals");
            DropTable("dbo.MealItems");
            DropTable("dbo.FoodItems");
        }
    }
}
