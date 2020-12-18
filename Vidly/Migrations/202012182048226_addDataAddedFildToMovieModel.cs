namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataAddedFildToMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "dataAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "dataAdded");
        }
    }
}
