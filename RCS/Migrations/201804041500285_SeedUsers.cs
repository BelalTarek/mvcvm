namespace RCS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5967cb18-9bfe-4bf0-9e04-912ba4755d6d', N'A@domain.com', 0, N'AFI0cJtKuHjGuNEVDzXO/ittu4I4YffDYye0Ak0Ig5lYv744lH+coSGFDy1c8vygTw==', N'17abe6fe-67f9-4463-aed7-0a36a817e7e6', NULL, 0, 0, NULL, 1, 0, N'A@domain.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b8bc6933-3383-4456-b234-0af8d577ed47', N'hoss_c.ronaldo@hotmail.com', 0, N'ANJerPG+Y0i+i1BzOcDKGIQxaTs/FqRMV6qnAuCkh+kidWeNEo6zIkiCA470NGHjrw==', N'9d616ea8-691a-45f9-abef-1af5fce8b8b1', NULL, 0, 0, NULL, 1, 0, N'hoss_c.ronaldo@hotmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ba957635-f01f-403b-ac95-f4fde4b1c54b', N'H@domain.com', 0, N'AMNqrJ1VveGcUCKNOsO4olTACJuWWedYHqUQa4FAGJ3+M8Msg5voV1Qv7r2iZf8F0w==', N'6df7009a-cd68-4349-8bb8-590410611d82', NULL, 0, 0, NULL, 1, 0, N'H@domain.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'877fa28f-9ba6-490e-83fb-d61aae4573d4', N'Admin')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ba957635-f01f-403b-ac95-f4fde4b1c54b', N'877fa28f-9ba6-490e-83fb-d61aae4573d4')

");
        }
        
        public override void Down()
        {

        }
    }
}
