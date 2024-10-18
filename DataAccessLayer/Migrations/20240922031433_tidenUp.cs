using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class tidenUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PastMemorandums_Subjects_SubjectId",
                table: "PastMemorandums");

            migrationBuilder.DropIndex(
                name: "IX_PastMemorandums_SubjectId",
                table: "PastMemorandums");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("0a7d699a-13a2-4fdb-b0ad-12a6ce9052bd"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("2f0dfd4b-c1a0-4eef-bae5-e94ce89989a6"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("4cc9faa2-aeba-49f1-bda0-c97e926be087"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("892d2858-1498-4948-9b4f-23db99753e19"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("8faed0f8-5d22-48bc-accf-1e924dbbe62f"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("740bc85e-2943-4120-94ed-27d90863809d"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("ae5705ac-a35d-4bdc-8a86-0050e52512f4"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("bc9a070a-22ca-45d9-9cff-40348c501379"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("e25d169f-db1a-4ce2-a05c-c71c68db2112"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("2dfbc084-ea30-4e05-abab-f6e1a7b8956a"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("8313b46b-4419-4be0-9484-3fab328df9c7"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("93704109-ab99-443d-83e6-017f995ca664"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("d60bd7f2-0c4d-4e5e-bbb9-00c060fafdcc"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("e573bb63-0171-4ddf-9fd7-7abe0026cdb4"));

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "PastMemorandums");

            migrationBuilder.AddColumn<Guid>(
                name: "YearId",
                table: "PastPapers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_PastPapers_YearId",
                table: "PastPapers",
                column: "YearId");

            migrationBuilder.AddForeignKey(
                name: "FK_PastPapers_Years_YearId",
                table: "PastPapers",
                column: "YearId",
                principalTable: "Years",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PastPapers_Years_YearId",
                table: "PastPapers");

            migrationBuilder.DropIndex(
                name: "IX_PastPapers_YearId",
                table: "PastPapers");

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

            migrationBuilder.DropColumn(
                name: "YearId",
                table: "PastPapers");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Chapters");

            migrationBuilder.AddColumn<Guid>(
                name: "SubjectId",
                table: "PastMemorandums",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21368df0-6d7e-4fb2-8108-3dc397749bca", "AQAAAAIAAYagAAAAEBiiyuZ3+tktkWhE9PUV8e5pZkBlqznpB7zNhJuK8Fv84y/VmaiVOwPoFwmholOROA==", "e470e073-d1c4-4e92-97de-6d0a983f74d6" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("0a7d699a-13a2-4fdb-b0ad-12a6ce9052bd"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("2f0dfd4b-c1a0-4eef-bae5-e94ce89989a6"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" },
                    { new Guid("4cc9faa2-aeba-49f1-bda0-c97e926be087"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("892d2858-1498-4948-9b4f-23db99753e19"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("8faed0f8-5d22-48bc-accf-1e924dbbe62f"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("740bc85e-2943-4120-94ed-27d90863809d"), "Jul - Sep", "Term 3" },
                    { new Guid("ae5705ac-a35d-4bdc-8a86-0050e52512f4"), "Oct - Dec", "Term 4" },
                    { new Guid("bc9a070a-22ca-45d9-9cff-40348c501379"), "Jan - Mar", "Term 1" },
                    { new Guid("e25d169f-db1a-4ce2-a05c-c71c68db2112"), "Apr - Jun", "Term 2" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("2dfbc084-ea30-4e05-abab-f6e1a7b8956a"), 2023 },
                    { new Guid("8313b46b-4419-4be0-9484-3fab328df9c7"), 2024 },
                    { new Guid("93704109-ab99-443d-83e6-017f995ca664"), 2021 },
                    { new Guid("d60bd7f2-0c4d-4e5e-bbb9-00c060fafdcc"), 2022 },
                    { new Guid("e573bb63-0171-4ddf-9fd7-7abe0026cdb4"), 2020 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PastMemorandums_SubjectId",
                table: "PastMemorandums",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_PastMemorandums_Subjects_SubjectId",
                table: "PastMemorandums",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
