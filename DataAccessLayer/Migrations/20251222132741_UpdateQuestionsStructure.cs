using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuestionsStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("0e8e0ea0-3d5b-4786-94e1-d33178d04378"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("d63f64ac-9de0-4098-9e64-482d9008f5bb"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("f2e1a133-5ba0-4c3c-b2ee-3e9f25a16a33"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("f7a3ea3e-f2bd-4772-be50-55a663791746"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("f9f64363-aaf3-446e-a8a2-e81aa0e061a3"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("49ce4c31-f032-450b-ac81-9950c8052a46"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("e791d99e-2a6f-4792-b02e-5472b718a54e"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("f918359a-498f-46c3-8928-1c4317b78af7"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("fc977587-a042-4037-bf45-a11551288e2e"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("090fc745-6b53-42af-a2f0-3442f3280d2f"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("8fceb78d-6b28-4eae-8a7e-db9d5912cbc1"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("aa462ed6-bdf7-4b82-8e84-43c6f78a84a9"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("e11906d0-7520-411a-aa3b-fdee890ccd29"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("fdac523c-00e2-4ffe-9497-5cdab5959335"));

            migrationBuilder.AddColumn<int>(
                name: "MaxSelections",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Options",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b29c20f-9706-4645-a4fc-61f91dc7974f", "AQAAAAIAAYagAAAAEMrjrxuQ9RtsDtwspC9QaIXDxb22hFMtlmdwQa6FztfgrBvc7zp6xnlFjUX1Y/1AXQ==", "803deda9-6b38-4cce-9224-b1b92ae73e1d" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "Screenshot", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("5db519b9-af1e-435b-9e3d-9ec86e8ea275"), "What are common algebra problems students face?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("88af048c-ec43-4737-8c56-80a83b64330b"), "What are common algebra problems students face?", null, new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("b7c4ffea-e19a-4a7c-84bb-c5ac39d6e9b5"), "What are the best study guides for exam preparation?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("d842efc6-2baa-4a3d-944b-d6905b489dd4"), "How do we understand Newton’s Laws?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("f1a403d2-1e6b-47d7-8188-617c0c73c897"), "How should I approach exam preparation effectively?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("14800601-fbc9-40be-ba7f-876cb21f2c5e"), "Jul - Sep", "Term 3" },
                    { new Guid("324fd5f7-96f0-4d3a-85d0-dbe77d0590af"), "Oct - Dec", "Term 4" },
                    { new Guid("a74a6af6-4b26-4f64-bcdc-64922ee539a4"), "Apr - Jun", "Term 2" },
                    { new Guid("fdfaf835-0a7d-4252-810e-0ab2f06a6b43"), "Jan - Mar", "Term 1" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("0eff7484-b76b-4552-a008-7b12a6f097c2"), 2024 },
                    { new Guid("2a88547d-fcee-46e9-9bd8-4fd281ab2d64"), 2020 },
                    { new Guid("57535a16-c031-4e26-bc1f-25ba1b0f8a93"), 2021 },
                    { new Guid("db1afc20-b1e2-486e-a6df-7ce655c8632c"), 2023 },
                    { new Guid("f12f3ea6-1b85-4a56-845b-391acfaa52f6"), 2022 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("5db519b9-af1e-435b-9e3d-9ec86e8ea275"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("88af048c-ec43-4737-8c56-80a83b64330b"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("b7c4ffea-e19a-4a7c-84bb-c5ac39d6e9b5"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("d842efc6-2baa-4a3d-944b-d6905b489dd4"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("f1a403d2-1e6b-47d7-8188-617c0c73c897"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("14800601-fbc9-40be-ba7f-876cb21f2c5e"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("324fd5f7-96f0-4d3a-85d0-dbe77d0590af"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("a74a6af6-4b26-4f64-bcdc-64922ee539a4"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("fdfaf835-0a7d-4252-810e-0ab2f06a6b43"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("0eff7484-b76b-4552-a008-7b12a6f097c2"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("2a88547d-fcee-46e9-9bd8-4fd281ab2d64"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("57535a16-c031-4e26-bc1f-25ba1b0f8a93"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("db1afc20-b1e2-486e-a6df-7ce655c8632c"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("f12f3ea6-1b85-4a56-845b-391acfaa52f6"));

            migrationBuilder.DropColumn(
                name: "MaxSelections",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Options",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d3f76ae-3b48-450c-931f-389c95a470d0", "AQAAAAIAAYagAAAAEO30xzS570w8Tx8qFemEa1lONPMMyKA140Fng+3tt9/Jlaq39fJtT15/7fhd7hkY3A==", "19567588-92f3-4192-8fbb-de7f67d1ae55" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "Screenshot", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("0e8e0ea0-3d5b-4786-94e1-d33178d04378"), "How do we understand Newton’s Laws?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("d63f64ac-9de0-4098-9e64-482d9008f5bb"), "What are the best study guides for exam preparation?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("f2e1a133-5ba0-4c3c-b2ee-3e9f25a16a33"), "How should I approach exam preparation effectively?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" },
                    { new Guid("f7a3ea3e-f2bd-4772-be50-55a663791746"), "What are common algebra problems students face?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("f9f64363-aaf3-446e-a8a2-e81aa0e061a3"), "What are common algebra problems students face?", null, new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("49ce4c31-f032-450b-ac81-9950c8052a46"), "Jul - Sep", "Term 3" },
                    { new Guid("e791d99e-2a6f-4792-b02e-5472b718a54e"), "Apr - Jun", "Term 2" },
                    { new Guid("f918359a-498f-46c3-8928-1c4317b78af7"), "Oct - Dec", "Term 4" },
                    { new Guid("fc977587-a042-4037-bf45-a11551288e2e"), "Jan - Mar", "Term 1" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("090fc745-6b53-42af-a2f0-3442f3280d2f"), 2021 },
                    { new Guid("8fceb78d-6b28-4eae-8a7e-db9d5912cbc1"), 2023 },
                    { new Guid("aa462ed6-bdf7-4b82-8e84-43c6f78a84a9"), 2022 },
                    { new Guid("e11906d0-7520-411a-aa3b-fdee890ccd29"), 2024 },
                    { new Guid("fdac523c-00e2-4ffe-9497-5cdab5959335"), 2020 }
                });
        }
    }
}
