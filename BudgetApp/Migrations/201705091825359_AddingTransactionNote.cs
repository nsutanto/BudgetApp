namespace BudgetApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTransactionNote : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Transactions", "Note");
        }
    }
}
