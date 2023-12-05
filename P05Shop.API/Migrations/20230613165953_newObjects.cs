using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class newObjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDetailsId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Manufactuer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContantEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSuppliers",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSuppliers", x => new { x.ProductId, x.SupplierId });
                    table.ForeignKey(
                        name: "FK_ProductSuppliers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSuppliers_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 10, 26, 0, 19, 53, 578, DateTimeKind.Local).AddTicks(5525) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 5, 7, 20, 58, 27, 214, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 8, 26, 15, 52, 10, 487, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 3, 28, 4, 5, 40, 847, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 9, 28, 5, 23, 52, 576, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 4, 11, 17, 11, 25, 686, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 11, 10, 16, 23, 38, 96, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 2, 3, 7, 38, 5, 784, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 7, 25, 23, 37, 21, 241, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 5, 17, 15, 19, 30, 702, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 3, 16, 8, 33, 34, 844, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 3, 24, 13, 5, 31, 618, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 2, 21, 18, 19, 0, 537, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 8, 18, 7, 31, 39, 25, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 3, 9, 0, 37, 32, 55, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 6, 26, 16, 32, 20, 522, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 2, 3, 6, 53, 52, 100, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 1, 31, 8, 36, 33, 459, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 6, 26, 19, 54, 33, 38, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 11, 17, 21, 25, 17, 520, DateTimeKind.Local).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 1, 26, 8, 48, 11, 709, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 9, 8, 4, 15, 33, 978, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 1, 7, 22, 5, 41, 297, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 2, 8, 14, 42, 0, 526, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 2, 24, 16, 10, 52, 90, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 12, 20, 9, 47, 12, 213, DateTimeKind.Local).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 9, 10, 21, 50, 48, 209, DateTimeKind.Local).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 12, 4, 0, 16, 43, 321, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 2, 26, 10, 47, 37, 314, DateTimeKind.Local).AddTicks(6406) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 6, 23, 11, 43, 0, 530, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 5, 19, 10, 8, 49, 727, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 2, 27, 5, 56, 15, 666, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 12, 5, 6, 25, 16, 917, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 7, 3, 23, 41, 4, 756, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 7, 22, 4, 33, 22, 750, DateTimeKind.Local).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 8, 10, 23, 7, 20, 284, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 11, 6, 14, 40, 33, 679, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 8, 18, 12, 42, 13, 999, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 11, 12, 20, 20, 28, 558, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 1, 30, 17, 6, 45, 182, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 3, 15, 0, 12, 7, 330, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 3, 6, 11, 23, 6, 760, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 8, 29, 3, 9, 20, 316, DateTimeKind.Local).AddTicks(472) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 9, 2, 0, 49, 45, 474, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 8, 10, 20, 56, 8, 544, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 12, 14, 1, 38, 20, 104, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 8, 18, 20, 37, 54, 406, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 9, 30, 17, 30, 11, 832, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2022, 11, 13, 22, 12, 15, 434, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "ProductDetailsId", "ReleaseDate" },
                values: new object[] { null, null, new DateTime(2023, 4, 2, 11, 21, 14, 614, DateTimeKind.Local).AddTicks(3793) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSuppliers_SupplierId",
                table: "ProductSuppliers",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "ProductSuppliers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductDetailsId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 18, 15, 16, 56, 509, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 30, 11, 55, 30, 145, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 19, 6, 49, 13, 418, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 20, 19, 2, 43, 777, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 20, 20, 20, 55, 507, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2023, 4, 4, 8, 8, 28, 617, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 3, 7, 20, 41, 27, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 26, 22, 35, 8, 715, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2022, 7, 18, 14, 34, 24, 172, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 10, 6, 16, 33, 633, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 8, 23, 30, 37, 775, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 17, 4, 2, 34, 549, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 14, 9, 16, 3, 468, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 10, 22, 28, 41, 956, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 1, 15, 34, 34, 985, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 19, 7, 29, 23, 452, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 26, 21, 50, 55, 30, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 23, 33, 36, 390, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 19, 10, 51, 35, 969, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 10, 12, 22, 20, 451, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 18, 23, 45, 14, 640, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 31, 19, 12, 36, 909, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 31, 13, 2, 44, 228, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 1, 5, 39, 3, 457, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 17, 7, 7, 55, 21, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 13, 0, 44, 15, 144, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 3, 12, 47, 51, 140, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 26, 15, 13, 46, 252, DateTimeKind.Local).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 19, 1, 44, 40, 245, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 16, 2, 40, 3, 461, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2023, 5, 12, 1, 5, 52, 658, DateTimeKind.Local).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 19, 20, 53, 18, 597, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 27, 21, 22, 19, 848, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2022, 6, 26, 14, 38, 7, 686, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2022, 7, 14, 19, 30, 25, 681, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 3, 14, 4, 23, 214, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "ReleaseDate",
                value: new DateTime(2022, 10, 30, 5, 37, 36, 610, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 11, 3, 39, 16, 929, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 5, 11, 17, 31, 489, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "ReleaseDate",
                value: new DateTime(2023, 1, 23, 8, 3, 48, 113, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 7, 15, 9, 10, 261, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "ReleaseDate",
                value: new DateTime(2023, 2, 27, 2, 20, 9, 690, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 21, 18, 6, 23, 246, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 25, 15, 46, 48, 405, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 3, 11, 53, 11, 475, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "ReleaseDate",
                value: new DateTime(2022, 12, 6, 16, 35, 23, 35, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                column: "ReleaseDate",
                value: new DateTime(2022, 8, 11, 11, 34, 57, 337, DateTimeKind.Local).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "ReleaseDate",
                value: new DateTime(2022, 9, 23, 8, 27, 14, 763, DateTimeKind.Local).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                column: "ReleaseDate",
                value: new DateTime(2022, 11, 6, 13, 9, 18, 365, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "ReleaseDate",
                value: new DateTime(2023, 3, 26, 2, 18, 17, 545, DateTimeKind.Local).AddTicks(1817));
        }
    }
}
