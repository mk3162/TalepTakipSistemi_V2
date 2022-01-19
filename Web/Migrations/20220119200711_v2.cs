using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Kullanicilar");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Kullanicilar",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Kullanicilar");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar",
                column: "KullaniciId");
        }
    }
}
