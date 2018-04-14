namespace RCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carColor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "color", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "color");
        }
    }
}
