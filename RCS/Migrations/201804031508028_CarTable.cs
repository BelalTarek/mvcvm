namespace RCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Model = c.String(nullable: false, maxLength: 255),
                        Type = c.String(nullable: false, maxLength: 255),
                        NumberOfChairs = c.Int(nullable: false),
                        RentAmount = c.Single(nullable: false),
                        isAvailable = c.Boolean(nullable: false),
                        user_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id, cascadeDelete: true)
                .Index(t => t.user_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "user_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Cars", new[] { "user_Id" });
            DropTable("dbo.Cars");
        }
    }
}
