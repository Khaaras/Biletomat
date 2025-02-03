namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMatchDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    HomeTeam = c.String(nullable: false),
                    GuestTeam = c.String(nullable: false),
                    GameDate = c.DateTime(nullable: false),
                    TypeOfEvent = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);
                
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matches");
        }
    }
}
