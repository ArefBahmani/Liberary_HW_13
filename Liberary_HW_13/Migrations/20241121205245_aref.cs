using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Liberary_HW_13.Migrations
{
    /// <inheritdoc />
    public partial class aref : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8946));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 21, 58, 268, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 21, 58, 268, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 21, 58, 268, DateTimeKind.Local).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 21, 58, 268, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 21, 58, 268, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 11, 22, 0, 21, 58, 268, DateTimeKind.Local).AddTicks(9209));
        }
    }
}
