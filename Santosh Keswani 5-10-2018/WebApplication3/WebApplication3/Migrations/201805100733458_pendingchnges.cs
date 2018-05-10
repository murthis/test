namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pendingchnges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WaterIntakes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        numberOfGlassesConsumed = c.Int(nullable: false),
                        targetGlasses = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WaterIntakes");
        }
    }
}
