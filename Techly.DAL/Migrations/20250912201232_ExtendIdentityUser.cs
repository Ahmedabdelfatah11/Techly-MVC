using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Techly.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Sony", 3, "Noise-cancelling wireless headphones", 12000.0, 11500.0, 10500.0, 11000.0, "AUD-001", "Sony WH-1000XM5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Logitech", 1, "Advanced wireless mouse", 3000.0, 2800.0, 2500.0, 2600.0, "ACC-002", "Logitech MX Master 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "HP", 5, "2-in-1 convertible laptop", 27000.0, 26000.0, 24000.0, 25000.0, "LAP-002", "HP Spectre x360" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Apple", 3, "True wireless earbuds with ANC", 9500.0, 9200.0, 8600.0, 8900.0, "AUD-002", "Apple AirPods Pro 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Baseus", 2, "Dual USB fast car charger", 700.0, 650.0, 550.0, 600.0, "CHG-001", "Baseus Car Charger" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Xiaomi", 4, "Fitness tracker with AMOLED display", 2000.0, 1900.0, 1700.0, 1800.0, "GAD-002", "Xiaomi Smart Band 7" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Samsung", 4, "Smartwatch with health tracking", 8000.0, 7700.0, 7100.0, 7400.0, "GAD-001", "Samsung Galaxy Watch 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Anker", 2, "Fast charging portable power bank", 1500.0, 1400.0, 1200.0, 1300.0, "ACC-001", "Anker Power Bank 20000mAh" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Anker", 2, "Fast charging portable power bank", 1500.0, 1400.0, 1200.0, 1300.0, "ACC-001", "Anker Power Bank 20000mAh" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Sony", 3, "Noise-cancelling wireless headphones", 12000.0, 11500.0, 10500.0, 11000.0, "AUD-001", "Sony WH-1000XM5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Samsung", 4, "Smartwatch with health tracking", 8000.0, 7700.0, 7100.0, 7400.0, "GAD-001", "Samsung Galaxy Watch 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Logitech", 1, "Advanced wireless mouse", 3000.0, 2800.0, 2500.0, 2600.0, "ACC-002", "Logitech MX Master 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "HP", 5, "2-in-1 convertible laptop", 27000.0, 26000.0, 24000.0, 25000.0, "LAP-002", "HP Spectre x360" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Apple", 3, "True wireless earbuds with ANC", 9500.0, 9200.0, 8600.0, 8900.0, "AUD-002", "Apple AirPods Pro 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Baseus", 2, "Dual USB fast car charger", 700.0, 650.0, 550.0, 600.0, "CHG-001", "Baseus Car Charger" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Brand", "CategoryId", "Description", "ListPrice", "Price", "Price100", "Price50", "SKU", "Title" },
                values: new object[] { "Xiaomi", 4, "Fitness tracker with AMOLED display", 2000.0, 1900.0, 1700.0, 1800.0, "GAD-002", "Xiaomi Smart Band 7" });
        }
    }
}
