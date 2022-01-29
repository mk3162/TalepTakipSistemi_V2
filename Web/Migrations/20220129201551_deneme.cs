using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrunTanimi",
                table: "Urunler",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(127)",
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Tipler",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TedarikciUnvani",
                table: "Tedarikciler",
                maxLength: 127,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(127)",
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Sirketler",
                maxLength: 48,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(48)",
                oldMaxLength: 48,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Proje",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Kodu",
                table: "Proje",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "IslemTipleri",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Birimler",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrunTanimi",
                table: "Urunler",
                type: "nvarchar(127)",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Tipler",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "TedarikciUnvani",
                table: "Tedarikciler",
                type: "nvarchar(127)",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Sirketler",
                type: "nvarchar(48)",
                maxLength: 48,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 48);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Proje",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Kodu",
                table: "Proje",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "IslemTipleri",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Birimler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32);
        }
    }
}
