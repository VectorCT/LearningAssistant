using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class fix_missing_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Ensure Terms columns exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','CreatedAt') IS NULL
BEGIN
    ALTER TABLE [Terms] ADD [CreatedAt] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','CreatedBy') IS NULL
BEGIN
    ALTER TABLE [Terms] ADD [CreatedBy] nvarchar(max) NULL;
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','ModifiedAt') IS NULL
BEGIN
    ALTER TABLE [Terms] ADD [ModifiedAt] datetime2 NULL;
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','StartDate') IS NULL
BEGIN
    ALTER TABLE [Terms] ADD [StartDate] datetime2 NULL;
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','EndDate') IS NULL
BEGIN
    ALTER TABLE [Terms] ADD [EndDate] datetime2 NULL;
END");

            // Ensure Years columns exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Years','CreatedAt') IS NULL
BEGIN
    ALTER TABLE [Years] ADD [CreatedAt] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Years','CreatedBy') IS NULL
BEGIN
    ALTER TABLE [Years] ADD [CreatedBy] nvarchar(max) NULL;
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Years','ModifiedAt') IS NULL
BEGIN
    ALTER TABLE [Years] ADD [ModifiedAt] datetime2 NULL;
END");

            // Ensure Subjects columns exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Subjects','CreatedAt') IS NULL
BEGIN
    ALTER TABLE [Subjects] ADD [CreatedAt] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Subjects','CreatedBy') IS NULL
BEGIN
    ALTER TABLE [Subjects] ADD [CreatedBy] nvarchar(max) NULL;
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Subjects','ModifiedAt') IS NULL
BEGIN
    ALTER TABLE [Subjects] ADD [ModifiedAt] datetime2 NULL;
END");

            // Ensure QuestionTypes columns exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.QuestionTypes','CreatedAt') IS NULL
BEGIN
    ALTER TABLE [QuestionTypes] ADD [CreatedAt] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.QuestionTypes','CreatedBy') IS NULL
BEGIN
    ALTER TABLE [QuestionTypes] ADD [CreatedBy] nvarchar(max) NULL;
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.QuestionTypes','ModifiedAt') IS NULL
BEGIN
    ALTER TABLE [QuestionTypes] ADD [ModifiedAt] datetime2 NULL;
END");

            // Ensure Questions columns exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Questions','CreatedAt') IS NULL
BEGIN
    ALTER TABLE [Questions] ADD [CreatedAt] datetime2 NOT NULL DEFAULT GETDATE();
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Questions','CreatedBy') IS NULL
BEGIN
    ALTER TABLE [Questions] ADD [CreatedBy] nvarchar(max) NULL;
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Questions','ModifiedAt') IS NULL
BEGIN
    ALTER TABLE [Questions] ADD [ModifiedAt] datetime2 NULL;
END");

            // Ensure Grades columns exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Grades','CreatedAt') IS NULL
BEGIN
    ALTER TABLE [Grades] ADD [CreatedAt] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Grades','CreatedBy') IS NULL
BEGIN
    ALTER TABLE [Grades] ADD [CreatedBy] nvarchar(max) NULL;
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Grades','ModifiedAt') IS NULL
BEGIN
    ALTER TABLE [Grades] ADD [ModifiedAt] datetime2 NULL;
END");

            // Ensure Answers columns exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Answers','CreatedAt') IS NULL
BEGIN
    ALTER TABLE [Answers] ADD [CreatedAt] datetime2 NOT NULL DEFAULT GETDATE();
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Answers','CreatedBy') IS NULL
BEGIN
    ALTER TABLE [Answers] ADD [CreatedBy] nvarchar(max) NULL;
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Answers','ModifiedAt') IS NULL
BEGIN
    ALTER TABLE [Answers] ADD [ModifiedAt] datetime2 NULL;
END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop Answers columns if exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Answers','ModifiedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Answers] DROP COLUMN [ModifiedAt];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Answers','CreatedBy') IS NOT NULL
BEGIN
    ALTER TABLE [Answers] DROP COLUMN [CreatedBy];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Answers','CreatedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Answers] DROP COLUMN [CreatedAt];
END");

            // Drop Grades columns if exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Grades','ModifiedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Grades] DROP COLUMN [ModifiedAt];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Grades','CreatedBy') IS NOT NULL
BEGIN
    ALTER TABLE [Grades] DROP COLUMN [CreatedBy];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Grades','CreatedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Grades] DROP COLUMN [CreatedAt];
END");

            // Drop Questions columns if exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Questions','ModifiedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Questions] DROP COLUMN [ModifiedAt];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Questions','CreatedBy') IS NOT NULL
BEGIN
    ALTER TABLE [Questions] DROP COLUMN [CreatedBy];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Questions','CreatedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Questions] DROP COLUMN [CreatedAt];
END");

            // Drop QuestionTypes columns if exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.QuestionTypes','ModifiedAt') IS NOT NULL
BEGIN
    ALTER TABLE [QuestionTypes] DROP COLUMN [ModifiedAt];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.QuestionTypes','CreatedBy') IS NOT NULL
BEGIN
    ALTER TABLE [QuestionTypes] DROP COLUMN [CreatedBy];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.QuestionTypes','CreatedAt') IS NOT NULL
BEGIN
    ALTER TABLE [QuestionTypes] DROP COLUMN [CreatedAt];
END");

            // Drop Subjects columns if exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Subjects','ModifiedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Subjects] DROP COLUMN [ModifiedAt];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Subjects','CreatedBy') IS NOT NULL
BEGIN
    ALTER TABLE [Subjects] DROP COLUMN [CreatedBy];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Subjects','CreatedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Subjects] DROP COLUMN [CreatedAt];
END");

            // Drop Years columns if exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Years','ModifiedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Years] DROP COLUMN [ModifiedAt];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Years','CreatedBy') IS NOT NULL
BEGIN
    ALTER TABLE [Years] DROP COLUMN [CreatedBy];
END");
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Years','CreatedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Years] DROP COLUMN [CreatedAt];
END");

            // Drop Terms columns if exist
            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','EndDate') IS NOT NULL
BEGIN
    ALTER TABLE [Terms] DROP COLUMN [EndDate];
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','StartDate') IS NOT NULL
BEGIN
    ALTER TABLE [Terms] DROP COLUMN [StartDate];
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','ModifiedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Terms] DROP COLUMN [ModifiedAt];
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','CreatedBy') IS NOT NULL
BEGIN
    ALTER TABLE [Terms] DROP COLUMN [CreatedBy];
END");

            migrationBuilder.Sql(@"IF COL_LENGTH('dbo.Terms','CreatedAt') IS NOT NULL
BEGIN
    ALTER TABLE [Terms] DROP COLUMN [CreatedAt];
END");
        }
    }
}
