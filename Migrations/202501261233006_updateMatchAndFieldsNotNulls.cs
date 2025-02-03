namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMatchAndFieldsNotNulls : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matches", "NumberOfTicket", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matches", "NumberOfTicket");
        }
    }
}
