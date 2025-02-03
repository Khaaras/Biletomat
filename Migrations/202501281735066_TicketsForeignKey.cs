namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketsForeignKey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Tickets", "MatchId");
            AddForeignKey("dbo.Tickets", "MatchId", "dbo.Matches", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "MatchId", "dbo.Matches");
            DropIndex("dbo.Tickets", new[] { "MatchId" });
        }
    }
}
