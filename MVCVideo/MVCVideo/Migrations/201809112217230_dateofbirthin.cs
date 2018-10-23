namespace MVCVideo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateofbirthin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DOB", c => c.DateTime(nullable: false));
            Sql("Update dbo.Customers set DOB='1/1/1980' where Id = 1");
            Sql("Update dbo.Customers set DOB='1/2/1980' where Id = 2");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DOB");
        }
    }
}
