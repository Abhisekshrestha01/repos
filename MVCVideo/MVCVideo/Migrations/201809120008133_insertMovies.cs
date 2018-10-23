namespace MVCVideo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertMovies : DbMigration
    {
        public override void Up()
        {
            Sql("insert into dbo.Movies values ('Hangover','01/02/1993','09/10/2018','5','1','1')");
            Sql("insert into dbo.Movies values ('Die Hard','01/03/1993','09/10/2018','4','2','2')");
            Sql("insert into dbo.Movies values ('The Terminator','01/04/1993','09/10/2018','6','2','2')");
            Sql("insert into dbo.Movies values ('Toy Story','01/05/1993','09/10/2018','3','3','3')");
            Sql("insert into dbo.Movies values ('Titanic','01/07/1993','09/10/2018','2','4','4')");

        }
        
        public override void Down()
        {
        }
    }
}
