namespace MVCVideo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameInMemberType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("update dbo.MembershipTypes set Name='Pay as You Go' where Id = '1'");
            Sql("update dbo.MembershipTypes set Name='Yearly' where Id = '2'");
            Sql("update dbo.MembershipTypes set Name='Monthly' where Id = '3'");
            Sql("update dbo.MembershipTypes set Name='Weekly' where Id = '4'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
