namespace eUseControl.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.FoodItems", "UserId");
            AddForeignKey("dbo.FoodItems", "UserId", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodItems", "UserId", "dbo.Users");
            DropIndex("dbo.FoodItems", new[] { "UserId" });
        }
    }
}
