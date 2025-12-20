using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addChapterSections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChapterSection_ChapterSection_ParentSectionId",
                table: "ChapterSection");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterSection_Chapters_ChapterId",
                table: "ChapterSection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChapterSection",
                table: "ChapterSection");

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("0d546113-3176-48ab-9ec6-d63a151b5c1f"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("637fb787-d46f-48d3-ab26-fe745766d52a"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("8920e0d8-ef9a-4001-94b7-fe7640f96d6e"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("97e2db24-ecda-499d-868c-dfbcf455ca89"));

            migrationBuilder.DeleteData(
                table: "Forums",
                keyColumn: "Id",
                keyValue: new Guid("bb15272d-beb6-4a28-9c1e-2b89e353a87f"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("50d87b43-6aea-48df-ac8b-dcd9340203a5"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("8058424b-83b1-4077-b756-910ac9448108"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("a0be02a9-cbac-4318-b6ec-2207966a5c7b"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("a6340666-5d6f-4335-9ef8-2b30e6b2f621"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("36ca013c-4d00-404f-a369-3a1a12c166f8"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("43756c9a-d179-460a-b84d-a8e4946c3e10"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("ddd7617f-c9bd-4fe9-bef7-aba0c17d3a56"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("e55875ab-2394-4b5d-822e-add0be798cae"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("f04cf27e-bb93-4d5b-b9fe-06fc1602c33e"));

            migrationBuilder.RenameTable(
                name: "ChapterSection",
                newName: "ChapterSections");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterSection_ParentSectionId",
                table: "ChapterSections",
                newName: "IX_ChapterSections_ParentSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterSection_ChapterId",
                table: "ChapterSections",
                newName: "IX_ChapterSections_ChapterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChapterSections",
                table: "ChapterSections",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce35f0a1-bb66-4e57-b195-1c38ec6a2556", "AQAAAAIAAYagAAAAEJrdH0l0j+SFmO4oHEUv2EmBVfN4qprBLUVf1gTboaw5H5heRYo3OlbARNQFh8QsDg==", "996f1b0a-6f10-4fcd-8c01-2c40fe13c311" });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "ChapterNumber", "ChapterTitle", "Description", "SubjectId", "TermId" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), 1, "Introduction to Biology", "Basic concepts of biology.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 2, "Cell Structure", "Understanding the building blocks of life.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
                    { new Guid("33333333-3333-3333-3333-333333333333"), 3, "Genetics", "Introduction to genetics.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
                    { new Guid("44444444-4444-4444-4444-444444444444"), 4, "Evolution", "Theory of evolution.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
                    { new Guid("55555555-5555-5555-5555-555555555555"), 5, "Ecology", "Ecosystems and environment.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
                    { new Guid("66666666-6666-6666-6666-666666666666"), 6, "Human Body", "Human anatomy and physiology.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
                    { new Guid("77777777-7777-7777-7777-777777777777"), 7, "Plant Biology", "Plant structure and function.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
                    { new Guid("88888888-8888-8888-8888-888888888888"), 8, "Microbiology", "Microorganisms and their roles.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
                    { new Guid("99999999-9999-9999-9999-999999999999"), 9, "Biotechnology", "Applications of biology.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 10, "Conservation", "Conservation of biodiversity.", new Guid("5a5da2f4-f649-4994-95b1-228b82e9d98c"), new Guid("aa10883b-b521-4c82-8cf5-7dfb4215ebe4") }
                });

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

            migrationBuilder.InsertData(
                table: "ChapterSections",
                columns: new[] { "Id", "ChapterId", "Content", "Order", "ParentSectionId", "Type" },
                values: new object[,]
                {
                    { new Guid("a1a1a1a1-a1a1-a1a1-a1a1-a1a1a1a1a1a1"), new Guid("11111111-1111-1111-1111-111111111111"), "What is Biology?", 1, null, 0 },
                    { new Guid("a3a3a3a3-a3a3-a3a3-a3a3-a3a3a3a3a3a3"), new Guid("22222222-2222-2222-2222-222222222222"), "Cell Structure Overview", 1, null, 0 },
                    { new Guid("a5a5a5a5-a5a5-a5a5-a5a5-a5a5a5a5a5a5"), new Guid("33333333-3333-3333-3333-333333333333"), "Introduction to Genetics", 1, null, 0 },
                    { new Guid("a7a7a7a7-a7a7-a7a7-a7a7-a7a7a7a7a7a7"), new Guid("44444444-4444-4444-4444-444444444444"), "Theory of Evolution", 1, null, 0 },
                    { new Guid("a9a9a9a9-a9a9-a9a9-a9a9-a9a9a9a9a9a9"), new Guid("55555555-5555-5555-5555-555555555555"), "Ecosystems", 1, null, 0 },
                    { new Guid("a2a2a2a2-a2a2-a2a2-a2a2-a2a2a2a2a2a2"), new Guid("11111111-1111-1111-1111-111111111111"), "Biology is the study of living organisms.", 2, new Guid("a1a1a1a1-a1a1-a1a1-a1a1-a1a1a1a1a1a1"), 2 },
                    { new Guid("a4a4a4a4-a4a4-a4a4-a4a4-a4a4a4a4a4a4"), new Guid("22222222-2222-2222-2222-222222222222"), "Cells are the basic units of life.", 2, new Guid("a3a3a3a3-a3a3-a3a3-a3a3-a3a3a3a3a3a3"), 2 },
                    { new Guid("a6a6a6a6-a6a6-a6a6-a6a6-a6a6a6a6a6a6"), new Guid("33333333-3333-3333-3333-333333333333"), "Genes are units of heredity.", 2, new Guid("a5a5a5a5-a5a5-a5a5-a5a5-a5a5a5a5a5a5"), 2 },
                    { new Guid("a8a8a8a8-a8a8-a8a8-a8a8-a8a8a8a8a8a8"), new Guid("44444444-4444-4444-4444-444444444444"), "Evolution explains diversity.", 2, new Guid("a7a7a7a7-a7a7-a7a7-a7a7-a7a7a7a7a7a7"), 2 },
                    { new Guid("b1b1b1b1-b1b1-b1b1-b1b1-b1b1b1b1b1b1"), new Guid("55555555-5555-5555-5555-555555555555"), "Ecosystems are communities of organisms.", 2, new Guid("a9a9a9a9-a9a9-a9a9-a9a9-a9a9a9a9a9a9"), 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterSections_ChapterSections_ParentSectionId",
                table: "ChapterSections",
                column: "ParentSectionId",
                principalTable: "ChapterSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterSections_Chapters_ChapterId",
                table: "ChapterSections",
                column: "ChapterId",
                principalTable: "Chapters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChapterSections_ChapterSections_ParentSectionId",
                table: "ChapterSections");

            migrationBuilder.DropForeignKey(
                name: "FK_ChapterSections_Chapters_ChapterId",
                table: "ChapterSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChapterSections",
                table: "ChapterSections");

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a2a2a2a2-a2a2-a2a2-a2a2-a2a2a2a2a2a2"));

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a4a4a4a4-a4a4-a4a4-a4a4-a4a4a4a4a4a4"));

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a6a6a6a6-a6a6-a6a6-a6a6-a6a6a6a6a6a6"));

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a8a8a8a8-a8a8-a8a8-a8a8-a8a8a8a8a8a8"));

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("b1b1b1b1-b1b1-b1b1-b1b1-b1b1b1b1b1b1"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-999999999999"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

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

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a1a1a1a1-a1a1-a1a1-a1a1-a1a1a1a1a1a1"));

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a3a3a3a3-a3a3-a3a3-a3a3-a3a3a3a3a3a3"));

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a5a5a5a5-a5a5-a5a5-a5a5-a5a5a5a5a5a5"));

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a7a7a7a7-a7a7-a7a7-a7a7-a7a7a7a7a7a7"));

            migrationBuilder.DeleteData(
                table: "ChapterSections",
                keyColumn: "Id",
                keyValue: new Guid("a9a9a9a9-a9a9-a9a9-a9a9-a9a9a9a9a9a9"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DropColumn(
                name: "Screenshot",
                table: "Forums");

            migrationBuilder.RenameTable(
                name: "ChapterSections",
                newName: "ChapterSection");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterSections_ParentSectionId",
                table: "ChapterSection",
                newName: "IX_ChapterSection_ParentSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterSections_ChapterId",
                table: "ChapterSection",
                newName: "IX_ChapterSection_ChapterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChapterSection",
                table: "ChapterSection",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aa07c2a-eeb6-45ec-9803-6de4e395367d", "AQAAAAIAAYagAAAAEIqHm0baav1ZbA6bFRoH5XmIWm2EeLCvwSBwSgIfjvidtKZiEY4Vn74XSJ3Rn4/0Gw==", "add92cee-acfa-4370-b522-b57e2d2b690e" });

            migrationBuilder.InsertData(
                table: "Forums",
                columns: new[] { "Id", "DiscussionQuestion", "SubjectId", "Topic" },
                values: new object[,]
                {
                    { new Guid("0d546113-3176-48ab-9ec6-d63a151b5c1f"), "What are common algebra problems students face?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Difficult problems in Algebra" },
                    { new Guid("637fb787-d46f-48d3-ab26-fe745766d52a"), "How do we understand Newton’s Laws?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Physics Chapter 1" },
                    { new Guid("8920e0d8-ef9a-4001-94b7-fe7640f96d6e"), "What are the best study guides for exam preparation?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Best study guides?" },
                    { new Guid("97e2db24-ecda-499d-868c-dfbcf455ca89"), "What are common algebra problems students face?", new Guid("3fe2283b-6751-4633-8903-2043997bbf20"), "Difficult problems in Algebra" },
                    { new Guid("bb15272d-beb6-4a28-9c1e-2b89e353a87f"), "How should I approach exam preparation effectively?", new Guid("b2df6db3-2b38-4c3a-9517-5e3e2b98b741"), "Exam preparation tips" }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("50d87b43-6aea-48df-ac8b-dcd9340203a5"), "Jul - Sep", "Term 3" },
                    { new Guid("8058424b-83b1-4077-b756-910ac9448108"), "Jan - Mar", "Term 1" },
                    { new Guid("a0be02a9-cbac-4318-b6ec-2207966a5c7b"), "Apr - Jun", "Term 2" },
                    { new Guid("a6340666-5d6f-4335-9ef8-2b30e6b2f621"), "Oct - Dec", "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("36ca013c-4d00-404f-a369-3a1a12c166f8"), 2024 },
                    { new Guid("43756c9a-d179-460a-b84d-a8e4946c3e10"), 2022 },
                    { new Guid("ddd7617f-c9bd-4fe9-bef7-aba0c17d3a56"), 2020 },
                    { new Guid("e55875ab-2394-4b5d-822e-add0be798cae"), 2021 },
                    { new Guid("f04cf27e-bb93-4d5b-b9fe-06fc1602c33e"), 2023 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterSection_ChapterSection_ParentSectionId",
                table: "ChapterSection",
                column: "ParentSectionId",
                principalTable: "ChapterSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterSection_Chapters_ChapterId",
                table: "ChapterSection",
                column: "ChapterId",
                principalTable: "Chapters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
