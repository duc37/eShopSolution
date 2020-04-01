using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class LoginDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 2, 1, 42, 26, 755, DateTimeKind.Local).AddTicks(5921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 4, 2, 1, 21, 55, 411, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("ae32e6ad-db36-419a-a0a9-5f8b84428ac3"), "af9df42f-0bc8-4c43-9d0f-59710925b306", "admintratoe guid", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a0e4d870-2fc6-4ea0-beab-953f2e2d8942"), new Guid("ae32e6ad-db36-419a-a0a9-5f8b84428ac3") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a0e4d870-2fc6-4ea0-beab-953f2e2d8942"), 0, "d5cb027a-1e01-4c88-a9f7-1ae2285fc2e7", new DateTime(22, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "dangtrongduc02@gmail.com", true, "Dang trong", "Duc", false, null, "dangtrongduc02@gmail.com", "admin", "AQAAAAEAACcQAAAAEEH4e3rTz0bIN9Q2g4lfqdBFLoeYlTE/GxEU8IesAE5gqKs/q/gK/GsOUBqu05+SKg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 2, 1, 42, 26, 777, DateTimeKind.Local).AddTicks(6241));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: new Guid("ae32e6ad-db36-419a-a0a9-5f8b84428ac3"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a0e4d870-2fc6-4ea0-beab-953f2e2d8942"), new Guid("ae32e6ad-db36-419a-a0a9-5f8b84428ac3") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0e4d870-2fc6-4ea0-beab-953f2e2d8942"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 2, 1, 21, 55, 411, DateTimeKind.Local).AddTicks(7083),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 4, 2, 1, 42, 26, 755, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 4, 2, 1, 21, 55, 431, DateTimeKind.Local).AddTicks(8754));
        }
    }
}
