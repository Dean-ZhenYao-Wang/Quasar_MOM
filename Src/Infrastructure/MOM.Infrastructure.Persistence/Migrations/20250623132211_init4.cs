using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
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
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HierarchyScopeRelDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SpatialDefinition_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRIAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseOrgDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    EnabledTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactoryNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepreciationLife = table.Column<int>(type: "int", nullable: false),
                    FactoryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitialPrice = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    DateOfPurchase = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WarrantyPeriod = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Equipment_HierarchyScope_HierarchyScopeRelDtId",
                        column: x => x.HierarchyScopeRelDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_Equipment_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_Equipment_PersonnelClasses_UseOrgDtId",
                        column: x => x.UseOrgDtId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentClass",
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HierarchyScopeRelDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClass", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentClass_HierarchyScope_HierarchyScopeRelDtId",
                        column: x => x.HierarchyScopeRelDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAsset",
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
                    FixedAssetID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRIAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HierarchyScopeRelDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhysicalLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalLocationRelDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhysicalLocationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAsset", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAsset_HierarchyScope_HierarchyScopeRelDtId",
                        column: x => x.HierarchyScopeRelDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PhysicalAsset_OperationalLocation_PhysicalLocationRelDtId",
                        column: x => x.PhysicalLocationRelDtId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetClass",
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
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HierarchyScopeRelDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetClass", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClass_HierarchyScope_HierarchyScopeRelDtId",
                        column: x => x.HierarchyScopeRelDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentIsMadeUpOfRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentIsMadeUpOfRelationship_Equipment_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Equipment",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentIsMadeUpOfRelationship_Equipment_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Equipment",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentClassIncludesPropertiesOfRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClassIncludesPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentClassIncludesPropertiesOfRelationship_EquipmentClass_SourceId",
                        column: x => x.SourceId,
                        principalTable: "EquipmentClass",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentClassIncludesPropertiesOfRelationship_EquipmentClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentClassIsMadeUpOfRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClassIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentClassIsMadeUpOfRelationship_EquipmentClass_SourceId",
                        column: x => x.SourceId,
                        principalTable: "EquipmentClass",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentClassIsMadeUpOfRelationship_EquipmentClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentDefinedByRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentDefinedByRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentDefinedByRelationship_EquipmentClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentDefinedByRelationship_Equipment_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Equipment",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentImplementedByRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentImplementedByRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentImplementedByRelationship_Equipment_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Equipment",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentImplementedByRelationship_PhysicalAsset_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetIsMadeUpOfRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetIsMadeUpOfRelationship_PhysicalAsset_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PhysicalAssetIsMadeUpOfRelationship_PhysicalAsset_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetClassIncludesPropertiesOfRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetClassIncludesPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClassIncludesPropertiesOfRelationship_PhysicalAssetClass_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PhysicalAssetClass",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClassIncludesPropertiesOfRelationship_PhysicalAssetClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetClassIsMadeUpOfRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetClassIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClassIsMadeUpOfRelationship_PhysicalAssetClass_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PhysicalAssetClass",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClassIsMadeUpOfRelationship_PhysicalAssetClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetDefinedByRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetDefinedByRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetDefinedByRelationship_PhysicalAssetClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetDefinedByRelationship_PhysicalAsset_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_HierarchyScopeRelDtId",
                table: "Equipment",
                column: "HierarchyScopeRelDtId",
                unique: true,
                filter: "[HierarchyScopeRelDtId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ResponsibleDtId",
                table: "Equipment",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_UseOrgDtId",
                table: "Equipment",
                column: "UseOrgDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClass_HierarchyScopeRelDtId",
                table: "EquipmentClass",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassIncludesPropertiesOfRelationship_SourceId",
                table: "EquipmentClassIncludesPropertiesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassIncludesPropertiesOfRelationship_TargetId",
                table: "EquipmentClassIncludesPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassIsMadeUpOfRelationship_SourceId",
                table: "EquipmentClassIsMadeUpOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassIsMadeUpOfRelationship_TargetId",
                table: "EquipmentClassIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentDefinedByRelationship_SourceId",
                table: "EquipmentDefinedByRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentDefinedByRelationship_TargetId",
                table: "EquipmentDefinedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentImplementedByRelationship_SourceId",
                table: "EquipmentImplementedByRelationship",
                column: "SourceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentImplementedByRelationship_TargetId",
                table: "EquipmentImplementedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentIsMadeUpOfRelationship_SourceId",
                table: "EquipmentIsMadeUpOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentIsMadeUpOfRelationship_TargetId",
                table: "EquipmentIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAsset_HierarchyScopeRelDtId",
                table: "PhysicalAsset",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAsset_PhysicalLocationRelDtId",
                table: "PhysicalAsset",
                column: "PhysicalLocationRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClass_HierarchyScopeRelDtId",
                table: "PhysicalAssetClass",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassIncludesPropertiesOfRelationship_SourceId",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassIncludesPropertiesOfRelationship_TargetId",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassIsMadeUpOfRelationship_SourceId",
                table: "PhysicalAssetClassIsMadeUpOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassIsMadeUpOfRelationship_TargetId",
                table: "PhysicalAssetClassIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetDefinedByRelationship_SourceId",
                table: "PhysicalAssetDefinedByRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetDefinedByRelationship_TargetId",
                table: "PhysicalAssetDefinedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetIsMadeUpOfRelationship_SourceId",
                table: "PhysicalAssetIsMadeUpOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetIsMadeUpOfRelationship_TargetId",
                table: "PhysicalAssetIsMadeUpOfRelationship",
                column: "TargetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentClassIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentImplementedByRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentClass");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClass");

            migrationBuilder.DropTable(
                name: "PhysicalAsset");
        }
    }
}
