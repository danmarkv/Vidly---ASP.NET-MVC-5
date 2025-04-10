namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Web.UI.WebControls.WebParts;

    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go', SignUpFee = 0, DurationInMonths = 0, DiscountRate = 0 WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly', SignUpFee = 30, DurationInMonths = 1, DiscountRate = 10 WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly', SignUpFee = 90, DurationInMonths = 3, DiscountRate = 15 WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annually', SignUpFee = 300, DurationInMonths = 12, DiscountRate = 20 WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
