namespace BudgetApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToken : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SecretToken", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SecretToken");
        }
    }
}
