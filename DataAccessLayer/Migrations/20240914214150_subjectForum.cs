using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class subjectForum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("26648141-4271-4920-bfa9-d53f3ae55da9"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("28e1f859-5f85-4d4c-b416-7755a57ee1ed"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("76ac3144-24bf-4086-8792-a86c835ec4a3"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("7e72a716-ef78-469d-9ee7-6417a9f65399"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("31f2ec57-e14c-4a87-9603-e1f1fe81215b"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("582e6277-29ca-4367-b12b-0e6d443a8799"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("744493a1-0066-48ae-9e8e-aea6abe35269"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("8256b1f4-89fa-404e-9b4e-24ccbfe9e46d"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("e4367e4b-c148-4576-95aa-96e91b97a7fd"));

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectId",
                table: "Forums",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a8b393-45d7-4048-89cc-ae83c524c97d", "AQAAAAIAAYagAAAAEABl+gfwcuPdDVABwF8Z3Hj1xUiC461khUlbQtjQJhBZ1K20uOlTVkAkivhFt4O1lA==", "b2e5db51-04f3-4cca-a7ab-5003f40898dc" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "PrescribedTextBook" },
                values: new object[,]
                {
                    { new Guid("4b1e2df5-c5ad-488e-94d6-b249d1016c40"), "Science", "Physics Textbook" },
                    { new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), "Mathematics", "MathBook.pdf" },
                    { new Guid("8bae0fe9-7853-4d3d-949c-b5537303f330"), "Biology", "Biology Textbook" },
                    { new Guid("948e6d61-8d75-46ca-8701-8921979eb1fa"), "Chemistry", "Chemistry Textbook" },
                    { new Guid("c62a461a-0ab8-4bd7-83c4-a1bbb56a4772"), "Geography", "Geography Textbook" }
                });

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
                    { new Guid("6096b475-8871-4f68-9d13-8a037aaf0ad2"), 2021 },
                    { new Guid("8b8a04bc-caa2-47ac-a830-3d47ae4beea2"), 2024 },
                    { new Guid("a46b629d-e145-4cc2-a770-3a29c81e0770"), 2022 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forums_SubjectId",
                table: "Forums",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_Subjects_SubjectId",
                table: "Forums",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forums_Subjects_SubjectId",
                table: "Forums");

            migrationBuilder.DropIndex(
                name: "IX_Forums_SubjectId",
                table: "Forums");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4b1e2df5-c5ad-488e-94d6-b249d1016c40"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8bae0fe9-7853-4d3d-949c-b5537303f330"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("948e6d61-8d75-46ca-8701-8921979eb1fa"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c62a461a-0ab8-4bd7-83c4-a1bbb56a4772"));

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

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Forums");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af9e2f13-cebd-4fe5-ba6b-d40ac26391c3", "AQAAAAIAAYagAAAAEGyqB/oTDqplVHzgf8NnuUw24V3o+usokZIM0XHfaa663vxZF7POn1VBr5iyviV7ug==", "f90d9d52-35d4-4f74-b594-bcb2e38314da" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("26648141-4271-4920-bfa9-d53f3ae55da9"), "Jul - Sep", "Term 3" },
                    { new Guid("28e1f859-5f85-4d4c-b416-7755a57ee1ed"), "Apr - Jun", "Term 2" },
                    { new Guid("76ac3144-24bf-4086-8792-a86c835ec4a3"), "Oct - Dec", "Term 4" },
                    { new Guid("7e72a716-ef78-469d-9ee7-6417a9f65399"), "Jan - Mar", "Term 1" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("31f2ec57-e14c-4a87-9603-e1f1fe81215b"), 2021 },
                    { new Guid("582e6277-29ca-4367-b12b-0e6d443a8799"), 2020 },
                    { new Guid("744493a1-0066-48ae-9e8e-aea6abe35269"), 2023 },
                    { new Guid("8256b1f4-89fa-404e-9b4e-24ccbfe9e46d"), 2022 },
                    { new Guid("e4367e4b-c148-4576-95aa-96e91b97a7fd"), 2024 }
                });
        }
    }
}
