using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_table_PersonnelClassHierarchyScopeRelRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonnelClassHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelClassHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnelClassHierarchyScopeRelRelationship_PersonnelClasses_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassHierarchyScopeRelRelationship_SourceId",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassHierarchyScopeRelRelationship_TargetId",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                column: "TargetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonnelClassHierarchyScopeRelRelationship");
        }
    }
}
