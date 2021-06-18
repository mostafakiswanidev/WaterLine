using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WATERLINE.Context.Migrations
{
    public partial class addedAvatarToUSer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 18, 16, 25, 18, 996, DateTimeKind.Unspecified).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 6, 18, 16, 25, 19, 1, DateTimeKind.Unspecified).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 6, 18, 16, 25, 19, 1, DateTimeKind.Unspecified).AddTicks(5935));
        }
    }
}
