using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class additionalSubjectColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("2203ad2c-b713-4039-b63c-b463832ccee3"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("3e8a434e-f56a-494b-ae49-f265325379c1"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("4793f280-c07c-47b1-8fff-49732bf12391"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("6329fc57-c2b7-443d-9085-6bab6533edb2"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("e0e085c5-9142-485b-99f7-b1a2a04350c0"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("025758b2-1108-4df8-b2d0-00b090bac49b"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("718ffa52-9e13-42d2-8678-83abb9438cc0"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("b569f424-d857-453e-8647-331c90ba0af4"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("d2703a9d-1704-498e-9aea-3e5d655d0847"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("1bbe3c60-a241-4041-bbf9-067102ac81af"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("93d7db65-fb36-40f4-9e70-65ae9d62ca16"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("c3b523e6-a6d4-4930-b72d-ced7eb73e354"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("ea44a6fd-25a0-4c3e-8f90-25bd5bdf400e"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("f3be7543-60b8-4411-b8fa-6a1cb4f8f4c1"));

            migrationBuilder.AddColumn<string>(
                name: "PrescribedTextBookFileUrl",
                table: "Subjects",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubjectDescription",
                table: "Subjects",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubjectImageUrl",
                table: "Subjects",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "PastPapers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "PastMemorandums",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "899c9f31-f92a-41ef-b669-be559b2b9c7c", "AQAAAAIAAYagAAAAEH5cYvWUF8JnEEToAe0GPdxZCOyCwRiIhWBCkijkTolBaxMfOw2nR+AAJXbL4B3pgg==", "a0c03c8c-3d34-473c-8f0d-5f7bc54d011f" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("2599134e-c4ac-4c61-b0f8-67a4c602ae88"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("30cf5611-416f-426f-b57d-931c1d2fdaa6"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("6fa3f772-0f98-4ec8-b146-73cdd0d14bc6"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("9086c175-886b-42b8-89b4-378ad9130b92"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("9bc1e979-a78b-4175-9a4a-7f609b08f718"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("4b1e2df5-c5ad-488e-94d6-b249d1016c40"),
                columns: new[] { "PrescribedTextBookFileUrl", "SubjectDescription", "SubjectImageUrl" },
                values: new object[] { "", "Science Description", "" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"),
                columns: new[] { "PrescribedTextBookFileUrl", "SubjectDescription", "SubjectImageUrl" },
                values: new object[] { "", "Math Description", "" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8bae0fe9-7853-4d3d-949c-b5537303f330"),
                columns: new[] { "Name", "PrescribedTextBookFileUrl", "SubjectDescription", "SubjectImageUrl" },
                values: new object[] { "Life Science", "", "Life Science Description", "" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("948e6d61-8d75-46ca-8701-8921979eb1fa"),
                columns: new[] { "PrescribedTextBookFileUrl", "SubjectDescription", "SubjectImageUrl" },
                values: new object[] { "", "Chemistry Description", "" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c62a461a-0ab8-4bd7-83c4-a1bbb56a4772"),
                columns: new[] { "PrescribedTextBookFileUrl", "SubjectDescription", "SubjectImageUrl" },
                values: new object[] { "", "Geography Description", "" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("55427cde-4f1a-4dc5-adb0-14c602473e61"), "Apr - Jun", "Term 2" },
                    { new Guid("7babc12c-39c2-4184-90b3-b18c058e14a7"), "Oct - Dec", "Term 4" },
                    { new Guid("9ffad846-0931-4662-ae92-04a7f2b4b4e4"), "Jul - Sep", "Term 3" },
                    { new Guid("f764eba1-c31b-4012-b9b3-50ed56c5398d"), "Jan - Mar", "Term 1" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("5685d55c-3aee-4abf-b87e-0fb47f85f5f7"), 2023 },
                    { new Guid("74056caa-0668-4f36-b438-71fe6a176c6e"), 2024 },
                    { new Guid("a0086435-4f50-45d4-bdbf-fcb0bdb2ce8b"), 2020 },
                    { new Guid("ec81fc2c-1c3c-4a57-878b-ad8729bab3f5"), 2021 },
                    { new Guid("fda2ad56-66b6-47e4-9ce2-e14ea7210542"), 2022 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("2599134e-c4ac-4c61-b0f8-67a4c602ae88"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("30cf5611-416f-426f-b57d-931c1d2fdaa6"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("6fa3f772-0f98-4ec8-b146-73cdd0d14bc6"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("9086c175-886b-42b8-89b4-378ad9130b92"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("9bc1e979-a78b-4175-9a4a-7f609b08f718"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("55427cde-4f1a-4dc5-adb0-14c602473e61"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("7babc12c-39c2-4184-90b3-b18c058e14a7"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("9ffad846-0931-4662-ae92-04a7f2b4b4e4"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("f764eba1-c31b-4012-b9b3-50ed56c5398d"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("5685d55c-3aee-4abf-b87e-0fb47f85f5f7"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("74056caa-0668-4f36-b438-71fe6a176c6e"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("a0086435-4f50-45d4-bdbf-fcb0bdb2ce8b"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("ec81fc2c-1c3c-4a57-878b-ad8729bab3f5"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("fda2ad56-66b6-47e4-9ce2-e14ea7210542"));

            migrationBuilder.DropColumn(
                name: "PrescribedTextBookFileUrl",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SubjectDescription",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SubjectImageUrl",
                table: "Subjects");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "PastPapers",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "PastMemorandums",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3e2135d-257a-43f4-bd71-3353b01b05fd", "AQAAAAIAAYagAAAAEG4Fjgt9HirvXYYqbBmPpo4lJAWPdvU+Wdioa6xJWcS/J2SPUe8lRmGp2lDcFIZPdg==", "0fb6feb8-99ef-4d5f-9dc9-9876b0efc602" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("2203ad2c-b713-4039-b63c-b463832ccee3"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("3e8a434e-f56a-494b-ae49-f265325379c1"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("4793f280-c07c-47b1-8fff-49732bf12391"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("6329fc57-c2b7-443d-9085-6bab6533edb2"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" },
                    { new Guid("e0e085c5-9142-485b-99f7-b1a2a04350c0"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("8bae0fe9-7853-4d3d-949c-b5537303f330"),
                column: "Name",
                value: "Biology");

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("025758b2-1108-4df8-b2d0-00b090bac49b"), "Apr - Jun", "Term 2" },
                    { new Guid("718ffa52-9e13-42d2-8678-83abb9438cc0"), "Jul - Sep", "Term 3" },
                    { new Guid("b569f424-d857-453e-8647-331c90ba0af4"), "Jan - Mar", "Term 1" },
                    { new Guid("d2703a9d-1704-498e-9aea-3e5d655d0847"), "Oct - Dec", "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("1bbe3c60-a241-4041-bbf9-067102ac81af"), 2020 },
                    { new Guid("93d7db65-fb36-40f4-9e70-65ae9d62ca16"), 2022 },
                    { new Guid("c3b523e6-a6d4-4930-b72d-ced7eb73e354"), 2024 },
                    { new Guid("ea44a6fd-25a0-4c3e-8f90-25bd5bdf400e"), 2023 },
                    { new Guid("f3be7543-60b8-4411-b8fa-6a1cb4f8f4c1"), 2021 }
                });
        }
    }
}
