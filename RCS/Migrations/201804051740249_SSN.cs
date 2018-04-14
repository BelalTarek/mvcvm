namespace RCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SSN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SSN", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SSN");
        }
    }
}
