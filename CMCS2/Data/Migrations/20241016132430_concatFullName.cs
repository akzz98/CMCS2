using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMCS2.Data.Migrations
{
    /// <inheritdoc />
    public partial class concatFullName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LecturerName",
                table: "Claims");

            migrationBuilder.RenameColumn(
                name: "LecturerSurname",
                table: "Claims",
                newName: "LecturerFullName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LecturerFullName",
                table: "Claims",
                newName: "LecturerSurname");

            migrationBuilder.AddColumn<string>(
                name: "LecturerName",
                table: "Claims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
