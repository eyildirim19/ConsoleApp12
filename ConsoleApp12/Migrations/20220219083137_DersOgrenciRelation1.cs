using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp12.Migrations
{
    public partial class DersOgrenciRelation1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Donem",
                table: "Ders");

            migrationBuilder.AddColumn<int>(
                name: "DonemID",
                table: "Ders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OgrenciNo",
                table: "Ders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ders_DonemID",
                table: "Ders",
                column: "DonemID");

            migrationBuilder.CreateIndex(
                name: "IX_Ders_OgrenciNo",
                table: "Ders",
                column: "OgrenciNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Ders_Donem_DonemID",
                table: "Ders",
                column: "DonemID",
                principalTable: "Donem",
                principalColumn: "DonemID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ders_Ogrencis_OgrenciNo",
                table: "Ders",
                column: "OgrenciNo",
                principalTable: "Ogrencis",
                principalColumn: "No",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ders_Donem_DonemID",
                table: "Ders");

            migrationBuilder.DropForeignKey(
                name: "FK_Ders_Ogrencis_OgrenciNo",
                table: "Ders");

            migrationBuilder.DropIndex(
                name: "IX_Ders_DonemID",
                table: "Ders");

            migrationBuilder.DropIndex(
                name: "IX_Ders_OgrenciNo",
                table: "Ders");

            migrationBuilder.DropColumn(
                name: "DonemID",
                table: "Ders");

            migrationBuilder.DropColumn(
                name: "OgrenciNo",
                table: "Ders");

            migrationBuilder.AddColumn<string>(
                name: "Donem",
                table: "Ders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
