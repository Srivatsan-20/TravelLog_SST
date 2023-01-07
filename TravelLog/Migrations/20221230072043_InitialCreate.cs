using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelLog.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartingKm = table.Column<int>(type: "int", nullable: false),
                    ClosingKm = table.Column<int>(type: "int", nullable: false),
                    TotalKm = table.Column<int>(type: "int", nullable: false),
                    AdvanceAmount = table.Column<int>(type: "int", nullable: false),
                    Expenses = table.Column<int>(type: "int", nullable: false),
                    BalanceAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "AdvanceAmount", "BalanceAmount", "BusNo", "ClosingKm", "Expenses", "FromDate", "StartingKm", "ToDate", "TotalKm" },
                values: new object[] { 1, 1000, 500, "123", 100, 500, new DateTime(2022, 12, 30, 12, 50, 42, 909, DateTimeKind.Local).AddTicks(2261), 0, new DateTime(2022, 12, 30, 12, 50, 42, 911, DateTimeKind.Local).AddTicks(283), 100 });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "AdvanceAmount", "BalanceAmount", "BusNo", "ClosingKm", "Expenses", "FromDate", "StartingKm", "ToDate", "TotalKm" },
                values: new object[] { 2, 2000, 1000, "456", 200, 1000, new DateTime(2022, 12, 30, 12, 50, 42, 911, DateTimeKind.Local).AddTicks(3019), 0, new DateTime(2022, 12, 30, 12, 50, 42, 911, DateTimeKind.Local).AddTicks(3040), 200 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
