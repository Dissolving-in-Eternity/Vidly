namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ba913713-13f3-4441-bb23-7061cab16a2d', N'admin@vidly.com', 0, N'AKbDNcusRQ5g0XAQxPJd6d6e6nUU8FNMNqpTlZvEjg7ZqFcguj4FHnJc4dtCVHzFNQ==', N'337f4db9-e9e8-4458-9f67-7b9a1978fdaf', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd53ac7cc-b8c6-410a-9643-3b581644a599', N'guest@vidly.com', 0, N'ACbj/sPeeZSGzL7I3bARWbV32DRFTmYeQ4ZZj8rM4EAfe2YXpW3kauFFfuhgqZVD5A==', N'b9efb0af-b477-4573-9bb0-a7f7a1a1c119', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'01bd34b8-e1d8-48bd-8e5b-9d0ae753c3cf', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ba913713-13f3-4441-bb23-7061cab16a2d', N'01bd34b8-e1d8-48bd-8e5b-9d0ae753c3cf')

");
        }
        
        public override void Down()
        {
        }
    }
}
