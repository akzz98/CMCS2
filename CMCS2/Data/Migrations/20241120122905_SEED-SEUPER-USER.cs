using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMCS2.Migrations
{
    /// <inheritdoc />
    public partial class SEEDSEUPERUSER : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "040e1ef2-65ca-4236-b76c-71d46a8a6998");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e3e303-4f1a-43a3-b74a-85b57fa0dcb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfb922d8-fb76-491b-8ba4-e7bcb763daf8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c1ddeb23-270c-463a-896f-f28820a8e9a0", "e1251d17-939e-495f-9a5a-823ed0a4aaa4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1ddeb23-270c-463a-896f-f28820a8e9a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1251d17-939e-495f-9a5a-823ed0a4aaa4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "350deb18-264e-40ec-b601-35746f9e9387", null, "SuperUser", "SUPERUSER" },
                    { "456f4cf4-fb0b-4c8e-9f54-89f672cdeffa", null, "Manager", "MANAGER" },
                    { "568df1aa-91b5-4887-95d8-9b5d7d83a135", null, "Lecturer", "LECTURER" },
                    { "dafc279f-4893-4ea0-bb90-5efdff3e31e4", null, "Coordinator", "COORDINATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a8ccce7d-a743-49b9-93c8-91f7335c7674", 0, "990bbb37-23d1-4925-a0d5-79cf27619a03", "admin@cmcs.com", true, false, null, "Admin", "ADMIN@CMCS.COM", "ADMIN@CMCS.COM", "AQAAAAIAAYagAAAAEMAIxIHmba2mCz7zmpVjwzdWaJmuwrkfxFxua+WXEdMpIW2E45QKHYwcpJAeqGKtfA==", null, false, "73fd8dcc-145a-437b-bb11-221034cba429", "User", false, "admin@cmcs.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "350deb18-264e-40ec-b601-35746f9e9387", "a8ccce7d-a743-49b9-93c8-91f7335c7674" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "456f4cf4-fb0b-4c8e-9f54-89f672cdeffa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "568df1aa-91b5-4887-95d8-9b5d7d83a135");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dafc279f-4893-4ea0-bb90-5efdff3e31e4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "350deb18-264e-40ec-b601-35746f9e9387", "a8ccce7d-a743-49b9-93c8-91f7335c7674" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "350deb18-264e-40ec-b601-35746f9e9387");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8ccce7d-a743-49b9-93c8-91f7335c7674");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "040e1ef2-65ca-4236-b76c-71d46a8a6998", null, "Manager", "MANAGER" },
                    { "a6e3e303-4f1a-43a3-b74a-85b57fa0dcb6", null, "Lecturer", "LECTURER" },
                    { "bfb922d8-fb76-491b-8ba4-e7bcb763daf8", null, "Coordinator", "COORDINATOR" },
                    { "c1ddeb23-270c-463a-896f-f28820a8e9a0", null, "SuperUser", "SUPERUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e1251d17-939e-495f-9a5a-823ed0a4aaa4", 0, "7d93e66c-c314-47b4-bfdf-e2edf24c8455", "admin@yourapp.com", true, false, null, "Admin", "ADMIN@YOURAPP.COM", "ADMIN@YOURAPP.COM", "AQAAAAIAAYagAAAAEMbQQ7Dr1b9YkugcVX+04ke9vOO/mCis77Mtp4NOTHpRBlU/aHshDfkhIDY1fdW4wQ==", null, false, "0fb90e6e-84c8-4375-99f5-bf9417841538", "User", false, "admin@yourapp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c1ddeb23-270c-463a-896f-f28820a8e9a0", "e1251d17-939e-495f-9a5a-823ed0a4aaa4" });
        }
    }
}
