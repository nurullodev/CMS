using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Data.Migrations
{
    public partial class AddInTimeZonSeedDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "FontSizes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "FontSizes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9462));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "FontSizes",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "FontSizes",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4690));
        }
    }
}
