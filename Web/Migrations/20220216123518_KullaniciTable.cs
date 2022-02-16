using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class KullaniciTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YeniSifre",
                table: "Kullanicilar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YeniSifreTekrar",
                table: "Kullanicilar",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YeniSifre",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "YeniSifreTekrar",
                table: "Kullanicilar");
        }
    }
}
