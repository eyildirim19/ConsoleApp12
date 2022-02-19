using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp12.Migrations
{
    public partial class CreateColumnOgrenciTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DersAdi2",
                table: "Ogrencis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DersAdi3",
                table: "Ogrencis",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DersAdi2",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "DersAdi3",
                table: "Ogrencis");
        }
    }
}
