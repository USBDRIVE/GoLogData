using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoLogData.Data.Migrations
{
    public partial class booleandatamodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentViewModels_Databook_DatabookId",
                table: "ParentViewModels");

            migrationBuilder.AlterColumn<Guid>(
                name: "DatabookId",
                table: "ParentViewModels",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<bool>(
                name: "MultipleModels",
                table: "Databook",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentViewModels_Databook_DatabookId",
                table: "ParentViewModels",
                column: "DatabookId",
                principalTable: "Databook",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParentViewModels_Databook_DatabookId",
                table: "ParentViewModels");

            migrationBuilder.DropColumn(
                name: "MultipleModels",
                table: "Databook");

            migrationBuilder.AlterColumn<Guid>(
                name: "DatabookId",
                table: "ParentViewModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ParentViewModels_Databook_DatabookId",
                table: "ParentViewModels",
                column: "DatabookId",
                principalTable: "Databook",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
