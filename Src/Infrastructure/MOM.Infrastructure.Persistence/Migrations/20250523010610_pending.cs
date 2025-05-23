using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class pending : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "PersonDtId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_SourceId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_SourceId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_SourceId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_SourceId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.AddColumn<Guid>(
                name: "PersonDtId",
                table: "PersonHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "PersonDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "PersonDtId",
                principalTable: "Person",
                principalColumn: "DtId");
        }
    }
}
