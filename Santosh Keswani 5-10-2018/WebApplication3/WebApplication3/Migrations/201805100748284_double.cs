namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _double : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WaterIntakes", "numberOfGlassesConsumed", c => c.Double(nullable: false));
            AlterColumn("dbo.WaterIntakes", "targetGlasses", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WaterIntakes", "targetGlasses", c => c.Int(nullable: false));
            AlterColumn("dbo.WaterIntakes", "numberOfGlassesConsumed", c => c.Int(nullable: false));
        }
    }
}
