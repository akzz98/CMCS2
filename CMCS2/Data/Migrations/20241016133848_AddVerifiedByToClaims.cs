using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMCS2.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddVerifiedByToClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoordinatorFullName",
                table: "Claims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateVerified",
                table: "Claims",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoordinatorFullName",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "DateVerified",
                table: "Claims");
        }
    }
}
