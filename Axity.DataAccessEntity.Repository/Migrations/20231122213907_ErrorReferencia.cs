using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axity.DataAccessEntity.Entities.Migrations
{
    public partial class ErrorReferencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActSubPages_Actions_ActionsId",
                schema: "act",
                table: "ActSubPages");

            migrationBuilder.DropIndex(
                name: "IX_ActSubPages_ActionsId",
                schema: "act",
                table: "ActSubPages");

            migrationBuilder.DropColumn(
                name: "ActionsId",
                schema: "act",
                table: "ActSubPages");

            migrationBuilder.CreateIndex(
                name: "IX_ActSubPages_ActionId",
                schema: "act",
                table: "ActSubPages",
                column: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActSubPages_Actions_ActionId",
                schema: "act",
                table: "ActSubPages",
                column: "ActionId",
                principalSchema: "act",
                principalTable: "Actions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActSubPages_Actions_ActionId",
                schema: "act",
                table: "ActSubPages");

            migrationBuilder.DropIndex(
                name: "IX_ActSubPages_ActionId",
                schema: "act",
                table: "ActSubPages");

            migrationBuilder.AddColumn<int>(
                name: "ActionsId",
                schema: "act",
                table: "ActSubPages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActSubPages_ActionsId",
                schema: "act",
                table: "ActSubPages",
                column: "ActionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActSubPages_Actions_ActionsId",
                schema: "act",
                table: "ActSubPages",
                column: "ActionsId",
                principalSchema: "act",
                principalTable: "Actions",
                principalColumn: "Id");
        }
    }
}
