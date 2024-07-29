namespace Optical_Office_Mangment_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addglassestype : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GlassesTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManfacuturePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GlassesTypes");
        }
    }
}
