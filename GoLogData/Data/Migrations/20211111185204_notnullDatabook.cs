using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoLogData.Data.Migrations
{
    public partial class notnullDatabook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentViewModels_DataModels_DataModelModelId",
                table: "ParentViewModels");

            migrationBuilder.AlterColumn<Guid>(
                name: "DataModelModelId",
                table: "ParentViewModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentViewModels_DataModels_DataModelModelId",
                table: "ParentViewModels",
                column: "DataModelModelId",
                principalTable: "DataModels",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentViewModels_DataModels_DataModelModelId",
                table: "ParentViewModels");

            migrationBuilder.AlterColumn<Guid>(
                name: "DataModelModelId",
                table: "ParentViewModels",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_ParentViewModels_DataModels_DataModelModelId",
                table: "ParentViewModels",
                column: "DataModelModelId",
                principalTable: "DataModels",
                principalColumn: "ModelId");
        }
    }
}
