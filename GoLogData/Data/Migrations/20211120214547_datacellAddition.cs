using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoLogData.Data.Migrations
{
    public partial class datacellAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DatacellId",
                table: "ParentViewModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Datacell",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    input = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datacell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datacell_DataModels_DataModelId",
                        column: x => x.DataModelId,
                        principalTable: "DataModels",
                        principalColumn: "ModelId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParentViewModels_DatacellId",
                table: "ParentViewModels",
                column: "DatacellId");

            migrationBuilder.CreateIndex(
                name: "IX_Datacell_DataModelId",
                table: "Datacell",
                column: "DataModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentViewModels_Datacell_DatacellId",
                table: "ParentViewModels",
                column: "DatacellId",
                principalTable: "Datacell",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentViewModels_Datacell_DatacellId",
                table: "ParentViewModels");

            migrationBuilder.DropTable(
                name: "Datacell");

            migrationBuilder.DropIndex(
                name: "IX_ParentViewModels_DatacellId",
                table: "ParentViewModels");

            migrationBuilder.DropColumn(
                name: "DatacellId",
                table: "ParentViewModels");
        }
    }
}
