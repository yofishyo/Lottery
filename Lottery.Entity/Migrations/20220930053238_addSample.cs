using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lottery.Entities.Migrations
{
    public partial class addSample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sample",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Sort = table.Column<int>(type: "int", nullable: false),
                    CreateDatetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<string>(type: "char(50)", maxLength: 50, nullable: true),
                    UpdateDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sample", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sample",
                columns: new[] { "Id", "CreateDatetime", "IsDelete", "Name", "Sort", "UpdateDatetime", "UpdateUserId" },
                values: new object[] { 1, new DateTime(2022, 9, 30, 13, 32, 38, 330, DateTimeKind.Local).AddTicks(9477), false, "類別A", 0, null, null });

            migrationBuilder.InsertData(
                table: "Sample",
                columns: new[] { "Id", "CreateDatetime", "IsDelete", "Name", "Sort", "UpdateDatetime", "UpdateUserId" },
                values: new object[] { 2, new DateTime(2022, 9, 30, 13, 32, 38, 330, DateTimeKind.Local).AddTicks(9496), false, "類別B", 1, null, null });

            migrationBuilder.InsertData(
                table: "Sample",
                columns: new[] { "Id", "CreateDatetime", "IsDelete", "Name", "Sort", "UpdateDatetime", "UpdateUserId" },
                values: new object[] { 3, new DateTime(2022, 9, 30, 13, 32, 38, 330, DateTimeKind.Local).AddTicks(9498), false, "類別C", 2, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sample");
        }
    }
}
