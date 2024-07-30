namespace Optical_Office_Mangment_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixbillnumbertoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerPayments", "BillNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerPayments", "BillNumber", c => c.String());
        }
    }
}
