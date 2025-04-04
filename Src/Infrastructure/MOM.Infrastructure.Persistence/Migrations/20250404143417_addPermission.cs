using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addPermission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_People_ResponsibleDtId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_HierarchyScope_People_ResponsibleDtId",
                table: "HierarchyScope");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonDefinedByRelationship_People_SourceId",
                table: "PersonDefinedByRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHasValuesOfRelationship_People_SourceId",
                table: "PersonHasValuesOfRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_People_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelSpecificationCorrespondsToPersonRelationship_People_TargetId",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonOperationalLocationRelRelationship_People_PersonDtId",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Person");

            migrationBuilder.AddColumn<int>(
                name: "FailedCount",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LockoutDateTime",
                table: "Person",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutOnFailure",
                table: "Person",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PassWord",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "DtId");

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
                    table.ForeignKey(
                        name: "FK_AvailablePermissions_Person_PersonDtId",
                        column: x => x.PersonDtId,
                        principalTable: "Person",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Component = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hidden = table.Column<bool>(type: "bit", nullable: false),
                    AlwaysShow = table.Column<bool>(type: "bit", nullable: false),
                    Depth = table.Column<int>(type: "int", nullable: false),
                    MenuDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Menus_Menus_MenuDtId",
                        column: x => x.MenuDtId,
                        principalTable: "Menus",
                        principalColumn: "DtId");
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuButtonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelClassDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Permissions_PersonnelClasses_PersonnelClassDtId",
                        column: x => x.PersonnelClassDtId,
                        principalTable: "PersonnelClasses",
                        principalColumn: "DtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Buttons",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuDtId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buttons", x => x.DtId);
                    table.ForeignKey(
                        name: "FK_Buttons_Menus_MenuDtId",
                        column: x => x.MenuDtId,
                        principalTable: "Menus",
                        principalColumn: "DtId");
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
                name: "IX_Menus_MenuDtId",
                table: "Menus",
                column: "MenuDtId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PersonnelClassDtId",
                table: "Permissions",
                column: "PersonnelClassDtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Person_ResponsibleDtId",
                table: "Equipment",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_HierarchyScope_Person_ResponsibleDtId",
                table: "HierarchyScope",
                column: "ResponsibleDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonDefinedByRelationship_Person_SourceId",
                table: "PersonDefinedByRelationship",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHasValuesOfRelationship_Person_SourceId",
                table: "PersonHasValuesOfRelationship",
                column: "SourceId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "PersonDtId",
                principalTable: "Person",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelSpecificationCorrespondsToPersonRelationship_Person_TargetId",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                column: "TargetId",
                principalTable: "Person",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonOperationalLocationRelRelationship_Person_PersonDtId",
                table: "PersonOperationalLocationRelRelationship",
                column: "PersonDtId",
                principalTable: "Person",
                principalColumn: "DtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Person_ResponsibleDtId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_HierarchyScope_Person_ResponsibleDtId",
                table: "HierarchyScope");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonDefinedByRelationship_Person_SourceId",
                table: "PersonDefinedByRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHasValuesOfRelationship_Person_SourceId",
                table: "PersonHasValuesOfRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_Person_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonnelSpecificationCorrespondsToPersonRelationship_Person_TargetId",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonOperationalLocationRelRelationship_Person_PersonDtId",
                table: "PersonOperationalLocationRelRelationship");

            migrationBuilder.DropTable(
                name: "AvailablePermissions");

            migrationBuilder.DropTable(
                name: "Buttons");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "FailedCount",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LockoutDateTime",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LockoutOnFailure",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PassWord",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "People");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "DtId");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    DtId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.DtId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_People_ResponsibleDtId",
                table: "Equipment",
                column: "ResponsibleDtId",
                principalTable: "People",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_HierarchyScope_People_ResponsibleDtId",
                table: "HierarchyScope",
                column: "ResponsibleDtId",
                principalTable: "People",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonDefinedByRelationship_People_SourceId",
                table: "PersonDefinedByRelationship",
                column: "SourceId",
                principalTable: "People",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHasValuesOfRelationship_People_SourceId",
                table: "PersonHasValuesOfRelationship",
                column: "SourceId",
                principalTable: "People",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHierarchyScopeRelRelationship_People_PersonDtId",
                table: "PersonHierarchyScopeRelRelationship",
                column: "PersonDtId",
                principalTable: "People",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonnelSpecificationCorrespondsToPersonRelationship_People_TargetId",
                table: "PersonnelSpecificationCorrespondsToPersonRelationship",
                column: "TargetId",
                principalTable: "People",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonOperationalLocationRelRelationship_People_PersonDtId",
                table: "PersonOperationalLocationRelRelationship",
                column: "PersonDtId",
                principalTable: "People",
                principalColumn: "DtId");
        }
    }
}
