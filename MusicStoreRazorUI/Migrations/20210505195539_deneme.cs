using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStoreRazorUI.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BarcodeNumber",
                table: "Musics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarcodeNumber",
                table: "Musics");
        }
    }
}
