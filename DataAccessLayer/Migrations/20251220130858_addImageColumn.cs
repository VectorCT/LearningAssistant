using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addImageColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("0abf9894-3900-4f4c-a5ef-ba38e65fe4a9"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("34c1dd73-3bac-4569-80d9-128f4cf563bb"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("f30cd2a6-0286-4cf7-9513-0a3cb50f0b22"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("f7498361-6dd4-4421-9674-ea6963c5b7de"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("fd7b32ad-1b2b-48bc-9709-1d6041f8417c"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("34ef466b-aa20-463a-8f8d-03597c21a784"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("58a711dd-bcf1-48fd-a01b-2106bef410d1"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("8e315cd9-f52b-4a76-adc4-376dadcb0af2"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("cec54d64-6c2d-4fe2-83ef-38bee82d3be8"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("0a27d1bd-5f60-4624-99df-3634d80f0924"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("122ac230-43e6-4a77-9888-482a5eafa37c"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("3b80c8d7-bf13-4b58-aeea-60591dea4987"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("9d2d9624-c06e-4c51-9600-4be41e3d0f07"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("e9880002-95b7-4e23-8fb9-dea3e7c0a2a3"));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ChapterSections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d3f76ae-3b48-450c-931f-389c95a470d0", "AQAAAAIAAYagAAAAEO30xzS570w8Tx8qFemEa1lONPMMyKA140Fng+3tt9/Jlaq39fJtT15/7fhd7hkY3A==", "19567588-92f3-4192-8fbb-de7f67d1ae55" });

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a1a1a1a1-a1a1-a1a1-a1a1-a1a1a1a1a1a1"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a2a2a2a2-a2a2-a2a2-a2a2-a2a2a2a2a2a2"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a3a3a3a3-a3a3-a3a3-a3a3-a3a3a3a3a3a3"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a4a4a4a4-a4a4-a4a4-a4a4-a4a4a4a4a4a4"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a5a5a5a5-a5a5-a5a5-a5a5-a5a5a5a5a5a5"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a6a6a6a6-a6a6-a6a6-a6a6-a6a6a6a6a6a6"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a7a7a7a7-a7a7-a7a7-a7a7-a7a7a7a7a7a7"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a8a8a8a8-a8a8-a8a8-a8a8-a8a8a8a8a8a8"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a9a9a9a9-a9a9-a9a9-a9a9-a9a9a9a9a9a9"),
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("b1b1b1b1-b1b1-b1b1-b1b1-b1b1b1b1b1b1"),
                column: "Image",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ChapterSections");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce35f0a1-bb66-4e57-b195-1c38ec6a2556", "AQAAAAIAAYagAAAAEJrdH0l0j+SFmO4oHEUv2EmBVfN4qprBLUVf1gTboaw5H5heRYo3OlbARNQFh8QsDg==", "996f1b0a-6f10-4fcd-8c01-2c40fe13c311" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "Screenshot", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("0abf9894-3900-4f4c-a5ef-ba38e65fe4a9"), "What are common algebra problems students face?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("34c1dd73-3bac-4569-80d9-128f4cf563bb"), "How should I approach exam preparation effectively?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" },
                    { new Guid("f30cd2a6-0286-4cf7-9513-0a3cb50f0b22"), "What are the best study guides for exam preparation?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("f7498361-6dd4-4421-9674-ea6963c5b7de"), "What are common algebra problems students face?", null, new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("fd7b32ad-1b2b-48bc-9709-1d6041f8417c"), "How do we understand Newton’s Laws?", null, new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("34ef466b-aa20-463a-8f8d-03597c21a784"), "Jul - Sep", "Term 3" },
                    { new Guid("58a711dd-bcf1-48fd-a01b-2106bef410d1"), "Jan - Mar", "Term 1" },
                    { new Guid("8e315cd9-f52b-4a76-adc4-376dadcb0af2"), "Apr - Jun", "Term 2" },
                    { new Guid("cec54d64-6c2d-4fe2-83ef-38bee82d3be8"), "Oct - Dec", "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("0a27d1bd-5f60-4624-99df-3634d80f0924"), 2024 },
                    { new Guid("122ac230-43e6-4a77-9888-482a5eafa37c"), 2023 },
                    { new Guid("3b80c8d7-bf13-4b58-aeea-60591dea4987"), 2020 },
                    { new Guid("9d2d9624-c06e-4c51-9600-4be41e3d0f07"), 2022 },
                    { new Guid("e9880002-95b7-4e23-8fb9-dea3e7c0a2a3"), 2021 }
                });
        }
    }
}
