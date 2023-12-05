using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class addInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 712.021981759007m, new DateTime(2022, 10, 18, 15, 16, 56, 509, DateTimeKind.Local).AddTicks(3637), "Gorgeous Wooden Chair" },
                    { 2, "7", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 839.010165513032m, new DateTime(2023, 4, 30, 11, 55, 30, 145, DateTimeKind.Local).AddTicks(5509), "Handcrafted Steel Shoes" },
                    { 3, "1", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 198.083692779804m, new DateTime(2022, 8, 19, 6, 49, 13, 418, DateTimeKind.Local).AddTicks(7493), "Handmade Granite Table" },
                    { 4, "1", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 160.643399712929m, new DateTime(2023, 3, 20, 19, 2, 43, 777, DateTimeKind.Local).AddTicks(8854), "Handmade Wooden Table" },
                    { 5, "0", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 359.887736376788m, new DateTime(2022, 9, 20, 20, 20, 55, 507, DateTimeKind.Local).AddTicks(5017), "Intelligent Steel Salad" },
                    { 6, "8", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 181.360829243139m, new DateTime(2023, 4, 4, 8, 8, 28, 617, DateTimeKind.Local).AddTicks(2314), "Handcrafted Rubber Bike" },
                    { 7, "1", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 938.297015022625m, new DateTime(2022, 11, 3, 7, 20, 41, 27, DateTimeKind.Local).AddTicks(2350), "Unbranded Steel Car" },
                    { 8, "3", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 223.882037785315m, new DateTime(2023, 1, 26, 22, 35, 8, 715, DateTimeKind.Local).AddTicks(4556), "Tasty Plastic Cheese" },
                    { 9, "0", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 249.172251003875m, new DateTime(2022, 7, 18, 14, 34, 24, 172, DateTimeKind.Local).AddTicks(2009), "Handcrafted Fresh Sausages" },
                    { 10, "1", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 905.322284099796m, new DateTime(2023, 5, 10, 6, 16, 33, 633, DateTimeKind.Local).AddTicks(4650), "Fantastic Frozen Gloves" },
                    { 11, "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 842.480734222792m, new DateTime(2023, 3, 8, 23, 30, 37, 775, DateTimeKind.Local).AddTicks(1797), "Generic Steel Ball" },
                    { 12, "1", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 928.928430071533m, new DateTime(2023, 3, 17, 4, 2, 34, 549, DateTimeKind.Local).AddTicks(485), "Ergonomic Rubber Car" },
                    { 13, "6", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 706.948686653259m, new DateTime(2023, 2, 14, 9, 16, 3, 468, DateTimeKind.Local).AddTicks(6471), "Generic Steel Pizza" },
                    { 14, "3", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 306.262494314584m, new DateTime(2022, 8, 10, 22, 28, 41, 956, DateTimeKind.Local).AddTicks(2766), "Small Metal Sausages" },
                    { 15, "2", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 378.222576259273m, new DateTime(2023, 3, 1, 15, 34, 34, 985, DateTimeKind.Local).AddTicks(9896), "Fantastic Soft Pants" },
                    { 16, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 461.718092748764m, new DateTime(2022, 6, 19, 7, 29, 23, 452, DateTimeKind.Local).AddTicks(8735), "Gorgeous Frozen Towels" },
                    { 17, "7", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 126.128098112125m, new DateTime(2023, 1, 26, 21, 50, 55, 30, DateTimeKind.Local).AddTicks(8205), "Tasty Steel Cheese" },
                    { 18, "8", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 530.970371435383m, new DateTime(2023, 1, 23, 23, 33, 36, 390, DateTimeKind.Local).AddTicks(1241), "Gorgeous Granite Cheese" },
                    { 19, "9", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 913.003066283186m, new DateTime(2022, 6, 19, 10, 51, 35, 969, DateTimeKind.Local).AddTicks(4599), "Sleek Rubber Chicken" },
                    { 20, "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 940.814879371698m, new DateTime(2022, 11, 10, 12, 22, 20, 451, DateTimeKind.Local).AddTicks(7829), "Intelligent Wooden Salad" },
                    { 21, "4", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 479.41424090062m, new DateTime(2023, 1, 18, 23, 45, 14, 640, DateTimeKind.Local).AddTicks(190), "Handcrafted Wooden Sausages" },
                    { 22, "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 320.499838554068m, new DateTime(2022, 8, 31, 19, 12, 36, 909, DateTimeKind.Local).AddTicks(7892), "Sleek Granite Car" },
                    { 23, "6", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 478.915239043029m, new DateTime(2022, 12, 31, 13, 2, 44, 228, DateTimeKind.Local).AddTicks(1440), "Small Wooden Car" },
                    { 24, "2", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 910.785444308438m, new DateTime(2023, 2, 1, 5, 39, 3, 457, DateTimeKind.Local).AddTicks(4592), "Sleek Steel Shirt" },
                    { 25, "3", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 802.238750720974m, new DateTime(2023, 2, 17, 7, 7, 55, 21, DateTimeKind.Local).AddTicks(1026), "Incredible Frozen Mouse" },
                    { 26, "7", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 150.818741621831m, new DateTime(2022, 12, 13, 0, 44, 15, 144, DateTimeKind.Local).AddTicks(6304), "Incredible Wooden Chair" },
                    { 27, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 721.773541800572m, new DateTime(2022, 9, 3, 12, 47, 51, 140, DateTimeKind.Local).AddTicks(7861), "Gorgeous Plastic Chips" },
                    { 28, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 688.245783060904m, new DateTime(2022, 11, 26, 15, 13, 46, 252, DateTimeKind.Local).AddTicks(3068), "Incredible Fresh Bacon" },
                    { 29, "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 553.558320945389m, new DateTime(2023, 2, 19, 1, 44, 40, 245, DateTimeKind.Local).AddTicks(4357), "Incredible Soft Computer" },
                    { 30, "4", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 663.536718269594m, new DateTime(2022, 6, 16, 2, 40, 3, 461, DateTimeKind.Local).AddTicks(6127), "Handcrafted Rubber Bike" },
                    { 31, "2", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 922.479030014704m, new DateTime(2023, 5, 12, 1, 5, 52, 658, DateTimeKind.Local).AddTicks(4267), "Handcrafted Concrete Tuna" },
                    { 32, "3", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 255.49067058018m, new DateTime(2023, 2, 19, 20, 53, 18, 597, DateTimeKind.Local).AddTicks(4683), "Gorgeous Wooden Fish" },
                    { 33, "7", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 955.272407213818m, new DateTime(2022, 11, 27, 21, 22, 19, 848, DateTimeKind.Local).AddTicks(574), "Handcrafted Frozen Keyboard" },
                    { 34, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 151.982358236323m, new DateTime(2022, 6, 26, 14, 38, 7, 686, DateTimeKind.Local).AddTicks(8156), "Intelligent Plastic Chair" },
                    { 35, "9", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 434.299358334532m, new DateTime(2022, 7, 14, 19, 30, 25, 681, DateTimeKind.Local).AddTicks(7818), "Unbranded Wooden Pizza" },
                    { 36, "4", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 57.7988712865854m, new DateTime(2022, 8, 3, 14, 4, 23, 214, DateTimeKind.Local).AddTicks(9787), "Gorgeous Rubber Bacon" },
                    { 37, "7", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 883.980300599234m, new DateTime(2022, 10, 30, 5, 37, 36, 610, DateTimeKind.Local).AddTicks(7975), "Handcrafted Rubber Shirt" },
                    { 38, "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 822.452619476455m, new DateTime(2022, 8, 11, 3, 39, 16, 929, DateTimeKind.Local).AddTicks(9338), "Rustic Granite Shoes" },
                    { 39, "7", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 22.2432652671092m, new DateTime(2022, 11, 5, 11, 17, 31, 489, DateTimeKind.Local).AddTicks(4472), "Sleek Granite Chair" },
                    { 40, "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 158.364214679396m, new DateTime(2023, 1, 23, 8, 3, 48, 113, DateTimeKind.Local).AddTicks(2250), "Incredible Rubber Soap" },
                    { 41, "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 533.504530191656m, new DateTime(2023, 3, 7, 15, 9, 10, 261, DateTimeKind.Local).AddTicks(4287), "Awesome Soft Fish" },
                    { 42, "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 265.709933652407m, new DateTime(2023, 2, 27, 2, 20, 9, 690, DateTimeKind.Local).AddTicks(9584), "Intelligent Cotton Tuna" },
                    { 43, "2", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 294.402654204239m, new DateTime(2022, 8, 21, 18, 6, 23, 246, DateTimeKind.Local).AddTicks(8547), "Refined Soft Bike" },
                    { 44, "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 741.648888164036m, new DateTime(2022, 8, 25, 15, 46, 48, 405, DateTimeKind.Local).AddTicks(6162), "Handmade Cotton Bacon" },
                    { 45, "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 825.239833488706m, new DateTime(2022, 8, 3, 11, 53, 11, 475, DateTimeKind.Local).AddTicks(7666), "Small Soft Tuna" },
                    { 46, "1", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 305.894089151124m, new DateTime(2022, 12, 6, 16, 35, 23, 35, DateTimeKind.Local).AddTicks(1204), "Practical Frozen Computer" },
                    { 47, "4", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 778.911179241683m, new DateTime(2022, 8, 11, 11, 34, 57, 337, DateTimeKind.Local).AddTicks(4333), "Rustic Wooden Mouse" },
                    { 48, "2", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 318.709401070936m, new DateTime(2022, 9, 23, 8, 27, 14, 763, DateTimeKind.Local).AddTicks(3956), "Handcrafted Metal Mouse" },
                    { 49, "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 463.195345650052m, new DateTime(2022, 11, 6, 13, 9, 18, 365, DateTimeKind.Local).AddTicks(3151), "Handcrafted Rubber Salad" },
                    { 50, "6", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 717.609017980569m, new DateTime(2023, 3, 26, 2, 18, 17, 545, DateTimeKind.Local).AddTicks(1817), "Incredible Plastic Shoes" }
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
