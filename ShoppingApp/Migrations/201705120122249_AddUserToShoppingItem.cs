namespace ShoppingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToShoppingItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShoppingItems", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.ShoppingItems", "ApplicationUser_Id");
            AddForeignKey("dbo.ShoppingItems", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingItems", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ShoppingItems", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.ShoppingItems", "ApplicationUser_Id");
        }
    }
}
