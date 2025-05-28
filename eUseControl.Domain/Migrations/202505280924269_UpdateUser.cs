namespace eUseControl.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FoodItems", "User_Id", c => c.Int());
            CreateIndex("dbo.FoodItems", "User_Id");
            AddForeignKey("dbo.FoodItems", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.FoodItems", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodItems", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.FoodItems", "User_Id", "dbo.Users");
            DropIndex("dbo.FoodItems", new[] { "User_Id" });
            DropColumn("dbo.FoodItems", "User_Id");
        }
    }
}
