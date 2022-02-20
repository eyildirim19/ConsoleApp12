using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp12.Migrations
{
    public partial class OgrenciAlter2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreDate",
                table: "Ogrencis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 20, 10, 7, 6, 399, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.AlterColumn<string>(
                name: "FullAd",
                table: "Ogrencis",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "(Concat(Adi,' ',SoyAdi))",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComputedColumnSql: "(Adi + SoyAdi)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreDate",
                table: "Ogrencis");

            migrationBuilder.AlterColumn<string>(
                name: "FullAd",
                table: "Ogrencis",
                type: "nvarchar(max)",
                nullable: true,
                computedColumnSql: "(Adi + SoyAdi)",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComputedColumnSql: "(Concat(Adi,' ',SoyAdi))");
        }
    }
}
