using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lottery.Entities.Migrations
{
    public partial class addActionLog2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActionLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionType = table.Column<int>(type: "int", nullable: false, comment: "操作行為"),
                    UserId = table.Column<string>(type: "char(50)", maxLength: 50, nullable: false, comment: "使用者識別碼"),
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "操作紀錄時間"),
                    LogDesc = table.Column<string>(type: "nvarchar", nullable: true, comment: "操作記錄描述"),
                    IpAddress = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "來源位址"),
                    Logger = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, comment: "功能名稱"),
                    AreaName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "程式Area名稱"),
                    ControllerName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "程式Controller名稱"),
                    ActionName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, comment: "程式Action名稱"),
                    MainId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "資料Id"),
                    BrowserVersion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true, comment: "瀏覽器版本")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionLog", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 6, 16, 34, 32, 518, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 6, 16, 34, 32, 518, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Sample",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDatetime",
                value: new DateTime(2022, 10, 6, 16, 34, 32, 518, DateTimeKind.Local).AddTicks(5693));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActionLog");

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
    }
}
