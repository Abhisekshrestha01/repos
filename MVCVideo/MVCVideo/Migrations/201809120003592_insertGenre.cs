namespace MVCVideo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into dbo.Genres values('Comedy')");
            Sql("insert into dbo.Genres values('Action')");
            Sql("insert into dbo.Genres values('Family')");
            Sql("insert into dbo.Genres values('Romance')");

           
        }


        
        public override void Down()
        {
        }
    }
}
