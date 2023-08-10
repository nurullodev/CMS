using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CMS.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Damens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DesignCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FontSizes",
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
                    table.PrimaryKey("PK_FontSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeZons",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    abbreviation = table.Column<string>(type: "text", nullable: true),
                    OffSet = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeZons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    sescription = table.Column<string>(type: "text", nullable: true),
                    Attribute = table.Column<int>(type: "integer", nullable: false),
                    Language = table.Column<int>(type: "integer", nullable: false),
                    DamenId = table.Column<long>(type: "bigint", nullable: true),
                    DesignCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    DesignCategoryId1 = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designs_Damens_DamenId",
                        column: x => x.DamenId,
                        principalTable: "Damens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Designs_DesignCategories_DesignCategoryId",
                        column: x => x.DesignCategoryId,
                        principalTable: "DesignCategories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Designs_DesignCategories_DesignCategoryId1",
                        column: x => x.DesignCategoryId1,
                        principalTable: "DesignCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DesignTools",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ColorId = table.Column<long>(type: "bigint", nullable: true),
                    FontSizeId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignTools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DesignTools_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DesignTools_FontSizes_FontSizeId",
                        column: x => x.FontSizeId,
                        principalTable: "FontSizes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    last_name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    email_address = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: true),
                    DamenId = table.Column<long>(type: "bigint", nullable: true),
                    DesignId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Damens_DamenId",
                        column: x => x.DamenId,
                        principalTable: "Damens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Designs_DesignId",
                        column: x => x.DesignId,
                        principalTable: "Designs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    DamenId = table.Column<long>(type: "bigint", nullable: true),
                    UserId1 = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Damens_DamenId",
                        column: x => x.DamenId,
                        principalTable: "Damens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Groups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Groups_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedAt", "name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4814), "Red", null },
                    { 2L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4815), "Yellow", null }
                });

            migrationBuilder.InsertData(
                table: "Damens",
                columns: new[] { "Id", "CreatedAt", "name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4786), "Uzum", null },
                    { 2L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4787), "laptops", null },
                    { 3L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4788), "Vachach", null },
                    { 4L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4788), "Naura", null }
                });

            migrationBuilder.InsertData(
                table: "DesignCategories",
                columns: new[] { "Id", "CreatedAt", "name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4872), "Movies", null },
                    { 2L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4873), "Fitness", null },
                    { 3L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4874), "Politics", null },
                    { 4L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4874), "World", null },
                    { 5L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4875), "Technology", null }
                });

            migrationBuilder.InsertData(
                table: "FontSizes",
                columns: new[] { "Id", "CreatedAt", "size", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4825), "5px", null },
                    { 2L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4825), "10px", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZons",
                columns: new[] { "Id", "abbreviation", "CreatedAt", "name", "OffSet", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "ADT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arabia", "UTC +4", null },
                    { 2L, "AMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armenia", "UTC +4", null },
                    { 3L, "AFT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afganistan", "UTC +4:30", null },
                    { 4L, "ALMT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alma-Ata", "UTC +6", null },
                    { 5L, "UZT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uzbekistan ", "UTC +5", null }
                });

            migrationBuilder.InsertData(
                table: "DesignTools",
                columns: new[] { "Id", "ColorId", "CreatedAt", "FontSizeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4834), 1L, null },
                    { 2L, 2L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4835), 1L, null },
                    { 3L, 2L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4836), 1L, null },
                    { 4L, 1L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4836), 1L, null }
                });

            migrationBuilder.InsertData(
                table: "Designs",
                columns: new[] { "Id", "Attribute", "CreatedAt", "DamenId", "sescription", "DesignCategoryId", "DesignCategoryId1", "Language", "name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4861), 1L, "Good", 1L, null, 1, "Saua", null },
                    { 2L, 2, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4862), 2L, "Good", 2L, null, 1, "One", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DamenId", "DesignId", "email_address", "first_name", "last_name", "password", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4684), 1L, null, "nurullo@gmail.com", "Nurullo", "Nurmatov", "1234", null },
                    { 2L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4687), 2L, null, "asad@gmail.com", "Asadbek", "Asadov", "2564", null },
                    { 3L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4689), 3L, null, "ikrom@gmail.com", "Ikrom", "Ikromov", "4567", null },
                    { 4L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4690), 4L, null, "nurullo@gmail.com", "Axror", "Alimov", "7415", null }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CreatedAt", "DamenId", "Email", "UpdatedAt", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4801), 1L, "john@example@gmail.com", null, 1L, null },
                    { 2L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4802), 2L, "examp@gmail.com", null, 2L, null },
                    { 3L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4802), 3L, "exam2p@gmail.com", null, 3L, null },
                    { 4L, new DateTime(2023, 8, 10, 7, 38, 51, 845, DateTimeKind.Utc).AddTicks(4803), 4L, "examp3@gmail.com", null, 4L, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Designs_DamenId",
                table: "Designs",
                column: "DamenId");

            migrationBuilder.CreateIndex(
                name: "IX_Designs_DesignCategoryId",
                table: "Designs",
                column: "DesignCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Designs_DesignCategoryId1",
                table: "Designs",
                column: "DesignCategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_DesignTools_ColorId",
                table: "DesignTools",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_DesignTools_FontSizeId",
                table: "DesignTools",
                column: "FontSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DamenId",
                table: "Groups",
                column: "DamenId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_UserId",
                table: "Groups",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_UserId1",
                table: "Groups",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DamenId",
                table: "Users",
                column: "DamenId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DesignId",
                table: "Users",
                column: "DesignId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesignTools");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "TimeZons");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "FontSizes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Designs");

            migrationBuilder.DropTable(
                name: "Damens");

            migrationBuilder.DropTable(
                name: "DesignCategories");
        }
    }
}
