using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp12.Migrations
{
    public partial class OgrenciDersNots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgrenciDersId",
                table: "Not",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OgrenciDersId",
                table: "Not");
        }
    }
}
