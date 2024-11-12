using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class linkPapers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PastPaperMemorandums_PastPapers_PastPaperId",
                table: "PastPaperMemorandums");

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

            migrationBuilder.AddColumn<Guid>(
                name: "PastPaperId",
                table: "PastMemorandums",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d95badb3-81d6-44fb-89aa-9b55cc9881ba", "AQAAAAIAAYagAAAAEL049y8Hvqlk1eJ5Jt+FVk6Tmv2/OJJgdrhq3vSjOP71LzcKY82uoRuBHS4Fcz9YaA==", "3c1077b2-198d-4e87-8a44-f6b081135a6f" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("42b49949-596b-4415-aab2-546ceb398731"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("6031f48a-c711-46e4-8562-5b6687adcb34"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("87749244-b61a-46d2-adeb-ef059d7c75de"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" },
                    { new Guid("c86131aa-ae78-4ccc-879a-9509333e01ee"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("e4d530e2-017f-4d20-beaf-c5ada90d330e"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("386f3ca0-1f3a-4b93-ad11-15fc97c12352"), "Jan - Mar", "Term 1" },
                    { new Guid("46c6696d-9fdb-445b-bc69-f083731734b3"), "Oct - Dec", "Term 4" },
                    { new Guid("daa3d4dc-6767-4258-aecf-130f9a20c580"), "Jul - Sep", "Term 3" },
                    { new Guid("ff5aa618-c5ff-4036-b301-e89d714b09d9"), "Apr - Jun", "Term 2" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("0c0048fe-76d0-4c1f-bcae-0c47010a6820"), 2020 },
                    { new Guid("2b3db392-8c6e-48e7-934e-eab4d77c6fb4"), 2024 },
                    { new Guid("31dd6771-593e-411e-adda-43295bf59c38"), 2021 },
                    { new Guid("a55e8818-c6c9-45c0-a0d3-40f1b67c1f5a"), 2022 },
                    { new Guid("eddfde96-550b-4cc3-916b-8493ffb111a7"), 2023 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PastMemorandums_PastPaperId",
                table: "PastMemorandums",
                column: "PastPaperId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PastMemorandums_PastPapers_PastPaperId",
                table: "PastMemorandums",
                column: "PastPaperId",
                principalTable: "PastPapers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PastPaperMemorandums_PastPapers_PastPaperId",
                table: "PastPaperMemorandums",
                column: "PastPaperId",
                principalTable: "PastPapers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PastMemorandums_PastPapers_PastPaperId",
                table: "PastMemorandums");

            migrationBuilder.DropForeignKey(
                name: "FK_PastPaperMemorandums_PastPapers_PastPaperId",
                table: "PastPaperMemorandums");

            migrationBuilder.DropIndex(
                name: "IX_PastMemorandums_PastPaperId",
                table: "PastMemorandums");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("42b49949-596b-4415-aab2-546ceb398731"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("6031f48a-c711-46e4-8562-5b6687adcb34"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("87749244-b61a-46d2-adeb-ef059d7c75de"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("c86131aa-ae78-4ccc-879a-9509333e01ee"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("e4d530e2-017f-4d20-beaf-c5ada90d330e"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("386f3ca0-1f3a-4b93-ad11-15fc97c12352"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("46c6696d-9fdb-445b-bc69-f083731734b3"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("daa3d4dc-6767-4258-aecf-130f9a20c580"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("ff5aa618-c5ff-4036-b301-e89d714b09d9"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("0c0048fe-76d0-4c1f-bcae-0c47010a6820"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("2b3db392-8c6e-48e7-934e-eab4d77c6fb4"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("31dd6771-593e-411e-adda-43295bf59c38"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("a55e8818-c6c9-45c0-a0d3-40f1b67c1f5a"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("eddfde96-550b-4cc3-916b-8493ffb111a7"));

            migrationBuilder.DropColumn(
                name: "PastPaperId",
                table: "PastMemorandums");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PastPaperMemorandums_PastPapers_PastPaperId",
                table: "PastPaperMemorandums",
                column: "PastPaperId",
                principalTable: "PastPapers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
