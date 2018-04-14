namespace RCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarTypeDelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "TypeId", "dbo.CarTypes");
            DropIndex("dbo.Cars", new[] { "TypeId" });
            DropColumn("dbo.Cars", "TypeId");
            DropTable("dbo.CarTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TypeId);
            
            AddColumn("dbo.Cars", "TypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "TypeId");
            AddForeignKey("dbo.Cars", "TypeId", "dbo.CarTypes", "TypeId", cascadeDelete: true);
        }
    }
}
