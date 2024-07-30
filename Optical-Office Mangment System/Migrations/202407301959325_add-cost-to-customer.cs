namespace Optical_Office_Mangment_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcosttocustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "TotalCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "TotalCost");
        }
    }
}
