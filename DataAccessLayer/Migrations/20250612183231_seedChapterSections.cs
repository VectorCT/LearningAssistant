using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class seedChapterSections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Screenshot",
                table: "Forums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d32e4d02-3dd5-424f-ad7b-f0f9033afcff", "AQAAAAIAAYagAAAAEMTZooneDL6NgUVWb0joQ0QZTROrsurHKGEExsFeDGD+XnQpsVULuhP1WiVaXR92AQ==", "5b35fdbb-0006-43af-9320-93bec8ce5d76" });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterNumber", "ChapterTitle", "Description", "SubjectId", "TermId" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), 1, "Introduction to Biology", "Basic concepts of biology.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "Screenshot", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("12592406-647b-4c68-bd06-0ad14a665077"), "What are common algebra problems students face?", null, new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("3eda5bc4-4dda-4a08-890e-8b1cbb188adc"), "What are common algebra problems students face?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("4e789033-2c18-488f-b1ba-4093b2c77053"), "How do we understand Newton’s Laws?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("644838f5-d3fe-4210-b3e9-aaa2df8303cd"), "What are the best study guides for exam preparation?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("a64ddebd-47dd-433b-8d8a-ba45ee975b4c"), "How should I approach exam preparation effectively?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("35d8f4d4-7e22-4cb0-8ebe-c9438eb5dc12"), "Jan - Mar", "Term 1" },
                    { new Guid("9467f589-2992-4b73-a436-d386f877df69"), "Oct - Dec", "Term 4" },
                    { new Guid("b3895435-34c2-417c-bbe8-d2ed98a812df"), "Jul - Sep", "Term 3" },
                    { new Guid("e6e44195-e518-4f7e-b573-40f5eb5e7b17"), "Apr - Jun", "Term 2" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("08e5841c-a6ee-42e4-8272-c4f41d078082"), 2020 },
                    { new Guid("254d2ed0-f07c-4a85-b61d-3f216d543caa"), 2024 },
                    { new Guid("627d3968-8dd1-4aa4-8e31-f9b61fd4c017"), 2021 },
                    { new Guid("b188f316-9bbd-4adb-9c3e-bdc5b7d405f5"), 2023 },
                    { new Guid("ccc2043c-3ccc-4285-95c2-f63daec454b0"), 2022 }
                });

            migrationBuilder.InsertData(
                table: "ChapterSection",
                columns: new[] { "Id", "ChapterId", "Content", "Order", "ParentSectionId", "Type" },
                values: new object[,]
                {
                    { new Guid("44444444-4444-4444-4444-444444444444"), new Guid("11111111-1111-1111-1111-111111111111"), "What is Biology?", 1, null, 0 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), new Guid("11111111-1111-1111-1111-111111111111"), "Biology is the study of living organisms.", 2, new Guid("44444444-4444-4444-4444-444444444444"), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChapterSection",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("12592406-647b-4c68-bd06-0ad14a665077"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("3eda5bc4-4dda-4a08-890e-8b1cbb188adc"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("4e789033-2c18-488f-b1ba-4093b2c77053"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("644838f5-d3fe-4210-b3e9-aaa2df8303cd"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("a64ddebd-47dd-433b-8d8a-ba45ee975b4c"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("35d8f4d4-7e22-4cb0-8ebe-c9438eb5dc12"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("9467f589-2992-4b73-a436-d386f877df69"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("b3895435-34c2-417c-bbe8-d2ed98a812df"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("e6e44195-e518-4f7e-b573-40f5eb5e7b17"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("08e5841c-a6ee-42e4-8272-c4f41d078082"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("254d2ed0-f07c-4a85-b61d-3f216d543caa"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("627d3968-8dd1-4aa4-8e31-f9b61fd4c017"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("b188f316-9bbd-4adb-9c3e-bdc5b7d405f5"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("ccc2043c-3ccc-4285-95c2-f63daec454b0"));

            migrationBuilder.DeleteData(
                table: "ChapterSection",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DropColumn(
                name: "Screenshot",
                table: "Forums");

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
        }
    }
}
