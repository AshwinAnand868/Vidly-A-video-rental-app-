namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'bb126c4a-6362-438f-a0a4-d6e8bf79803d', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'420b19fb-6e01-4f8e-9e01-29c7f40c9a59', N'admin@vidly.com', 0, N'ANAFc+UsGHhvOCWQPbEdvUJgYh+UEt1EQCqUzQEw7v2b9A/lKaqHhFfbZVV5Md+gng==', N'60f80af9-ceb0-4c86-8ca4-d69adadfb9af', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8eb7a2de-7548-44d0-ac5f-c30b5f3fdc2e', N'guest@vidly.com', 0, N'AGV899TT3eKSmrbjHtJJP5Og111ikyoPaikgOobFSxnr38CP6CitkIHXd42nGjEiGg==', N'c5a4b07b-efea-4a3c-ac17-222a958caa68', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c1db1aca-961c-4658-a2d7-bcec3fac3ea0', N'anandashwin@gmail.com', 0, N'ABFuAC3VHy7vIw0EQXKncbt/n6A9sXL3nH+nypIRbrgszzAObOsGARPgI8mx4K+LvQ==', N'2436925e-01cd-4d9d-ab69-bdcee45243db', NULL, 0, 0, NULL, 1, 0, N'anandashwin@gmail.com')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'420b19fb-6e01-4f8e-9e01-29c7f40c9a59', N'bb126c4a-6362-438f-a0a4-d6e8bf79803d')


            ");
        }

        public override void Down()
        {
        }
    }
}
