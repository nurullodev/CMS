using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CMS.Data.Migrations
{
    public partial class ChangeTableFontTypeDateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesignTools_FontSizes_FontSizeId",
                table: "DesignTools");

            migrationBuilder.DropTable(
                name: "FontSizes");

            migrationBuilder.RenameColumn(
                name: "FontSizeId",
                table: "DesignTools",
                newName: "FontTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_DesignTools_FontSizeId",
                table: "DesignTools",
                newName: "IX_DesignTools_FontTypeId");

            migrationBuilder.CreateTable(
                name: "FontTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    size = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FontTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Damens",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "DesignCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "DesignTools",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.InsertData(
                table: "FontTypes",
                columns: new[] { "Id", "CreatedAt", "size", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4323), "Normal Text", null },
                    { 2L, new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4324), "[3mSmaller Text [0m", null }
                });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "TimeZons",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 10, 20, 53, 35, 643, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.AddForeignKey(
                name: "FK_DesignTools_FontTypes_FontTypeId",
                table: "DesignTools",
                column: "FontTypeId",
                principalTable: "FontTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesignTools_FontTypes_FontTypeId",
                table: "DesignTools");

            migrationBuilder.DropTable(
                name: "FontTypes");

            migrationBuilder.RenameColumn(
                name: "FontTypeId",
                table: "DesignTools",
                newName: "FontSizeId");

            migrationBuilder.RenameIndex(
                name: "IX_DesignTools_FontTypeId",
                table: "DesignTools",
                newName: "IX_DesignTools_FontSizeId");

            migrationBuilder.CreateTable(
                name: "FontSizes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    size = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FontSizes", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "FontSizes",
                columns: new[] { "Id", "CreatedAt", "size", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9662), "5px", null },
                    { 2L, new DateTime(2023, 8, 10, 19, 34, 28, 565, DateTimeKind.Utc).AddTicks(9663), "10px", null }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_DesignTools_FontSizes_FontSizeId",
                table: "DesignTools",
                column: "FontSizeId",
                principalTable: "FontSizes",
                principalColumn: "Id");
        }
    }
}
