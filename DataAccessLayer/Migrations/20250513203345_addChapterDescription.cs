using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addChapterDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TermYears_Years_YearId",
                table: "TermYears");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("2a218ade-2694-4294-96a9-0324eb1d96b0"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("3c5bd506-87ad-4f93-b44c-e7d1d05cbd39"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("4a5d9366-ea08-4a42-a7a1-33f9e8baafe7"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("70e735f3-2f8d-4b04-a55e-cabdb11aa316"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("73db6e37-009d-4939-855e-a3e64547543d"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("0c9d64be-d163-4b10-ac7d-befd96b5ed1f"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("0f89fe64-e58c-48c4-9227-3ecaea20a7d8"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("641cf045-fc16-4299-968b-4fb00479c4a8"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("fe43385d-7dce-4431-8d39-b7a90d91b7c7"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("37520dfd-bdae-46d2-8bc3-3ee23a886f64"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("46cbc764-99b6-475a-82af-6ec479cf3fb2"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("5fd8fd77-57f2-41a8-aca8-c608842345d4"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("69d59ab7-af44-464d-8645-9c5428f6fd66"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("d72512f4-c828-490b-8c09-70bce1b3e76c"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Chapters",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acce8102-3030-4846-8b2b-c6c51632dd72", "AQAAAAIAAYagAAAAEJJBQi1qLVLEtLt9ivPlTWpNSxIADEfBH11UaT1lqxcUKfRi0LI6VAUcHKrVmvfCNQ==", "399cbc3b-a4d9-478a-a0c7-9a70650a4927" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("33c6bfd9-90f3-4c12-b043-324332a29241"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" },
                    { new Guid("a380491a-709a-4755-bf84-c3b5a209331c"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("a51126ce-b6a1-4705-bee3-e29b4a88f761"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("bb45774e-d705-4918-943f-21a0ec5694cb"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("f7117018-f52f-4bb4-8a5f-22bb1e149743"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("408c7e28-35e6-47a0-9d20-a3ba59e5eba0"), "Jul - Sep", "Term 3" },
                    { new Guid("70bdb354-0235-4ab0-b00e-bdfa58563509"), "Apr - Jun", "Term 2" },
                    { new Guid("bbe104c4-cb3c-47a2-84f6-04f798bfae14"), "Oct - Dec", "Term 4" },
                    { new Guid("ecc6f29f-2aa1-4666-be12-2f564ebd6d6e"), "Jan - Mar", "Term 1" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("2bdb7573-423b-49fc-a468-7a0abaccdcd6"), 2024 },
                    { new Guid("6ac14e31-9f19-40fb-a8ec-bfd841c1a5b4"), 2023 },
                    { new Guid("7d86b8eb-109f-43ee-b916-1d591e35cd6b"), 2020 },
                    { new Guid("c1aa47ef-227b-4e7c-9dc5-bc51764e3a76"), 2022 },
                    { new Guid("f505243a-b79c-4165-a8db-8e56644d9dee"), 2021 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TermYears_Years_YearId",
                table: "TermYears",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TermYears_Years_YearId",
                table: "TermYears");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("33c6bfd9-90f3-4c12-b043-324332a29241"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("a380491a-709a-4755-bf84-c3b5a209331c"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("a51126ce-b6a1-4705-bee3-e29b4a88f761"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("bb45774e-d705-4918-943f-21a0ec5694cb"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("f7117018-f52f-4bb4-8a5f-22bb1e149743"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("408c7e28-35e6-47a0-9d20-a3ba59e5eba0"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("70bdb354-0235-4ab0-b00e-bdfa58563509"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("bbe104c4-cb3c-47a2-84f6-04f798bfae14"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("ecc6f29f-2aa1-4666-be12-2f564ebd6d6e"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("2bdb7573-423b-49fc-a468-7a0abaccdcd6"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("6ac14e31-9f19-40fb-a8ec-bfd841c1a5b4"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("7d86b8eb-109f-43ee-b916-1d591e35cd6b"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("c1aa47ef-227b-4e7c-9dc5-bc51764e3a76"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("f505243a-b79c-4165-a8db-8e56644d9dee"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Chapters");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be319529-9300-4d63-ab70-d9548f83b23c", "AQAAAAIAAYagAAAAEFHZZI0V1glDtgkrmzaratrKXjOdWSDTltPZRZz/xOnjiUmBB9YwNPyIg9Zlf6DuGw==", "fea0c9f5-3baf-43db-b375-ce2e5841aa0e" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("2a218ade-2694-4294-96a9-0324eb1d96b0"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("3c5bd506-87ad-4f93-b44c-e7d1d05cbd39"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" },
                    { new Guid("4a5d9366-ea08-4a42-a7a1-33f9e8baafe7"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("70e735f3-2f8d-4b04-a55e-cabdb11aa316"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("73db6e37-009d-4939-855e-a3e64547543d"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("0c9d64be-d163-4b10-ac7d-befd96b5ed1f"), "Apr - Jun", "Term 2" },
                    { new Guid("0f89fe64-e58c-48c4-9227-3ecaea20a7d8"), "Jul - Sep", "Term 3" },
                    { new Guid("641cf045-fc16-4299-968b-4fb00479c4a8"), "Jan - Mar", "Term 1" },
                    { new Guid("fe43385d-7dce-4431-8d39-b7a90d91b7c7"), "Oct - Dec", "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("37520dfd-bdae-46d2-8bc3-3ee23a886f64"), 2021 },
                    { new Guid("46cbc764-99b6-475a-82af-6ec479cf3fb2"), 2023 },
                    { new Guid("5fd8fd77-57f2-41a8-aca8-c608842345d4"), 2020 },
                    { new Guid("69d59ab7-af44-464d-8645-9c5428f6fd66"), 2022 },
                    { new Guid("d72512f4-c828-490b-8c09-70bce1b3e76c"), 2024 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TermYears_Years_YearId",
                table: "TermYears",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
