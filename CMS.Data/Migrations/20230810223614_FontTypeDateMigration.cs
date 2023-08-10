using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Data.Migrations
{
    public partial class FontTypeDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "FontTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "FontTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 36, 13, 829, DateTimeKind.Utc).AddTicks(3986));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "FontTypes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "FontTypes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 22, 20, 37, 49, DateTimeKind.Utc).AddTicks(5146));
        }
    }
}
