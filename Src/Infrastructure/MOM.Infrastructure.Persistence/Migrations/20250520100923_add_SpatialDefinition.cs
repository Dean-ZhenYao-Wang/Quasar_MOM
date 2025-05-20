using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_SpatialDefinition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HierarchyScope",
                table: "Person",
                newName: "SpatialDefinition_Value");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PersonnelClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpatialDefinition_Format",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpatialDefinition_SRID",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpatialDefinition_SRIDauthority",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpatialDefinition_Format",
                table: "OperationalLocation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpatialDefinition_SRID",
                table: "OperationalLocation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpatialDefinition_SRIDauthority",
                table: "OperationalLocation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpatialDefinition_Value",
                table: "OperationalLocation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClasses_ResponsibleDtId",
                table: "PersonnelClasses",
                column: "ResponsibleDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelClasses_Person_ResponsibleDtId",
                table: "PersonnelClasses",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelClasses_Person_ResponsibleDtId",
                table: "PersonnelClasses");

            migrationBuilder.DropIndex(
                name: "IX_PersonnelClasses_ResponsibleDtId",
                table: "PersonnelClasses");

            migrationBuilder.DropColumn(
                name: "SpatialDefinition_Format",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SpatialDefinition_SRID",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SpatialDefinition_SRIDauthority",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SpatialDefinition_Format",
                table: "OperationalLocation");

            migrationBuilder.DropColumn(
                name: "SpatialDefinition_SRID",
                table: "OperationalLocation");

            migrationBuilder.DropColumn(
                name: "SpatialDefinition_SRIDauthority",
                table: "OperationalLocation");

            migrationBuilder.DropColumn(
                name: "SpatialDefinition_Value",
                table: "OperationalLocation");

            migrationBuilder.RenameColumn(
                name: "SpatialDefinition_Value",
                table: "Person",
                newName: "HierarchyScope");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "PersonnelClasses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
