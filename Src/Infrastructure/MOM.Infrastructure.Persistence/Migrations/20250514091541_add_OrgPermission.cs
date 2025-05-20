using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_OrgPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.CreateTable(
                name: "OrgPermission",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuButtonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgPermission", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OrgPermission_HierarchyScope_OrgDtId",
                        column: x => x.OrgDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClassPermission",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuButtonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelClassPermission", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelClassPermission_PersonnelClasses_PersonnelClassDtId",
                        column: x => x.PersonnelClassDtId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrgPermission_OrgDtId",
                table: "OrgPermission",
                column: "OrgDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassPermission_PersonnelClassDtId",
                table: "PersonnelClassPermission",
                column: "PersonnelClassDtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrgPermission");

            migrationBuilder.DropTable(
                name: "PersonnelClassPermission");

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonnelClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuButtonId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Permissions_PersonnelClasses_PersonnelClassDtId",
                        column: x => x.PersonnelClassDtId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PersonnelClassDtId",
                table: "Permissions",
                column: "PersonnelClassDtId");
        }
    }
}