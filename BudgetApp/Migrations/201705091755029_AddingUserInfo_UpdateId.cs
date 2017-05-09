namespace BudgetApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingUserInfo_UpdateId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserDetailId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.UserDetailId);
            
            AddColumn("dbo.Transactions", "UserDetailId", c => c.Int(nullable: false));
            CreateIndex("dbo.Transactions", "UserDetailId");
            AddForeignKey("dbo.Transactions", "UserDetailId", "dbo.UserDetails", "UserDetailId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "UserDetailId", "dbo.UserDetails");
            DropIndex("dbo.Transactions", new[] { "UserDetailId" });
            DropColumn("dbo.Transactions", "UserDetailId");
            DropTable("dbo.UserDetails");
        }
    }
}
