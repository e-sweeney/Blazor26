using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blazor26.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Books" },
                    { 3, "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "Image", "Name", "Price", "description" },
                values: new object[,]
                {
                    { 1, 1, "/Images/Products/smartphone.jpg", "Smartphone", 699.99f, "High-end smartphone" },
                    { 2, 1, "/Images/Products/laptop.jpg", "Laptop", 1299.99f, "Powerful gaming laptop" },
                    { 3, 2, "/Images/Products/novel.jpg", "Novel", 19.99f, "Interesting fiction novel" },
                    { 4, 2, "/Images/Products/biography.jpg", "Biography", 24.99f, "Famous person's biography" },
                    { 5, 3, "/Images/Products/tshirt.jpg", "T-Shirt", 14.99f, "Cotton t-shirt" },
                    { 6, 3, "/Images/Products/jeans.jpg", "Jeans", 49.99f, "Denim jeans" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "MonthName", "ProductID", "SalesAmount" },
                values: new object[,]
                {
                    { 1, "January", 1, 10m },
                    { 2, "February", 2, 5m },
                    { 3, "March", 3, 9m },
                    { 4, "April", 4, 5m },
                    { 5, "May", 5, 8m },
                    { 6, "June", 6, 16m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
