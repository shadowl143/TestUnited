using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axity.DataAccessEntity.Entities.Migrations
{
    public partial class Primermigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "act");

            migrationBuilder.CreateTable(
                name: "Actions",
                schema: "act",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Pk_Rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Pk_Rol);
                });

            migrationBuilder.CreateTable(
                name: "UserRols",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRols", x => new { x.UserId, x.RolId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                },
                comment: "Tabla usuarios")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "subMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubMenuId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_subMenus_SubMenuId",
                        column: x => x.SubMenuId,
                        principalTable: "subMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActSubPages",
                schema: "act",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionId = table.Column<int>(type: "int", nullable: false),
                    FkPage = table.Column<int>(type: "int", nullable: true),
                    SubMenuId = table.Column<int>(type: "int", nullable: true),
                    ActionsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActSubPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActSubPages_Actions_ActionsId",
                        column: x => x.ActionsId,
                        principalSchema: "act",
                        principalTable: "Actions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActSubPages_Pages_FkPage",
                        column: x => x.FkPage,
                        principalTable: "Pages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActSubPages_subMenus_SubMenuId",
                        column: x => x.SubMenuId,
                        principalTable: "subMenus",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "act",
                table: "Actions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Alta" },
                    { 2, "Baja" },
                    { 3, "Cambios" },
                    { 4, "Actualizar" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Code", "Icon", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "menu", "menu", "menu", true },
                    { 2, "menu 1", "menu 1", "menu 1", true },
                    { 3, "menu 2", "menu 2", "menu 2", true },
                    { 4, "menu 3", "menu 3", "menu 3", true },
                    { 5, "menu 4", "menu 4", "menu 4", true }
                });

            migrationBuilder.InsertData(
                table: "UserRols",
                columns: new[] { "RolId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "LastName", "Mail", "Name", "Password", "Phone", "RegisterDate", "SecondLastName", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, "Last", "Mail", "Name", "Password", "123456789", new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "SecondLastName", true, "Mail" },
                    { 2, "user1", "user1", "user1", "user1", "123456788", new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1", true, "user1" }
                });

            migrationBuilder.InsertData(
                table: "subMenus",
                columns: new[] { "Id", "Code", "Icon", "MenuId", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "submenu", "submenu", 1, "submenu", true },
                    { 2, "submenu 1", "submenu 1", 1, "submenu 1", true },
                    { 3, "submenu 4", "submenu 4", 2, "submenu 4", true },
                    { 4, "submenu 5", "submenu 5", 2, "submenu 5", true },
                    { 5, "submenu 6", "submenu 6", 3, "submenu 6", true },
                    { 6, "submenu 7", "submenu 7", 3, "submenu 7", true },
                    { 7, "submenu 8", "submenu 8", 4, "submenu 8", true },
                    { 8, "submenu 9", "submenu 9", 5, "submenu 9", true }
                });

            migrationBuilder.InsertData(
                schema: "act",
                table: "ActSubPages",
                columns: new[] { "Id", "ActionId", "ActionsId", "FkPage", "SubMenuId" },
                values: new object[,]
                {
                    { 1, 1, null, null, 1 },
                    { 2, 2, null, null, 1 },
                    { 3, 3, null, null, 1 },
                    { 4, 4, null, null, 1 },
                    { 5, 1, null, null, 2 },
                    { 6, 2, null, null, 2 },
                    { 7, 3, null, null, 2 },
                    { 8, 4, null, null, 2 },
                    { 9, 1, null, null, 3 },
                    { 10, 3, null, null, 3 },
                    { 11, 1, null, null, 4 },
                    { 12, 2, null, null, 4 },
                    { 13, 3, null, null, 4 },
                    { 14, 4, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Code", "Icon", "Name", "Status", "SubMenuId" },
                values: new object[,]
                {
                    { 1, "page", "page", "page", true, 4 },
                    { 2, "page 1", "page 1", "page 1", true, 4 },
                    { 3, "page 2", "page 2", "page 2", true, 4 },
                    { 4, "page 5", "page 5", "page 5", true, 4 },
                    { 5, "page 6", "page 6", "page 6", true, 4 },
                    { 6, "page 7", "page 7", "page 7", true, 4 }
                });

            migrationBuilder.InsertData(
                schema: "act",
                table: "ActSubPages",
                columns: new[] { "Id", "ActionId", "ActionsId", "FkPage", "SubMenuId" },
                values: new object[,]
                {
                    { 15, 1, null, 1, null },
                    { 16, 2, null, 1, null },
                    { 17, 3, null, 1, null },
                    { 18, 1, null, 2, null },
                    { 19, 2, null, 2, null },
                    { 20, 3, null, 2, null },
                    { 21, 4, null, 2, null },
                    { 22, 1, null, 3, null },
                    { 23, 2, null, 3, null },
                    { 24, 2, null, 4, null },
                    { 25, 3, null, 4, null },
                    { 26, 4, null, 4, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActSubPages_ActionsId",
                schema: "act",
                table: "ActSubPages",
                column: "ActionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActSubPages_FkPage",
                schema: "act",
                table: "ActSubPages",
                column: "FkPage");

            migrationBuilder.CreateIndex(
                name: "IX_ActSubPages_SubMenuId",
                schema: "act",
                table: "ActSubPages",
                column: "SubMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_SubMenuId",
                table: "Pages",
                column: "SubMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_subMenus_MenuId",
                table: "subMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActSubPages",
                schema: "act");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserRols");

            migrationBuilder.DropTable(
                name: "Users")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "Actions",
                schema: "act");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "subMenus");

            migrationBuilder.DropTable(
                name: "Menus");
        }
    }
}
