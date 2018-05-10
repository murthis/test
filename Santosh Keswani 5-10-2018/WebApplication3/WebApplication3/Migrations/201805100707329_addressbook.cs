namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addressbook : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AddressBooks", "address", c => c.String(nullable: false));
            AlterColumn("dbo.AddressBooks", "city", c => c.String(nullable: false));
            AlterColumn("dbo.AddressBooks", "pincode", c => c.String(nullable: false, maxLength: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AddressBooks", "pincode", c => c.String());
            AlterColumn("dbo.AddressBooks", "city", c => c.String());
            AlterColumn("dbo.AddressBooks", "address", c => c.String());
        }
    }
}
