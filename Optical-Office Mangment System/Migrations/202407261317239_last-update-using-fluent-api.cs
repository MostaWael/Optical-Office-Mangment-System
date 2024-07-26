namespace Optical_Office_Mangment_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastupdateusingfluentapi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Optics", "Workers_Id", "dbo.Workers");
            DropIndex("dbo.Optics", new[] { "Workers_Id" });
            CreateTable(
                "dbo.DestroyedOptics",
                c => new
                    {
                        Optics_Code = c.String(nullable: false, maxLength: 128),
                        Workers_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Optics_Code, t.Workers_Id })
                .ForeignKey("dbo.Optics", t => t.Optics_Code, cascadeDelete: true)
                .ForeignKey("dbo.Workers", t => t.Workers_Id, cascadeDelete: true)
                .Index(t => t.Optics_Code)
                .Index(t => t.Workers_Id);
            
            DropColumn("dbo.Optics", "Workers_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Optics", "Workers_Id", c => c.Int());
            DropForeignKey("dbo.DestroyedOptics", "Workers_Id", "dbo.Workers");
            DropForeignKey("dbo.DestroyedOptics", "Optics_Code", "dbo.Optics");
            DropIndex("dbo.DestroyedOptics", new[] { "Workers_Id" });
            DropIndex("dbo.DestroyedOptics", new[] { "Optics_Code" });
            DropTable("dbo.DestroyedOptics");
            CreateIndex("dbo.Optics", "Workers_Id");
            AddForeignKey("dbo.Optics", "Workers_Id", "dbo.Workers", "Id");
        }
    }
}
