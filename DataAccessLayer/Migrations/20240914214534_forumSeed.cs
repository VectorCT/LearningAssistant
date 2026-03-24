using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class forumSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("7514a691-c2dd-4953-a59a-398f928fe45a"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("7c88249b-ce4e-4dde-a42f-71fbc091d890"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("9a98713d-89bc-4aef-a23d-4c5343426a51"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("e80ec0cd-4fba-46ca-a385-a9a6efeee7c5"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("029c77ce-4a5d-4c1c-9263-57f69422d915"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("04690ce2-c802-4268-90cb-4de44e012027"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("6096b475-8871-4f68-9d13-8a037aaf0ad2"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("8b8a04bc-caa2-47ac-a830-3d47ae4beea2"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("a46b629d-e145-4cc2-a770-3a29c81e0770"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f155c4b-c7d3-4436-97e0-954adb87930c", "AQAAAAIAAYagAAAAEFMGx2YWHSCyvirY95Qim+xiJmIYvFuDH+krqf9ZIvK6owa+qREQG4Kp/P5qyrtEXQ==", "c49cfb4c-5028-4842-8b9f-73ca1256b5f7" });

            // REMOVED Forums seed data - causes FK constraint errors with non-existent SubjectIds:
            // SubjectId 'b2df6db3-2b38-4c3a-9517-5e3e2b98b741' and '3fe2283b-6751-4633-8903-2043997bbf20' don't exist
            // Forums can be created through the application UI instead

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("043e2788-0869-404c-921d-8b96ee7a196f"), "Apr - Jun", "Term 2" },
                    { new Guid("131aed40-9764-489b-bd15-c6d8b65ce2ca"), "Jul - Sep", "Term 3" },
                    { new Guid("76cef0a0-eaf2-40f2-9084-353f0a3124d1"), "Jan - Mar", "Term 1" },
                    { new Guid("d68ba6ed-f2d1-446e-aec9-524bf6337666"), "Oct - Dec", "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("3e9ec2f9-d47c-4c32-b491-1c5333646a8a"), 2024 },
                    { new Guid("b1bcb39a-86d0-4550-a58a-ae298001e7f2"), 2022 },
                    { new Guid("cc52bf88-cbfb-4f09-b56c-58a03bfb1aee"), 2020 },
                    { new Guid("d341c28b-9c6d-44a7-a6bc-ea6d8b530418"), 2021 },
                    { new Guid("f1a58bb0-94b3-4379-9f85-13ffdce020e2"), 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // REMOVED Forums DeleteData - no longer inserting Forums in Up()

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("043e2788-0869-404c-921d-8b96ee7a196f"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("131aed40-9764-489b-bd15-c6d8b65ce2ca"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("76cef0a0-eaf2-40f2-9084-353f0a3124d1"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("d68ba6ed-f2d1-446e-aec9-524bf6337666"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("3e9ec2f9-d47c-4c32-b491-1c5333646a8a"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("b1bcb39a-86d0-4550-a58a-ae298001e7f2"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("cc52bf88-cbfb-4f09-b56c-58a03bfb1aee"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("d341c28b-9c6d-44a7-a6bc-ea6d8b530418"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("f1a58bb0-94b3-4379-9f85-13ffdce020e2"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a8b393-45d7-4048-89cc-ae83c524c97d", "AQAAAAIAAYagAAAAEABl+gfwcuPdDVABwF8Z3Hj1xUiC461khUlbQtjQJhBZ1K20uOlTVkAkivhFt4O1lA==", "b2e5db51-04f3-4cca-a7ab-5003f40898dc" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("7514a691-c2dd-4953-a59a-398f928fe45a"), "Apr - Jun", "Term 2" },
                    { new Guid("7c88249b-ce4e-4dde-a42f-71fbc091d890"), "Jul - Sep", "Term 3" },
                    { new Guid("9a98713d-89bc-4aef-a23d-4c5343426a51"), "Oct - Dec", "Term 4" },
                    { new Guid("e80ec0cd-4fba-46ca-a385-a9a6efeee7c5"), "Jan - Mar", "Term 1" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("029c77ce-4a5d-4c1c-9263-57f69422d915"), 2020 },
                    { new Guid("04690ce2-c802-4268-90cb-4de44e012027"), 2023 },
                    { new Guid("6096b475-8871-4f68-9d13-8a037aaf0ad2"), 2022 },
                    { new Guid("8b8a04bc-caa2-47ac-a830-3d47ae4beea2"), 2024 },
                    { new Guid("a46b629d-e145-4cc2-a770-3a29c81e0770"), 2021 }
                });
        }
    }
}
