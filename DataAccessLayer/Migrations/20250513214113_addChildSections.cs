using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addChildSections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "ParentSectionId",
                table: "ChapterSection",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aa07c2a-eeb6-45ec-9803-6de4e395367d", "AQAAAAIAAYagAAAAEIqHm0baav1ZbA6bFRoH5XmIWm2EeLCvwSBwSgIfjvidtKZiEY4Vn74XSJ3Rn4/0Gw==", "add92cee-acfa-4370-b522-b57e2d2b690e" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("0d546113-3176-48ab-9ec6-d63a151b5c1f"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("637fb787-d46f-48d3-ab26-fe745766d52a"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("8920e0d8-ef9a-4001-94b7-fe7640f96d6e"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("97e2db24-ecda-499d-868c-dfbcf455ca89"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("bb15272d-beb6-4a28-9c1e-2b89e353a87f"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("50d87b43-6aea-48df-ac8b-dcd9340203a5"), "Jul - Sep", "Term 3" },
                    { new Guid("8058424b-83b1-4077-b756-910ac9448108"), "Jan - Mar", "Term 1" },
                    { new Guid("a0be02a9-cbac-4318-b6ec-2207966a5c7b"), "Apr - Jun", "Term 2" },
                    { new Guid("a6340666-5d6f-4335-9ef8-2b30e6b2f621"), "Oct - Dec", "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("36ca013c-4d00-404f-a369-3a1a12c166f8"), 2024 },
                    { new Guid("43756c9a-d179-460a-b84d-a8e4946c3e10"), 2022 },
                    { new Guid("ddd7617f-c9bd-4fe9-bef7-aba0c17d3a56"), 2020 },
                    { new Guid("e55875ab-2394-4b5d-822e-add0be798cae"), 2021 },
                    { new Guid("f04cf27e-bb93-4d5b-b9fe-06fc1602c33e"), 2023 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChapterSection_ParentSectionId",
                table: "ChapterSection",
                column: "ParentSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterSection_ChapterSection_ParentSectionId",
                table: "ChapterSection",
                column: "ParentSectionId",
                principalTable: "ChapterSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChapterSection_ChapterSection_ParentSectionId",
                table: "ChapterSection");

            migrationBuilder.DropIndex(
                name: "IX_ChapterSection_ParentSectionId",
                table: "ChapterSection");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("0d546113-3176-48ab-9ec6-d63a151b5c1f"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("637fb787-d46f-48d3-ab26-fe745766d52a"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("8920e0d8-ef9a-4001-94b7-fe7640f96d6e"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("97e2db24-ecda-499d-868c-dfbcf455ca89"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("bb15272d-beb6-4a28-9c1e-2b89e353a87f"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("50d87b43-6aea-48df-ac8b-dcd9340203a5"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("8058424b-83b1-4077-b756-910ac9448108"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("a0be02a9-cbac-4318-b6ec-2207966a5c7b"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("a6340666-5d6f-4335-9ef8-2b30e6b2f621"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("36ca013c-4d00-404f-a369-3a1a12c166f8"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("43756c9a-d179-460a-b84d-a8e4946c3e10"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("ddd7617f-c9bd-4fe9-bef7-aba0c17d3a56"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("e55875ab-2394-4b5d-822e-add0be798cae"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("f04cf27e-bb93-4d5b-b9fe-06fc1602c33e"));

            migrationBuilder.DropColumn(
                name: "ParentSectionId",
                table: "ChapterSection");

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
        }
    }
}
