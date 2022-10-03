using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lottery.Entities.Migrations
{
    public partial class updateSampleComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdateUserId",
                table: "Sample",
                type: "char(50)",
                maxLength: 50,
                nullable: true,
                comment: "異動者",
                oldClrType: typeof(string),
                oldType: "char(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDatetime",
                table: "Sample",
                type: "datetime2",
                nullable: true,
                comment: "異動時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sample",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                comment: "名稱",
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Sample",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                comment: "描述",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 3, 14, 10, 6, 587, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 3, 14, 10, 6, 587, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 3, 14, 10, 6, 587, DateTimeKind.Local).AddTicks(9211));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdateUserId",
                table: "Sample",
                type: "char(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "異動者");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDatetime",
                table: "Sample",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldComment: "異動時間");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sample",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128,
                oldComment: "名稱");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Sample",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true,
                oldComment: "描述");

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 3, 14, 7, 59, 671, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 3, 14, 7, 59, 671, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 3, 14, 7, 59, 671, DateTimeKind.Local).AddTicks(4742));
        }
    }
}
