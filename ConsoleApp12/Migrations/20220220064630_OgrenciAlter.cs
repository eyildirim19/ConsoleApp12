using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp12.Migrations
{
    public partial class OgrenciAlter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdiSoyAdi",
                table: "Ogrencis",
                newName: "SoyAdi");

            migrationBuilder.AddColumn<string>(
                name: "Adi",
                table: "Ogrencis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullAd",
                table: "Ogrencis",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "(Adi + SoyAdi)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adi",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "FullAd",
                table: "Ogrencis");

            migrationBuilder.RenameColumn(
                name: "SoyAdi",
                table: "Ogrencis",
                newName: "AdiSoyAdi");
        }
    }
}
