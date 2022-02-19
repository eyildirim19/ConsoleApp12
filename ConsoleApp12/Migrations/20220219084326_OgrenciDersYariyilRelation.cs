using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp12.Migrations
{
    public partial class OgrenciDersYariyilRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YariYil",
                columns: table => new
                {
                    YariYilID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YariYil", x => x.YariYilID);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDers",
                columns: table => new
                {
                    OgrenciDersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersID = table.Column<string>(type: "nvarchar(4)", nullable: true),
                    OgrenciID = table.Column<int>(type: "int", nullable: false),
                    YariYilID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDers", x => x.OgrenciDersID);
                    table.ForeignKey(
                        name: "FK_OgrenciDers_Ders_DersID",
                        column: x => x.DersID,
                        principalTable: "Ders",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OgrenciDers_Ogrencis_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrencis",
                        principalColumn: "No",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDers_YariYil_YariYilID",
                        column: x => x.YariYilID,
                        principalTable: "YariYil",
                        principalColumn: "YariYilID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_DersID",
                table: "OgrenciDers",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_OgrenciID",
                table: "OgrenciDers",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_YariYilID",
                table: "OgrenciDers",
                column: "YariYilID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgrenciDers");

            migrationBuilder.DropTable(
                name: "YariYil");
        }
    }
}
