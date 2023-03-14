using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "History",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "SerieCategory",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "SerieGenre",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "SerieTime",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieTime",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "TvSeries",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "SerieYear",
                table: "TvSeries",
                type: "int",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "SerieScore",
                table: "TvSeries",
                type: "float",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "TvSeries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieYear",
                table: "Movies",
                type: "int",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(600)",
                oldMaxLength: 600,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Top10MovieLists",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Top10MovieLists", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "Top10TvSerieLists",
                columns: table => new
                {
                    TvSerieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Top10TvSerieLists", x => x.TvSerieID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Top10MovieLists");

            migrationBuilder.DropTable(
                name: "Top10TvSerieLists");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "TvSeries");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "TvSeries");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TvSeries",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "SerieYear",
                table: "TvSeries",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SerieScore",
                table: "TvSeries",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "TvSeries",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "History",
                table: "TvSeries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SerieCategory",
                table: "TvSeries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SerieGenre",
                table: "TvSeries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SerieTime",
                table: "TvSeries",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MovieYear",
                table: "Movies",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Movies",
                type: "nvarchar(600)",
                maxLength: 600,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "History",
                table: "Movies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieTime",
                table: "Movies",
                type: "int",
                nullable: true);
        }
    }
}
