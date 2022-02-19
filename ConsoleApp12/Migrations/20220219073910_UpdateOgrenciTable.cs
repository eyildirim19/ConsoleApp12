using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp12.Migrations
{
    public partial class UpdateOgrenciTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DersAdi",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "DersAdi2",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "DersAdi3",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "Donem",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "Final",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "Ortalama",
                table: "Ogrencis");

            migrationBuilder.DropColumn(
                name: "Vize",
                table: "Ogrencis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DersAdi",
                table: "Ogrencis",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "Donem",
                table: "Ogrencis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Final",
                table: "Ogrencis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ortalama",
                table: "Ogrencis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vize",
                table: "Ogrencis",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
