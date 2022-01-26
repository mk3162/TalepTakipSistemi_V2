using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tip",
                table: "Tip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IslemTips",
                table: "IslemTips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "TedarikciId",
                table: "Suppliers");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Birimler");

            migrationBuilder.RenameTable(
                name: "Tip",
                newName: "Tipler");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Tedarikciler");

            migrationBuilder.RenameTable(
                name: "IslemTips",
                newName: "IslemTipleri");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Sirketler");

            migrationBuilder.AlterColumn<string>(
                name: "UrunTanimi",
                table: "Urunler",
                maxLength: 127,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "Urunler",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Tipler",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(48)",
                oldMaxLength: 48,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TedarikciKodu",
                table: "Tedarikciler",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler",
                column: "UrunKodu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Birimler",
                table: "Birimler",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipler",
                table: "Tipler",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tedarikciler",
                table: "Tedarikciler",
                column: "TedarikciKodu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IslemTipleri",
                table: "IslemTipleri",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sirketler",
                table: "Sirketler",
                column: "SiraNo");

            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    SiraNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanimi = table.Column<string>(maxLength: 48, nullable: false),
                    SirketSiraNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.SiraNo);
                    table.ForeignKey(
                        name: "FK_Departmanlar_Sirketler_SirketSiraNo",
                        column: x => x.SirketSiraNo,
                        principalTable: "Sirketler",
                        principalColumn: "SiraNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Kodu = table.Column<string>(maxLength: 12, nullable: false),
                    Sifre = table.Column<string>(maxLength: 12, nullable: false),
                    AdiSoyadi = table.Column<string>(maxLength: 48, nullable: false),
                    Yetki = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Kodu);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlar_SirketSiraNo",
                table: "Departmanlar",
                column: "SirketSiraNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departmanlar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipler",
                table: "Tipler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tedarikciler",
                table: "Tedarikciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sirketler",
                table: "Sirketler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IslemTipleri",
                table: "IslemTipleri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Birimler",
                table: "Birimler");

            migrationBuilder.RenameTable(
                name: "Tipler",
                newName: "Tip");

            migrationBuilder.RenameTable(
                name: "Tedarikciler",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "Sirketler",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "IslemTipleri",
                newName: "IslemTips");

            migrationBuilder.RenameTable(
                name: "Birimler",
                newName: "Units");

            migrationBuilder.AlterColumn<string>(
                name: "UrunTanimi",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 127,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrunKodu",
                table: "Urunler",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Tip",
                type: "nvarchar(48)",
                maxLength: 48,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TedarikciKodu",
                table: "Suppliers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "TedarikciId",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Urunler",
                table: "Urunler",
                column: "UrunId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tip",
                table: "Tip",
                column: "SiraNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "TedarikciId");

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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdiSoyadi = table.Column<string>(type: "nvarchar(48)", maxLength: 48, nullable: false),
                    Kodu = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Yetki = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }
    }
}
