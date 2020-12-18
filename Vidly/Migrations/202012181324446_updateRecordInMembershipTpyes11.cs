namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateRecordInMembershipTpyes11 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET name = 'Pay as You Go' WHERE id = 1");
            Sql("UPDATE MembershipTypes SET name = 'Monthly' WHERE id = 1");
            Sql("UPDATE MembershipTypes SET name = 'Quarterly' WHERE id = 1");
            Sql("UPDATE MembershipTypes SET name = 'Annual' WHERE id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
