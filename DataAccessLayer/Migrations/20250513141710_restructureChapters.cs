using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class restructureChapters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("268ead06-5492-44e9-969e-ddd6bce1172b"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("3732d6b3-15b8-4941-a87b-50befbef82ac"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("44a7f98a-3f54-4370-b4aa-720596fb7174"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("827fa14e-6690-4933-91a6-b54d019ccb8c"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("8b5123d6-d3a4-467b-b12a-b081f0868b75"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("366df5d5-9ed4-4b46-8400-d5f0c907844b"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("69043259-47d3-4e8a-a23f-61154187976c"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("98b9cca4-6df4-4b73-9532-eecb2caa7e19"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("c796a6ba-1133-4849-aae4-1e9dfd6bef61"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("2bf34d54-2284-4d02-8552-42018e793a6d"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("714dc8aa-5a56-4fbb-94a0-bb808fcbb20f"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("c359d331-7f86-4041-a677-16cad9b0fee9"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("c7d914ef-295a-405a-bec8-e80785d33134"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("d2a0f9da-c79a-4a81-9446-84950b060759"));

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Chapters");

            migrationBuilder.CreateTable(
                name: "ChapterSection",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChapterSection_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ChapterSection_ChapterId",
                table: "ChapterSection",
                column: "ChapterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChapterSection");

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
                name: "Content",
                table: "Chapters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c8faca8-cd7d-4525-8f6c-ce22403c4cb4", "AQAAAAIAAYagAAAAEEhFc/5tVKq19l7rOs3aCaWUqPPODq24+SM5LHaMXIcHNdyXQnRGoqQvikyFjWM9Pg==", "b38a9389-a685-4714-98fb-35272a3663a0" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("268ead06-5492-44e9-969e-ddd6bce1172b"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("3732d6b3-15b8-4941-a87b-50befbef82ac"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("44a7f98a-3f54-4370-b4aa-720596fb7174"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("827fa14e-6690-4933-91a6-b54d019ccb8c"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("8b5123d6-d3a4-467b-b12a-b081f0868b75"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("366df5d5-9ed4-4b46-8400-d5f0c907844b"), "Oct - Dec", "Term 4" },
                    { new Guid("69043259-47d3-4e8a-a23f-61154187976c"), "Apr - Jun", "Term 2" },
                    { new Guid("98b9cca4-6df4-4b73-9532-eecb2caa7e19"), "Jul - Sep", "Term 3" },
                    { new Guid("c796a6ba-1133-4849-aae4-1e9dfd6bef61"), "Jan - Mar", "Term 1" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("2bf34d54-2284-4d02-8552-42018e793a6d"), 2023 },
                    { new Guid("714dc8aa-5a56-4fbb-94a0-bb808fcbb20f"), 2020 },
                    { new Guid("c359d331-7f86-4041-a677-16cad9b0fee9"), 2021 },
                    { new Guid("c7d914ef-295a-405a-bec8-e80785d33134"), 2022 },
                    { new Guid("d2a0f9da-c79a-4a81-9446-84950b060759"), 2024 }
                });
        }
    }
}
