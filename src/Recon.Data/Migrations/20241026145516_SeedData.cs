using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recon.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LookupCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Provider" },
                    { 2L, "Product" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "LookupCategories",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
