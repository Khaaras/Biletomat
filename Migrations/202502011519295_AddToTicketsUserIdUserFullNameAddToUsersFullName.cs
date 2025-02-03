namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToTicketsUserIdUserFullNameAddToUsersFullName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "UserId", c => c.Int(nullable: true));
            AddColumn("dbo.Tickets", "FullName", c => c.String(nullable: true));
            AddColumn("dbo.Users", "FullName", c => c.String());
            CreateIndex("dbo.Tickets", "UserId");
            AddForeignKey("dbo.Tickets", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "UserId", "dbo.Users");
            DropIndex("dbo.Tickets", new[] { "UserId" });
            DropColumn("dbo.Users", "FullName");
            DropColumn("dbo.Tickets", "FullName");
            DropColumn("dbo.Tickets", "UserId");
        }
    }
}
