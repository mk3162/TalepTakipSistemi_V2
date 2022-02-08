using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proje_Sirketler_SirketSiraNo",
                table: "Proje");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Proje",
                table: "Proje");

            migrationBuilder.RenameTable(
                name: "Proje",
                newName: "Projeler");

            migrationBuilder.RenameIndex(
                name: "IX_Proje_SirketSiraNo",
                table: "Projeler",
                newName: "IX_Projeler_SirketSiraNo");

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Projeler",
                maxLength: 48,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Kodu",
                table: "Projeler",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projeler",
                table: "Projeler",
                column: "SiraNo");

            migrationBuilder.CreateTable(
                name: "MasrafMerkezleri",
                columns: table => new
                {
                    SiraNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanimi = table.Column<string>(maxLength: 48, nullable: false),
                    MuhasebeKodu1 = table.Column<string>(maxLength: 16, nullable: false),
                    MuhasebeKodu2 = table.Column<string>(maxLength: 16, nullable: false),
                    MuhasebeKodu3 = table.Column<string>(maxLength: 16, nullable: false),
                    SirketSiraNo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasrafMerkezleri", x => x.SiraNo);
                    table.ForeignKey(
                        name: "FK_MasrafMerkezleri_Sirketler_SirketSiraNo",
                        column: x => x.SirketSiraNo,
                        principalTable: "Sirketler",
                        principalColumn: "SiraNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParaBirimleri",
                columns: table => new
                {
                    SiraNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanimi = table.Column<string>(maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParaBirimleri", x => x.SiraNo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MasrafMerkezleri_SirketSiraNo",
                table: "MasrafMerkezleri",
                column: "SirketSiraNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Projeler_Sirketler_SirketSiraNo",
                table: "Projeler",
                column: "SirketSiraNo",
                principalTable: "Sirketler",
                principalColumn: "SiraNo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projeler_Sirketler_SirketSiraNo",
                table: "Projeler");

            migrationBuilder.DropTable(
                name: "MasrafMerkezleri");

            migrationBuilder.DropTable(
                name: "ParaBirimleri");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projeler",
                table: "Projeler");

            migrationBuilder.RenameTable(
                name: "Projeler",
                newName: "Proje");

            migrationBuilder.RenameIndex(
                name: "IX_Projeler_SirketSiraNo",
                table: "Proje",
                newName: "IX_Proje_SirketSiraNo");

            migrationBuilder.AlterColumn<string>(
                name: "Tanimi",
                table: "Proje",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 48);

            migrationBuilder.AlterColumn<string>(
                name: "Kodu",
                table: "Proje",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Proje",
                table: "Proje",
                column: "SiraNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Proje_Sirketler_SirketSiraNo",
                table: "Proje",
                column: "SirketSiraNo",
                principalTable: "Sirketler",
                principalColumn: "SiraNo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
