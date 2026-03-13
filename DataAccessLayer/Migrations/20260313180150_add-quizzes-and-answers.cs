using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addquizzesandanswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("27ae350f-ed55-493d-a7c4-c506a6610f5f"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("32722c04-287e-4051-953d-703af54c6abd"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("4c2f5dbd-c85a-4bdd-85c7-d6b9ce04f3d6"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("b49f3046-4906-4cf4-89a8-447c60d80fb3"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("c804d0b9-535c-4437-854f-45e57c063e2e"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("5200dbc4-b04d-4a10-8cfa-1ef143ed7701"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("6d28e353-593d-4022-99d7-e4b8cf6b089d"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("8fa4d96b-1fcc-44ce-9cd8-1acd0f1fb694"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("e232a6fb-e273-44e4-a38d-2d2d7d8cb9e0"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("098121d5-304f-45f3-bc61-f9867ad56713"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("0b77ca3f-8f96-4df4-9c17-516e96c159c5"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("8633f25f-632e-49d6-b40f-ad745b1a2742"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("a6420640-a592-44e5-a6ec-3f2ba9389922"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("ede6eb52-1560-4317-a7d3-4133a84f6d55"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29b1e14a-913e-4e34-ac70-57ad38391455", "AQAAAAIAAYagAAAAEOrwclPBzoSlxOFF+1XaF05wFbGABwa9tkzg2jp3w+vlA+arxyDoEtmPfve1Dy0lfw==", "3a62d460-5c58-415b-b357-9bc10806bcb5" });

            // Insert forum seeds only if the referenced Subject exists and forum not already present
            migrationBuilder.Sql(@"IF EXISTS (SELECT 1 FROM [dbo].[Subjects] WHERE Id = '3fe2283b-6751-4633-8903-2043997bbf20') AND NOT EXISTS (SELECT 1 FROM [dbo].[Forums] WHERE Id = '1b33c031-8dee-4f31-930f-7370e02a6e87')
BEGIN
    INSERT INTO [Forums] ([Id], [DiscussionQuestion], [Screenshot], [SubjectId], [Topic]) VALUES ('1b33c031-8dee-4f31-930f-7370e02a6e87', N'What are common algebra problems students face?', NULL, '3fe2283b-6751-4633-8903-2043997bbf20', N'Difficult problems in Algebra');
END");

            migrationBuilder.Sql(@"IF EXISTS (SELECT 1 FROM [dbo].[Subjects] WHERE Id = 'b2df6db3-2b38-4c3a-9517-5e3e2b98b741') AND NOT EXISTS (SELECT 1 FROM [dbo].[Forums] WHERE Id = '58c3fd35-d2f8-4bba-aac7-9a32a0e455ba')
BEGIN
    INSERT INTO [Forums] ([Id], [DiscussionQuestion], [Screenshot], [SubjectId], [Topic]) VALUES ('58c3fd35-d2f8-4bba-aac7-9a32a0e455ba', N'What are common algebra problems students face?', NULL, 'b2df6db3-2b38-4c3a-9517-5e3e2b98b741', N'Difficult problems in Algebra');
END");

            migrationBuilder.Sql(@"IF EXISTS (SELECT 1 FROM [dbo].[Subjects] WHERE Id = 'b2df6db3-2b38-4c3a-9517-5e3e2b98b741') AND NOT EXISTS (SELECT 1 FROM [dbo].[Forums] WHERE Id = '648a20d2-bff7-4a38-a40f-b26a351bc173')
BEGIN
    INSERT INTO [Forums] ([Id], [DiscussionQuestion], [Screenshot], [SubjectId], [Topic]) VALUES ('648a20d2-bff7-4a38-a40f-b26a351bc173', N'How do we understand Newton''s Laws?', NULL, 'b2df6db3-2b38-4c3a-9517-5e3e2b98b741', N'Physics Chapter 1');
END");

            migrationBuilder.Sql(@"IF EXISTS (SELECT 1 FROM [dbo].[Subjects] WHERE Id = 'b2df6db3-2b38-4c3a-9517-5e3e2b98b741') AND NOT EXISTS (SELECT 1 FROM [dbo].[Forums] WHERE Id = 'a87241e0-6a8a-4d6f-b2f9-dc2f718083c5')
BEGIN
    INSERT INTO [Forums] ([Id], [DiscussionQuestion], [Screenshot], [SubjectId], [Topic]) VALUES ('a87241e0-6a8a-4d6f-b2f9-dc2f718083c5', N'What are the best study guides for exam preparation?', NULL, 'b2df6db3-2b38-4c3a-9517-5e3e2b98b741', N'Best study guides?');
END");

            migrationBuilder.Sql(@"IF EXISTS (SELECT 1 FROM [dbo].[Subjects] WHERE Id = 'b2df6db3-2b38-4c3a-9517-5e3e2b98b741') AND NOT EXISTS (SELECT 1 FROM [dbo].[Forums] WHERE Id = 'd1966477-0039-4d39-bdf8-feb7418e22c7')
BEGIN
    INSERT INTO [Forums] ([Id], [DiscussionQuestion], [Screenshot], [SubjectId], [Topic]) VALUES ('d1966477-0039-4d39-bdf8-feb7418e22c7', N'How should I approach exam preparation effectively?', NULL, 'b2df6db3-2b38-4c3a-9517-5e3e2b98b741', N'Exam preparation tips');
END");

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Duration", "EndDate", "ModifiedAt", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("05e57366-1a65-4199-828d-fdef273022f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jul - Sep", null, null, "Term 3", null },
                    { new Guid("c1ecb4c6-3c23-49d1-8395-dd9fffff4c09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Apr - Jun", null, null, "Term 2", null },
                    { new Guid("e193b82c-7381-432d-a1fa-ee22136ff46a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Oct - Dec", null, null, "Term 4", null },
                    { new Guid("face04fa-dcf4-45be-8d95-289e0df75fcd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jan - Mar", null, null, "Term 1", null }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("00b588fc-037f-4439-a310-1ef63c44eca8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2020 },
                    { new Guid("01be353c-80a1-45d1-ac45-71ac1be33d25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2021 },
                    { new Guid("3478f862-9b82-4015-b8eb-2a538137935f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2022 },
                    { new Guid("ba5018c1-ace8-4b58-92ed-88b1e6df1f1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2024 },
                    { new Guid("efba28a1-8947-4ae6-808f-a18cad8f0e10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("1b33c031-8dee-4f31-930f-7370e02a6e87"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("58c3fd35-d2f8-4bba-aac7-9a32a0e455ba"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("648a20d2-bff7-4a38-a40f-b26a351bc173"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("a87241e0-6a8a-4d6f-b2f9-dc2f718083c5"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("d1966477-0039-4d39-bdf8-feb7418e22c7"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("05e57366-1a65-4199-828d-fdef273022f6"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("c1ecb4c6-3c23-49d1-8395-dd9fffff4c09"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("e193b82c-7381-432d-a1fa-ee22136ff46a"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("face04fa-dcf4-45be-8d95-289e0df75fcd"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("00b588fc-037f-4439-a310-1ef63c44eca8"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("01be353c-80a1-45d1-ac45-71ac1be33d25"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("3478f862-9b82-4015-b8eb-2a538137935f"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("ba5018c1-ace8-4b58-92ed-88b1e6df1f1b"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("efba28a1-8947-4ae6-808f-a18cad8f0e10"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "501b0e44-dd5c-4db7-9edf-18010c8e2530", "AQAAAAIAAYagAAAAEEKw3nTHqRrYpf4d3h/U3hbPaVrDtRbXJiq92q89k/n4lo9gQ3qGm+D2/SgHbUoRfA==", "3c5c3623-0fbb-4a16-8bd5-bec20d0bb65f" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "Screenshot", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("27ae350f-ed55-493d-a7c4-c506a6610f5f"), "What are common algebra problems students face?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("32722c04-287e-4051-953d-703af54c6abd"), "How do we understand Newton’s Laws?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("4c2f5dbd-c85a-4bdd-85c7-d6b9ce04f3d6"), "What are the best study guides for exam preparation?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("b49f3046-4906-4cf4-89a8-447c60d80fb3"), "How should I approach exam preparation effectively?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" },
                    { new Guid("c804d0b9-535c-4437-854f-45e57c063e2e"), "What are common algebra problems students face?", null, new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Duration", "EndDate", "ModifiedAt", "Name", "StartDate" },
                values: new object[,]
                {
                    { new Guid("5200dbc4-b04d-4a10-8cfa-1ef143ed7701"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Apr - Jun", null, null, "Term 2", null },
                    { new Guid("6d28e353-593d-4022-99d7-e4b8cf6b089d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Oct - Dec", null, null, "Term 4", null },
                    { new Guid("8fa4d96b-1fcc-44ce-9cd8-1acd0f1fb694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jan - Mar", null, null, "Term 1", null },
                    { new Guid("e232a6fb-e273-44e4-a38d-2d2d7d8cb9e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jul - Sep", null, null, "Term 3", null }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("098121d5-304f-45f3-bc61-f9867ad56713"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2022 },
                    { new Guid("0b77ca3f-8f96-4df4-9c17-516e96c159c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2023 },
                    { new Guid("8633f25f-632e-49d6-b40f-ad745b1a2742"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2024 },
                    { new Guid("a6420640-a592-44e5-a6ec-3f2ba9389922"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2020 },
                    { new Guid("ede6eb52-1560-4317-a7d3-4133a84f6d55"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2021 }
                });
        }
    }
}
