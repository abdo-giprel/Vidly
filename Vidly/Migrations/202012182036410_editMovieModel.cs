namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "release_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "numberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Genresid", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Genresid");
            AddForeignKey("dbo.Movies", "Genresid", "dbo.Genres", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genresid", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genresid" });
            DropColumn("dbo.Movies", "Genresid");
            DropColumn("dbo.Movies", "numberInStock");
            DropColumn("dbo.Movies", "release_date");
        }
    }
}
