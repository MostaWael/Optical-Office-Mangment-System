namespace Optical_Office_Mangment_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixtimeinsupplierPayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SuppliersPayments", "PaymentTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.SuppliersPayments", "PaymentAmmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SuppliersPayments", "PaymentAmmount", c => c.DateTime(nullable: false));
            DropColumn("dbo.SuppliersPayments", "PaymentTime");
        }
    }
}
