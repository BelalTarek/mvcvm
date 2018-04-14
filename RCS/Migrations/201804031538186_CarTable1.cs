namespace RCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarTable1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cars", name: "user_Id", newName: "UserId");
            RenameIndex(table: "dbo.Cars", name: "IX_user_Id", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Cars", name: "IX_UserId", newName: "IX_user_Id");
            RenameColumn(table: "dbo.Cars", name: "UserId", newName: "user_Id");
        }
    }
}
