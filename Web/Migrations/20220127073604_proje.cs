using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class proje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lokasyonlar",
                columns: table => new
                {
                    SiraNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanimi = table.Column<string>(maxLength: 48, nullable: false),
                    SirketSiraNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokasyonlar", x => x.SiraNo);
                    table.ForeignKey(
                        name: "FK_Lokasyonlar_Sirketler_SirketSiraNo",
                        column: x => x.SirketSiraNo,
                        principalTable: "Sirketler",
                        principalColumn: "SiraNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proje",
                columns: table => new
                {
                    SiraNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kodu = table.Column<string>(nullable: true),
                    Tanimi = table.Column<string>(nullable: true),
                    SirketSiraNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proje", x => x.SiraNo);
                    table.ForeignKey(
                        name: "FK_Proje_Sirketler_SirketSiraNo",
                        column: x => x.SirketSiraNo,
                        principalTable: "Sirketler",
                        principalColumn: "SiraNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servisler",
                columns: table => new
                {
                    SiraNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanimi = table.Column<string>(maxLength: 48, nullable: false),
                    DepartmanSiraNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servisler", x => x.SiraNo);
                    table.ForeignKey(
                        name: "FK_Servisler_Departmanlar_DepartmanSiraNo",
                        column: x => x.DepartmanSiraNo,
                        principalTable: "Departmanlar",
                        principalColumn: "SiraNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurecTipler",
                columns: table => new
                {
                    SiraNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanimi = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurecTipler", x => x.SiraNo);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Kodu = table.Column<string>(maxLength: 12, nullable: false),
                    AdiSoyadi = table.Column<string>(maxLength: 48, nullable: false),
                    Unvani = table.Column<string>(maxLength: 48, nullable: false),
                    ServisSiraNo = table.Column<int>(nullable: false),
                    Oncelik = table.Column<int>(nullable: false),
                    Pasif = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Kodu);
                    table.ForeignKey(
                        name: "FK_Personeller_Servisler_ServisSiraNo",
                        column: x => x.ServisSiraNo,
                        principalTable: "Servisler",
                        principalColumn: "SiraNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lokasyonlar_SirketSiraNo",
                table: "Lokasyonlar",
                column: "SirketSiraNo");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_ServisSiraNo",
                table: "Personeller",
                column: "ServisSiraNo");

            migrationBuilder.CreateIndex(
                name: "IX_Proje_SirketSiraNo",
                table: "Proje",
                column: "SirketSiraNo");

            migrationBuilder.CreateIndex(
                name: "IX_Servisler_DepartmanSiraNo",
                table: "Servisler",
                column: "DepartmanSiraNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lokasyonlar");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Proje");

            migrationBuilder.DropTable(
                name: "SurecTipler");

            migrationBuilder.DropTable(
                name: "Servisler");
        }
    }
}
