using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Menus",
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
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    AlwaysShow = table.Column<bool>(type: "bit", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    ParentMenuDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Menus_Menus_ParentMenuDtId",
                        column: x => x.ParentMenuDtId,
                        principalTable: "Menus",
                        principalColumn: "DtId");
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

            migrationBuilder.CreateTable(
                name: "Buttons",
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
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buttons", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Buttons_Menus_MenuDtId",
                        column: x => x.MenuDtId,
                        principalTable: "Menus",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvailablePermissions",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuButtonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    PersonDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailablePermissions", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "Enterprise",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enterprise", x => x.DtId);
                });

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
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseOrgDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    EnabledTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactoryNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepreciationLife = table.Column<int>(type: "int", nullable: true),
                    FactoryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitialPrice = table.Column<decimal>(type: "decimal(18,6)", nullable: true),
                    DateOfPurchase = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WarrantyPeriod = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.DtId);
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
                });

            migrationBuilder.CreateTable(
                name: "HierarchyScope",
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
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    FullPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HierarchyScope", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_HierarchyScope_HierarchyScope_SourceDtId",
                        column: x => x.SourceDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HierarchyScopeContainsRelationship",
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
                    table.PrimaryKey("PK_HierarchyScopeContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_HierarchyScopeContainsRelationship_HierarchyScope_SourceId",
                        column: x => x.SourceId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HierarchyScopeContainsRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocation",
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
                    SpatialDefinition_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRIAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocation", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocation_HierarchyScope_HierarchyScopeRelDtId",
                        column: x => x.HierarchyScopeRelDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClass",
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
                    HierarchyScopeRelDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClass", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationClass_HierarchyScope_HierarchyScopeRelDtId",
                        column: x => x.HierarchyScopeRelDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OrgPermission",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuButtonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgPermission", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OrgPermission_HierarchyScope_OrgDtId",
                        column: x => x.OrgDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
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
                    SpatialDefinition_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRIAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationalLocationType = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    ContactInformation_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInformation_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkStatus = table.Column<int>(type: "int", nullable: false),
                    LockoutOnFailure = table.Column<bool>(type: "bit", nullable: false),
                    LockoutDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FailedCount = table.Column<int>(type: "int", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Person_HierarchyScope_HierarchyScopeRelDtId",
                        column: x => x.HierarchyScopeRelDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId");
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
                name: "Site",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnterpriseDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Site_Enterprise_EnterpriseDtId",
                        column: x => x.EnterpriseDtId,
                        principalTable: "Enterprise",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_Site_HierarchyScope_DtId",
                        column: x => x.DtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationIsMadeUpOfRelationship",
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
                    table.PrimaryKey("PK_OperationalLocationIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationIsMadeUpOfRelationship_OperationalLocation_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_OperationalLocationIsMadeUpOfRelationship_OperationalLocation_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "OperationalLocationClassIncludesPropertiesOfRelationship",
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
                    table.PrimaryKey("PK_OperationalLocationClassIncludesPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassIncludesPropertiesOfRelationship_OperationalLocationClass_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocationClass",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassIncludesPropertiesOfRelationship_OperationalLocationClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocationClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassIsMadeUpOfRelationship",
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
                    table.PrimaryKey("PK_OperationalLocationClassIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassIsMadeUpOfRelationship_OperationalLocationClass_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocationClass",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_OperationalLocationClassIsMadeUpOfRelationship_OperationalLocationClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocationClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationDefinedByRelationship",
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
                    table.PrimaryKey("PK_OperationalLocationDefinedByRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationalLocationDefinedByRelationship_OperationalLocationClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocationClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OperationalLocationDefinedByRelationship_OperationalLocation_SourceId",
                        column: x => x.SourceId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonHierarchyScopeRelRelationship",
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
                    table.PrimaryKey("PK_PersonHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonHierarchyScopeRelRelationship_Person_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Person",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClasses",
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
                    HierarchyScopeRelDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelClasses", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelClasses_HierarchyScope_HierarchyScopeRelDtId",
                        column: x => x.HierarchyScopeRelDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonnelClasses_Person_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "Person",
                        principalColumn: "DtId");
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
                name: "PersonDefinedByRelationship",
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
                    table.PrimaryKey("PK_PersonDefinedByRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonDefinedByRelationship_Person_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Person",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonDefinedByRelationship_PersonnelClasses_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClassIncludesPropertiesOfRelationships",
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
                    table.PrimaryKey("PK_PersonnelClassIncludesPropertiesOfRelationships", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelClassIncludesPropertiesOfRelationships_PersonnelClasses_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonnelClassIncludesPropertiesOfRelationships_PersonnelClasses_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClassPermission",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuButtonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelClassPermission", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelClassPermission_PersonnelClasses_PersonnelClassDtId",
                        column: x => x.PersonnelClassDtId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailablePermissions_PersonDtId",
                table: "AvailablePermissions",
                column: "PersonDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Buttons_MenuDtId",
                table: "Buttons",
                column: "MenuDtId");

            migrationBuilder.CreateIndex(
                name: "IX_CodingSegments_RuleDtId",
                table: "CodingSegments",
                column: "RuleDtId");

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
                name: "IX_HierarchyScope_ResponsibleDtId",
                table: "HierarchyScope",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScope_SourceDtId",
                table: "HierarchyScope",
                column: "SourceDtId");

            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScopeContainsRelationship_SourceId_TargetId",
                table: "HierarchyScopeContainsRelationship",
                columns: new[] { "SourceId", "TargetId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScopeContainsRelationship_TargetId",
                table: "HierarchyScopeContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ParentMenuDtId",
                table: "Menus",
                column: "ParentMenuDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocation_HierarchyScopeRelDtId",
                table: "OperationalLocation",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClass_HierarchyScopeRelDtId",
                table: "OperationalLocationClass",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassIncludesPropertiesOfRelationship_SourceId",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassIncludesPropertiesOfRelationship_TargetId",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassIsMadeUpOfRelationship_SourceId",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassIsMadeUpOfRelationship_TargetId",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationDefinedByRelationship_SourceId",
                table: "OperationalLocationDefinedByRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationDefinedByRelationship_TargetId",
                table: "OperationalLocationDefinedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationIsMadeUpOfRelationship_SourceId",
                table: "OperationalLocationIsMadeUpOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationIsMadeUpOfRelationship_TargetId",
                table: "OperationalLocationIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OrgPermission_OrgDtId",
                table: "OrgPermission",
                column: "OrgDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_HierarchyScopeRelDtId",
                table: "Person",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDefinedByRelationship_SourceId",
                table: "PersonDefinedByRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonDefinedByRelationship_TargetId",
                table: "PersonDefinedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_SourceId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_TargetId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClasses_HierarchyScopeRelDtId",
                table: "PersonnelClasses",
                column: "HierarchyScopeRelDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClasses_ResponsibleDtId",
                table: "PersonnelClasses",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassIncludesPropertiesOfRelationships_SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassIncludesPropertiesOfRelationships_TargetId",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassPermission_PersonnelClassDtId",
                table: "PersonnelClassPermission",
                column: "PersonnelClassDtId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Site_EnterpriseDtId",
                table: "Site",
                column: "EnterpriseDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_AvailablePermissions_Person_PersonDtId",
                table: "AvailablePermissions",
                column: "PersonDtId",
                principalTable: "Person",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enterprise_HierarchyScope_DtId",
                table: "Enterprise",
                column: "DtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_HierarchyScope_HierarchyScopeRelDtId",
                table: "Equipment",
                column: "HierarchyScopeRelDtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Person_ResponsibleDtId",
                table: "Equipment",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_PersonnelClasses_UseOrgDtId",
                table: "Equipment",
                column: "UseOrgDtId",
                principalTable: "PersonnelClasses",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentClass_HierarchyScope_HierarchyScopeRelDtId",
                table: "EquipmentClass",
                column: "HierarchyScopeRelDtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipmentImplementedByRelationship_PhysicalAsset_TargetId",
                table: "EquipmentImplementedByRelationship",
                column: "TargetId",
                principalTable: "PhysicalAsset",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HierarchyScope_Person_ResponsibleDtId",
                table: "HierarchyScope",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HierarchyScope_Person_ResponsibleDtId",
                table: "HierarchyScope");

            migrationBuilder.DropTable(
                name: "AvailablePermissions");

            migrationBuilder.DropTable(
                name: "Buttons");

            migrationBuilder.DropTable(
                name: "CodingSegments");

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
                name: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "OrgPermission");

            migrationBuilder.DropTable(
                name: "PersonDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropTable(
                name: "PersonnelClassPermission");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "SequenceStates");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "CodingRules");

            migrationBuilder.DropTable(
                name: "EquipmentClass");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "OperationalLocationClass");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClass");

            migrationBuilder.DropTable(
                name: "PhysicalAsset");

            migrationBuilder.DropTable(
                name: "Enterprise");

            migrationBuilder.DropTable(
                name: "PersonnelClasses");

            migrationBuilder.DropTable(
                name: "OperationalLocation");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "HierarchyScope");
        }
    }
}
