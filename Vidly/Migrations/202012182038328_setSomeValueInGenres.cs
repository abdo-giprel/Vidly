namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setSomeValueInGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (name) VALUES ('Comedy')");
            Sql("INSERT INTO Genres (name) VALUES ('Action')");
            Sql("INSERT INTO Genres (name) VALUES ('Family')");
            Sql("INSERT INTO Genres (name) VALUES ('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
