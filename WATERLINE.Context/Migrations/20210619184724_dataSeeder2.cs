using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WATERLINE.Context.Migrations
{
    public partial class dataSeeder2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "EditableBySupers" },
                values: new object[] { new DateTime(2021, 6, 19, 21, 47, 23, 528, DateTimeKind.Unspecified).AddTicks(6873), false });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "EditableBySupers" },
                values: new object[] { new DateTime(2021, 6, 19, 21, 47, 23, 529, DateTimeKind.Unspecified).AddTicks(183), false });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 19, 21, 47, 23, 523, DateTimeKind.Unspecified).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 19, 21, 47, 23, 528, DateTimeKind.Unspecified).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 19, 21, 47, 23, 528, DateTimeKind.Unspecified).AddTicks(6120));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "EditableBySupers" },
                values: new object[] { new DateTime(2021, 6, 19, 21, 32, 7, 137, DateTimeKind.Unspecified).AddTicks(2929), true });

            migrationBuilder.UpdateData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "EditableBySupers" },
                values: new object[] { new DateTime(2021, 6, 19, 21, 32, 7, 137, DateTimeKind.Unspecified).AddTicks(6983), true });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 19, 21, 32, 7, 132, DateTimeKind.Unspecified).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 19, 21, 32, 7, 137, DateTimeKind.Unspecified).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 19, 21, 32, 7, 137, DateTimeKind.Unspecified).AddTicks(2034));
        }
    }
}
