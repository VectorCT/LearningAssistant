using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("56dc42b0-4739-48fc-9a63-2394c47a365e"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("590dc112-4b86-4e56-8699-308f33373bf8"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("6fcda535-585a-4354-bc77-d9d0530a92f9"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("76b1a419-5ae2-4865-80dc-0365c55cae80"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Forums",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e31c42b9-b484-4f16-83dd-948d4d43d889", "AQAAAAIAAYagAAAAEHGUMHDkkkV0yasBX7tMaLCE+L3adwG3/gknYau+Gc6HlPOGmf0FKwwW3/g3jtw2Cg==", "6d3abade-fa9a-470f-bc21-c43f07a3f77b" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("2e80c7e4-91fe-4c00-a50b-370f9a039f6f"), "Jul - Sep", "Term 3" },
                    { new Guid("c246bc78-42c8-477b-9dbc-72bae1c2d3e3"), "Apr - Jun", "Term 2" },
                    { new Guid("dd9585ea-765c-457a-83f2-8e2eb39fba6c"), "Jan - Mar", "Term 1" },
                    { new Guid("ecf6b25c-c06f-4362-9aac-7e5f14b11d2b"), "Oct - Dec", "Term 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("2e80c7e4-91fe-4c00-a50b-370f9a039f6f"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("c246bc78-42c8-477b-9dbc-72bae1c2d3e3"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("dd9585ea-765c-457a-83f2-8e2eb39fba6c"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("ecf6b25c-c06f-4362-9aac-7e5f14b11d2b"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Forums");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d742292c-4a31-4e8b-b06f-f505fecf6e57", "AQAAAAIAAYagAAAAEID04XTlHebR85OzYhpcV50nDHMDXufS6vOjmVSb4Ui4H24DDlKPP//ankxm9cwQnA==", "7a1e08f5-56dd-4f56-8da1-269644712636" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("56dc42b0-4739-48fc-9a63-2394c47a365e"), "Jan - Mar", "Term 1" },
                    { new Guid("590dc112-4b86-4e56-8699-308f33373bf8"), "Oct - Dec", "Term 4" },
                    { new Guid("6fcda535-585a-4354-bc77-d9d0530a92f9"), "Apr - Jun", "Term 2" },
                    { new Guid("76b1a419-5ae2-4865-80dc-0365c55cae80"), "Jul - Sep", "Term 3" }
                });
        }
    }
}
