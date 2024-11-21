using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Liberary_HW_13.Migrations
{
    /// <inheritdoc />
    public partial class asad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleEnum = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Writer = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsBorrowed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "DateTime", "Discription", "IsBorrowed", "Pages", "Titel", "UserId", "Writer" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 21, 22, 25, 17, 928, DateTimeKind.Local).AddTicks(9832), "Hichi", false, 1000, "C#", null, "Aref" },
                    { 2, new DateTime(2024, 11, 21, 22, 25, 17, 928, DateTimeKind.Local).AddTicks(9880), "100 Hours Tutaial", false, 100, "SQL", null, "hosein" },
                    { 3, new DateTime(2024, 11, 21, 22, 25, 17, 928, DateTimeKind.Local).AddTicks(9890), "salam halet khobe>?", false, 2000, "Java", null, "javad" },
                    { 4, new DateTime(2024, 11, 21, 22, 25, 17, 928, DateTimeKind.Local).AddTicks(9898), "Mamnon merc", false, 1250, "Django", null, "saeid" },
                    { 5, new DateTime(2024, 11, 21, 22, 25, 17, 928, DateTimeKind.Local).AddTicks(9906), "Chekhabara?", false, 444, "Java_Script", null, "masoud" },
                    { 6, new DateTime(2024, 11, 21, 22, 25, 17, 928, DateTimeKind.Local).AddTicks(9918), "Salamati to khobi?", false, 10, "C++", null, "rasool" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
