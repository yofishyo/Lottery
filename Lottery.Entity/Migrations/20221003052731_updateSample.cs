using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lottery.Entities.Migrations
{
    public partial class updateSample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Sample",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Sample");

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDatetime",
                value: new DateTime(2022, 9, 30, 13, 32, 38, 330, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDatetime",
                value: new DateTime(2022, 9, 30, 13, 32, 38, 330, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDatetime",
                value: new DateTime(2022, 9, 30, 13, 32, 38, 330, DateTimeKind.Local).AddTicks(9498));
        }
    }
}
