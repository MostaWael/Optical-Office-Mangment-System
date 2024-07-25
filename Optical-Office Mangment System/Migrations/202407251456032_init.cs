namespace Optical_Office_Mangment_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BillTimeCreation = c.DateTime(nullable: false),
                        TotalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Number = c.Int(nullable: false),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        ComapnyName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentDate = c.DateTime(nullable: false),
                        PaidTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Remain = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BillNumber = c.String(),
                        BillState = c.String(),
                        Customer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
            CreateTable(
                "dbo.BillIteams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        PriceManfcture = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bill_Id = c.Int(),
                        optic_Code = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bills", t => t.Bill_Id)
                .ForeignKey("dbo.Optics", t => t.optic_Code)
                .Index(t => t.Bill_Id)
                .Index(t => t.optic_Code);
            
            CreateTable(
                "dbo.Optics",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        Type = c.String(),
                        Sph = c.String(),
                        Cyl = c.String(),
                        Quantity = c.Int(nullable: false),
                        PriceSell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceBuy = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Worker_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Code)
                .ForeignKey("dbo.Workers", t => t.Worker_Id)
                .Index(t => t.Worker_Id);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        loses = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Borrowers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BorrowTime = c.DateTime(nullable: false),
                        Workers_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Workers", t => t.Workers_Id)
                .Index(t => t.Workers_Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Money = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SuppliersPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentAmmount = c.DateTime(nullable: false),
                        Supplier_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id)
                .Index(t => t.Supplier_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SuppliersPayments", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.BillIteams", "optic_Code", "dbo.Optics");
            DropForeignKey("dbo.Optics", "Worker_Id", "dbo.Workers");
            DropForeignKey("dbo.Borrowers", "Workers_Id", "dbo.Workers");
            DropForeignKey("dbo.BillIteams", "Bill_Id", "dbo.Bills");
            DropForeignKey("dbo.CustomerPayments", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Bills", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.SuppliersPayments", new[] { "Supplier_Id" });
            DropIndex("dbo.Borrowers", new[] { "Workers_Id" });
            DropIndex("dbo.Optics", new[] { "Worker_Id" });
            DropIndex("dbo.BillIteams", new[] { "optic_Code" });
            DropIndex("dbo.BillIteams", new[] { "Bill_Id" });
            DropIndex("dbo.CustomerPayments", new[] { "Customer_Id" });
            DropIndex("dbo.Bills", new[] { "Customer_Id" });
            DropTable("dbo.SuppliersPayments");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Borrowers");
            DropTable("dbo.Workers");
            DropTable("dbo.Optics");
            DropTable("dbo.BillIteams");
            DropTable("dbo.CustomerPayments");
            DropTable("dbo.Customers");
            DropTable("dbo.Bills");
        }
    }
}
