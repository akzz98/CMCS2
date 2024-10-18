using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMCS2.Migrations
{
    /// <inheritdoc />
    public partial class initCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c3c823c-01cc-41d5-b84c-fee525a6605a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94cac02c-cfd7-471d-98c2-b6cb4a68f8aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad1bb794-7571-4f22-a910-efcbfc9e0c51");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3c35a983-9a42-4ccc-b0c2-1fac24e5a40e", "e5fd6c0c-9c90-4f85-8cbb-1055765ffdcb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c35a983-9a42-4ccc-b0c2-1fac24e5a40e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5fd6c0c-9c90-4f85-8cbb-1055765ffdcb");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3c35a983-9a42-4ccc-b0c2-1fac24e5a40e", null, "SuperUser", "SUPERUSER" },
                    { "3c3c823c-01cc-41d5-b84c-fee525a6605a", null, "Lecturer", "LECTURER" },
                    { "94cac02c-cfd7-471d-98c2-b6cb4a68f8aa", null, "Manager", "MANAGER" },
                    { "ad1bb794-7571-4f22-a910-efcbfc9e0c51", null, "Coordinator", "COORDINATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e5fd6c0c-9c90-4f85-8cbb-1055765ffdcb", 0, "c524fb38-c65c-43d1-b5e0-efc906e3d4e8", "admin@yourapp.com", true, false, null, "Admin", "ADMIN@YOURAPP.COM", "ADMIN@YOURAPP.COM", "AQAAAAIAAYagAAAAECyZN9bYHt1nKn2/NLZlZYkKWiDNLMcCcWOtUcZUVYeiCbjq5+gtb+NovJNnMDwclg==", null, false, "f4117e87-6501-4248-94ed-a11635a76842", "User", false, "admin@yourapp.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3c35a983-9a42-4ccc-b0c2-1fac24e5a40e", "e5fd6c0c-9c90-4f85-8cbb-1055765ffdcb" });
        }
    }
}
