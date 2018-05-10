namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class notes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotesViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        notes = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NotesViewModels");
        }
    }
}
