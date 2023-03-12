using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieCategory",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieGenre",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Movies",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CategoryId",
                table: "Movies",
                newName: "IX_Movies_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryID",
                table: "Movies",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryID",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Movies",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_CategoryID",
                table: "Movies",
                newName: "IX_Movies_CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "MovieCategory",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieGenre",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
