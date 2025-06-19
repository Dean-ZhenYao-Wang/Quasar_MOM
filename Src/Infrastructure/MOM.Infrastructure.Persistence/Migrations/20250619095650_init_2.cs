using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationalLocationDefinedByRelationship_OperationalLocation_SourceId",
                table: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_SourceId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonOperationalLocationRelRelationship_Person_SourceId",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationPropertyMapsToRelationship");

            migrationBuilder.DropTable(
                name: "PersonHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelClassHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelClassPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PersonPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PersonPropertyMapsToRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassProperty");

            migrationBuilder.DropTable(
                name: "OperationalLocationProperty");

            migrationBuilder.DropTable(
                name: "PersonProperty");

            migrationBuilder.DropTable(
                name: "PersonnelClassProperty");

            migrationBuilder.DropIndex(
                name: "IX_PersonOperationalLocationRelRelationship_SourceId",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.RenameColumn(
                name: "SpatialDefinition_SRIDauthority",
                table: "Person",
                newName: "SpatialDefinition_SRIAuthority");

            migrationBuilder.RenameColumn(
                name: "HierarchyScope",
                table: "OperationalLocationClass",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "SpatialDefinition_SRIDauthority",
                table: "OperationalLocation",
                newName: "SpatialDefinition_SRIAuthority");

            migrationBuilder.RenameColumn(
                name: "HierarchyScope",
                table: "OperationalLocation",
                newName: "Description");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "PersonOperationalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "PersonHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "PersonDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "OperationalLocationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "OperationalLocationDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HierarchyScopeRelDtId",
                table: "OperationalLocationClass",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HierarchyScopeRelDtId",
                table: "OperationalLocation",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "HierarchyScopeContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CodingRules",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Separator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodingRules", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "SequenceStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SequenceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CurrentValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SequenceStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodingSegments",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    PaddingChar = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    PadLeft = table.Column<bool>(type: "bit", nullable: false),
                    RuleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodingSegments", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_CodingSegments_CodingRules_RuleDtId",
                        column: x => x.RuleDtId,
                        principalTable: "CodingRules",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonOperationalLocationRelRelationship_SourceId",
                table: "PersonOperationalLocationRelRelationship",
                column: "SourceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClass_HierarchyScopeRelDtId",
                table: "OperationalLocationClass",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocation_HierarchyScopeRelDtId",
                table: "OperationalLocation",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_CodingSegments_RuleDtId",
                table: "CodingSegments",
                column: "RuleDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationalLocation_HierarchyScope_HierarchyScopeRelDtId",
                table: "OperationalLocation",
                column: "HierarchyScopeRelDtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationalLocationClass_HierarchyScope_HierarchyScopeRelDtId",
                table: "OperationalLocationClass",
                column: "HierarchyScopeRelDtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationalLocationDefinedByRelationship_OperationalLocation_SourceId",
                table: "OperationalLocationDefinedByRelationship",
                column: "SourceId",
                principalTable: "OperationalLocation",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_SourceId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonOperationalLocationRelRelationship_Person_SourceId",
                table: "PersonOperationalLocationRelRelationship",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationalLocation_HierarchyScope_HierarchyScopeRelDtId",
                table: "OperationalLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationalLocationClass_HierarchyScope_HierarchyScopeRelDtId",
                table: "OperationalLocationClass");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationalLocationDefinedByRelationship_OperationalLocation_SourceId",
                table: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_SourceId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonOperationalLocationRelRelationship_Person_SourceId",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "CodingSegments");

            migrationBuilder.DropTable(
                name: "SequenceStates");

            migrationBuilder.DropTable(
                name: "CodingRules");

            migrationBuilder.DropIndex(
                name: "IX_PersonOperationalLocationRelRelationship_SourceId",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropIndex(
                name: "IX_OperationalLocationClass_HierarchyScopeRelDtId",
                table: "OperationalLocationClass");

            migrationBuilder.DropIndex(
                name: "IX_OperationalLocation_HierarchyScopeRelDtId",
                table: "OperationalLocation");

            migrationBuilder.DropColumn(
                name: "HierarchyScopeRelDtId",
                table: "OperationalLocationClass");

            migrationBuilder.DropColumn(
                name: "HierarchyScopeRelDtId",
                table: "OperationalLocation");

            migrationBuilder.RenameColumn(
                name: "SpatialDefinition_SRIAuthority",
                table: "Person",
                newName: "SpatialDefinition_SRIDauthority");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "OperationalLocationClass",
                newName: "HierarchyScope");

            migrationBuilder.RenameColumn(
                name: "SpatialDefinition_SRIAuthority",
                table: "OperationalLocation",
                newName: "SpatialDefinition_SRIDauthority");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "OperationalLocation",
                newName: "HierarchyScope");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "PersonOperationalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "PersonHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "PersonDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "OperationalLocationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "OperationalLocationDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "SourceId",
                table: "HierarchyScopeContainsRelationship",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClassHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassHierarchyScopeRelRelationship_OperationalLocationClass_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocationClass",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClassProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationalLocationHierarchyScopeRelRelationship_OperationalLocation_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClassProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelClassProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "PersonProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClassHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassHasPropertiesOfRelationship_OperationalLocationClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocationClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassHasPropertiesOfRelationship_OperationalLocationClass_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocationClass",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClassPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassPropertyContainsRelationship_OperationalLocationClassProperty_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocationClassProperty",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassPropertyContainsRelationship_OperationalLocationClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocationClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationHasValuesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationHasValuesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationHasValuesOfRelationship_OperationalLocationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationalLocationHasValuesOfRelationship_OperationalLocation_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationPropertyContainsRelationship_OperationalLocationProperty_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocationProperty",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_OperationalLocationPropertyContainsRelationship_OperationalLocationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationPropertyMapsToRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationPropertyMapsToRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationPropertyMapsToRelationship_OperationalLocationClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocationClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationalLocationPropertyMapsToRelationship_OperationalLocationProperty_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClassHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelClassHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelClassHasPropertiesOfRelationship_PersonnelClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnelClassHasPropertiesOfRelationship_PersonnelClasses_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClassPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelClassPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelClassPropertyContainsRelationship_PersonnelClassProperty_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PersonnelClassProperty",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonnelClassPropertyContainsRelationship_PersonnelClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonHasValuesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonHasValuesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonHasValuesOfRelationship_PersonProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonHasValuesOfRelationship_Person_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonPropertyContainsRelationship_PersonProperty_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PersonProperty",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonPropertyContainsRelationship_PersonProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonPropertyMapsToRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPropertyMapsToRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonPropertyMapsToRelationship_PersonProperty_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PersonProperty",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonPropertyMapsToRelationship_PersonnelClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonOperationalLocationRelRelationship_SourceId",
                table: "PersonOperationalLocationRelRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassHasPropertiesOfRelationship_SourceId",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassHasPropertiesOfRelationship_TargetId",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassHierarchyScopeRelRelationship_SourceId",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassHierarchyScopeRelRelationship_TargetId",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassPropertyContainsRelationship_SourceId",
                table: "OperationalLocationClassPropertyContainsRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassPropertyContainsRelationship_TargetId",
                table: "OperationalLocationClassPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationHasValuesOfRelationship_SourceId",
                table: "OperationalLocationHasValuesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationHasValuesOfRelationship_TargetId",
                table: "OperationalLocationHasValuesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationHierarchyScopeRelRelationship_SourceId",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationHierarchyScopeRelRelationship_TargetId",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationPropertyContainsRelationship_SourceId",
                table: "OperationalLocationPropertyContainsRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationPropertyContainsRelationship_TargetId",
                table: "OperationalLocationPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationPropertyMapsToRelationship_SourceId",
                table: "OperationalLocationPropertyMapsToRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationPropertyMapsToRelationship_TargetId",
                table: "OperationalLocationPropertyMapsToRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHasValuesOfRelationship_SourceId",
                table: "PersonHasValuesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHasValuesOfRelationship_TargetId",
                table: "PersonHasValuesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassHasPropertiesOfRelationship_SourceId",
                table: "PersonnelClassHasPropertiesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassHasPropertiesOfRelationship_TargetId",
                table: "PersonnelClassHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassPropertyContainsRelationship_SourceId",
                table: "PersonnelClassPropertyContainsRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassPropertyContainsRelationship_TargetId",
                table: "PersonnelClassPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPropertyContainsRelationship_SourceId",
                table: "PersonPropertyContainsRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPropertyContainsRelationship_TargetId",
                table: "PersonPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPropertyMapsToRelationship_SourceId",
                table: "PersonPropertyMapsToRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPropertyMapsToRelationship_TargetId",
                table: "PersonPropertyMapsToRelationship",
                column: "TargetId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationalLocationDefinedByRelationship_OperationalLocation_SourceId",
                table: "OperationalLocationDefinedByRelationship",
                column: "SourceId",
                principalTable: "OperationalLocation",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_SourceId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonOperationalLocationRelRelationship_Person_SourceId",
                table: "PersonOperationalLocationRelRelationship",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId");
        }
    }
}
