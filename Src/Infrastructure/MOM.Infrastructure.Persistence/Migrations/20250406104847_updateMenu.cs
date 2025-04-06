using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buttons_Menus_MenuDtId",
                table: "Buttons");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Menus_MenuDtId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Component",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "MenuDtId",
                table: "Menus",
                newName: "ParentMenuDtId");

            migrationBuilder.RenameIndex(
                name: "IX_Menus_MenuDtId",
                table: "Menus",
                newName: "IX_Menus_ParentMenuDtId");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuDtId",
                table: "Buttons",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Buttons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Buttons_Menus_MenuDtId",
                table: "Buttons",
                column: "MenuDtId",
                principalTable: "Menus",
                principalColumn: "DtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Menus_ParentMenuDtId",
                table: "Menus",
                column: "ParentMenuDtId",
                principalTable: "Menus",
                principalColumn: "DtId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buttons_Menus_MenuDtId",
                table: "Buttons");

            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Menus_ParentMenuDtId",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "ParentMenuDtId",
                table: "Menus",
                newName: "MenuDtId");

            migrationBuilder.RenameIndex(
                name: "IX_Menus_ParentMenuDtId",
                table: "Menus",
                newName: "IX_Menus_MenuDtId");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Component",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuDtId",
                table: "Buttons",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                table: "Buttons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Buttons_Menus_MenuDtId",
                table: "Buttons",
                column: "MenuDtId",
                principalTable: "Menus",
                principalColumn: "DtId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Menus_MenuDtId",
                table: "Menus",
                column: "MenuDtId",
                principalTable: "Menus",
                principalColumn: "DtId");
        }
    }
}
