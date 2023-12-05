using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class movies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "ProductSuppliers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Director = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Title" },
                values: new object[,]
                {
                    { 1, "Nazariusz Szeląg", "Gorgeous Wooden Chair" },
                    { 2, "Władysław Stępień", "Sleek Concrete Shirt" },
                    { 3, "Klaudiusz Rogowski", "Ergonomic Plastic Soap" },
                    { 4, "Eleonora Buczkowski", "Refined Metal Tuna" },
                    { 5, "Natalia Błaszczak", "Sleek Wooden Chicken" },
                    { 6, "Eudokia Michałowski", "Incredible Steel Chair" },
                    { 7, "Klemens Szymański", "Fantastic Rubber Salad" },
                    { 8, "Filemon Pieczek", "Ergonomic Metal Shoes" },
                    { 9, "Arkadiusz Kaźmierczak", "Rustic Soft Car" },
                    { 10, "Aleksander Kaczorowski", "Ergonomic Metal Hat" },
                    { 11, "Lea Skalski", "Practical Cotton Mouse" },
                    { 12, "Gerald Madej", "Rustic Cotton Keyboard" },
                    { 13, "Wilhelmina Krawiec", "Fantastic Concrete Chicken" },
                    { 14, "Jakub Nowaczyk", "Sleek Cotton Shoes" },
                    { 15, "Aleksy Wiśniewski", "Rustic Concrete Bike" },
                    { 16, "Walenty Andrzejewski", "Handmade Steel Tuna" },
                    { 17, "Mikołaj Cholewa", "Generic Rubber Chips" },
                    { 18, "Modest Rogowski", "Small Cotton Computer" },
                    { 19, "Renata Góral", "Handcrafted Rubber Bike" },
                    { 20, "Karolina Tracz", "Tasty Steel Car" },
                    { 21, "Paweł Dudziński", "Generic Concrete Bike" },
                    { 22, "Ofelia Adamczyk", "Gorgeous Wooden Mouse" },
                    { 23, "Izajasz Urbańczyk", "Small Soft Tuna" },
                    { 24, "Olga Krawiec", "Refined Concrete Gloves" },
                    { 25, "Wilfryd Wąsowski", "Ergonomic Plastic Computer" },
                    { 26, "Justyna Wolak", "Generic Frozen Gloves" },
                    { 27, "Koralia Konieczny", "Handcrafted Steel Chips" },
                    { 28, "Gilbert Turek", "Fantastic Plastic Towels" },
                    { 29, "Miron Piasecki", "Licensed Concrete Bike" },
                    { 30, "Apollinary Kołodziejczyk", "Refined Frozen Chips" },
                    { 31, "Gwido Sołtysiak", "Licensed Metal Mouse" },
                    { 32, "Samson Modzelewski", "Incredible Wooden Chicken" },
                    { 33, "Wiktoria Jasiński", "Gorgeous Fresh Shirt" },
                    { 34, "Olimpia Kędziora", "Small Soft Chips" },
                    { 35, "Albert Nawrot", "Sleek Rubber Computer" },
                    { 36, "Filipa Bożek", "Refined Wooden Cheese" },
                    { 37, "Nazary Czajka", "Generic Steel Ball" },
                    { 38, "Nina Bielak", "Tasty Fresh Cheese" },
                    { 39, "Kornelia Olszewski", "Incredible Metal Computer" },
                    { 40, "Artur Niedzielski", "Unbranded Fresh Bike" },
                    { 41, "Zachary Wiącek", "Small Frozen Car" },
                    { 42, "Beatrycze Wójcik", "Rustic Rubber Keyboard" },
                    { 43, "Pankracy Wypych", "Intelligent Plastic Cheese" },
                    { 44, "Martyna Kaczmarczyk", "Intelligent Rubber Chair" },
                    { 45, "Malwina Duda", "Intelligent Steel Car" },
                    { 46, "Pankracy Pietrzak", "Refined Granite Shoes" },
                    { 47, "Laurenty Banach", "Small Fresh Chicken" },
                    { 48, "Reginald Zawadzki", "Handcrafted Frozen Chicken" },
                    { 49, "Stella Szczygieł", "Fantastic Metal Keyboard" },
                    { 50, "Florencja Kowalski", "Tasty Fresh Chicken" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

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
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContantEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ProductDetailsId = table.Column<int>(type: "int", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "CategoryId", "Description", "Price", "ProductDetailsId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "3", null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 712.021981759007m, null, new DateTime(2022, 10, 26, 0, 19, 53, 578, DateTimeKind.Local).AddTicks(5525), "Gorgeous Wooden Chair" },
                    { 2, "7", null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 839.010165513032m, null, new DateTime(2023, 5, 7, 20, 58, 27, 214, DateTimeKind.Local).AddTicks(7360), "Handcrafted Steel Shoes" },
                    { 3, "1", null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 198.083692779804m, null, new DateTime(2022, 8, 26, 15, 52, 10, 487, DateTimeKind.Local).AddTicks(9352), "Handmade Granite Table" },
                    { 4, "1", null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 160.643399712929m, null, new DateTime(2023, 3, 28, 4, 5, 40, 847, DateTimeKind.Local).AddTicks(724), "Handmade Wooden Table" },
                    { 5, "0", null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 359.887736376788m, null, new DateTime(2022, 9, 28, 5, 23, 52, 576, DateTimeKind.Local).AddTicks(6911), "Intelligent Steel Salad" },
                    { 6, "8", null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 181.360829243139m, null, new DateTime(2023, 4, 11, 17, 11, 25, 686, DateTimeKind.Local).AddTicks(4187), "Handcrafted Rubber Bike" },
                    { 7, "1", null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 938.297015022625m, null, new DateTime(2022, 11, 10, 16, 23, 38, 96, DateTimeKind.Local).AddTicks(4226), "Unbranded Steel Car" },
                    { 8, "3", null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 223.882037785315m, null, new DateTime(2023, 2, 3, 7, 38, 5, 784, DateTimeKind.Local).AddTicks(6440), "Tasty Plastic Cheese" },
                    { 9, "0", null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 249.172251003875m, null, new DateTime(2022, 7, 25, 23, 37, 21, 241, DateTimeKind.Local).AddTicks(3900), "Handcrafted Fresh Sausages" },
                    { 10, "1", null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 905.322284099796m, null, new DateTime(2023, 5, 17, 15, 19, 30, 702, DateTimeKind.Local).AddTicks(6549), "Fantastic Frozen Gloves" },
                    { 11, "3", null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 842.480734222792m, null, new DateTime(2023, 3, 16, 8, 33, 34, 844, DateTimeKind.Local).AddTicks(3703), "Generic Steel Ball" },
                    { 12, "1", null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 928.928430071533m, null, new DateTime(2023, 3, 24, 13, 5, 31, 618, DateTimeKind.Local).AddTicks(2426), "Ergonomic Rubber Car" },
                    { 13, "6", null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 706.948686653259m, null, new DateTime(2023, 2, 21, 18, 19, 0, 537, DateTimeKind.Local).AddTicks(8398), "Generic Steel Pizza" },
                    { 14, "3", null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 306.262494314584m, null, new DateTime(2022, 8, 18, 7, 31, 39, 25, DateTimeKind.Local).AddTicks(4700), "Small Metal Sausages" },
                    { 15, "2", null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 378.222576259273m, null, new DateTime(2023, 3, 9, 0, 37, 32, 55, DateTimeKind.Local).AddTicks(1839), "Fantastic Soft Pants" },
                    { 16, "6", null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 461.718092748764m, null, new DateTime(2022, 6, 26, 16, 32, 20, 522, DateTimeKind.Local).AddTicks(683), "Gorgeous Frozen Towels" },
                    { 17, "7", null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 126.128098112125m, null, new DateTime(2023, 2, 3, 6, 53, 52, 100, DateTimeKind.Local).AddTicks(160), "Tasty Steel Cheese" },
                    { 18, "8", null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 530.970371435383m, null, new DateTime(2023, 1, 31, 8, 36, 33, 459, DateTimeKind.Local).AddTicks(3242), "Gorgeous Granite Cheese" },
                    { 19, "9", null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 913.003066283186m, null, new DateTime(2022, 6, 26, 19, 54, 33, 38, DateTimeKind.Local).AddTicks(6582), "Sleek Rubber Chicken" },
                    { 20, "5", null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 940.814879371698m, null, new DateTime(2022, 11, 17, 21, 25, 17, 520, DateTimeKind.Local).AddTicks(9817), "Intelligent Wooden Salad" },
                    { 21, "4", null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 479.41424090062m, null, new DateTime(2023, 1, 26, 8, 48, 11, 709, DateTimeKind.Local).AddTicks(2186), "Handcrafted Wooden Sausages" },
                    { 22, "7", null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 320.499838554068m, null, new DateTime(2022, 9, 8, 4, 15, 33, 978, DateTimeKind.Local).AddTicks(9896), "Sleek Granite Car" },
                    { 23, "6", null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 478.915239043029m, null, new DateTime(2023, 1, 7, 22, 5, 41, 297, DateTimeKind.Local).AddTicks(3451), "Small Wooden Car" },
                    { 24, "2", null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 910.785444308438m, null, new DateTime(2023, 2, 8, 14, 42, 0, 526, DateTimeKind.Local).AddTicks(6634), "Sleek Steel Shirt" },
                    { 25, "3", null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 802.238750720974m, null, new DateTime(2023, 2, 24, 16, 10, 52, 90, DateTimeKind.Local).AddTicks(3076), "Incredible Frozen Mouse" },
                    { 26, "7", null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 150.818741621831m, null, new DateTime(2022, 12, 20, 9, 47, 12, 213, DateTimeKind.Local).AddTicks(8334), "Incredible Wooden Chair" },
                    { 27, "5", null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 721.773541800572m, null, new DateTime(2022, 9, 10, 21, 50, 48, 209, DateTimeKind.Local).AddTicks(9897), "Gorgeous Plastic Chips" },
                    { 28, "5", null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 688.245783060904m, null, new DateTime(2022, 12, 4, 0, 16, 43, 321, DateTimeKind.Local).AddTicks(5110), "Incredible Fresh Bacon" },
                    { 29, "7", null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 553.558320945389m, null, new DateTime(2023, 2, 26, 10, 47, 37, 314, DateTimeKind.Local).AddTicks(6406), "Incredible Soft Computer" },
                    { 30, "4", null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 663.536718269594m, null, new DateTime(2022, 6, 23, 11, 43, 0, 530, DateTimeKind.Local).AddTicks(8185), "Handcrafted Rubber Bike" },
                    { 31, "2", null, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 922.479030014704m, null, new DateTime(2023, 5, 19, 10, 8, 49, 727, DateTimeKind.Local).AddTicks(6357), "Handcrafted Concrete Tuna" },
                    { 32, "3", null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 255.49067058018m, null, new DateTime(2023, 2, 27, 5, 56, 15, 666, DateTimeKind.Local).AddTicks(6783), "Gorgeous Wooden Fish" },
                    { 33, "7", null, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 955.272407213818m, null, new DateTime(2022, 12, 5, 6, 25, 16, 917, DateTimeKind.Local).AddTicks(2659), "Handcrafted Frozen Keyboard" },
                    { 34, "8", null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 151.982358236323m, null, new DateTime(2022, 7, 3, 23, 41, 4, 756, DateTimeKind.Local).AddTicks(247), "Intelligent Plastic Chair" },
                    { 35, "9", null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 434.299358334532m, null, new DateTime(2022, 7, 22, 4, 33, 22, 750, DateTimeKind.Local).AddTicks(9917), "Unbranded Wooden Pizza" },
                    { 36, "4", null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 57.7988712865854m, null, new DateTime(2022, 8, 10, 23, 7, 20, 284, DateTimeKind.Local).AddTicks(1706), "Gorgeous Rubber Bacon" },
                    { 37, "7", null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 883.980300599234m, null, new DateTime(2022, 11, 6, 14, 40, 33, 679, DateTimeKind.Local).AddTicks(9880), "Handcrafted Rubber Shirt" },
                    { 38, "7", null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 822.452619476455m, null, new DateTime(2022, 8, 18, 12, 42, 13, 999, DateTimeKind.Local).AddTicks(1250), "Rustic Granite Shoes" },
                    { 39, "7", null, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 22.2432652671092m, null, new DateTime(2022, 11, 12, 20, 20, 28, 558, DateTimeKind.Local).AddTicks(6393), "Sleek Granite Chair" },
                    { 40, "2", null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 158.364214679396m, null, new DateTime(2023, 1, 30, 17, 6, 45, 182, DateTimeKind.Local).AddTicks(4155), "Incredible Rubber Soap" },
                    { 41, "7", null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 533.504530191656m, null, new DateTime(2023, 3, 15, 0, 12, 7, 330, DateTimeKind.Local).AddTicks(6197), "Awesome Soft Fish" },
                    { 42, "8", null, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 265.709933652407m, null, new DateTime(2023, 3, 6, 11, 23, 6, 760, DateTimeKind.Local).AddTicks(1501), "Intelligent Cotton Tuna" },
                    { 43, "2", null, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 294.402654204239m, null, new DateTime(2022, 8, 29, 3, 9, 20, 316, DateTimeKind.Local).AddTicks(472), "Refined Soft Bike" },
                    { 44, "5", null, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 741.648888164036m, null, new DateTime(2022, 9, 2, 0, 49, 45, 474, DateTimeKind.Local).AddTicks(8118), "Handmade Cotton Bacon" },
                    { 45, "5", null, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 825.239833488706m, null, new DateTime(2022, 8, 10, 20, 56, 8, 544, DateTimeKind.Local).AddTicks(9633), "Small Soft Tuna" },
                    { 46, "1", null, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 305.894089151124m, null, new DateTime(2022, 12, 14, 1, 38, 20, 104, DateTimeKind.Local).AddTicks(3137), "Practical Frozen Computer" },
                    { 47, "4", null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 778.911179241683m, null, new DateTime(2022, 8, 18, 20, 37, 54, 406, DateTimeKind.Local).AddTicks(6272), "Rustic Wooden Mouse" },
                    { 48, "2", null, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 318.709401070936m, null, new DateTime(2022, 9, 30, 17, 30, 11, 832, DateTimeKind.Local).AddTicks(5904), "Handcrafted Metal Mouse" },
                    { 49, "6", null, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 463.195345650052m, null, new DateTime(2022, 11, 13, 22, 12, 15, 434, DateTimeKind.Local).AddTicks(5106), "Handcrafted Rubber Salad" },
                    { 50, "6", null, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 717.609017980569m, null, new DateTime(2023, 4, 2, 11, 21, 14, 614, DateTimeKind.Local).AddTicks(3793), "Incredible Plastic Shoes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSuppliers_SupplierId",
                table: "ProductSuppliers",
                column: "SupplierId");
        }
    }
}
