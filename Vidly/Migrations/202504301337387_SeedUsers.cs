namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c6adfa92-6f8c-4330-81b0-25d6227021a6', N'guest@vidly.com', 0, N'AAnp2yF4Orh2u2OI0v300XAvVxRIOucj3XKMmfBnzvHTyv/Su/IIvou9Z6gQTIAqkQ==', N'daf7cdb6-5041-41d7-b8ff-0ceffdbf475c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e5ecce80-e075-42f9-b6c8-9490f4884b73', N'admin@vidly.com', 0, N'AMO2tPCiv0bsfi46ZNrubpQLwSYkF6nJtrKvGAsgqoNx61WurXI6x1IFvgfFZmdK5w==', N'b8833d50-f84a-4336-a2fd-bfd88dfe5ca9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c391715f-2b53-4eb5-9668-49b2258b0475', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e5ecce80-e075-42f9-b6c8-9490f4884b73', N'c391715f-2b53-4eb5-9668-49b2258b0475')

");
        }
        
        public override void Down()
        {
        }
    }
}
