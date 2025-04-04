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
                name: "EquipmentClass",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClass", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentClassProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClassProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentProperty",
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
                    table.PrimaryKey("PK_EquipmentProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecification",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationalLocationType = table.Column<int>(type: "int", nullable: true),
                    EquipmentUse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecification", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "EvaluatedProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluatedProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialClass",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssemblyType = table.Column<int>(type: "int", nullable: true),
                    AssemblyRelationship = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialClass", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialClassProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialClassProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDefinition",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssemblyType = table.Column<int>(type: "int", nullable: true),
                    AssemblyRelationship = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Texture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnitOfMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDefinition", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDefinitionProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDefinitionProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialLot",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageLocationType = table.Column<int>(type: "int", nullable: true),
                    AssemblyType = table.Column<int>(type: "int", nullable: true),
                    AssemblyRelationship = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disposition = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLot", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialLotProperty",
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
                    table.PrimaryKey("PK_MaterialLotProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSegmentSpecificationProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSegmentSpecificationProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecification",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageLocationType = table.Column<int>(type: "int", nullable: true),
                    AssemblyType = table.Column<int>(type: "int", nullable: true),
                    AssemblyRelationship = table.Column<int>(type: "int", nullable: true),
                    MaterialUse = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecification", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSublot",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageLocationType = table.Column<int>(type: "int", nullable: true),
                    AssemblyType = table.Column<int>(type: "int", nullable: true),
                    AssemblyRelationship = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disposition = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSublot", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocation",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyType = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                name: "OperationsTestRequirement",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsTestRequirement", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "ParameterSpecification",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ParameterSpecification", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationalLocationType = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkStatus = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClasses",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelClasses", x => x.DtId);
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
                name: "PersonnelSpecification",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationalLocationType = table.Column<int>(type: "int", nullable: true),
                    PersonnelUse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecification", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationProperty", x => x.DtId);
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
                name: "PhysicalAsset",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixedAssetID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalLocationType = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAsset", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetClass",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HierarchyScope = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetClass", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetClassProperty",
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
                    table.PrimaryKey("PK_PhysicalAssetClassProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetProperty",
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
                    table.PrimaryKey("PK_PhysicalAssetProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecification",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalLocationType = table.Column<int>(type: "int", nullable: true),
                    PhysicalAssetUse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecification", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    QuantityUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "TestableObject",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestableObject", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "TestableObjectProperty",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestableObjectProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "TestSpecification",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EffectiveEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestSampleSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalSample = table.Column<int>(type: "int", nullable: true),
                    RecurrenceQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecurrenceTimeInterval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecification", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationCriteria",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    Expression = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<int>(type: "int", nullable: true),
                    OtherResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationCriteria", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationProperty",
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
                    table.PrimaryKey("PK_TestSpecificationProperty", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "WorkDefinition",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HierarchyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkType = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationUnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDefinition", x => x.DtId);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentClassIncludesPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClassIncludesPropertiesOfRelationship", x => x.DtId);
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClassIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentClassIsMadeUpOfRelationship_EquipmentClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentClassHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClassHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentClassHasPropertiesOfRelationship_EquipmentClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentClassHasPropertiesOfRelationship_EquipmentClass_EquipmentClassDtId",
                        column: x => x.EquipmentClassDtId,
                        principalTable: "EquipmentClass",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentClassPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClassPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentClassPropertyContainsRelationship_EquipmentClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentPropertyContainsRelationship_EquipmentProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentPropertyMapsToRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentPropertyMapsToRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentPropertyMapsToRelationship_EquipmentClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentPropertyMapsToRelationship_EquipmentProperty_EquipmentPropertyDtId",
                        column: x => x.EquipmentPropertyDtId,
                        principalTable: "EquipmentProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationCorrespondsToEquipmentClassRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationCorrespondsToEquipmentClassRelationship_EquipmentClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationCorrespondsToEquipmentClassRelationship_EquipmentSpecification_EquipmentSpecificationDtId",
                        column: x => x.EquipmentSpecificationDtId,
                        principalTable: "EquipmentSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationIsMadeUpOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationIsMadeUpOfRelationship_EquipmentSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationHasPropertiesOfRelationship_EquipmentSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationHasPropertiesOfRelationship_EquipmentSpecification_EquipmentSpecificationDtId",
                        column: x => x.EquipmentSpecificationDtId,
                        principalTable: "EquipmentSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationPropertyContainsRelationship_EquipmentSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationPropertyMapsToClassPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationPropertyMapsToClassPropertyRelationship_EquipmentClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationPropertyMapsToClassPropertyRelationship_EquipmentSpecificationProperty_EquipmentSpecificationPropertyD~",
                        column: x => x.EquipmentSpecificationPropertyDtId,
                        principalTable: "EquipmentSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationPropertyMapsToPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationPropertyMapsToPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationPropertyMapsToPropertyRelationship_EquipmentProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationPropertyMapsToPropertyRelationship_EquipmentSpecificationProperty_EquipmentSpecificationPropertyDtId",
                        column: x => x.EquipmentSpecificationPropertyDtId,
                        principalTable: "EquipmentSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialClassIncludesPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialClassIncludesPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialClassIncludesPropertiesOfRelationship_MaterialClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialClassIsAssembledFromRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialClassIsAssembledFromRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialClassIsAssembledFromRelationship_MaterialClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialClassHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialClassHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialClassHasPropertiesOfRelationship_MaterialClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialClassHasPropertiesOfRelationship_MaterialClass_MaterialClassDtId",
                        column: x => x.MaterialClassDtId,
                        principalTable: "MaterialClass",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialClassPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialClassPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialClassPropertyContainsRelationship_MaterialClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDefinitionIsAssembledFromRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDefinitionIsAssembledFromRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionIsAssembledFromRelationship_MaterialDefinition_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialDefinition",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDefinitionIsMemberOfClassRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialDefinitionDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDefinitionIsMemberOfClassRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionIsMemberOfClassRelationship_MaterialClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionIsMemberOfClassRelationship_MaterialDefinition_MaterialDefinitionDtId",
                        column: x => x.MaterialDefinitionDtId,
                        principalTable: "MaterialDefinition",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialDefinitionHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialDefinitionDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDefinitionHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionHasPropertiesOfRelationship_MaterialDefinitionProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialDefinitionProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionHasPropertiesOfRelationship_MaterialDefinition_MaterialDefinitionDtId",
                        column: x => x.MaterialDefinitionDtId,
                        principalTable: "MaterialDefinition",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialDefinitionPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDefinitionPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionPropertyContainsRelationship_MaterialDefinitionProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialDefinitionProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialDefinitionPropertyMapsToRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialDefinitionPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDefinitionPropertyMapsToRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionPropertyMapsToRelationship_MaterialClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionPropertyMapsToRelationship_MaterialDefinitionProperty_MaterialDefinitionPropertyDtId",
                        column: x => x.MaterialDefinitionPropertyDtId,
                        principalTable: "MaterialDefinitionProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialLotDefinedByRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialLotDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLotDefinedByRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialLotDefinedByRelationship_MaterialDefinition_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialDefinition",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialLotDefinedByRelationship_MaterialLot_MaterialLotDtId",
                        column: x => x.MaterialLotDtId,
                        principalTable: "MaterialLot",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialLotIsAssembledFromRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLotIsAssembledFromRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialLotIsAssembledFromRelationship_MaterialLot_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialLot",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialLotHasValuesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialLotDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLotHasValuesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialLotHasValuesOfRelationship_MaterialLotProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialLotProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialLotHasValuesOfRelationship_MaterialLot_MaterialLotDtId",
                        column: x => x.MaterialLotDtId,
                        principalTable: "MaterialLot",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialLotPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLotPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialLotPropertyContainsRelationship_MaterialLotProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialLotProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialLotPropertyMapsToRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialLotPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLotPropertyMapsToRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialLotPropertyMapsToRelationship_MaterialDefinitionProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialDefinitionProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialLotPropertyMapsToRelationship_MaterialLotProperty_MaterialLotPropertyDtId",
                        column: x => x.MaterialLotPropertyDtId,
                        principalTable: "MaterialLotProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSegmentSpecificationPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSegmentSpecificationPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSegmentSpecificationPropertyContainsRelationship_MaterialSegmentSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialSegmentSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSegmentSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship_MaterialClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship_MaterialSegmentSpecificationProperty_MaterialSegmentSpec~",
                        column: x => x.MaterialSegmentSpecificationPropertyDtId,
                        principalTable: "MaterialSegmentSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSegmentSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship_MaterialDefinitionProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialDefinitionProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship_MaterialSegmentSpecificationProperty_MaterialSegmen~",
                        column: x => x.MaterialSegmentSpecificationPropertyDtId,
                        principalTable: "MaterialSegmentSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSegmentSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship_MaterialLotProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialLotProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship_MaterialSegmentSpecificationProperty_MaterialSegmentSpecif~",
                        column: x => x.MaterialSegmentSpecificationPropertyDtId,
                        principalTable: "MaterialSegmentSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationCorrespondsToClassRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationCorrespondsToClassRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationCorrespondsToClassRelationship_MaterialClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationCorrespondsToClassRelationship_MaterialSpecification_MaterialSpecificationDtId",
                        column: x => x.MaterialSpecificationDtId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationCorrespondsToDefinitionRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationCorrespondsToDefinitionRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationCorrespondsToDefinitionRelationship_MaterialDefinition_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialDefinition",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationCorrespondsToDefinitionRelationship_MaterialSpecification_MaterialSpecificationDtId",
                        column: x => x.MaterialSpecificationDtId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationCorrespondsToLotRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationCorrespondsToLotRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationCorrespondsToLotRelationship_MaterialLot_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialLot",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationCorrespondsToLotRelationship_MaterialSpecification_MaterialSpecificationDtId",
                        column: x => x.MaterialSpecificationDtId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationIsAssembledFromRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationIsAssembledFromRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationIsAssembledFromRelationship_MaterialSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationHasPropertiesOfRelationship_MaterialSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationHasPropertiesOfRelationship_MaterialSpecification_MaterialSpecificationDtId",
                        column: x => x.MaterialSpecificationDtId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationPropertyContainsRelationship_MaterialSegmentSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialSegmentSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationPropertyContainsRelationship_MaterialSpecificationProperty_MaterialSpecificationPropertyDtId",
                        column: x => x.MaterialSpecificationPropertyDtId,
                        principalTable: "MaterialSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationPropertyMapsToClassPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationPropertyMapsToClassPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationPropertyMapsToClassPropertyRelationship_MaterialClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationPropertyMapsToClassPropertyRelationship_MaterialSpecificationProperty_MaterialSpecificationPropertyDtId",
                        column: x => x.MaterialSpecificationPropertyDtId,
                        principalTable: "MaterialSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship_MaterialDefinitionProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialDefinitionProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship_MaterialSpecificationProperty_MaterialSpecificationPropert~",
                        column: x => x.MaterialSpecificationPropertyDtId,
                        principalTable: "MaterialSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationPropertyMapsToLotPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationPropertyMapsToLotPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationPropertyMapsToLotPropertyRelationship_MaterialLotProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialLotProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationPropertyMapsToLotPropertyRelationship_MaterialSpecificationProperty_MaterialSpecificationPropertyDtId",
                        column: x => x.MaterialSpecificationPropertyDtId,
                        principalTable: "MaterialSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialLotIsAssembledFromSublotRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialLotDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLotIsAssembledFromSublotRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialLotIsAssembledFromSublotRelationship_MaterialLot_MaterialLotDtId",
                        column: x => x.MaterialLotDtId,
                        principalTable: "MaterialLot",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_MaterialLotIsAssembledFromSublotRelationship_MaterialSublot_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialSublot",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationCorrespondsToSublotRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationCorrespondsToSublotRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationCorrespondsToSublotRelationship_MaterialSpecification_MaterialSpecificationDtId",
                        column: x => x.MaterialSpecificationDtId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationCorrespondsToSublotRelationship_MaterialSublot_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialSublot",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSublotHasValuesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSublotDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSublotHasValuesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSublotHasValuesOfRelationship_MaterialLotProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialLotProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSublotHasValuesOfRelationship_MaterialSublot_MaterialSublotDtId",
                        column: x => x.MaterialSublotDtId,
                        principalTable: "MaterialSublot",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSublotIsAssembledFromLotRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSublotDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSublotIsAssembledFromLotRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSublotIsAssembledFromLotRelationship_MaterialLot_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialLot",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSublotIsAssembledFromLotRelationship_MaterialSublot_MaterialSublotDtId",
                        column: x => x.MaterialSublotDtId,
                        principalTable: "MaterialSublot",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSublotIsAssembledFromRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSublotIsAssembledFromRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSublotIsAssembledFromRelationship_MaterialSublot_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialSublot",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSublotIsMadeUpOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSublotIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSublotIsMadeUpOfRelationship_MaterialSublot_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialSublot",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationOperationalLocationRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationOperationalLocationRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationOperationalLocationRelRelationship_EquipmentSpecification_EquipmentSpecificationDtId",
                        column: x => x.EquipmentSpecificationDtId,
                        principalTable: "EquipmentSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationOperationalLocationRelRelationship_OperationalLocation_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialLotStorageLocationRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialLotDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLotStorageLocationRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialLotStorageLocationRelRelationship_MaterialLot_MaterialLotDtId",
                        column: x => x.MaterialLotDtId,
                        principalTable: "MaterialLot",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_MaterialLotStorageLocationRelRelationship_OperationalLocation_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationStorageLocationRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationStorageLocationRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationStorageLocationRelRelationship_MaterialSpecification_MaterialSpecificationDtId",
                        column: x => x.MaterialSpecificationDtId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationStorageLocationRelRelationship_OperationalLocation_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSublotStorageLocationRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSublotDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSublotStorageLocationRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSublotStorageLocationRelRelationship_MaterialSublot_MaterialSublotDtId",
                        column: x => x.MaterialSublotDtId,
                        principalTable: "MaterialSublot",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_MaterialSublotStorageLocationRelRelationship_OperationalLocation_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationIsMadeUpOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationIsMadeUpOfRelationship", x => x.DtId);
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClassIncludesPropertiesOfRelationship", x => x.DtId);
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClassIsMadeUpOfRelationship", x => x.DtId);
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationalLocationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_OperationalLocationDefinedByRelationship_OperationalLocation_OperationalLocationDtId",
                        column: x => x.OperationalLocationDtId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationalLocationClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_OperationalLocationClassHasPropertiesOfRelationship_OperationalLocationClass_OperationalLocationClassDtId",
                        column: x => x.OperationalLocationClassDtId,
                        principalTable: "OperationalLocationClass",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationClassPropertyContainsRelationship", x => x.DtId);
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationalLocationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_OperationalLocationHasValuesOfRelationship_OperationalLocation_OperationalLocationDtId",
                        column: x => x.OperationalLocationDtId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationalLocationPropertyContainsRelationship", x => x.DtId);
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationalLocationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_OperationalLocationPropertyMapsToRelationship_OperationalLocationProperty_OperationalLocationPropertyDtId",
                        column: x => x.OperationalLocationPropertyDtId,
                        principalTable: "OperationalLocationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "ParameterSpecificationContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterSpecificationContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ParameterSpecificationContainsRelationship_ParameterSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "ParameterSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HierarchyScope",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EquipmentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HierarchyScope", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_HierarchyScope_People_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "People",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonOperationalLocationRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_PersonOperationalLocationRelRelationship_People_PersonDtId",
                        column: x => x.PersonDtId,
                        principalTable: "People",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EquipmentLevel = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpatialDefinition_Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_Format = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpatialDefinition_SRIDauthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseDepartmentDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    EnabledTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponsibleDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FactoryNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepreciationLife = table.Column<int>(type: "int", nullable: false),
                    FactoryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitialPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateOfPurchase = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WarrantyPeriod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Equipment_People_ResponsibleDtId",
                        column: x => x.ResponsibleDtId,
                        principalTable: "People",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_Equipment_PersonnelClasses_UseDepartmentDtId",
                        column: x => x.UseDepartmentDtId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonDefinedByRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonDefinedByRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonDefinedByRelationship_People_SourceId",
                        column: x => x.SourceId,
                        principalTable: "People",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonDefinedByRelationship_PersonnelClasses_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClassIncludesPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelClassIncludesPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelClassIncludesPropertiesOfRelationship_PersonnelClasses_SourceId",
                        column: x => x.SourceId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonnelClassIncludesPropertiesOfRelationship_PersonnelClasses_TargetId",
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationCorrespondsToPersonnelClassRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationCorrespondsToPersonnelClassRelationship_PersonnelClasses_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationCorrespondsToPersonnelClassRelationship_PersonnelSpecification_PersonnelSpecificationDtId",
                        column: x => x.PersonnelSpecificationDtId,
                        principalTable: "PersonnelSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationCorrespondsToPersonRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationCorrespondsToPersonRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationCorrespondsToPersonRelationship_People_TargetId",
                        column: x => x.TargetId,
                        principalTable: "People",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationCorrespondsToPersonRelationship_PersonnelSpecification_PersonnelSpecificationDtId",
                        column: x => x.PersonnelSpecificationDtId,
                        principalTable: "PersonnelSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationIsMadeUpOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationIsMadeUpOfRelationship_PersonnelSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationOperationalLocationRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationOperationalLocationRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationOperationalLocationRelRelationship_OperationalLocation_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationOperationalLocationRelRelationship_PersonnelSpecification_PersonnelSpecificationDtId",
                        column: x => x.PersonnelSpecificationDtId,
                        principalTable: "PersonnelSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationHasPropertiesOfRelationship_PersonnelSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationHasPropertiesOfRelationship_PersonnelSpecification_PersonnelSpecificationDtId",
                        column: x => x.PersonnelSpecificationDtId,
                        principalTable: "PersonnelSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationPropertyContainsRelationship_PersonnelSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationPropertyMapsToClassPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationPropertyMapsToClassPropertyRelationship_PersonnelClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationPropertyMapsToClassPropertyRelationship_PersonnelSpecificationProperty_PersonnelSpecificationPropertyD~",
                        column: x => x.PersonnelSpecificationPropertyDtId,
                        principalTable: "PersonnelSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonHasValuesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonHasValuesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonHasValuesOfRelationship_People_SourceId",
                        column: x => x.SourceId,
                        principalTable: "People",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonHasValuesOfRelationship_PersonProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationPropertyMapsToPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationPropertyMapsToPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationPropertyMapsToPropertyRelationship_PersonProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationPropertyMapsToPropertyRelationship_PersonnelSpecificationProperty_PersonnelSpecificationPropertyDtId",
                        column: x => x.PersonnelSpecificationPropertyDtId,
                        principalTable: "PersonnelSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "PhysicalAssetIsMadeUpOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetIsMadeUpOfRelationship_PhysicalAsset_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetPhysicalLocationRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetPhysicalLocationRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetPhysicalLocationRelRelationship_OperationalLocation_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetPhysicalLocationRelRelationship_PhysicalAsset_PhysicalAssetDtId",
                        column: x => x.PhysicalAssetDtId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetClassIncludesPropertiesOfRelationship", x => x.DtId);
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetClassIsMadeUpOfRelationship", x => x.DtId);
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_PhysicalAssetDefinedByRelationship_PhysicalAsset_PhysicalAssetDtId",
                        column: x => x.PhysicalAssetDtId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetClassHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetClassHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClassHasPropertiesOfRelationship_PhysicalAssetClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClassHasPropertiesOfRelationship_PhysicalAssetClass_PhysicalAssetClassDtId",
                        column: x => x.PhysicalAssetClassDtId,
                        principalTable: "PhysicalAssetClass",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetClassPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetClassPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClassPropertyContainsRelationship_PhysicalAssetClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetHasValuesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetHasValuesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetHasValuesOfRelationship_PhysicalAssetProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetHasValuesOfRelationship_PhysicalAsset_PhysicalAssetDtId",
                        column: x => x.PhysicalAssetDtId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetPropertyContainsRelationship_PhysicalAssetProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetPropertyMapsToRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetPropertyMapsToRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetPropertyMapsToRelationship_PhysicalAssetClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetPropertyMapsToRelationship_PhysicalAssetProperty_PhysicalAssetPropertyDtId",
                        column: x => x.PhysicalAssetPropertyDtId,
                        principalTable: "PhysicalAssetProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship_PhysicalAssetClass_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetClass",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship_PhysicalAssetSpecification_PhysicalAssetSpecificationD~",
                        column: x => x.PhysicalAssetSpecificationDtId,
                        principalTable: "PhysicalAssetSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship_PhysicalAssetSpecification_PhysicalAssetSpecificationDtId",
                        column: x => x.PhysicalAssetSpecificationDtId,
                        principalTable: "PhysicalAssetSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship_PhysicalAsset_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationIsMadeUpOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationIsMadeUpOfRelationship_PhysicalAssetSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationPhysicalLocationRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationPhysicalLocationRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationPhysicalLocationRelRelationship_OperationalLocation_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationPhysicalLocationRelRelationship_PhysicalAssetSpecification_PhysicalAssetSpecificationDtId",
                        column: x => x.PhysicalAssetSpecificationDtId,
                        principalTable: "PhysicalAssetSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationHasPropertiesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationHasPropertiesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationHasPropertiesOfRelationship_PhysicalAssetSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationHasPropertiesOfRelationship_PhysicalAssetSpecification_PhysicalAssetSpecificationDtId",
                        column: x => x.PhysicalAssetSpecificationDtId,
                        principalTable: "PhysicalAssetSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationPropertyContainsRelationship_PhysicalAssetSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship_PhysicalAssetClassProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetClassProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship_PhysicalAssetSpecificationProperty_PhysicalAssetSpecificat~",
                        column: x => x.PhysicalAssetSpecificationPropertyDtId,
                        principalTable: "PhysicalAssetSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetSpecificationPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationPropertyMapsToPropertyRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationPropertyMapsToPropertyRelationship_PhysicalAssetProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationPropertyMapsToPropertyRelationship_PhysicalAssetSpecificationProperty_PhysicalAssetSpecificationPr~",
                        column: x => x.PhysicalAssetSpecificationPropertyDtId,
                        principalTable: "PhysicalAssetSpecificationProperty",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationsTestRequirementCorrespondsToAnElementInRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationsTestRequirementDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsTestRequirementCorrespondsToAnElementInRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationsTestRequirementCorrespondsToAnElementInRelationship_OperationsTestRequirement_OperationsTestRequirementDtId",
                        column: x => x.OperationsTestRequirementDtId,
                        principalTable: "OperationsTestRequirement",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_OperationsTestRequirementCorrespondsToAnElementInRelationship_TestableObject_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestableObject",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluatedPropertyCorrespondsToRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluatedPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluatedPropertyCorrespondsToRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EvaluatedPropertyCorrespondsToRelationship_EvaluatedProperty_EvaluatedPropertyDtId",
                        column: x => x.EvaluatedPropertyDtId,
                        principalTable: "EvaluatedProperty",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EvaluatedPropertyCorrespondsToRelationship_TestableObjectProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestableObjectProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationsTestRequirementMapsToAPropertyElementInRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationsTestRequirementDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsTestRequirementMapsToAPropertyElementInRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationsTestRequirementMapsToAPropertyElementInRelationship_OperationsTestRequirement_OperationsTestRequirementDtId",
                        column: x => x.OperationsTestRequirementDtId,
                        principalTable: "OperationsTestRequirement",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_OperationsTestRequirementMapsToAPropertyElementInRelationship_TestableObjectProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestableObjectProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestableObjectHasTestableObjectPropertyValuesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestableObjectDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestableObjectHasTestableObjectPropertyValuesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestableObjectHasTestableObjectPropertyValuesOfRelationship_TestableObjectProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestableObjectProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestableObjectHasTestableObjectPropertyValuesOfRelationship_TestableObject_TestableObjectDtId",
                        column: x => x.TestableObjectDtId,
                        principalTable: "TestableObject",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationSpecifiesRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationSpecifiesRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationSpecifiesRelationship_EquipmentSpecification_EquipmentSpecificationDtId",
                        column: x => x.EquipmentSpecificationDtId,
                        principalTable: "EquipmentSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationSpecifiesRelationship_TestSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationSpecifiesRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationSpecifiesRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationSpecifiesRelationship_MaterialSpecification_MaterialSpecificationDtId",
                        column: x => x.MaterialSpecificationDtId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationSpecifiesRelationship_TestSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationsTestRequirementSpecifiesRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationsTestRequirementDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsTestRequirementSpecifiesRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_OperationsTestRequirementSpecifiesRelationship_OperationsTestRequirement_OperationsTestRequirementDtId",
                        column: x => x.OperationsTestRequirementDtId,
                        principalTable: "OperationsTestRequirement",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_OperationsTestRequirementSpecifiesRelationship_TestSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationSpecifiesRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationSpecifiesRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationSpecifiesRelationship_PersonnelSpecification_PersonnelSpecificationDtId",
                        column: x => x.PersonnelSpecificationDtId,
                        principalTable: "PersonnelSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationSpecifiesRelationship_TestSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationSpecifiesRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationSpecifiesRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationSpecifiesRelationship_PhysicalAssetSpecification_PhysicalAssetSpecificationDtId",
                        column: x => x.PhysicalAssetSpecificationDtId,
                        principalTable: "PhysicalAssetSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationSpecifiesRelationship_TestSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestableObjectSpecifiesRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestableObjectDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestableObjectSpecifiesRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestableObjectSpecifiesRelationship_TestSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestableObjectSpecifiesRelationship_TestableObject_TestableObjectDtId",
                        column: x => x.TestableObjectDtId,
                        principalTable: "TestableObject",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationEvaluatesRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationEvaluatesRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestSpecificationEvaluatesRelationship_EvaluatedProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EvaluatedProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestSpecificationEvaluatesRelationship_TestSpecification_TestSpecificationDtId",
                        column: x => x.TestSpecificationDtId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationIsMadeUpOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestSpecificationIsMadeUpOfRelationship_TestSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationSpecifiesTestForObjectRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationSpecifiesTestForObjectRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestSpecificationSpecifiesTestForObjectRelationship_TestSpecification_TestSpecificationDtId",
                        column: x => x.TestSpecificationDtId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_TestSpecificationSpecifiesTestForObjectRelationship_TestableObject_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestableObject",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationSpecifiesTestForOperationsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationSpecifiesTestForOperationsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestSpecificationSpecifiesTestForOperationsRelationship_OperationsTestRequirement_TargetId",
                        column: x => x.TargetId,
                        principalTable: "OperationsTestRequirement",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestSpecificationSpecifiesTestForOperationsRelationship_TestSpecification_TestSpecificationDtId",
                        column: x => x.TestSpecificationDtId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EvaluatedPropertyReferencesRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluatedPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluatedPropertyReferencesRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EvaluatedPropertyReferencesRelationship_EvaluatedProperty_EvaluatedPropertyDtId",
                        column: x => x.EvaluatedPropertyDtId,
                        principalTable: "EvaluatedProperty",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EvaluatedPropertyReferencesRelationship_TestSpecificationCriteria_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecificationCriteria",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationCriteriaReferencesRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestSpecificationCriteriaDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationCriteriaReferencesRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestSpecificationCriteriaReferencesRelationship_EvaluatedProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EvaluatedProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestSpecificationCriteriaReferencesRelationship_TestSpecificationCriteria_TestSpecificationCriteriaDtId",
                        column: x => x.TestSpecificationCriteriaDtId,
                        principalTable: "TestSpecificationCriteria",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationIsMadeUpOfCriteriaRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationIsMadeUpOfCriteriaRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestSpecificationIsMadeUpOfCriteriaRelationship_TestSpecificationCriteria_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecificationCriteria",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestSpecificationIsMadeUpOfCriteriaRelationship_TestSpecification_TestSpecificationDtId",
                        column: x => x.TestSpecificationDtId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationHasValuesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationHasValuesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestSpecificationHasValuesOfRelationship_TestSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestSpecificationHasValuesOfRelationship_TestSpecification_TestSpecificationDtId",
                        column: x => x.TestSpecificationDtId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationPropertyContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationPropertyContainsRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestSpecificationPropertyContainsRelationship_TestSpecificationProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "TestSpecificationProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluatedPropertyMeasuredWithMethodOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvaluatedPropertyDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluatedPropertyMeasuredWithMethodOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EvaluatedPropertyMeasuredWithMethodOfRelationship_EvaluatedProperty_EvaluatedPropertyDtId",
                        column: x => x.EvaluatedPropertyDtId,
                        principalTable: "EvaluatedProperty",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EvaluatedPropertyMeasuredWithMethodOfRelationship_WorkDefinition_TargetId",
                        column: x => x.TargetId,
                        principalTable: "WorkDefinition",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkDefinitionContainsEquipmentRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDefinitionDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDefinitionContainsEquipmentRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsEquipmentRelationship_EquipmentSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsEquipmentRelationship_WorkDefinition_WorkDefinitionDtId",
                        column: x => x.WorkDefinitionDtId,
                        principalTable: "WorkDefinition",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "WorkDefinitionContainsMaterialRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDefinitionDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDefinitionContainsMaterialRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsMaterialRelationship_MaterialSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsMaterialRelationship_WorkDefinition_WorkDefinitionDtId",
                        column: x => x.WorkDefinitionDtId,
                        principalTable: "WorkDefinition",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "WorkDefinitionContainsParameterRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDefinitionDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDefinitionContainsParameterRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsParameterRelationship_ParameterSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "ParameterSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsParameterRelationship_WorkDefinition_WorkDefinitionDtId",
                        column: x => x.WorkDefinitionDtId,
                        principalTable: "WorkDefinition",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "WorkDefinitionContainsPersonnelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDefinitionDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDefinitionContainsPersonnelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsPersonnelRelationship_PersonnelSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PersonnelSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsPersonnelRelationship_WorkDefinition_WorkDefinitionDtId",
                        column: x => x.WorkDefinitionDtId,
                        principalTable: "WorkDefinition",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "WorkDefinitionContainsPhysicalAssetRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDefinitionDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDefinitionContainsPhysicalAssetRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsPhysicalAssetRelationship_PhysicalAssetSpecification_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAssetSpecification",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionContainsPhysicalAssetRelationship_WorkDefinition_WorkDefinitionDtId",
                        column: x => x.WorkDefinitionDtId,
                        principalTable: "WorkDefinition",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Area_HierarchyScope_DtId",
                        column: x => x.DtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enterprise",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enterprise", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Enterprise_HierarchyScope_DtId",
                        column: x => x.DtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentClassHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentClassHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentClassHierarchyScopeRelRelationship_EquipmentClass_EquipmentClassDtId",
                        column: x => x.EquipmentClassDtId,
                        principalTable: "EquipmentClass",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationHierarchyScopeRelRelationship_EquipmentSpecification_EquipmentSpecificationDtId",
                        column: x => x.EquipmentSpecificationDtId,
                        principalTable: "EquipmentSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HierarchyScopeContainsRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "MaterialClassHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialClassHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialClassHierarchyScopeRelRelationship_MaterialClass_MaterialClassDtId",
                        column: x => x.MaterialClassDtId,
                        principalTable: "MaterialClass",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialDefinitionHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialDefinitionDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialDefinitionHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialDefinitionHierarchyScopeRelRelationship_MaterialDefinition_MaterialDefinitionDtId",
                        column: x => x.MaterialDefinitionDtId,
                        principalTable: "MaterialDefinition",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialLotHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialLotDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialLotHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialLotHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialLotHierarchyScopeRelRelationship_MaterialLot_MaterialLotDtId",
                        column: x => x.MaterialLotDtId,
                        principalTable: "MaterialLot",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSpecificationHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSpecificationHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSpecificationHierarchyScopeRelRelationship_MaterialSpecification_MaterialSpecificationDtId",
                        column: x => x.MaterialSpecificationDtId,
                        principalTable: "MaterialSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "MaterialSublotHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialSublotDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialSublotHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_MaterialSublotHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialSublotHierarchyScopeRelRelationship_MaterialSublot_MaterialSublotDtId",
                        column: x => x.MaterialSublotDtId,
                        principalTable: "MaterialSublot",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationClassHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationalLocationClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_OperationalLocationClassHierarchyScopeRelRelationship_OperationalLocationClass_OperationalLocationClassDtId",
                        column: x => x.OperationalLocationClassDtId,
                        principalTable: "OperationalLocationClass",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "OperationalLocationHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationalLocationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_OperationalLocationHierarchyScopeRelRelationship_OperationalLocation_OperationalLocationDtId",
                        column: x => x.OperationalLocationDtId,
                        principalTable: "OperationalLocation",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "ParameterSpecificationHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParameterSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterSpecificationHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ParameterSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterSpecificationHierarchyScopeRelRelationship_ParameterSpecification_ParameterSpecificationDtId",
                        column: x => x.ParameterSpecificationDtId,
                        principalTable: "ParameterSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_PersonHierarchyScopeRelRelationship_People_PersonDtId",
                        column: x => x.PersonDtId,
                        principalTable: "People",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PersonnelClassHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "PersonnelSpecificationHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonnelSpecificationHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonnelSpecificationHierarchyScopeRelRelationship_PersonnelSpecification_PersonnelSpecificationDtId",
                        column: x => x.PersonnelSpecificationDtId,
                        principalTable: "PersonnelSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetClassHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetClassHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetClassHierarchyScopeRelRelationship_PhysicalAssetClass_PhysicalAssetClassDtId",
                        column: x => x.PhysicalAssetClassDtId,
                        principalTable: "PhysicalAssetClass",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetHierarchyScopeRelRelationship_PhysicalAsset_PhysicalAssetDtId",
                        column: x => x.PhysicalAssetDtId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhysicalAssetSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalAssetSpecificationHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalAssetSpecificationHierarchyScopeRelRelationship_PhysicalAssetSpecification_PhysicalAssetSpecificationDtId",
                        column: x => x.PhysicalAssetSpecificationDtId,
                        principalTable: "PhysicalAssetSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Site_HierarchyScope_DtId",
                        column: x => x.DtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestSpecificationHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSpecificationHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_TestSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestSpecificationHierarchyScopeRelRelationship_TestSpecification_TestSpecificationDtId",
                        column: x => x.TestSpecificationDtId,
                        principalTable: "TestSpecification",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "WorkCenter",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCenter", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkCenter_HierarchyScope_DtId",
                        column: x => x.DtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkDefinitionHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkDefinitionDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDefinitionHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkDefinitionHierarchyScopeRelRelationship_WorkDefinition_WorkDefinitionDtId",
                        column: x => x.WorkDefinitionDtId,
                        principalTable: "WorkDefinition",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "WorkUnit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkUnit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkUnit_HierarchyScope_DtId",
                        column: x => x.DtId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentDefinedByRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_EquipmentDefinedByRelationship_Equipment_EquipmentDtId",
                        column: x => x.EquipmentDtId,
                        principalTable: "Equipment",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentHasValuesOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentHasValuesOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentHasValuesOfRelationship_EquipmentProperty_TargetId",
                        column: x => x.TargetId,
                        principalTable: "EquipmentProperty",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentHasValuesOfRelationship_Equipment_EquipmentDtId",
                        column: x => x.EquipmentDtId,
                        principalTable: "Equipment",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "EquipmentHierarchyScopeRelRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentHierarchyScopeRelRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentHierarchyScopeRelRelationship_Equipment_EquipmentDtId",
                        column: x => x.EquipmentDtId,
                        principalTable: "Equipment",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                        column: x => x.TargetId,
                        principalTable: "HierarchyScope",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentImplementedByRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentImplementedByRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentImplementedByRelationship_Equipment_EquipmentDtId",
                        column: x => x.EquipmentDtId,
                        principalTable: "Equipment",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentImplementedByRelationship_PhysicalAsset_TargetId",
                        column: x => x.TargetId,
                        principalTable: "PhysicalAsset",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentIsMadeUpOfRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentIsMadeUpOfRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentIsMadeUpOfRelationship_Equipment_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Equipment",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentSpecificationCorrespondsToEquipmentRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentSpecificationDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSpecificationCorrespondsToEquipmentRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationCorrespondsToEquipmentRelationship_EquipmentSpecification_EquipmentSpecificationDtId",
                        column: x => x.EquipmentSpecificationDtId,
                        principalTable: "EquipmentSpecification",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_EquipmentSpecificationCorrespondsToEquipmentRelationship_Equipment_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Equipment",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EnterpriseSiteRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "AreaWorkCenterRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_AreaWorkCenterRelationship_WorkCenter_TargetId",
                        column: x => x.TargetId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessCell",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessCell", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ProcessCell_WorkCenter_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionLine",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionLine", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ProductionLine_WorkCenter_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionUnit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionUnit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_ProductionUnit_WorkCenter_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorageZone",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageZone", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_StorageZone_WorkCenter_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StorageUnit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageUnit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_StorageUnit_WorkUnit_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkUnit",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Unit_WorkUnit_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkUnit",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkCell",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCell", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkCell_WorkUnit_DtId",
                        column: x => x.DtId,
                        principalTable: "WorkUnit",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkCenterWorkUnitRelationship",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCenterWorkUnitRelationship", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_WorkCenterWorkUnitRelationship_WorkCenter_SourceId",
                        column: x => x.SourceId,
                        principalTable: "WorkCenter",
                        principalColumn: "DtId");
                    table.ForeignKey(
                        name: "FK_WorkCenterWorkUnitRelationship_WorkUnit_TargetId",
                        column: x => x.TargetId,
                        principalTable: "WorkUnit",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaWorkCenterRelationship_SourceId",
                table: "AreaWorkCenterRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_AreaWorkCenterRelationship_TargetId",
                table: "AreaWorkCenterRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseSiteRelationship_SourceId",
                table: "EnterpriseSiteRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_EnterpriseSiteRelationship_TargetId",
                table: "EnterpriseSiteRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_ResponsibleDtId",
                table: "Equipment",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_UseDepartmentDtId",
                table: "Equipment",
                column: "UseDepartmentDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassHasPropertiesOfRelationship_EquipmentClassDtId",
                table: "EquipmentClassHasPropertiesOfRelationship",
                column: "EquipmentClassDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassHasPropertiesOfRelationship_TargetId",
                table: "EquipmentClassHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassHierarchyScopeRelRelationship_EquipmentClassDtId",
                table: "EquipmentClassHierarchyScopeRelRelationship",
                column: "EquipmentClassDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassHierarchyScopeRelRelationship_TargetId",
                table: "EquipmentClassHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassIncludesPropertiesOfRelationship_TargetId",
                table: "EquipmentClassIncludesPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassIsMadeUpOfRelationship_TargetId",
                table: "EquipmentClassIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentClassPropertyContainsRelationship_TargetId",
                table: "EquipmentClassPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentDefinedByRelationship_EquipmentDtId",
                table: "EquipmentDefinedByRelationship",
                column: "EquipmentDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentDefinedByRelationship_TargetId",
                table: "EquipmentDefinedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentHasValuesOfRelationship_EquipmentDtId",
                table: "EquipmentHasValuesOfRelationship",
                column: "EquipmentDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentHasValuesOfRelationship_TargetId",
                table: "EquipmentHasValuesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentHierarchyScopeRelRelationship_EquipmentDtId",
                table: "EquipmentHierarchyScopeRelRelationship",
                column: "EquipmentDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentHierarchyScopeRelRelationship_TargetId",
                table: "EquipmentHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentImplementedByRelationship_EquipmentDtId",
                table: "EquipmentImplementedByRelationship",
                column: "EquipmentDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentImplementedByRelationship_TargetId",
                table: "EquipmentImplementedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentIsMadeUpOfRelationship_TargetId",
                table: "EquipmentIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentPropertyContainsRelationship_TargetId",
                table: "EquipmentPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentPropertyMapsToRelationship_EquipmentPropertyDtId",
                table: "EquipmentPropertyMapsToRelationship",
                column: "EquipmentPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentPropertyMapsToRelationship_TargetId",
                table: "EquipmentPropertyMapsToRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationCorrespondsToEquipmentClassRelationship_EquipmentSpecificationDtId",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship",
                column: "EquipmentSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationCorrespondsToEquipmentClassRelationship_TargetId",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationCorrespondsToEquipmentRelationship_EquipmentSpecificationDtId",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship",
                column: "EquipmentSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationCorrespondsToEquipmentRelationship_TargetId",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationHasPropertiesOfRelationship_EquipmentSpecificationDtId",
                table: "EquipmentSpecificationHasPropertiesOfRelationship",
                column: "EquipmentSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationHasPropertiesOfRelationship_TargetId",
                table: "EquipmentSpecificationHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationHierarchyScopeRelRelationship_EquipmentSpecificationDtId",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship",
                column: "EquipmentSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationHierarchyScopeRelRelationship_TargetId",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationIsMadeUpOfRelationship_TargetId",
                table: "EquipmentSpecificationIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationOperationalLocationRelRelationship_EquipmentSpecificationDtId",
                table: "EquipmentSpecificationOperationalLocationRelRelationship",
                column: "EquipmentSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationOperationalLocationRelRelationship_TargetId",
                table: "EquipmentSpecificationOperationalLocationRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationPropertyContainsRelationship_TargetId",
                table: "EquipmentSpecificationPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationPropertyMapsToClassPropertyRelationship_EquipmentSpecificationPropertyDtId",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship",
                column: "EquipmentSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationPropertyMapsToClassPropertyRelationship_TargetId",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationPropertyMapsToPropertyRelationship_EquipmentSpecificationPropertyDtId",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship",
                column: "EquipmentSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationPropertyMapsToPropertyRelationship_TargetId",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationSpecifiesRelationship_EquipmentSpecificationDtId",
                table: "EquipmentSpecificationSpecifiesRelationship",
                column: "EquipmentSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSpecificationSpecifiesRelationship_TargetId",
                table: "EquipmentSpecificationSpecifiesRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluatedPropertyCorrespondsToRelationship_EvaluatedPropertyDtId",
                table: "EvaluatedPropertyCorrespondsToRelationship",
                column: "EvaluatedPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluatedPropertyCorrespondsToRelationship_TargetId",
                table: "EvaluatedPropertyCorrespondsToRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluatedPropertyMeasuredWithMethodOfRelationship_EvaluatedPropertyDtId",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship",
                column: "EvaluatedPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluatedPropertyMeasuredWithMethodOfRelationship_TargetId",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluatedPropertyReferencesRelationship_EvaluatedPropertyDtId",
                table: "EvaluatedPropertyReferencesRelationship",
                column: "EvaluatedPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluatedPropertyReferencesRelationship_TargetId",
                table: "EvaluatedPropertyReferencesRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScope_ResponsibleDtId",
                table: "HierarchyScope",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScopeContainsRelationship_SourceId",
                table: "HierarchyScopeContainsRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_HierarchyScopeContainsRelationship_TargetId",
                table: "HierarchyScopeContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialClassHasPropertiesOfRelationship_MaterialClassDtId",
                table: "MaterialClassHasPropertiesOfRelationship",
                column: "MaterialClassDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialClassHasPropertiesOfRelationship_TargetId",
                table: "MaterialClassHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialClassHierarchyScopeRelRelationship_MaterialClassDtId",
                table: "MaterialClassHierarchyScopeRelRelationship",
                column: "MaterialClassDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialClassHierarchyScopeRelRelationship_TargetId",
                table: "MaterialClassHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialClassIncludesPropertiesOfRelationship_TargetId",
                table: "MaterialClassIncludesPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialClassIsAssembledFromRelationship_TargetId",
                table: "MaterialClassIsAssembledFromRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialClassPropertyContainsRelationship_TargetId",
                table: "MaterialClassPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionHasPropertiesOfRelationship_MaterialDefinitionDtId",
                table: "MaterialDefinitionHasPropertiesOfRelationship",
                column: "MaterialDefinitionDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionHasPropertiesOfRelationship_TargetId",
                table: "MaterialDefinitionHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionHierarchyScopeRelRelationship_MaterialDefinitionDtId",
                table: "MaterialDefinitionHierarchyScopeRelRelationship",
                column: "MaterialDefinitionDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionHierarchyScopeRelRelationship_TargetId",
                table: "MaterialDefinitionHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionIsAssembledFromRelationship_TargetId",
                table: "MaterialDefinitionIsAssembledFromRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionIsMemberOfClassRelationship_MaterialDefinitionDtId",
                table: "MaterialDefinitionIsMemberOfClassRelationship",
                column: "MaterialDefinitionDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionIsMemberOfClassRelationship_TargetId",
                table: "MaterialDefinitionIsMemberOfClassRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionPropertyContainsRelationship_TargetId",
                table: "MaterialDefinitionPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionPropertyMapsToRelationship_MaterialDefinitionPropertyDtId",
                table: "MaterialDefinitionPropertyMapsToRelationship",
                column: "MaterialDefinitionPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialDefinitionPropertyMapsToRelationship_TargetId",
                table: "MaterialDefinitionPropertyMapsToRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotDefinedByRelationship_MaterialLotDtId",
                table: "MaterialLotDefinedByRelationship",
                column: "MaterialLotDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotDefinedByRelationship_TargetId",
                table: "MaterialLotDefinedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotHasValuesOfRelationship_MaterialLotDtId",
                table: "MaterialLotHasValuesOfRelationship",
                column: "MaterialLotDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotHasValuesOfRelationship_TargetId",
                table: "MaterialLotHasValuesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotHierarchyScopeRelRelationship_MaterialLotDtId",
                table: "MaterialLotHierarchyScopeRelRelationship",
                column: "MaterialLotDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotHierarchyScopeRelRelationship_TargetId",
                table: "MaterialLotHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotIsAssembledFromRelationship_TargetId",
                table: "MaterialLotIsAssembledFromRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotIsAssembledFromSublotRelationship_MaterialLotDtId",
                table: "MaterialLotIsAssembledFromSublotRelationship",
                column: "MaterialLotDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotIsAssembledFromSublotRelationship_TargetId",
                table: "MaterialLotIsAssembledFromSublotRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotPropertyContainsRelationship_TargetId",
                table: "MaterialLotPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotPropertyMapsToRelationship_MaterialLotPropertyDtId",
                table: "MaterialLotPropertyMapsToRelationship",
                column: "MaterialLotPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotPropertyMapsToRelationship_TargetId",
                table: "MaterialLotPropertyMapsToRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotStorageLocationRelRelationship_MaterialLotDtId",
                table: "MaterialLotStorageLocationRelRelationship",
                column: "MaterialLotDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialLotStorageLocationRelRelationship_TargetId",
                table: "MaterialLotStorageLocationRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSegmentSpecificationPropertyContainsRelationship_TargetId",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship_MaterialSegmentSpecificationPropertyDtId",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship",
                column: "MaterialSegmentSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship_TargetId",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship_MaterialSegmentSpecificationPropertyDtId",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship",
                column: "MaterialSegmentSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship_TargetId",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship_MaterialSegmentSpecificationPropertyDtId",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship",
                column: "MaterialSegmentSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship_TargetId",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationCorrespondsToClassRelationship_MaterialSpecificationDtId",
                table: "MaterialSpecificationCorrespondsToClassRelationship",
                column: "MaterialSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationCorrespondsToClassRelationship_TargetId",
                table: "MaterialSpecificationCorrespondsToClassRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationCorrespondsToDefinitionRelationship_MaterialSpecificationDtId",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship",
                column: "MaterialSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationCorrespondsToDefinitionRelationship_TargetId",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationCorrespondsToLotRelationship_MaterialSpecificationDtId",
                table: "MaterialSpecificationCorrespondsToLotRelationship",
                column: "MaterialSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationCorrespondsToLotRelationship_TargetId",
                table: "MaterialSpecificationCorrespondsToLotRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationCorrespondsToSublotRelationship_MaterialSpecificationDtId",
                table: "MaterialSpecificationCorrespondsToSublotRelationship",
                column: "MaterialSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationCorrespondsToSublotRelationship_TargetId",
                table: "MaterialSpecificationCorrespondsToSublotRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationHasPropertiesOfRelationship_MaterialSpecificationDtId",
                table: "MaterialSpecificationHasPropertiesOfRelationship",
                column: "MaterialSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationHasPropertiesOfRelationship_TargetId",
                table: "MaterialSpecificationHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationHierarchyScopeRelRelationship_MaterialSpecificationDtId",
                table: "MaterialSpecificationHierarchyScopeRelRelationship",
                column: "MaterialSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationHierarchyScopeRelRelationship_TargetId",
                table: "MaterialSpecificationHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationIsAssembledFromRelationship_TargetId",
                table: "MaterialSpecificationIsAssembledFromRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationPropertyContainsRelationship_MaterialSpecificationPropertyDtId",
                table: "MaterialSpecificationPropertyContainsRelationship",
                column: "MaterialSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationPropertyContainsRelationship_TargetId",
                table: "MaterialSpecificationPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationPropertyMapsToClassPropertyRelationship_MaterialSpecificationPropertyDtId",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship",
                column: "MaterialSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationPropertyMapsToClassPropertyRelationship_TargetId",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship_MaterialSpecificationPropertyDtId",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship",
                column: "MaterialSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship_TargetId",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationPropertyMapsToLotPropertyRelationship_MaterialSpecificationPropertyDtId",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship",
                column: "MaterialSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationPropertyMapsToLotPropertyRelationship_TargetId",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationSpecifiesRelationship_MaterialSpecificationDtId",
                table: "MaterialSpecificationSpecifiesRelationship",
                column: "MaterialSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationSpecifiesRelationship_TargetId",
                table: "MaterialSpecificationSpecifiesRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationStorageLocationRelRelationship_MaterialSpecificationDtId",
                table: "MaterialSpecificationStorageLocationRelRelationship",
                column: "MaterialSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSpecificationStorageLocationRelRelationship_TargetId",
                table: "MaterialSpecificationStorageLocationRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotHasValuesOfRelationship_MaterialSublotDtId",
                table: "MaterialSublotHasValuesOfRelationship",
                column: "MaterialSublotDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotHasValuesOfRelationship_TargetId",
                table: "MaterialSublotHasValuesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotHierarchyScopeRelRelationship_MaterialSublotDtId",
                table: "MaterialSublotHierarchyScopeRelRelationship",
                column: "MaterialSublotDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotHierarchyScopeRelRelationship_TargetId",
                table: "MaterialSublotHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotIsAssembledFromLotRelationship_MaterialSublotDtId",
                table: "MaterialSublotIsAssembledFromLotRelationship",
                column: "MaterialSublotDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotIsAssembledFromLotRelationship_TargetId",
                table: "MaterialSublotIsAssembledFromLotRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotIsAssembledFromRelationship_TargetId",
                table: "MaterialSublotIsAssembledFromRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotIsMadeUpOfRelationship_TargetId",
                table: "MaterialSublotIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotStorageLocationRelRelationship_MaterialSublotDtId",
                table: "MaterialSublotStorageLocationRelRelationship",
                column: "MaterialSublotDtId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialSublotStorageLocationRelRelationship_TargetId",
                table: "MaterialSublotStorageLocationRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassHasPropertiesOfRelationship_OperationalLocationClassDtId",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                column: "OperationalLocationClassDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassHasPropertiesOfRelationship_TargetId",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassHierarchyScopeRelRelationship_OperationalLocationClassDtId",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                column: "OperationalLocationClassDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassHierarchyScopeRelRelationship_TargetId",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassIncludesPropertiesOfRelationship_TargetId",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassIsMadeUpOfRelationship_TargetId",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationClassPropertyContainsRelationship_TargetId",
                table: "OperationalLocationClassPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationDefinedByRelationship_OperationalLocationDtId",
                table: "OperationalLocationDefinedByRelationship",
                column: "OperationalLocationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationDefinedByRelationship_TargetId",
                table: "OperationalLocationDefinedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationHasValuesOfRelationship_OperationalLocationDtId",
                table: "OperationalLocationHasValuesOfRelationship",
                column: "OperationalLocationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationHasValuesOfRelationship_TargetId",
                table: "OperationalLocationHasValuesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationHierarchyScopeRelRelationship_OperationalLocationDtId",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                column: "OperationalLocationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationHierarchyScopeRelRelationship_TargetId",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationIsMadeUpOfRelationship_TargetId",
                table: "OperationalLocationIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationPropertyContainsRelationship_TargetId",
                table: "OperationalLocationPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationPropertyMapsToRelationship_OperationalLocationPropertyDtId",
                table: "OperationalLocationPropertyMapsToRelationship",
                column: "OperationalLocationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationalLocationPropertyMapsToRelationship_TargetId",
                table: "OperationalLocationPropertyMapsToRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationsTestRequirementCorrespondsToAnElementInRelationship_OperationsTestRequirementDtId",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship",
                column: "OperationsTestRequirementDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationsTestRequirementCorrespondsToAnElementInRelationship_TargetId",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationsTestRequirementMapsToAPropertyElementInRelationship_OperationsTestRequirementDtId",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship",
                column: "OperationsTestRequirementDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationsTestRequirementMapsToAPropertyElementInRelationship_TargetId",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationsTestRequirementSpecifiesRelationship_OperationsTestRequirementDtId",
                table: "OperationsTestRequirementSpecifiesRelationship",
                column: "OperationsTestRequirementDtId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationsTestRequirementSpecifiesRelationship_TargetId",
                table: "OperationsTestRequirementSpecifiesRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterSpecificationContainsRelationship_TargetId",
                table: "ParameterSpecificationContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterSpecificationHierarchyScopeRelRelationship_ParameterSpecificationDtId",
                table: "ParameterSpecificationHierarchyScopeRelRelationship",
                column: "ParameterSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterSpecificationHierarchyScopeRelRelationship_TargetId",
                table: "ParameterSpecificationHierarchyScopeRelRelationship",
                column: "TargetId");

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
                name: "IX_PersonHierarchyScopeRelRelationship_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "PersonDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHierarchyScopeRelRelationship_TargetId",
                table: "PersonHierarchyScopeRelRelationship",
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
                name: "IX_PersonnelClassHierarchyScopeRelRelationship_SourceId",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassHierarchyScopeRelRelationship_TargetId",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassIncludesPropertiesOfRelationship_SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelClassIncludesPropertiesOfRelationship_TargetId",
                table: "PersonnelClassIncludesPropertiesOfRelationship",
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
                name: "IX_PersonnelSpecificationCorrespondsToPersonnelClassRelationship_PersonnelSpecificationDtId",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship",
                column: "PersonnelSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationCorrespondsToPersonnelClassRelationship_TargetId",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationCorrespondsToPersonRelationship_PersonnelSpecificationDtId",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                column: "PersonnelSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationCorrespondsToPersonRelationship_TargetId",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationHasPropertiesOfRelationship_PersonnelSpecificationDtId",
                table: "PersonnelSpecificationHasPropertiesOfRelationship",
                column: "PersonnelSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationHasPropertiesOfRelationship_TargetId",
                table: "PersonnelSpecificationHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationHierarchyScopeRelRelationship_PersonnelSpecificationDtId",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship",
                column: "PersonnelSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationHierarchyScopeRelRelationship_TargetId",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationIsMadeUpOfRelationship_TargetId",
                table: "PersonnelSpecificationIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationOperationalLocationRelRelationship_PersonnelSpecificationDtId",
                table: "PersonnelSpecificationOperationalLocationRelRelationship",
                column: "PersonnelSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationOperationalLocationRelRelationship_TargetId",
                table: "PersonnelSpecificationOperationalLocationRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationPropertyContainsRelationship_TargetId",
                table: "PersonnelSpecificationPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationPropertyMapsToClassPropertyRelationship_PersonnelSpecificationPropertyDtId",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship",
                column: "PersonnelSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationPropertyMapsToClassPropertyRelationship_TargetId",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationPropertyMapsToPropertyRelationship_PersonnelSpecificationPropertyDtId",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship",
                column: "PersonnelSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationPropertyMapsToPropertyRelationship_TargetId",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationSpecifiesRelationship_PersonnelSpecificationDtId",
                table: "PersonnelSpecificationSpecifiesRelationship",
                column: "PersonnelSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonnelSpecificationSpecifiesRelationship_TargetId",
                table: "PersonnelSpecificationSpecifiesRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonOperationalLocationRelRelationship_PersonDtId",
                table: "PersonOperationalLocationRelRelationship",
                column: "PersonDtId");

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

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassHasPropertiesOfRelationship_PhysicalAssetClassDtId",
                table: "PhysicalAssetClassHasPropertiesOfRelationship",
                column: "PhysicalAssetClassDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassHasPropertiesOfRelationship_TargetId",
                table: "PhysicalAssetClassHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassHierarchyScopeRelRelationship_PhysicalAssetClassDtId",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship",
                column: "PhysicalAssetClassDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassHierarchyScopeRelRelationship_TargetId",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassIncludesPropertiesOfRelationship_TargetId",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassIsMadeUpOfRelationship_TargetId",
                table: "PhysicalAssetClassIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetClassPropertyContainsRelationship_TargetId",
                table: "PhysicalAssetClassPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetDefinedByRelationship_PhysicalAssetDtId",
                table: "PhysicalAssetDefinedByRelationship",
                column: "PhysicalAssetDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetDefinedByRelationship_TargetId",
                table: "PhysicalAssetDefinedByRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetHasValuesOfRelationship_PhysicalAssetDtId",
                table: "PhysicalAssetHasValuesOfRelationship",
                column: "PhysicalAssetDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetHasValuesOfRelationship_TargetId",
                table: "PhysicalAssetHasValuesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetHierarchyScopeRelRelationship_PhysicalAssetDtId",
                table: "PhysicalAssetHierarchyScopeRelRelationship",
                column: "PhysicalAssetDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetHierarchyScopeRelRelationship_TargetId",
                table: "PhysicalAssetHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetIsMadeUpOfRelationship_TargetId",
                table: "PhysicalAssetIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetPhysicalLocationRelRelationship_PhysicalAssetDtId",
                table: "PhysicalAssetPhysicalLocationRelRelationship",
                column: "PhysicalAssetDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetPhysicalLocationRelRelationship_TargetId",
                table: "PhysicalAssetPhysicalLocationRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetPropertyContainsRelationship_TargetId",
                table: "PhysicalAssetPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetPropertyMapsToRelationship_PhysicalAssetPropertyDtId",
                table: "PhysicalAssetPropertyMapsToRelationship",
                column: "PhysicalAssetPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetPropertyMapsToRelationship_TargetId",
                table: "PhysicalAssetPropertyMapsToRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship_PhysicalAssetSpecificationDtId",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship",
                column: "PhysicalAssetSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship_TargetId",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship_PhysicalAssetSpecificationDtId",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship",
                column: "PhysicalAssetSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship_TargetId",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationHasPropertiesOfRelationship_PhysicalAssetSpecificationDtId",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship",
                column: "PhysicalAssetSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationHasPropertiesOfRelationship_TargetId",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationHierarchyScopeRelRelationship_PhysicalAssetSpecificationDtId",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                column: "PhysicalAssetSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationHierarchyScopeRelRelationship_TargetId",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationIsMadeUpOfRelationship_TargetId",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationPhysicalLocationRelRelationship_PhysicalAssetSpecificationDtId",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship",
                column: "PhysicalAssetSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationPhysicalLocationRelRelationship_TargetId",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationPropertyContainsRelationship_TargetId",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship_PhysicalAssetSpecificationPropertyDtId",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship",
                column: "PhysicalAssetSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship_TargetId",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationPropertyMapsToPropertyRelationship_PhysicalAssetSpecificationPropertyDtId",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship",
                column: "PhysicalAssetSpecificationPropertyDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationPropertyMapsToPropertyRelationship_TargetId",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationSpecifiesRelationship_PhysicalAssetSpecificationDtId",
                table: "PhysicalAssetSpecificationSpecifiesRelationship",
                column: "PhysicalAssetSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalAssetSpecificationSpecifiesRelationship_TargetId",
                table: "PhysicalAssetSpecificationSpecifiesRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteAreaRelationship_SourceId",
                table: "SiteAreaRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteAreaRelationship_TargetId",
                table: "SiteAreaRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestableObjectHasTestableObjectPropertyValuesOfRelationship_TargetId",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestableObjectHasTestableObjectPropertyValuesOfRelationship_TestableObjectDtId",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship",
                column: "TestableObjectDtId");

            migrationBuilder.CreateIndex(
                name: "IX_TestableObjectSpecifiesRelationship_TargetId",
                table: "TestableObjectSpecifiesRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestableObjectSpecifiesRelationship_TestableObjectDtId",
                table: "TestableObjectSpecifiesRelationship",
                column: "TestableObjectDtId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationCriteriaReferencesRelationship_TargetId",
                table: "TestSpecificationCriteriaReferencesRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationCriteriaReferencesRelationship_TestSpecificationCriteriaDtId",
                table: "TestSpecificationCriteriaReferencesRelationship",
                column: "TestSpecificationCriteriaDtId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationEvaluatesRelationship_TargetId",
                table: "TestSpecificationEvaluatesRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationEvaluatesRelationship_TestSpecificationDtId",
                table: "TestSpecificationEvaluatesRelationship",
                column: "TestSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationHasValuesOfRelationship_TargetId",
                table: "TestSpecificationHasValuesOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationHasValuesOfRelationship_TestSpecificationDtId",
                table: "TestSpecificationHasValuesOfRelationship",
                column: "TestSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationHierarchyScopeRelRelationship_TargetId",
                table: "TestSpecificationHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationHierarchyScopeRelRelationship_TestSpecificationDtId",
                table: "TestSpecificationHierarchyScopeRelRelationship",
                column: "TestSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationIsMadeUpOfCriteriaRelationship_TargetId",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationIsMadeUpOfCriteriaRelationship_TestSpecificationDtId",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship",
                column: "TestSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationIsMadeUpOfRelationship_TargetId",
                table: "TestSpecificationIsMadeUpOfRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationPropertyContainsRelationship_TargetId",
                table: "TestSpecificationPropertyContainsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationSpecifiesTestForObjectRelationship_TargetId",
                table: "TestSpecificationSpecifiesTestForObjectRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationSpecifiesTestForObjectRelationship_TestSpecificationDtId",
                table: "TestSpecificationSpecifiesTestForObjectRelationship",
                column: "TestSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationSpecifiesTestForOperationsRelationship_TargetId",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSpecificationSpecifiesTestForOperationsRelationship_TestSpecificationDtId",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship",
                column: "TestSpecificationDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCenterWorkUnitRelationship_SourceId",
                table: "WorkCenterWorkUnitRelationship",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCenterWorkUnitRelationship_TargetId",
                table: "WorkCenterWorkUnitRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsEquipmentRelationship_TargetId",
                table: "WorkDefinitionContainsEquipmentRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsEquipmentRelationship_WorkDefinitionDtId",
                table: "WorkDefinitionContainsEquipmentRelationship",
                column: "WorkDefinitionDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsMaterialRelationship_TargetId",
                table: "WorkDefinitionContainsMaterialRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsMaterialRelationship_WorkDefinitionDtId",
                table: "WorkDefinitionContainsMaterialRelationship",
                column: "WorkDefinitionDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsParameterRelationship_TargetId",
                table: "WorkDefinitionContainsParameterRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsParameterRelationship_WorkDefinitionDtId",
                table: "WorkDefinitionContainsParameterRelationship",
                column: "WorkDefinitionDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsPersonnelRelationship_TargetId",
                table: "WorkDefinitionContainsPersonnelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsPersonnelRelationship_WorkDefinitionDtId",
                table: "WorkDefinitionContainsPersonnelRelationship",
                column: "WorkDefinitionDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsPhysicalAssetRelationship_TargetId",
                table: "WorkDefinitionContainsPhysicalAssetRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionContainsPhysicalAssetRelationship_WorkDefinitionDtId",
                table: "WorkDefinitionContainsPhysicalAssetRelationship",
                column: "WorkDefinitionDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionHierarchyScopeRelRelationship_TargetId",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDefinitionHierarchyScopeRelRelationship_WorkDefinitionDtId",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                column: "WorkDefinitionDtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaWorkCenterRelationship");

            migrationBuilder.DropTable(
                name: "EnterpriseSiteRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentClassHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentClassHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentClassIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentClassPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentImplementedByRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentPropertyMapsToRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationCorrespondsToEquipmentRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationSpecifiesRelationship");

            migrationBuilder.DropTable(
                name: "EvaluatedPropertyCorrespondsToRelationship");

            migrationBuilder.DropTable(
                name: "EvaluatedPropertyMeasuredWithMethodOfRelationship");

            migrationBuilder.DropTable(
                name: "EvaluatedPropertyReferencesRelationship");

            migrationBuilder.DropTable(
                name: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropTable(
                name: "MaterialClassHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "MaterialClassHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "MaterialClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "MaterialClassIsAssembledFromRelationship");

            migrationBuilder.DropTable(
                name: "MaterialClassPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "MaterialDefinitionHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "MaterialDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "MaterialDefinitionIsAssembledFromRelationship");

            migrationBuilder.DropTable(
                name: "MaterialDefinitionIsMemberOfClassRelationship");

            migrationBuilder.DropTable(
                name: "MaterialDefinitionPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "MaterialDefinitionPropertyMapsToRelationship");

            migrationBuilder.DropTable(
                name: "MaterialLotDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "MaterialLotHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "MaterialLotHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "MaterialLotIsAssembledFromRelationship");

            migrationBuilder.DropTable(
                name: "MaterialLotIsAssembledFromSublotRelationship");

            migrationBuilder.DropTable(
                name: "MaterialLotPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "MaterialLotPropertyMapsToRelationship");

            migrationBuilder.DropTable(
                name: "MaterialLotStorageLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSegmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationCorrespondsToClassRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationCorrespondsToDefinitionRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationCorrespondsToLotRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationCorrespondsToSublotRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationIsAssembledFromRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationSpecifiesRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationStorageLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSublotHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSublotHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSublotIsAssembledFromLotRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSublotIsAssembledFromRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSublotIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "MaterialSublotStorageLocationRelRelationship");

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
                name: "OperationsTestRequirementCorrespondsToAnElementInRelationship");

            migrationBuilder.DropTable(
                name: "OperationsTestRequirementMapsToAPropertyElementInRelationship");

            migrationBuilder.DropTable(
                name: "OperationsTestRequirementSpecifiesRelationship");

            migrationBuilder.DropTable(
                name: "ParameterSpecificationContainsRelationship");

            migrationBuilder.DropTable(
                name: "ParameterSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "PersonDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "PersonHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelClassHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelClassPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationCorrespondsToPersonRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationSpecifiesRelationship");

            migrationBuilder.DropTable(
                name: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "PersonPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PersonPropertyMapsToRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetDefinedByRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetPhysicalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetPropertyMapsToRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationPhysicalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationSpecifiesRelationship");

            migrationBuilder.DropTable(
                name: "ProcessCell");

            migrationBuilder.DropTable(
                name: "ProductionLine");

            migrationBuilder.DropTable(
                name: "ProductionUnit");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SiteAreaRelationship");

            migrationBuilder.DropTable(
                name: "StorageUnit");

            migrationBuilder.DropTable(
                name: "StorageZone");

            migrationBuilder.DropTable(
                name: "TestableObjectHasTestableObjectPropertyValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "TestableObjectSpecifiesRelationship");

            migrationBuilder.DropTable(
                name: "TestSpecificationCriteriaReferencesRelationship");

            migrationBuilder.DropTable(
                name: "TestSpecificationEvaluatesRelationship");

            migrationBuilder.DropTable(
                name: "TestSpecificationHasValuesOfRelationship");

            migrationBuilder.DropTable(
                name: "TestSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "TestSpecificationIsMadeUpOfCriteriaRelationship");

            migrationBuilder.DropTable(
                name: "TestSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropTable(
                name: "TestSpecificationPropertyContainsRelationship");

            migrationBuilder.DropTable(
                name: "TestSpecificationSpecifiesTestForObjectRelationship");

            migrationBuilder.DropTable(
                name: "TestSpecificationSpecifiesTestForOperationsRelationship");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "WorkCell");

            migrationBuilder.DropTable(
                name: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropTable(
                name: "WorkDefinitionContainsEquipmentRelationship");

            migrationBuilder.DropTable(
                name: "WorkDefinitionContainsMaterialRelationship");

            migrationBuilder.DropTable(
                name: "WorkDefinitionContainsParameterRelationship");

            migrationBuilder.DropTable(
                name: "WorkDefinitionContainsPersonnelRelationship");

            migrationBuilder.DropTable(
                name: "WorkDefinitionContainsPhysicalAssetRelationship");

            migrationBuilder.DropTable(
                name: "WorkDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropTable(
                name: "Enterprise");

            migrationBuilder.DropTable(
                name: "EquipmentClass");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "EquipmentClassProperty");

            migrationBuilder.DropTable(
                name: "EquipmentProperty");

            migrationBuilder.DropTable(
                name: "EquipmentSpecificationProperty");

            migrationBuilder.DropTable(
                name: "MaterialClass");

            migrationBuilder.DropTable(
                name: "MaterialDefinition");

            migrationBuilder.DropTable(
                name: "MaterialSegmentSpecificationProperty");

            migrationBuilder.DropTable(
                name: "MaterialClassProperty");

            migrationBuilder.DropTable(
                name: "MaterialDefinitionProperty");

            migrationBuilder.DropTable(
                name: "MaterialSpecificationProperty");

            migrationBuilder.DropTable(
                name: "MaterialLotProperty");

            migrationBuilder.DropTable(
                name: "MaterialLot");

            migrationBuilder.DropTable(
                name: "MaterialSublot");

            migrationBuilder.DropTable(
                name: "OperationalLocationClass");

            migrationBuilder.DropTable(
                name: "OperationalLocationClassProperty");

            migrationBuilder.DropTable(
                name: "OperationalLocationProperty");

            migrationBuilder.DropTable(
                name: "PersonnelSpecificationProperty");

            migrationBuilder.DropTable(
                name: "PersonProperty");

            migrationBuilder.DropTable(
                name: "PersonnelClassProperty");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClass");

            migrationBuilder.DropTable(
                name: "PhysicalAsset");

            migrationBuilder.DropTable(
                name: "OperationalLocation");

            migrationBuilder.DropTable(
                name: "PhysicalAssetClassProperty");

            migrationBuilder.DropTable(
                name: "PhysicalAssetProperty");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecificationProperty");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "TestableObjectProperty");

            migrationBuilder.DropTable(
                name: "EvaluatedProperty");

            migrationBuilder.DropTable(
                name: "TestSpecificationCriteria");

            migrationBuilder.DropTable(
                name: "TestSpecificationProperty");

            migrationBuilder.DropTable(
                name: "TestableObject");

            migrationBuilder.DropTable(
                name: "OperationsTestRequirement");

            migrationBuilder.DropTable(
                name: "TestSpecification");

            migrationBuilder.DropTable(
                name: "WorkCenter");

            migrationBuilder.DropTable(
                name: "WorkUnit");

            migrationBuilder.DropTable(
                name: "EquipmentSpecification");

            migrationBuilder.DropTable(
                name: "MaterialSpecification");

            migrationBuilder.DropTable(
                name: "ParameterSpecification");

            migrationBuilder.DropTable(
                name: "PersonnelSpecification");

            migrationBuilder.DropTable(
                name: "PhysicalAssetSpecification");

            migrationBuilder.DropTable(
                name: "WorkDefinition");

            migrationBuilder.DropTable(
                name: "PersonnelClasses");

            migrationBuilder.DropTable(
                name: "HierarchyScope");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
