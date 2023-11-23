using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axity.DataAccessEntity.Entities.Migrations
{
    public partial class Referenciatablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserRols_RolId",
                table: "UserRols",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRols_Roles_RolId",
                table: "UserRols",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "Pk_Rol",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRols_Users_UserId",
                table: "UserRols",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRols_Roles_RolId",
                table: "UserRols");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRols_Users_UserId",
                table: "UserRols");

            migrationBuilder.DropIndex(
                name: "IX_UserRols_RolId",
                table: "UserRols");
        }
    }
}
