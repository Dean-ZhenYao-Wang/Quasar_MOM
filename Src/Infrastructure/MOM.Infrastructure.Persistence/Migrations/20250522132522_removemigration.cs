using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class removemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonDefinedByRelationships_Person_SourceId",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonDefinedByRelationships_PersonnelClasses_TargetId",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_SourceId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_SourceId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonDefinedByRelationships",
                table: "PersonDefinedByRelationships");

            migrationBuilder.RenameTable(
                name: "PersonDefinedByRelationships",
                newName: "PersonDefinedByRelationship");

            migrationBuilder.RenameIndex(
                name: "IX_PersonDefinedByRelationships_TargetId",
                table: "PersonDefinedByRelationship",
                newName: "IX_PersonDefinedByRelationship_TargetId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonDefinedByRelationships_SourceId",
                table: "PersonDefinedByRelationship",
                newName: "IX_PersonDefinedByRelationship_SourceId");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonDtId",
                table: "PersonHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonDefinedByRelationship",
                table: "PersonDefinedByRelationship",
                column: "DtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "PersonDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonDefinedByRelationship_Person_SourceId",
                table: "PersonDefinedByRelationship",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonDefinedByRelationship_PersonnelClasses_TargetId",
                table: "PersonDefinedByRelationship",
                column: "TargetId",
                principalTable: "PersonnelClasses",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "PersonDtId",
                principalTable: "Person",
                principalColumn: "DtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonDefinedByRelationship_Person_SourceId",
                table: "PersonDefinedByRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonDefinedByRelationship_PersonnelClasses_TargetId",
                table: "PersonDefinedByRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonDefinedByRelationship",
                table: "PersonDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "PersonDtId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.RenameTable(
                name: "PersonDefinedByRelationship",
                newName: "PersonDefinedByRelationships");

            migrationBuilder.RenameIndex(
                name: "IX_PersonDefinedByRelationship_TargetId",
                table: "PersonDefinedByRelationships",
                newName: "IX_PersonDefinedByRelationships_TargetId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonDefinedByRelationship_SourceId",
                table: "PersonDefinedByRelationships",
                newName: "IX_PersonDefinedByRelationships_SourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonDefinedByRelationships",
                table: "PersonDefinedByRelationships",
                column: "DtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_SourceId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonDefinedByRelationships_Person_SourceId",
                table: "PersonDefinedByRelationships",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonDefinedByRelationships_PersonnelClasses_TargetId",
                table: "PersonDefinedByRelationships",
                column: "TargetId",
                principalTable: "PersonnelClasses",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_SourceId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId");
        }
    }
}
