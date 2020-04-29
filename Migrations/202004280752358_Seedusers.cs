namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seedusers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1c0f9bdc-d1c2-479e-a3e2-aa49ae464eff', N'admin@vidly.com', 0, N'ACWZgTu87Gf4f14BSbIuarIVsIzXmRjqkMoGjU9DsYcBKh2S8wpNZ2T1+qMyytq53g==', N'dfeed154-9bb7-401a-a9f3-9824b88aa0e4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5f15ed67-efc8-4c59-b7d5-41a13b1b3815', N'kaka.puwe@gmail.com', 0, N'AFQbx/uBhhOAjO/U834YAXMColoTymd7/gKWFJYlo+Ra1phIhjOXLyAB/ey51O/Kfw==', N'76bb2b58-0805-4ce0-8383-c51a31449c41', NULL, 0, 0, NULL, 1, 0, N'kaka.puwe@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fc257c27-cb14-4b8e-9be9-a69b0bc57ce5', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1c0f9bdc-d1c2-479e-a3e2-aa49ae464eff', N'fc257c27-cb14-4b8e-9be9-a69b0bc57ce5')

");
        }
        
        public override void Down()
        {
        }
    }
}
