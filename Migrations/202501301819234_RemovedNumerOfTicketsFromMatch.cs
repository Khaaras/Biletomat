namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedNumerOfTicketsFromMatch : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Matches", "NumberOfTicket");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matches", "NumberOfTicket", c => c.Int(nullable: false));
        }
    }
}
