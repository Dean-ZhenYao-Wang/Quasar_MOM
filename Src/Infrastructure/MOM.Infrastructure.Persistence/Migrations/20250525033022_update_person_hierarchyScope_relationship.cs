using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_person_hierarchyScope_relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "HierarchyScope",
                table: "PersonnelClasses");

            migrationBuilder.AddColumn<Guid>(
                name: "HierarchyScopeRelDtId",
                table: "PersonnelClasses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HierarchyScopeRelDtId",
                table: "Person",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClasses_HierarchyScopeRelDtId",
                table: "PersonnelClasses",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_HierarchyScopeRelDtId",
                table: "Person",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_HierarchyScope_HierarchyScopeRelDtId",
                table: "Person",
                column: "HierarchyScopeRelDtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelClasses_HierarchyScope_HierarchyScopeRelDtId",
                table: "PersonnelClasses",
                column: "HierarchyScopeRelDtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_HierarchyScope_HierarchyScopeRelDtId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelClasses_HierarchyScope_HierarchyScopeRelDtId",
                table: "PersonnelClasses");

            migrationBuilder.DropIndex(
                name: "IX_PersonnelClasses_HierarchyScopeRelDtId",
                table: "PersonnelClasses");

            migrationBuilder.DropIndex(
                name: "IX_Person_HierarchyScopeRelDtId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "HierarchyScopeRelDtId",
                table: "PersonnelClasses");

            migrationBuilder.DropColumn(
                name: "HierarchyScopeRelDtId",
                table: "Person");

            migrationBuilder.AddColumn<string>(
                name: "HierarchyScope",
                table: "PersonnelClasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonnelClassHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
    }
}
