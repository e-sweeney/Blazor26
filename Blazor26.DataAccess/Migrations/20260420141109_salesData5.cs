using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor26.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class salesData5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { null, "HP PRo", 892.99f, "Big desktop PC" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { null, "Dell X100", 140.99f, "Not a laptop" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { null, "HP 450x", 1200.99f, "bad colour printer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { null, "HP Meezie", 12500.99f, "Good colour printer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { null, "Gala Table", 12123.99f, "Very Big Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { null, "DreamTop", 900.99f, "Big Table" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { "/Images/Products/smartphone.jpg", "Smartphone", 699.99f, "High-end smartphone" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { "/Images/Products/laptop.jpg", "Laptop", 1299.99f, "Powerful gaming laptop" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { "/Images/Products/novel.jpg", "Novel", 19.99f, "Interesting fiction novel" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { "/Images/Products/biography.jpg", "Biography", 24.99f, "Famous person's biography" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { "/Images/Products/tshirt.jpg", "T-Shirt", 14.99f, "Cotton t-shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Image", "Name", "Price", "description" },
                values: new object[] { "/Images/Products/jeans.jpg", "Jeans", 49.99f, "Denim jeans" });
        }
    }
}
