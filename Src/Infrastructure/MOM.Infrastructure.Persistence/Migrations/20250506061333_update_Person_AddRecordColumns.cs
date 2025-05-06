using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOM.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class update_Person_AddRecordColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Person",
                newName: "ContactInformation_PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Person",
                newName: "ContactInformation_Email");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "ContactInformation_PhoneNumber",
                table: "Person",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "ContactInformation_Email",
                table: "Person",
                newName: "Email");
        }
    }
}
