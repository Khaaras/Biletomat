namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTickets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserTickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        MatchId = c.Int(nullable: false),
                        TicketNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matches", t => t.MatchId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.MatchId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTickets", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserTickets", "MatchId", "dbo.Matches");
            DropIndex("dbo.UserTickets", new[] { "MatchId" });
            DropIndex("dbo.UserTickets", new[] { "UserId" });
            DropTable("dbo.UserTickets");
        }
    }
}
