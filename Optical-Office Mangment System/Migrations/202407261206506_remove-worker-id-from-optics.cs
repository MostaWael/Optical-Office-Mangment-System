namespace Optical_Office_Mangment_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeworkeridfromoptics : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Optics", name: "Worker_Id", newName: "Workers_Id");
            RenameIndex(table: "dbo.Optics", name: "IX_Worker_Id", newName: "IX_Workers_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Optics", name: "IX_Workers_Id", newName: "IX_Worker_Id");
            RenameColumn(table: "dbo.Optics", name: "Workers_Id", newName: "Worker_Id");
        }
    }
}
