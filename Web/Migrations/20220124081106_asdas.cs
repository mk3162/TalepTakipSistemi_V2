using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class asdas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sirket",
                table: "Sirket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IslemTipleri",
                table: "IslemTipleri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Birimler",
                table: "Birimler");

            migrationBuilder.RenameTable(
                name: "Sirket",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "IslemTipleri",
                newName: "IslemTips");

            migrationBuilder.RenameTable(
                name: "Birimler",
                newName: "Units");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IslemTips",
                table: "IslemTips",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "SiraNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IslemTips",
                table: "IslemTips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Birimler");

            migrationBuilder.RenameTable(
                name: "IslemTips",
                newName: "IslemTipleri");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Sirket");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Birimler",
                table: "Birimler",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IslemTipleri",
                table: "IslemTipleri",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sirket",
                table: "Sirket",
                column: "SiraNo");
        }
    }
}
