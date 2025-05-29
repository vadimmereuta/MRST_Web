namespace eUseControl.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWorkoutTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Workouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Type = c.String(nullable: false),
                        DurationMinutes = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Workouts");
        }
    }
}
