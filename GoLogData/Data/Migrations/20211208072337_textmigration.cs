using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoLogData.Data.Migrations
{
    public partial class textmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Databook");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Databook",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
