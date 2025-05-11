using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deleteHC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaWorkCenterRelationship");

            migrationBuilder.DropTable(
                name: "EnterpriseSiteRelationship");

            migrationBuilder.DropTable(
                name: "ProcessCell");

            migrationBuilder.DropTable(
                name: "ProductionLine");

            migrationBuilder.DropTable(
                name: "ProductionUnit");

            migrationBuilder.DropTable(
                name: "SiteAreaRelationship");

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
                name: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropTable(
                name: "WorkUnit");

            migrationBuilder.DropTable(
                name: "Enterprise");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "EquipmentClassHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "EquipmentHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HierarchyScopeContainsRelationship_HierarchyScope_SourceId",
                table: "HierarchyScopeContainsRelationship",
                column: "SourceId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_HierarchyScopeContainsRelationship_HierarchyScope_TargetId",
                table: "HierarchyScopeContainsRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialClassHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialDefinitionHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialDefinitionHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialLotHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialLotHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialSpecificationHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialSublotHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialSublotHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperationalLocationClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OperationalLocationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "ParameterSpecificationHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalAssetClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalAssetHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PhysicalAssetHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalAssetSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "TestSpecificationHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkDefinitionHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "EquipmentClassHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "EquipmentHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_EquipmentSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_HierarchyScopeContainsRelationship_HierarchyScope_SourceId",
                table: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_HierarchyScopeContainsRelationship_HierarchyScope_TargetId",
                table: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialClassHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialDefinitionHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialLotHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialLotHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialSublotHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "MaterialSublotHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationalLocationClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "OperationalLocationClassHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_OperationalLocationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "OperationalLocationHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_ParameterSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "ParameterSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalAssetClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalAssetHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PhysicalAssetHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalAssetSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_TestSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "TestSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkDefinitionHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "WorkDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Area_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "Enterprise",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enterprise", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Enterprise_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "ProcessCell",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessCell", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ProcessCell_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "ProductionLine",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionLine", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ProductionLine_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "ProductionUnit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionUnit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ProductionUnit_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Site_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "StorageUnit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageUnit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_StorageUnit_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "StorageZone",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageZone", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_StorageZone_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Unit_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "WorkCell",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCell", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkCell_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "WorkCenter",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCenter", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkCenter_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "WorkCenterWorkUnitRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCenterWorkUnitRelationship", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "WorkUnit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkUnit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkUnit_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "AreaWorkCenterRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaWorkCenterRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_AreaWorkCenterRelationship_Area_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Area",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EnterpriseSiteRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnterpriseSiteRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EnterpriseSiteRelationship_Enterprise_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Enterprise",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EnterpriseSiteRelationship_Site_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Site",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteAreaRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteAreaRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_SiteAreaRelationship_Area_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Area",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteAreaRelationship_Site_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Site",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Area_ResponsibleDtId",
                table: "Area",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaWorkCenterRelationship_SourceId",
                table: "AreaWorkCenterRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaWorkCenterRelationship_TargetId",
                table: "AreaWorkCenterRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprise_ResponsibleDtId",
                table: "Enterprise",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseSiteRelationship_SourceId",
                table: "EnterpriseSiteRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseSiteRelationship_TargetId",
                table: "EnterpriseSiteRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessCell_ResponsibleDtId",
                table: "ProcessCell",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionLine_ResponsibleDtId",
                table: "ProductionLine",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionUnit_ResponsibleDtId",
                table: "ProductionUnit",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Site_ResponsibleDtId",
                table: "Site",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteAreaRelationship_SourceId",
                table: "SiteAreaRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteAreaRelationship_TargetId",
                table: "SiteAreaRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageUnit_ResponsibleDtId",
                table: "StorageUnit",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageZone_ResponsibleDtId",
                table: "StorageZone",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_ResponsibleDtId",
                table: "Unit",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCell_ResponsibleDtId",
                table: "WorkCell",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCenter_ResponsibleDtId",
                table: "WorkCenter",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCenterWorkUnitRelationship_SourceId",
                table: "WorkCenterWorkUnitRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCenterWorkUnitRelationship_TargetId",
                table: "WorkCenterWorkUnitRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkUnit_ResponsibleDtId",
                table: "WorkUnit",
                column: "ResponsibleDtId");
        }
    }
}
