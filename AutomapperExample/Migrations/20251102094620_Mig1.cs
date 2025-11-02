using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomapperExample.Migrations
{
    /// <inheritdoc />
    public partial class Mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 11, 2, 15, 16, 19, 555, DateTimeKind.Local).AddTicks(18));

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2025, 11, 2, 15, 9, 44, 14, DateTimeKind.Local).AddTicks(2016));
        }
    }
}
