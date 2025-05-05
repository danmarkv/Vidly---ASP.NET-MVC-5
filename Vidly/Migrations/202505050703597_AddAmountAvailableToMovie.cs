namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAmountAvailableToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AmountAvailable", c => c.Byte(nullable: false));

            Sql("UPDATE Movies SET AmountAvailable = StockAmount");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "AmountAvailable");
        }
    }
}
