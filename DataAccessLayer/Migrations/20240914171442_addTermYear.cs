using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addTermYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PastPaperMemorandums_Subjects_SubjectId",
                table: "PastPaperMemorandums");

            migrationBuilder.DropIndex(
                name: "IX_PastPaperMemorandums_SubjectId",
                table: "PastPaperMemorandums");

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
                name: "SubjectId",
                table: "PastPaperMemorandums");

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TermYears",
                columns: table => new
                {
                    TermId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermYears", x => new { x.TermId, x.YearId });
                    table.ForeignKey(
                        name: "FK_TermYears_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TermYears_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "545ebcab-a588-442b-b385-34eafe9c1a2e", "AQAAAAIAAYagAAAAEDs2sfkirt8MM87jhVx8osujGBexn3raLJl7A9S+rVzk2BgiSinXimWXPruzm+XGyw==", "7cb1c808-015c-4545-8938-9f8307648e03" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("50f5dc94-a720-415c-91b3-beb5a3df5302"), "Apr - Jun", "Term 2" },
                    { new Guid("7abcee94-b8be-4fdb-88d8-76bd790497b7"), "Jul - Sep", "Term 3" },
                    { new Guid("df0d08e1-d6e9-43db-b98d-8c6b4a80dec2"), "Jan - Mar", "Term 1" },
                    { new Guid("ed55b37d-f9b7-4b1d-931d-bf134213da9c"), "Oct - Dec", "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("1c755670-95d2-4b3c-9795-e205b49dedea"), 2024 },
                    { new Guid("49db3c1f-a0ef-4304-bc3d-bedff6066efd"), 2022 },
                    { new Guid("7f13a868-e692-46cb-9747-f879db8bb2ad"), 2021 },
                    { new Guid("d88bf9be-144a-482e-acbf-697069ac9dd9"), 2023 },
                    { new Guid("e924fd94-ee4b-4d12-a5e6-ca48a1a0974b"), 2020 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TermYears_YearId",
                table: "TermYears",
                column: "YearId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TermYears");

            migrationBuilder.DropTable(
                name: "Years");

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("50f5dc94-a720-415c-91b3-beb5a3df5302"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("7abcee94-b8be-4fdb-88d8-76bd790497b7"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("df0d08e1-d6e9-43db-b98d-8c6b4a80dec2"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("ed55b37d-f9b7-4b1d-931d-bf134213da9c"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectId",
                table: "PastPaperMemorandums",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_PastPaperMemorandums_SubjectId",
                table: "PastPaperMemorandums",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_PastPaperMemorandums_Subjects_SubjectId",
                table: "PastPaperMemorandums",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }
    }
}
