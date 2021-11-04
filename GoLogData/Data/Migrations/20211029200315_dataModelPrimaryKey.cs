using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoLogData.Data.Migrations
{
    public partial class dataModelPrimaryKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataModels",
                columns: table => new
                {
                    ModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DatabookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataModels", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_DataModels_Databook_DatabookId",
                        column: x => x.DatabookId,
                        principalTable: "Databook",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParentViewModels",
                columns: table => new
                {
                    ParentViewModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DatabookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataModelModelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentViewModels", x => x.ParentViewModelId);
                    table.ForeignKey(
                        name: "FK_ParentViewModels_Databook_DatabookId",
                        column: x => x.DatabookId,
                        principalTable: "Databook",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentViewModels_DataModels_DataModelModelId",
                        column: x => x.DataModelModelId,
                        principalTable: "DataModels",
                        principalColumn: "ModelId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DataModels_DatabookId",
                table: "DataModels",
                column: "DatabookId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentViewModels_DatabookId",
                table: "ParentViewModels",
                column: "DatabookId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentViewModels_DataModelModelId",
                table: "ParentViewModels",
                column: "DataModelModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParentViewModels");

            migrationBuilder.DropTable(
                name: "DataModels");
        }
    }
}
