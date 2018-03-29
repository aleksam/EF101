namespace EF101.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDirectorClass : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Actors", newName: "Actor");
            RenameTable(name: "dbo.Movies", newName: "Movie");
            CreateTable(
                "dbo.Director",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        isGood = c.Boolean(),
                        DateOfBirth = c.DateTime(nullable: false),
                        MarriageDate = c.DateTime(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Director");
            RenameTable(name: "dbo.Movie", newName: "Movies");
            RenameTable(name: "dbo.Actor", newName: "Actors");
        }
    }
}
