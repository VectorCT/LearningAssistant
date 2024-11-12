using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class linkSubjectYear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "SubjectYears",
                columns: table => new
                {
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    YearId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectYears", x => new { x.YearId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_SubjectYears_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectYears_Years_YearId",
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

            migrationBuilder.CreateIndex(
                name: "IX_SubjectYears_SubjectId",
                table: "SubjectYears",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectYears");

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
        }
    }
}
