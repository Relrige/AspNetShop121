using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SidData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "City", "Contact", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Electronics", "Rivne", "0312921399", "iPhone X laalalala", 650m, "iPhone X" },
                    { 2, "Sport", "Rivne", "04122411399", "PowerBall laalalala", 45m, "PowerBall" },
                    { 3, "Clothes", "Rivne", "0675586399", "Nike T-Shirt laalalala", 189m, "Nike T-Shirt" },
                    { 4, "Electronics", "Rivne", "097642399", "Samsung S23 laalalala", 1200m, "Samsung S23" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
