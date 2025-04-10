namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "Birhtdate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Birhtdate", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
