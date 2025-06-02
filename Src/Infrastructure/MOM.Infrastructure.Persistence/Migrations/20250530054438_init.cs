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
                name: "Menus",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "OperationalLocation",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRIDauthority = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocation", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClass",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClass", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClassProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "Buttons",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassHasPropertiesOfRelationship",
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
                name: "PersonnelClassPropertyContainsRelationship",
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
                name: "PersonPropertyContainsRelationship",
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
                name: "HierarchyScope",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HierarchyScope", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_HierarchyScope_HierarchyScope_SourceDtId",
                        column: x => x.SourceDtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId");
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_HierarchyScopeContainsRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassHierarchyScopeRelRelationship",
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
                name: "OperationalLocationHierarchyScopeRelRelationship",
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
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationalLocationType = table.Column<int>(type: "int", nullable: true),
                    HierarchyScopeRelDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SpatialDefinition_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRIDauthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "PersonHasValuesOfRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClasses",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    HierarchyScopeRelDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "PersonOperationalLocationRelRelationship",
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
                    table.PrimaryKey("PK_PersonOperationalLocationRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonOperationalLocationRelRelationship_OperationalLocation_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonOperationalLocationRelRelationship_Person_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Person",
                        principalColumn: "DtId");
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "PersonnelClassHasPropertiesOfRelationship",
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
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "IX_HierarchyScope_ResponsibleDtId",
                table: "HierarchyScope",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScope_SourceDtId",
                table: "HierarchyScope",
                column: "SourceDtId");

            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScopeContainsRelationship_SourceId",
                table: "HierarchyScopeContainsRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScopeContainsRelationship_TargetId",
                table: "HierarchyScopeContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ParentMenuDtId",
                table: "Menus",
                column: "ParentMenuDtId");

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
                name: "IX_OperationalLocationClassPropertyContainsRelationship_SourceId",
                table: "OperationalLocationClassPropertyContainsRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassPropertyContainsRelationship_TargetId",
                table: "OperationalLocationClassPropertyContainsRelationship",
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
                name: "IX_OperationalLocationIsMadeUpOfRelationship_SourceId",
                table: "OperationalLocationIsMadeUpOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationIsMadeUpOfRelationship_TargetId",
                table: "OperationalLocationIsMadeUpOfRelationship",
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
                name: "IX_PersonHasValuesOfRelationship_SourceId",
                table: "PersonHasValuesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHasValuesOfRelationship_TargetId",
                table: "PersonHasValuesOfRelationship",
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
                name: "IX_PersonnelClassHasPropertiesOfRelationship_SourceId",
                table: "PersonnelClassHasPropertiesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassHasPropertiesOfRelationship_TargetId",
                table: "PersonnelClassHasPropertiesOfRelationship",
                column: "TargetId");

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
                name: "IX_PersonnelClassPropertyContainsRelationship_SourceId",
                table: "PersonnelClassPropertyContainsRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassPropertyContainsRelationship_TargetId",
                table: "PersonnelClassPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonOperationalLocationRelRelationship_SourceId",
                table: "PersonOperationalLocationRelRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonOperationalLocationRelRelationship_TargetId",
                table: "PersonOperationalLocationRelRelationship",
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
                name: "FK_AvailablePermissions_Person_PersonDtId",
                table: "AvailablePermissions",
                column: "PersonDtId",
                principalTable: "Person",
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
                name: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "OperationalLocationPropertyMapsToRelationship");

            migrationBuilder.DropTable(
                name: "OrgPermission");

            migrationBuilder.DropTable(
                name: "PersonDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "PersonHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelClassHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropTable(
                name: "PersonnelClassPermission");

            migrationBuilder.DropTable(
                name: "PersonnelClassPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "PersonPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PersonPropertyMapsToRelationship");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "OperationalLocationClass");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassProperty");

            migrationBuilder.DropTable(
                name: "OperationalLocationProperty");

            migrationBuilder.DropTable(
                name: "PersonnelClasses");

            migrationBuilder.DropTable(
                name: "OperationalLocation");

            migrationBuilder.DropTable(
                name: "PersonProperty");

            migrationBuilder.DropTable(
                name: "PersonnelClassProperty");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "HierarchyScope");
        }
    }
}
