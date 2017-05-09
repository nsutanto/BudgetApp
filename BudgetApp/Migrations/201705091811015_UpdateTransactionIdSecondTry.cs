namespace BudgetApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTransactionIdSecondTry : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Transactions");
            AddPrimaryKey("dbo.Transactions", "TransactionId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Transactions");
            DropColumn("dbo.Transactions", "TransactionId");
        }
    }
}
