using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WATERLINE.Context.Migrations
{
    public partial class dataSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Arabic", "CreatedBy", "DateCreated", "DateUpdated", "DeletableByNormals", "DeletableBySupers", "Deleted", "EditableByNormals", "EditableBySupers", "Key", "UpdatedBy", "Value", "ViewableByNormals", "ViewableBySupers" },
                values: new object[,]
                {
                    { 1, null, "System", new DateTime(2021, 6, 19, 21, 32, 7, 137, DateTimeKind.Unspecified).AddTicks(2929), null, false, false, false, false, true, "Application Name", null, "Waterline", true, true },
                    { 2, null, "System", new DateTime(2021, 6, 19, 21, 32, 7, 137, DateTimeKind.Unspecified).AddTicks(6983), null, false, false, false, false, true, "Application Slogan", null, "Interior Design Studio", true, true }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 18, 21, 38, 6, 931, DateTimeKind.Unspecified).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 18, 21, 38, 6, 936, DateTimeKind.Unspecified).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 18, 21, 38, 6, 936, DateTimeKind.Unspecified).AddTicks(7525));
        }
    }
}
