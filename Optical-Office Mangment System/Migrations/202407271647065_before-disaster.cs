﻿namespace Optical_Office_Mangment_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class beforedisaster : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Borrowers", "remain", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Borrowers", "remain");
        }
    }
}
