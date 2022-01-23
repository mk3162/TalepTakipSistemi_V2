using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tedarikciler",
                table: "Tedarikciler");

            migrationBuilder.RenameTable(
                name: "Tedarikciler",
                newName: "Suppliers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "TedarikciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Tedarikciler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tedarikciler",
                table: "Tedarikciler",
                column: "TedarikciId");
        }
    }
}
