using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp12.Migrations
{
    public partial class ogrenciCreDatealter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreDate",
                table: "Ogrencis",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 2, 20, 10, 7, 6, 399, DateTimeKind.Local).AddTicks(9942));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreDate",
                table: "Ogrencis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 2, 20, 10, 7, 6, 399, DateTimeKind.Local).AddTicks(9942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");
        }
    }
}
