namespace DDDCommerce.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name_FirstName = c.String(maxLength: 50),
                        Name_LastName = c.String(maxLength: 50),
                        Document = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        Email_MailAddress = c.String(maxLength: 60),
                        Phone = c.String(maxLength: 14),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Budget",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 80),
                        Description = c.String(nullable: false, maxLength: 180),
                        Image = c.String(),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        QuantityOnHand = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItem", "Order_Id", "dbo.Order");
            DropForeignKey("dbo.OrderItem", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.Order", "Customer_Id", "dbo.Customer");
            DropIndex("dbo.OrderItem", new[] { "Order_Id" });
            DropIndex("dbo.OrderItem", new[] { "Product_Id" });
            DropIndex("dbo.Order", new[] { "Customer_Id" });
            DropTable("dbo.Product");
            DropTable("dbo.OrderItem");
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
        }
    }
}
