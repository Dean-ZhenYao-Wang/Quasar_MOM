using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Site_Enterprise_EnterpriseDtId",
                table: "Site");

            migrationBuilder.DropIndex(
                name: "IX_Site_EnterpriseDtId",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "EnterpriseDtId",
                table: "Site");

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Area_HierarchyScope_DtId",
                        column: x => x.DtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkCenter",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCenter", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkCenter_HierarchyScope_DtId",
                        column: x => x.DtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkUnit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkUnit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkUnit_HierarchyScope_DtId",
                        column: x => x.DtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessCell",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessCell", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ProcessCell_WorkCenter_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionLine",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionLine", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ProductionLine_WorkCenter_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionUnit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionUnit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ProductionUnit_WorkCenter_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorageZone",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageZone", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_StorageZone_WorkCenter_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorageUnit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageUnit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_StorageUnit_WorkUnit_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkUnit",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Unit_WorkUnit_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkUnit",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkCell",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCell", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkCell_WorkUnit_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkUnit",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "ProcessCell");

            migrationBuilder.DropTable(
                name: "ProductionLine");

            migrationBuilder.DropTable(
                name: "ProductionUnit");

            migrationBuilder.DropTable(
                name: "StorageUnit");

            migrationBuilder.DropTable(
                name: "StorageZone");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "WorkCell");

            migrationBuilder.DropTable(
                name: "WorkCenter");

            migrationBuilder.DropTable(
                name: "WorkUnit");

            migrationBuilder.AddColumn<Guid>(
                name: "EnterpriseDtId",
                table: "Site",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Site_EnterpriseDtId",
                table: "Site",
                column: "EnterpriseDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Site_Enterprise_EnterpriseDtId",
                table: "Site",
                column: "EnterpriseDtId",
                principalTable: "Enterprise",
                principalColumn: "DtId");
        }
    }
}
