using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plugins.Datastor.SQL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SoldQty = table.Column<int>(type: "int", nullable: false),
                    BeforeQty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CashierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Computers, Phones and all electronic machines from office to home.", "Electronic" },
                    { 2, "all what a men need to steal eyes.", "Men's Fashion" },
                    { 3, "Women's Fashion ... we got her cover ", "Women's Fashion" },
                    { 4, "Home and pet ", "Home & Pets" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "Iphone 8", 9500.0, 100 },
                    { 2, 1, "hp laptop", 3700.0, 25 },
                    { 3, 1, "Keyboard", 550.0, 200 },
                    { 4, 2, "Hat", 50.0, 20 },
                    { 5, 2, "Watch", 1500.0, 45 },
                    { 6, 2, "jeans", 300.0, 300 },
                    { 7, 3, "silver ring", 250.0, 70 },
                    { 8, 3, "Bras", 34.0, 500 },
                    { 9, 3, "Pajamas sets", 220.0, 20 },
                    { 10, 4, "Wall Stickers", 270.0, 50 },
                    { 11, 4, "Dog Toys", 20.0, 200 },
                    { 12, 4, "Umbrellas", 70.0, 60 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
