using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class tsts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipler",
                table: "Tipler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sirketler",
                table: "Sirketler");

            migrationBuilder.RenameTable(
                name: "Tipler",
                newName: "Tip");

            migrationBuilder.RenameTable(
                name: "Sirketler",
                newName: "Sirket");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tip",
                table: "Tip",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sirket",
                table: "Sirket",
                column: "SiraNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tip",
                table: "Tip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sirket",
                table: "Sirket");

            migrationBuilder.RenameTable(
                name: "Tip",
                newName: "Tipler");

            migrationBuilder.RenameTable(
                name: "Sirket",
                newName: "Sirketler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipler",
                table: "Tipler",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sirketler",
                table: "Sirketler",
                column: "SiraNo");
        }
    }
}
