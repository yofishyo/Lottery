using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lottery.Entities.Migrations
{
    public partial class addActionLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 6, 16, 2, 1, 980, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 6, 16, 2, 1, 980, DateTimeKind.Local).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 6, 16, 2, 1, 980, DateTimeKind.Local).AddTicks(3897));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 5, 15, 59, 29, 818, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 5, 15, 59, 29, 818, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 5, 15, 59, 29, 818, DateTimeKind.Local).AddTicks(8027));
        }
    }
}
