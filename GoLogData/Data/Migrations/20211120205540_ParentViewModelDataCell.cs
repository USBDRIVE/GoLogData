using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoLogData.Data.Migrations
{
    public partial class ParentViewModelDataCell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CellDataCellId",
                table: "ParentViewModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DataCell",
                columns: table => new
                {
                    DataCellId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataInput = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataCell", x => x.DataCellId);
                    table.ForeignKey(
                        name: "FK_DataCell_DataModels_ModelId",
                        column: x => x.ModelId,
                        principalTable: "DataModels",
                        principalColumn: "ModelId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParentViewModels_CellDataCellId",
                table: "ParentViewModels",
                column: "CellDataCellId");

            migrationBuilder.CreateIndex(
                name: "IX_DataCell_ModelId",
                table: "DataCell",
                column: "ModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentViewModels_DataCell_CellDataCellId",
                table: "ParentViewModels",
                column: "CellDataCellId",
                principalTable: "DataCell",
                principalColumn: "DataCellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentViewModels_DataCell_CellDataCellId",
                table: "ParentViewModels");

            migrationBuilder.DropTable(
                name: "DataCell");

            migrationBuilder.DropIndex(
                name: "IX_ParentViewModels_CellDataCellId",
                table: "ParentViewModels");

            migrationBuilder.DropColumn(
                name: "CellDataCellId",
                table: "ParentViewModels");
        }
    }
}
