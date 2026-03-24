using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class removeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("4fec6eae-2c0f-4adc-9260-1267c3dab170"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("d8bb409a-c4b6-41a4-a7ee-57f9880a1bc8"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("dd060e17-e5c8-42a1-9529-00a51660581c"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("df3725d9-0c15-4c57-90fd-ea28a65b627b"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("f0b4e6d5-1632-4a03-81fe-8f8424eae98d"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("6c63220b-e83b-4e0b-86f0-629c98501571"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("6c84b3fa-ab3b-4a1f-a4a0-df26cee87e0b"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("9cd53201-1d1c-4a25-bac5-77da42b98d15"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("9e743446-dd65-412b-b9c4-fdc915312465"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("e27fd1a7-1381-4878-8a69-9cd78aca328a"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32fa7b97-e6e2-403c-b297-ccff971b2579", "AQAAAAIAAYagAAAAEMb3QkYUJ2q2IWc6V8vfKlMcEBaQ5eVt7BBMYmqmqqMrOVu9zv3oaF0RL1DlOme4tw==", "b838966f-2ec7-427b-95e7-d2d4957bd134" });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("80f58e96-693e-405b-a8f2-295458cb0d6e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2024 },
                    { new Guid("9dae6545-5d77-478c-b154-530bde599489"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2020 },
                    { new Guid("a6e78972-5244-434f-8fd1-6af63a1c3433"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2022 },
                    { new Guid("af7a3d1b-efa2-4727-923e-57738930818d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2021 },
                    { new Guid("b36e124d-7a25-4a90-af4b-b38964100809"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("80f58e96-693e-405b-a8f2-295458cb0d6e"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("9dae6545-5d77-478c-b154-530bde599489"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("a6e78972-5244-434f-8fd1-6af63a1c3433"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("af7a3d1b-efa2-4727-923e-57738930818d"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("b36e124d-7a25-4a90-af4b-b38964100809"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0f0880a-3f6e-4697-8c89-e4e6e8dd9a7f", "AQAAAAIAAYagAAAAEHRMl8+MVAY5lPabFqQSTsLra1QgrOBTMa21fZKTOOt05Uf4DR2Uh/lR3FAn96E68A==", "b10054c7-64de-4c49-ba7c-86212c242060" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "Screenshot", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("4fec6eae-2c0f-4adc-9260-1267c3dab170"), "What are the best study guides for exam preparation?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("d8bb409a-c4b6-41a4-a7ee-57f9880a1bc8"), "How do we understand Newton’s Laws?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("dd060e17-e5c8-42a1-9529-00a51660581c"), "What are common algebra problems students face?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("df3725d9-0c15-4c57-90fd-ea28a65b627b"), "How should I approach exam preparation effectively?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" },
                    { new Guid("f0b4e6d5-1632-4a03-81fe-8f8424eae98d"), "What are common algebra problems students face?", null, new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("6c63220b-e83b-4e0b-86f0-629c98501571"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2023 },
                    { new Guid("6c84b3fa-ab3b-4a1f-a4a0-df26cee87e0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2024 },
                    { new Guid("9cd53201-1d1c-4a25-bac5-77da42b98d15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2022 },
                    { new Guid("9e743446-dd65-412b-b9c4-fdc915312465"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2020 },
                    { new Guid("e27fd1a7-1381-4878-8a69-9cd78aca328a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 2021 }
                });
        }
    }
}
