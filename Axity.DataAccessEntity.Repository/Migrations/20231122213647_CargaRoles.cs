using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axity.DataAccessEntity.Entities.Migrations
{
    public partial class CargaRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Pk_Rol", "Codigo", "Descripcion", "Nombre", "Estado" },
                values: new object[] { 1, "rol", "rol", "rol", true });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Pk_Rol", "Codigo", "Descripcion", "Nombre", "Estado" },
                values: new object[] { 2, "rol1", "rol1", "rol1", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Pk_Rol",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Pk_Rol",
                keyValue: 2);
        }
    }
}
