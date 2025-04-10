namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdatesToCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1996-06-03' WHERE Name = 'John Smith'");
            Sql("UPDATE Customers SET Birthdate = '1997-06-23' WHERE Name = 'Princess Moreen'");
        }
        
        public override void Down()
        {
        }
    }
}
