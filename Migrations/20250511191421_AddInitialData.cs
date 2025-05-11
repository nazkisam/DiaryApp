using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.InsertData(
                table: "diaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe", new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Went Hiking" },
                    { 2, "Went climbing with Sam", new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Went Climbing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "diaryEntries");
        }
    }
}
