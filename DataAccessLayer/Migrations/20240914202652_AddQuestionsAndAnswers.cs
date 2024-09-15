using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddQuestionsAndAnswers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("50f5dc94-a720-415c-91b3-beb5a3df5302"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("7abcee94-b8be-4fdb-88d8-76bd790497b7"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("df0d08e1-d6e9-43db-b98d-8c6b4a80dec2"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("ed55b37d-f9b7-4b1d-931d-bf134213da9c"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("1c755670-95d2-4b3c-9795-e205b49dedea"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("49db3c1f-a0ef-4304-bc3d-bedff6066efd"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("7f13a868-e692-46cb-9747-f879db8bb2ad"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("d88bf9be-144a-482e-acbf-697069ac9dd9"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("e924fd94-ee4b-4d12-a5e6-ca48a1a0974b"));

            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PointValue = table.Column<int>(type: "int", nullable: false),
                    ChapterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionTypes_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerType = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Options = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectOption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsTrue = table.Column<bool>(type: "bit", nullable: true),
                    TrueFalseAnswer_Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af9e2f13-cebd-4fe5-ba6b-d40ac26391c3", "AQAAAAIAAYagAAAAEGyqB/oTDqplVHzgf8NnuUw24V3o+usokZIM0XHfaa663vxZF7POn1VBr5iyviV7ug==", "f90d9d52-35d4-4f74-b594-bcb2e38314da" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("26648141-4271-4920-bfa9-d53f3ae55da9"), "Jul - Sep", "Term 3" },
                    { new Guid("28e1f859-5f85-4d4c-b416-7755a57ee1ed"), "Apr - Jun", "Term 2" },
                    { new Guid("76ac3144-24bf-4086-8792-a86c835ec4a3"), "Oct - Dec", "Term 4" },
                    { new Guid("7e72a716-ef78-469d-9ee7-6417a9f65399"), "Jan - Mar", "Term 1" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("31f2ec57-e14c-4a87-9603-e1f1fe81215b"), 2021 },
                    { new Guid("582e6277-29ca-4367-b12b-0e6d443a8799"), 2020 },
                    { new Guid("744493a1-0066-48ae-9e8e-aea6abe35269"), 2023 },
                    { new Guid("8256b1f4-89fa-404e-9b4e-24ccbfe9e46d"), 2022 },
                    { new Guid("e4367e4b-c148-4576-95aa-96e91b97a7fd"), 2024 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ChapterId",
                table: "Questions",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("26648141-4271-4920-bfa9-d53f3ae55da9"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("28e1f859-5f85-4d4c-b416-7755a57ee1ed"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("76ac3144-24bf-4086-8792-a86c835ec4a3"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("7e72a716-ef78-469d-9ee7-6417a9f65399"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("31f2ec57-e14c-4a87-9603-e1f1fe81215b"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("582e6277-29ca-4367-b12b-0e6d443a8799"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("744493a1-0066-48ae-9e8e-aea6abe35269"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("8256b1f4-89fa-404e-9b4e-24ccbfe9e46d"));

            migrationBuilder.DeleteData(
                table: "Years",
                keyColumn: "Id",
                keyValue: new Guid("e4367e4b-c148-4576-95aa-96e91b97a7fd"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "default-admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "545ebcab-a588-442b-b385-34eafe9c1a2e", "AQAAAAIAAYagAAAAEDs2sfkirt8MM87jhVx8osujGBexn3raLJl7A9S+rVzk2BgiSinXimWXPruzm+XGyw==", "7cb1c808-015c-4545-8938-9f8307648e03" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "Duration", "Name" },
                values: new object[,]
                {
                    { new Guid("50f5dc94-a720-415c-91b3-beb5a3df5302"), "Apr - Jun", "Term 2" },
                    { new Guid("7abcee94-b8be-4fdb-88d8-76bd790497b7"), "Jul - Sep", "Term 3" },
                    { new Guid("df0d08e1-d6e9-43db-b98d-8c6b4a80dec2"), "Jan - Mar", "Term 1" },
                    { new Guid("ed55b37d-f9b7-4b1d-931d-bf134213da9c"), "Oct - Dec", "Term 4" }
                });

            migrationBuilder.InsertData(
                table: "Years",
                columns: new[] { "Id", "YearNumber" },
                values: new object[,]
                {
                    { new Guid("1c755670-95d2-4b3c-9795-e205b49dedea"), 2024 },
                    { new Guid("49db3c1f-a0ef-4304-bc3d-bedff6066efd"), 2022 },
                    { new Guid("7f13a868-e692-46cb-9747-f879db8bb2ad"), 2021 },
                    { new Guid("d88bf9be-144a-482e-acbf-697069ac9dd9"), 2023 },
                    { new Guid("e924fd94-ee4b-4d12-a5e6-ca48a1a0974b"), 2020 }
                });
        }
    }
}
