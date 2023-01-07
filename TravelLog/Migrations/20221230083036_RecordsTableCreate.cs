using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelLog.Migrations
{
    public partial class RecordsTableCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FromDate", "ToDate" },
                values: new object[] { new DateTime(2022, 12, 30, 14, 0, 35, 650, DateTimeKind.Local).AddTicks(3796), new DateTime(2022, 12, 30, 14, 0, 35, 652, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FromDate", "ToDate" },
                values: new object[] { new DateTime(2022, 12, 30, 14, 0, 35, 652, DateTimeKind.Local).AddTicks(5376), new DateTime(2022, 12, 30, 14, 0, 35, 652, DateTimeKind.Local).AddTicks(5399) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FromDate", "ToDate" },
                values: new object[] { new DateTime(2022, 12, 30, 12, 50, 42, 909, DateTimeKind.Local).AddTicks(2261), new DateTime(2022, 12, 30, 12, 50, 42, 911, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FromDate", "ToDate" },
                values: new object[] { new DateTime(2022, 12, 30, 12, 50, 42, 911, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 12, 30, 12, 50, 42, 911, DateTimeKind.Local).AddTicks(3040) });
        }
    }
}
