using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lottery.Entities.Migrations
{
    public partial class updateSample2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sort",
                table: "Sample",
                type: "int",
                nullable: false,
                comment: "排序",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDatetime",
                table: "Sample",
                type: "datetime2",
                nullable: false,
                comment: "建立時間",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Sort",
                table: "Sample",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "排序");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDatetime",
                table: "Sample",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "建立時間");

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 3, 13, 27, 31, 423, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 3, 13, 27, 31, 423, DateTimeKind.Local).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 3, 13, 27, 31, 423, DateTimeKind.Local).AddTicks(5924));
        }
    }
}
