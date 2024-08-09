using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Part_In_Office_Managment_System.Migrations
{
    /// <inheritdoc />
    public partial class addbillstodatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Reports_Report_id",
                table: "Bill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.RenameTable(
                name: "Bill",
                newName: "Bills");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_Report_id",
                table: "Bills",
                newName: "IX_Bills_Report_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bills",
                table: "Bills",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Reports_Report_id",
                table: "Bills",
                column: "Report_id",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Reports_Report_id",
                table: "Bills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bills",
                table: "Bills");

            migrationBuilder.RenameTable(
                name: "Bills",
                newName: "Bill");

            migrationBuilder.RenameIndex(
                name: "IX_Bills_Report_id",
                table: "Bill",
                newName: "IX_Bill_Report_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Reports_Report_id",
                table: "Bill",
                column: "Report_id",
                principalTable: "Reports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
