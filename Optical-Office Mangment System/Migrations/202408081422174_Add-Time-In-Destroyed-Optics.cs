namespace Optical_Office_Mangment_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTimeInDestroyedOptics : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DestroyedOptics", "PaymentDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DestroyedOptics", "PaymentDate");
        }
    }
}
