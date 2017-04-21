namespace Sportscasters_final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        LastPurchase = c.DateTime(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        UPC = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Inventory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transaction", "ProductID", "dbo.Product");
            DropForeignKey("dbo.Transaction", "EmployeeID", "dbo.Employee");
            DropForeignKey("dbo.Transaction", "CustomerID", "dbo.Customer");
            DropIndex("dbo.Transaction", new[] { "EmployeeID" });
            DropIndex("dbo.Transaction", new[] { "CustomerID" });
            DropIndex("dbo.Transaction", new[] { "ProductID" });
            DropTable("dbo.Product");
            DropTable("dbo.Employee");
            DropTable("dbo.Transaction");
            DropTable("dbo.Customer");
        }
    }
}
