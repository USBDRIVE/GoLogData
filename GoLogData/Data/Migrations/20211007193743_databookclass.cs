using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoLogData.Data.Migrations
{
    public partial class databookclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Databook",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Databook",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Databook",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Databook");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Databook");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Databook");
        }
    }
}
