using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_hieraychyScope_column_Source : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScope_SourceDtId",
                table: "HierarchyScope",
                column: "SourceDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_HierarchyScope_HierarchyScope_SourceDtId",
                table: "HierarchyScope",
                column: "SourceDtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HierarchyScope_HierarchyScope_SourceDtId",
                table: "HierarchyScope");

            migrationBuilder.DropIndex(
                name: "IX_HierarchyScope_SourceDtId",
                table: "HierarchyScope");
        }
    }
}
