using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_PersonDefinedByRelationship_PersonnelClassIncludesPropertiesOfRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Area_HierarchyScope_DtId",
                table: "Area");

            migrationBuilder.DropForeignKey(
                name: "FK_AreaWorkCenterRelationship_WorkCenter_TargetId",
                table: "AreaWorkCenterRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_Enterprise_HierarchyScope_DtId",
                table: "Enterprise");

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
                name: "FK_PersonDefinedByRelationship_Person_SourceId",
                table: "PersonDefinedByRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonDefinedByRelationship_PersonnelClasses_TargetId",
                table: "PersonDefinedByRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelClassHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelClassIncludesPropertiesOfRelationship_PersonnelClasses_SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelClassIncludesPropertiesOfRelationship_PersonnelClasses_TargetId",
                table: "PersonnelClassIncludesPropertiesOfRelationship");

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
                name: "FK_ProcessCell_WorkCenter_DtId",
                table: "ProcessCell");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionLine_WorkCenter_DtId",
                table: "ProductionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionUnit_WorkCenter_DtId",
                table: "ProductionUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_Site_HierarchyScope_DtId",
                table: "Site");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageUnit_WorkUnit_DtId",
                table: "StorageUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageZone_WorkCenter_DtId",
                table: "StorageZone");

            migrationBuilder.DropForeignKey(
                name: "FK_TestSpecificationHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "TestSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_WorkUnit_DtId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkCell_WorkUnit_DtId",
                table: "WorkCell");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkCenter_HierarchyScope_DtId",
                table: "WorkCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkCenterWorkUnitRelationship_WorkCenter_SourceId",
                table: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkCenterWorkUnitRelationship_WorkUnit_TargetId",
                table: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkDefinitionHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "WorkDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkUnit_HierarchyScope_DtId",
                table: "WorkUnit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonnelClassIncludesPropertiesOfRelationship",
                table: "PersonnelClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonDefinedByRelationship",
                table: "PersonDefinedByRelationship");

            migrationBuilder.RenameTable(
                name: "PersonnelClassIncludesPropertiesOfRelationship",
                newName: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.RenameTable(
                name: "PersonDefinedByRelationship",
                newName: "PersonDefinedByRelationships");

            migrationBuilder.RenameIndex(
                name: "IX_PersonnelClassIncludesPropertiesOfRelationship_TargetId",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                newName: "IX_PersonnelClassIncludesPropertiesOfRelationships_TargetId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonnelClassIncludesPropertiesOfRelationship_SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                newName: "IX_PersonnelClassIncludesPropertiesOfRelationships_SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonDefinedByRelationship_TargetId",
                table: "PersonDefinedByRelationships",
                newName: "IX_PersonDefinedByRelationships_TargetId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonDefinedByRelationship_SourceId",
                table: "PersonDefinedByRelationships",
                newName: "IX_PersonDefinedByRelationships_SourceId");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "WorkUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkUnit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkUnit",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "WorkUnit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "WorkUnit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "WorkUnit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkUnit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkUnit",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "WorkUnit",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkDefinitionContainsPhysicalAssetRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkDefinitionContainsPhysicalAssetRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkDefinitionContainsPhysicalAssetRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkDefinitionContainsPhysicalAssetRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkDefinitionContainsPhysicalAssetRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsPhysicalAssetRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkDefinitionContainsPersonnelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkDefinitionContainsPersonnelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkDefinitionContainsPersonnelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkDefinitionContainsPersonnelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkDefinitionContainsPersonnelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsPersonnelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkDefinitionContainsParameterRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkDefinitionContainsParameterRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkDefinitionContainsParameterRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkDefinitionContainsParameterRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkDefinitionContainsParameterRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsParameterRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkDefinitionContainsMaterialRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkDefinitionContainsMaterialRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkDefinitionContainsMaterialRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkDefinitionContainsMaterialRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkDefinitionContainsMaterialRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsMaterialRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkDefinitionContainsEquipmentRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkDefinitionContainsEquipmentRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkDefinitionContainsEquipmentRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkDefinitionContainsEquipmentRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkDefinitionContainsEquipmentRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsEquipmentRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkCenterWorkUnitRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkCenterWorkUnitRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkCenterWorkUnitRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkCenterWorkUnitRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkCenterWorkUnitRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkCenterWorkUnitRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "WorkCenter",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkCenter",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkCenter",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "WorkCenter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "WorkCenter",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "WorkCenter",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkCenter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkCenter",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkCenter",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkCenter",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "WorkCenter",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "WorkCell",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "WorkCell",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "WorkCell",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "WorkCell",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "WorkCell",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "WorkCell",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "WorkCell",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "WorkCell",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "WorkCell",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "WorkCell",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "WorkCell",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Unit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Unit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Unit",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Unit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "Unit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "Unit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Unit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Unit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Unit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "Unit",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "Unit",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestSpecificationSpecifiesTestForObjectRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestSpecificationSpecifiesTestForObjectRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestSpecificationSpecifiesTestForObjectRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestSpecificationSpecifiesTestForObjectRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestSpecificationSpecifiesTestForObjectRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestSpecificationSpecifiesTestForObjectRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestSpecificationPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestSpecificationPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestSpecificationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestSpecificationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestSpecificationIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestSpecificationIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestSpecificationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestSpecificationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestSpecificationHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestSpecificationHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestSpecificationHasValuesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestSpecificationHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestSpecificationHasValuesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestSpecificationHasValuesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestSpecificationHasValuesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestSpecificationHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestSpecificationEvaluatesRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestSpecificationEvaluatesRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestSpecificationEvaluatesRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestSpecificationEvaluatesRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestSpecificationEvaluatesRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestSpecificationEvaluatesRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestSpecificationCriteriaReferencesRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestSpecificationCriteriaReferencesRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestSpecificationCriteriaReferencesRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestSpecificationCriteriaReferencesRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestSpecificationCriteriaReferencesRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestSpecificationCriteriaReferencesRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestableObjectSpecifiesRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestableObjectSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestableObjectSpecifiesRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestableObjectSpecifiesRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestableObjectSpecifiesRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestableObjectSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "StorageZone",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "StorageZone",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "StorageZone",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "StorageZone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "StorageZone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "StorageZone",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "StorageZone",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "StorageZone",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "StorageZone",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "StorageZone",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "StorageZone",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "StorageUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "StorageUnit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "StorageUnit",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "StorageUnit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "StorageUnit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "StorageUnit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "StorageUnit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "StorageUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "StorageUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "StorageUnit",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "StorageUnit",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "SiteAreaRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "SiteAreaRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "SiteAreaRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "SiteAreaRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "SiteAreaRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "SiteAreaRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Site",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Site",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Site",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Site",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "Site",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "Site",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Site",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Site",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Site",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "Site",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "Site",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ProductionUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ProductionUnit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "ProductionUnit",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductionUnit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "ProductionUnit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "ProductionUnit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ProductionUnit",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ProductionUnit",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ProductionUnit",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "ProductionUnit",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "ProductionUnit",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ProductionLine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ProductionLine",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "ProductionLine",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductionLine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "ProductionLine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "ProductionLine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ProductionLine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ProductionLine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ProductionLine",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "ProductionLine",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "ProductionLine",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "ProcessCell",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ProcessCell",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "ProcessCell",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProcessCell",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "ProcessCell",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "ProcessCell",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ProcessCell",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ProcessCell",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ProcessCell",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "ProcessCell",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "ProcessCell",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationSpecifiesRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationSpecifiesRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationSpecifiesRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationSpecifiesRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetPropertyMapsToRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetPropertyMapsToRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetPropertyMapsToRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetPropertyMapsToRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetPhysicalLocationRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetPhysicalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetPhysicalLocationRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetPhysicalLocationRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetPhysicalLocationRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetPhysicalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetHasValuesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetHasValuesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetHasValuesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetHasValuesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetDefinedByRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetDefinedByRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetDefinedByRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetDefinedByRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetClassPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetClassPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetClassIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetClassIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetClassIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetClassIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetClassIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PhysicalAssetClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PhysicalAssetClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PhysicalAssetClassHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PhysicalAssetClassHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PhysicalAssetClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonPropertyMapsToRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonPropertyMapsToRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonPropertyMapsToRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonPropertyMapsToRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonOperationalLocationRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonOperationalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonOperationalLocationRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonOperationalLocationRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonOperationalLocationRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonOperationalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationSpecifiesRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationSpecifiesRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationSpecifiesRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationSpecifiesRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationOperationalLocationRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationOperationalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationOperationalLocationRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationOperationalLocationRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationOperationalLocationRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationOperationalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelClassPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelClassPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelClassHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelClassHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonHasValuesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonHasValuesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonHasValuesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonHasValuesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ParameterSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "ParameterSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ParameterSpecificationHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ParameterSpecificationHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ParameterSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "ParameterSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ParameterSpecificationContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "ParameterSpecificationContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ParameterSpecificationContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "ParameterSpecificationContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ParameterSpecificationContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "ParameterSpecificationContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationsTestRequirementSpecifiesRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationsTestRequirementSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationsTestRequirementSpecifiesRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationsTestRequirementSpecifiesRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationsTestRequirementSpecifiesRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationsTestRequirementSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationPropertyMapsToRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationPropertyMapsToRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationPropertyMapsToRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationPropertyMapsToRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationHasValuesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationHasValuesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationHasValuesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationHasValuesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationDefinedByRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationDefinedByRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationDefinedByRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationDefinedByRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationClassPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationClassPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationClassIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "OperationalLocationClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSublotStorageLocationRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSublotStorageLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSublotStorageLocationRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSublotStorageLocationRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSublotStorageLocationRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSublotStorageLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSublotIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSublotIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSublotIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSublotIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSublotIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSublotIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSublotIsAssembledFromRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSublotIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSublotIsAssembledFromRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSublotIsAssembledFromRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSublotIsAssembledFromRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSublotIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSublotIsAssembledFromLotRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSublotIsAssembledFromLotRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSublotIsAssembledFromLotRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSublotIsAssembledFromLotRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSublotIsAssembledFromLotRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSublotIsAssembledFromLotRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSublotHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSublotHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSublotHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSublotHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSublotHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSublotHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSublotHasValuesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSublotHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSublotHasValuesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSublotHasValuesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSublotHasValuesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSublotHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationStorageLocationRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationStorageLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationStorageLocationRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationStorageLocationRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationStorageLocationRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationStorageLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationSpecifiesRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationSpecifiesRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationSpecifiesRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationSpecifiesRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationIsAssembledFromRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationIsAssembledFromRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationIsAssembledFromRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationIsAssembledFromRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationCorrespondsToSublotRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationCorrespondsToSublotRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationCorrespondsToSublotRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationCorrespondsToSublotRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationCorrespondsToSublotRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationCorrespondsToSublotRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationCorrespondsToLotRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationCorrespondsToLotRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationCorrespondsToLotRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationCorrespondsToLotRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationCorrespondsToLotRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationCorrespondsToLotRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSpecificationCorrespondsToClassRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSpecificationCorrespondsToClassRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSpecificationCorrespondsToClassRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSpecificationCorrespondsToClassRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSpecificationCorrespondsToClassRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSpecificationCorrespondsToClassRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialLotStorageLocationRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialLotStorageLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialLotStorageLocationRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialLotStorageLocationRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialLotStorageLocationRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialLotStorageLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialLotPropertyMapsToRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialLotPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialLotPropertyMapsToRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialLotPropertyMapsToRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialLotPropertyMapsToRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialLotPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialLotPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialLotPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialLotPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialLotPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialLotPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialLotPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialLotIsAssembledFromSublotRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialLotIsAssembledFromSublotRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialLotIsAssembledFromSublotRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialLotIsAssembledFromSublotRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialLotIsAssembledFromSublotRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialLotIsAssembledFromSublotRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialLotIsAssembledFromRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialLotIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialLotIsAssembledFromRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialLotIsAssembledFromRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialLotIsAssembledFromRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialLotIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialLotHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialLotHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialLotHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialLotHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialLotHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialLotHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialLotHasValuesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialLotHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialLotHasValuesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialLotHasValuesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialLotHasValuesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialLotHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialLotDefinedByRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialLotDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialLotDefinedByRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialLotDefinedByRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialLotDefinedByRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialLotDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialDefinitionPropertyMapsToRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialDefinitionPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialDefinitionPropertyMapsToRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialDefinitionPropertyMapsToRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialDefinitionPropertyMapsToRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialDefinitionPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialDefinitionPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialDefinitionPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialDefinitionPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialDefinitionPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialDefinitionPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialDefinitionPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialDefinitionIsMemberOfClassRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialDefinitionIsMemberOfClassRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialDefinitionIsMemberOfClassRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialDefinitionIsMemberOfClassRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialDefinitionIsMemberOfClassRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialDefinitionIsMemberOfClassRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialDefinitionIsAssembledFromRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialDefinitionIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialDefinitionIsAssembledFromRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialDefinitionIsAssembledFromRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialDefinitionIsAssembledFromRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialDefinitionIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialDefinitionHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialDefinitionHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialDefinitionHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialDefinitionHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialDefinitionHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialDefinitionHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialDefinitionHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialDefinitionHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialDefinitionHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialDefinitionHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialDefinitionHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialDefinitionHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialClassPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialClassPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialClassIsAssembledFromRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialClassIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialClassIsAssembledFromRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialClassIsAssembledFromRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialClassIsAssembledFromRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialClassIsAssembledFromRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialClassIncludesPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialClassIncludesPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialClassIncludesPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialClassIncludesPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialClassHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialClassHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "MaterialClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "MaterialClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MaterialClassHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "MaterialClassHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "MaterialClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "MaterialClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "HierarchyScopeContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "HierarchyScopeContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "HierarchyScopeContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "HierarchyScopeContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "HierarchyScopeContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "HierarchyScopeContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EvaluatedPropertyReferencesRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EvaluatedPropertyReferencesRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EvaluatedPropertyReferencesRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EvaluatedPropertyReferencesRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EvaluatedPropertyReferencesRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EvaluatedPropertyReferencesRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EvaluatedPropertyCorrespondsToRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EvaluatedPropertyCorrespondsToRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EvaluatedPropertyCorrespondsToRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EvaluatedPropertyCorrespondsToRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EvaluatedPropertyCorrespondsToRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EvaluatedPropertyCorrespondsToRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationSpecifiesRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationSpecifiesRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationSpecifiesRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationSpecifiesRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationSpecifiesRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationOperationalLocationRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationOperationalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationOperationalLocationRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationOperationalLocationRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationOperationalLocationRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationOperationalLocationRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentPropertyMapsToRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentPropertyMapsToRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentPropertyMapsToRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentPropertyMapsToRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentPropertyMapsToRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentImplementedByRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentImplementedByRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentImplementedByRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentImplementedByRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentImplementedByRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentImplementedByRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentHasValuesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentHasValuesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentHasValuesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentHasValuesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentHasValuesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentDefinedByRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentDefinedByRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentDefinedByRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentDefinedByRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentDefinedByRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentClassPropertyContainsRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentClassPropertyContainsRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentClassPropertyContainsRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentClassPropertyContainsRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentClassIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentClassIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentClassIsMadeUpOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentClassIsMadeUpOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentClassIsMadeUpOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentClassIsMadeUpOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentClassIncludesPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentClassIncludesPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentClassIncludesPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentClassIncludesPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentClassIncludesPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentClassHierarchyScopeRelRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentClassHierarchyScopeRelRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentClassHierarchyScopeRelRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentClassHierarchyScopeRelRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EquipmentClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EquipmentClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EquipmentClassHasPropertiesOfRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EquipmentClassHasPropertiesOfRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EquipmentClassHasPropertiesOfRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EquipmentClassHasPropertiesOfRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "EnterpriseSiteRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "EnterpriseSiteRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "EnterpriseSiteRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "EnterpriseSiteRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "EnterpriseSiteRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "EnterpriseSiteRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Enterprise",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Enterprise",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Enterprise",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Enterprise",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "Enterprise",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "Enterprise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Enterprise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Enterprise",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Enterprise",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "Enterprise",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "Enterprise",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AreaWorkCenterRelationship",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "AreaWorkCenterRelationship",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "AreaWorkCenterRelationship",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "AreaWorkCenterRelationship",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "AreaWorkCenterRelationship",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "AreaWorkCenterRelationship",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Area",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Area",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Area",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Area",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "Area",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentLevel",
                table: "Area",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Area",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Area",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Area",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "Area",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ResponsibleDtId",
                table: "Area",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PersonDefinedByRelationships",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "PersonDefinedByRelationships",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonDefinedByRelationships",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "PersonDefinedByRelationships",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PersonDefinedByRelationships",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "PersonDefinedByRelationships",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonnelClassIncludesPropertiesOfRelationships",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                column: "DtId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonDefinedByRelationships",
                table: "PersonDefinedByRelationships",
                column: "DtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkUnit_ResponsibleDtId",
                table: "WorkUnit",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCenter_ResponsibleDtId",
                table: "WorkCenter",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCell_ResponsibleDtId",
                table: "WorkCell",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_ResponsibleDtId",
                table: "Unit",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageZone_ResponsibleDtId",
                table: "StorageZone",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageUnit_ResponsibleDtId",
                table: "StorageUnit",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Site_ResponsibleDtId",
                table: "Site",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionUnit_ResponsibleDtId",
                table: "ProductionUnit",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionLine_ResponsibleDtId",
                table: "ProductionLine",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessCell_ResponsibleDtId",
                table: "ProcessCell",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprise_ResponsibleDtId",
                table: "Enterprise",
                column: "ResponsibleDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Area_ResponsibleDtId",
                table: "Area",
                column: "ResponsibleDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Area_Person_ResponsibleDtId",
                table: "Area",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enterprise_Person_ResponsibleDtId",
                table: "Enterprise",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

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
                name: "FK_PersonnelClassIncludesPropertiesOfRelationships_PersonnelClasses_SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                column: "SourceId",
                principalTable: "PersonnelClasses",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelClassIncludesPropertiesOfRelationships_PersonnelClasses_TargetId",
                table: "PersonnelClassIncludesPropertiesOfRelationships",
                column: "TargetId",
                principalTable: "PersonnelClasses",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProcessCell_Person_ResponsibleDtId",
                table: "ProcessCell",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionLine_Person_ResponsibleDtId",
                table: "ProductionLine",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionUnit_Person_ResponsibleDtId",
                table: "ProductionUnit",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Site_Person_ResponsibleDtId",
                table: "Site",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageUnit_Person_ResponsibleDtId",
                table: "StorageUnit",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_StorageZone_Person_ResponsibleDtId",
                table: "StorageZone",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Unit_Person_ResponsibleDtId",
                table: "Unit",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkCell_Person_ResponsibleDtId",
                table: "WorkCell",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkCenter_Person_ResponsibleDtId",
                table: "WorkCenter",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkUnit_Person_ResponsibleDtId",
                table: "WorkUnit",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Area_Person_ResponsibleDtId",
                table: "Area");

            migrationBuilder.DropForeignKey(
                name: "FK_Enterprise_Person_ResponsibleDtId",
                table: "Enterprise");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonDefinedByRelationships_Person_SourceId",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonDefinedByRelationships_PersonnelClasses_TargetId",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelClassIncludesPropertiesOfRelationships_PersonnelClasses_SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelClassIncludesPropertiesOfRelationships_PersonnelClasses_TargetId",
                table: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropForeignKey(
                name: "FK_ProcessCell_Person_ResponsibleDtId",
                table: "ProcessCell");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionLine_Person_ResponsibleDtId",
                table: "ProductionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductionUnit_Person_ResponsibleDtId",
                table: "ProductionUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_Site_Person_ResponsibleDtId",
                table: "Site");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageUnit_Person_ResponsibleDtId",
                table: "StorageUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageZone_Person_ResponsibleDtId",
                table: "StorageZone");

            migrationBuilder.DropForeignKey(
                name: "FK_Unit_Person_ResponsibleDtId",
                table: "Unit");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkCell_Person_ResponsibleDtId",
                table: "WorkCell");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkCenter_Person_ResponsibleDtId",
                table: "WorkCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkUnit_Person_ResponsibleDtId",
                table: "WorkUnit");

            migrationBuilder.DropIndex(
                name: "IX_WorkUnit_ResponsibleDtId",
                table: "WorkUnit");

            migrationBuilder.DropIndex(
                name: "IX_WorkCenter_ResponsibleDtId",
                table: "WorkCenter");

            migrationBuilder.DropIndex(
                name: "IX_WorkCell_ResponsibleDtId",
                table: "WorkCell");

            migrationBuilder.DropIndex(
                name: "IX_Unit_ResponsibleDtId",
                table: "Unit");

            migrationBuilder.DropIndex(
                name: "IX_StorageZone_ResponsibleDtId",
                table: "StorageZone");

            migrationBuilder.DropIndex(
                name: "IX_StorageUnit_ResponsibleDtId",
                table: "StorageUnit");

            migrationBuilder.DropIndex(
                name: "IX_Site_ResponsibleDtId",
                table: "Site");

            migrationBuilder.DropIndex(
                name: "IX_ProductionUnit_ResponsibleDtId",
                table: "ProductionUnit");

            migrationBuilder.DropIndex(
                name: "IX_ProductionLine_ResponsibleDtId",
                table: "ProductionLine");

            migrationBuilder.DropIndex(
                name: "IX_ProcessCell_ResponsibleDtId",
                table: "ProcessCell");

            migrationBuilder.DropIndex(
                name: "IX_Enterprise_ResponsibleDtId",
                table: "Enterprise");

            migrationBuilder.DropIndex(
                name: "IX_Area_ResponsibleDtId",
                table: "Area");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonnelClassIncludesPropertiesOfRelationships",
                table: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonDefinedByRelationships",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "WorkUnit");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkDefinitionContainsPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkDefinitionContainsPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkDefinitionContainsPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkDefinitionContainsPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkDefinitionContainsPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkDefinitionContainsPersonnelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkDefinitionContainsPersonnelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkDefinitionContainsPersonnelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkDefinitionContainsPersonnelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkDefinitionContainsPersonnelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsPersonnelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkDefinitionContainsParameterRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkDefinitionContainsParameterRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkDefinitionContainsParameterRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkDefinitionContainsParameterRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkDefinitionContainsParameterRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsParameterRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkDefinitionContainsMaterialRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkDefinitionContainsMaterialRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkDefinitionContainsMaterialRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkDefinitionContainsMaterialRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkDefinitionContainsMaterialRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsMaterialRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkDefinitionContainsEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkDefinitionContainsEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkDefinitionContainsEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkDefinitionContainsEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkDefinitionContainsEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkDefinitionContainsEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkCenterWorkUnitRelationship");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "WorkCenter");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "Unit");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestSpecificationSpecifiesTestForOperationsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestSpecificationSpecifiesTestForObjectRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestSpecificationSpecifiesTestForObjectRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestSpecificationSpecifiesTestForObjectRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestSpecificationSpecifiesTestForObjectRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestSpecificationSpecifiesTestForObjectRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestSpecificationSpecifiesTestForObjectRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestSpecificationIsMadeUpOfCriteriaRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestSpecificationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestSpecificationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestSpecificationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestSpecificationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestSpecificationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestSpecificationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestSpecificationEvaluatesRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestSpecificationEvaluatesRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestSpecificationEvaluatesRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestSpecificationEvaluatesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestSpecificationEvaluatesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestSpecificationEvaluatesRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestSpecificationCriteriaReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestSpecificationCriteriaReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestSpecificationCriteriaReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestSpecificationCriteriaReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestSpecificationCriteriaReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestSpecificationCriteriaReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestableObjectSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestableObjectSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestableObjectSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestableObjectSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestableObjectSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestableObjectSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TestableObjectHasTestableObjectPropertyValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "StorageZone");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "StorageUnit");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "SiteAreaRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SiteAreaRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SiteAreaRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "SiteAreaRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "SiteAreaRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "SiteAreaRelationship");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "ProductionUnit");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "ProductionLine");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "ProcessCell");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetSpecificationCorrespondsToPhysicalAssetClassRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetPhysicalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PhysicalAssetClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PhysicalAssetClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PhysicalAssetClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PhysicalAssetClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PhysicalAssetClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PhysicalAssetClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelSpecificationCorrespondsToPersonnelClassRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ParameterSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ParameterSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ParameterSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ParameterSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ParameterSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ParameterSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ParameterSpecificationContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ParameterSpecificationContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ParameterSpecificationContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "ParameterSpecificationContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ParameterSpecificationContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ParameterSpecificationContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationsTestRequirementSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationsTestRequirementSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationsTestRequirementSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationsTestRequirementSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationsTestRequirementSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationsTestRequirementSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationsTestRequirementMapsToAPropertyElementInRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationsTestRequirementCorrespondsToAnElementInRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "OperationalLocationClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OperationalLocationClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OperationalLocationClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "OperationalLocationClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "OperationalLocationClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "OperationalLocationClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSublotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSublotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSublotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSublotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSublotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSublotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSublotIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSublotIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSublotIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSublotIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSublotIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSublotIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSublotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSublotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSublotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSublotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSublotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSublotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSublotIsAssembledFromLotRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSublotIsAssembledFromLotRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSublotIsAssembledFromLotRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSublotIsAssembledFromLotRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSublotIsAssembledFromLotRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSublotIsAssembledFromLotRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSublotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSublotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSublotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSublotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSublotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSublotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSublotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSublotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSublotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSublotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSublotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSublotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationCorrespondsToSublotRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationCorrespondsToSublotRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationCorrespondsToSublotRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationCorrespondsToSublotRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationCorrespondsToSublotRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationCorrespondsToSublotRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationCorrespondsToLotRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationCorrespondsToLotRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationCorrespondsToLotRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationCorrespondsToLotRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationCorrespondsToLotRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationCorrespondsToLotRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationCorrespondsToDefinitionRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSpecificationCorrespondsToClassRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSpecificationCorrespondsToClassRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSpecificationCorrespondsToClassRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSpecificationCorrespondsToClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSpecificationCorrespondsToClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSpecificationCorrespondsToClassRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToLotPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToDefinitionPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSegmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialSegmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialLotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialLotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialLotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialLotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialLotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialLotStorageLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialLotPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialLotPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialLotPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialLotPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialLotPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialLotPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialLotPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialLotPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialLotPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialLotPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialLotPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialLotPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialLotIsAssembledFromSublotRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialLotIsAssembledFromSublotRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialLotIsAssembledFromSublotRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialLotIsAssembledFromSublotRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialLotIsAssembledFromSublotRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialLotIsAssembledFromSublotRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialLotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialLotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialLotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialLotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialLotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialLotIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialLotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialLotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialLotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialLotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialLotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialLotHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialLotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialLotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialLotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialLotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialLotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialLotHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialLotDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialLotDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialLotDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialLotDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialLotDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialLotDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialDefinitionPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialDefinitionPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialDefinitionPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialDefinitionPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialDefinitionPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialDefinitionPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialDefinitionPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialDefinitionPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialDefinitionPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialDefinitionPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialDefinitionPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialDefinitionPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialDefinitionIsMemberOfClassRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialDefinitionIsMemberOfClassRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialDefinitionIsMemberOfClassRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialDefinitionIsMemberOfClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialDefinitionIsMemberOfClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialDefinitionIsMemberOfClassRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialDefinitionIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialDefinitionIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialDefinitionIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialDefinitionIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialDefinitionIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialDefinitionIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialDefinitionHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialDefinitionHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialDefinitionHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialDefinitionHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialDefinitionHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialDefinitionHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialDefinitionHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialClassIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialClassIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialClassIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialClassIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialClassIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialClassIsAssembledFromRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "MaterialClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MaterialClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MaterialClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "MaterialClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "MaterialClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "MaterialClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "HierarchyScopeContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EvaluatedPropertyReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EvaluatedPropertyReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EvaluatedPropertyReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EvaluatedPropertyReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EvaluatedPropertyReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EvaluatedPropertyReferencesRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EvaluatedPropertyMeasuredWithMethodOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EvaluatedPropertyCorrespondsToRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EvaluatedPropertyCorrespondsToRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EvaluatedPropertyCorrespondsToRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EvaluatedPropertyCorrespondsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EvaluatedPropertyCorrespondsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EvaluatedPropertyCorrespondsToRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationSpecifiesRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationPropertyMapsToPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationPropertyMapsToClassPropertyRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationOperationalLocationRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationCorrespondsToEquipmentRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentSpecificationCorrespondsToEquipmentClassRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentPropertyMapsToRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentImplementedByRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentImplementedByRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentImplementedByRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentImplementedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentImplementedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentImplementedByRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentHasValuesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentDefinedByRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentClassPropertyContainsRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentClassIsMadeUpOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentClassIncludesPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentClassHierarchyScopeRelRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EquipmentClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EquipmentClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EquipmentClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EquipmentClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EquipmentClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EquipmentClassHasPropertiesOfRelationship");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "EnterpriseSiteRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EnterpriseSiteRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EnterpriseSiteRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "EnterpriseSiteRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "EnterpriseSiteRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EnterpriseSiteRelationship");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "Enterprise");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AreaWorkCenterRelationship");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AreaWorkCenterRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AreaWorkCenterRelationship");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "AreaWorkCenterRelationship");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "AreaWorkCenterRelationship");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AreaWorkCenterRelationship");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "EquipmentLevel",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "ResponsibleDtId",
                table: "Area");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonnelClassIncludesPropertiesOfRelationships");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PersonDefinedByRelationships");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PersonDefinedByRelationships");

            migrationBuilder.RenameTable(
                name: "PersonnelClassIncludesPropertiesOfRelationships",
                newName: "PersonnelClassIncludesPropertiesOfRelationship");

            migrationBuilder.RenameTable(
                name: "PersonDefinedByRelationships",
                newName: "PersonDefinedByRelationship");

            migrationBuilder.RenameIndex(
                name: "IX_PersonnelClassIncludesPropertiesOfRelationships_TargetId",
                table: "PersonnelClassIncludesPropertiesOfRelationship",
                newName: "IX_PersonnelClassIncludesPropertiesOfRelationship_TargetId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonnelClassIncludesPropertiesOfRelationships_SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationship",
                newName: "IX_PersonnelClassIncludesPropertiesOfRelationship_SourceId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonDefinedByRelationships_TargetId",
                table: "PersonDefinedByRelationship",
                newName: "IX_PersonDefinedByRelationship_TargetId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonDefinedByRelationships_SourceId",
                table: "PersonDefinedByRelationship",
                newName: "IX_PersonDefinedByRelationship_SourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonnelClassIncludesPropertiesOfRelationship",
                table: "PersonnelClassIncludesPropertiesOfRelationship",
                column: "DtId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonDefinedByRelationship",
                table: "PersonDefinedByRelationship",
                column: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Area_HierarchyScope_DtId",
                table: "Area",
                column: "DtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AreaWorkCenterRelationship_WorkCenter_TargetId",
                table: "AreaWorkCenterRelationship",
                column: "TargetId",
                principalTable: "WorkCenter",
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
                name: "FK_PersonnelClassIncludesPropertiesOfRelationship_PersonnelClasses_SourceId",
                table: "PersonnelClassIncludesPropertiesOfRelationship",
                column: "SourceId",
                principalTable: "PersonnelClasses",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelClassIncludesPropertiesOfRelationship_PersonnelClasses_TargetId",
                table: "PersonnelClassIncludesPropertiesOfRelationship",
                column: "TargetId",
                principalTable: "PersonnelClasses",
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
                name: "FK_ProcessCell_WorkCenter_DtId",
                table: "ProcessCell",
                column: "DtId",
                principalTable: "WorkCenter",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionLine_WorkCenter_DtId",
                table: "ProductionLine",
                column: "DtId",
                principalTable: "WorkCenter",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionUnit_WorkCenter_DtId",
                table: "ProductionUnit",
                column: "DtId",
                principalTable: "WorkCenter",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Site_HierarchyScope_DtId",
                table: "Site",
                column: "DtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StorageUnit_WorkUnit_DtId",
                table: "StorageUnit",
                column: "DtId",
                principalTable: "WorkUnit",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StorageZone_WorkCenter_DtId",
                table: "StorageZone",
                column: "DtId",
                principalTable: "WorkCenter",
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
                name: "FK_Unit_WorkUnit_DtId",
                table: "Unit",
                column: "DtId",
                principalTable: "WorkUnit",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkCell_WorkUnit_DtId",
                table: "WorkCell",
                column: "DtId",
                principalTable: "WorkUnit",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkCenter_HierarchyScope_DtId",
                table: "WorkCenter",
                column: "DtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkCenterWorkUnitRelationship_WorkCenter_SourceId",
                table: "WorkCenterWorkUnitRelationship",
                column: "SourceId",
                principalTable: "WorkCenter",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkCenterWorkUnitRelationship_WorkUnit_TargetId",
                table: "WorkCenterWorkUnitRelationship",
                column: "TargetId",
                principalTable: "WorkUnit",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkDefinitionHierarchyScopeRelRelationship_HierarchyScope_TargetId",
                table: "WorkDefinitionHierarchyScopeRelRelationship",
                column: "TargetId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkUnit_HierarchyScope_DtId",
                table: "WorkUnit",
                column: "DtId",
                principalTable: "HierarchyScope",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
