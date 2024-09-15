using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class notnull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forums_Subjects_SubjectId",
                table: "Forums");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("11bb9624-2c8b-4386-add6-decd914b8a1c"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("1982cdb3-0bb0-4231-924b-7e1a792f3102"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("5a3f0e81-700b-43e4-80f5-750096a6f391"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("df4a1879-6b87-4f6e-8874-c9b6ba35cf03"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("f2f8d30c-7b6f-4214-bc48-e5b035646fbc"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("043e2788-0869-404c-921d-8b96ee7a196f"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("131aed40-9764-489b-bd15-c6d8b65ce2ca"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("76cef0a0-eaf2-40f2-9084-353f0a3124d1"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("d68ba6ed-f2d1-446e-aec9-524bf6337666"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("3e9ec2f9-d47c-4c32-b491-1c5333646a8a"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("b1bcb39a-86d0-4550-a58a-ae298001e7f2"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("cc52bf88-cbfb-4f09-b56c-58a03bfb1aee"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("d341c28b-9c6d-44a7-a6bc-ea6d8b530418"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("f1a58bb0-94b3-4379-9f85-13ffdce020e2"));

            migrationBuilder.AlterColumn<Guid>(
                name: "SubjectId",
                table: "Forums",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_Subjects_SubjectId",
                table: "Forums",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forums_Subjects_SubjectId",
                table: "Forums");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "SubjectId",
                table: "Forums",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f155c4b-c7d3-4436-97e0-954adb87930c", "AQAAAAIAAYagAAAAEFMGx2YWHSCyvirY95Qim+xiJmIYvFuDH+krqf9ZIvK6owa+qREQG4Kp/P5qyrtEXQ==", "c49cfb4c-5028-4842-8b9f-73ca1256b5f7" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("11bb9624-2c8b-4386-add6-decd914b8a1c"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("1982cdb3-0bb0-4231-924b-7e1a792f3102"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("5a3f0e81-700b-43e4-80f5-750096a6f391"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("df4a1879-6b87-4f6e-8874-c9b6ba35cf03"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("f2f8d30c-7b6f-4214-bc48-e5b035646fbc"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("043e2788-0869-404c-921d-8b96ee7a196f"), "Apr - Jun", "Term 2" },
                    { new Guid("131aed40-9764-489b-bd15-c6d8b65ce2ca"), "Jul - Sep", "Term 3" },
                    { new Guid("76cef0a0-eaf2-40f2-9084-353f0a3124d1"), "Jan - Mar", "Term 1" },
                    { new Guid("d68ba6ed-f2d1-446e-aec9-524bf6337666"), "Oct - Dec", "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("3e9ec2f9-d47c-4c32-b491-1c5333646a8a"), 2024 },
                    { new Guid("b1bcb39a-86d0-4550-a58a-ae298001e7f2"), 2022 },
                    { new Guid("cc52bf88-cbfb-4f09-b56c-58a03bfb1aee"), 2020 },
                    { new Guid("d341c28b-9c6d-44a7-a6bc-ea6d8b530418"), 2021 },
                    { new Guid("f1a58bb0-94b3-4379-9f85-13ffdce020e2"), 2023 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_Subjects_SubjectId",
                table: "Forums",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id");
        }
    }
}
