using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.CampaignId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "JobTitle", "Name", "PersonNumber", "TelNr" },
                values: new object[,]
                {
                    { 2, "General staff", "Emma", 134, "07036271" },
                    { 3, "General staff", "Pelle", 126, "07807866" },
                    { 4, "General staff", "Maria", 154, "07007865" },
                    { 5, "General staff", "Eric", 144, "07907943" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Name", "EmployeeRefId" },
                values: new object[,]
                {
                    { "Fruit", 2 },
                    { "Bread", 2 },
                    { "Meat products", 5 },
                    { "Drink", 5 },
                    { "Pantry", 3 },
                    { "Dairy products", 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Barcode", "ExpirationDate", "InventoriedBy", "InventoriedDate", "Name", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1044, "2023-02-02", 5, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cola", 25, 14.5 },
                    { 1062, "2022-01-14", 4, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Croissant", 6, 10.0 },
                    { 1057, "2022-01-15", 4, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baguette", 9, 18.899999999999999 },
                    { 1055, "2022-01-20", 4, new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toast", 5, 25.68 },
                    { 1018, "2022-02-05", 4, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cheese", 10, 89.900000000000006 },
                    { 1015, "2022-02-03", 4, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Butter", 3, 41.329999999999998 },
                    { 1010, "2022-01-20", 4, new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milk", 2, 13.25 },
                    { 1038, "2022-12-20", 3, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fruit tea", 11, 28.949999999999999 },
                    { 1035, null, 3, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sugar", 5, 11.550000000000001 },
                    { 1032, "2022-05-06", 3, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flour", 8, 18.850000000000001 },
                    { 1077, "2022-01-06", 2, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicken", 7, 55.5 },
                    { 1073, "2022-01-05", 2, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pork", 8, 76.879999999999995 },
                    { 1068, "2022-01-04", 2, new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beef", 12, 396.89999999999998 },
                    { 1026, null, 2, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orange", 20, 7.3499999999999996 },
                    { 1025, null, 2, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pear", 15, 4.5 },
                    { 1023, null, 2, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", 12, 6.5 },
                    { 1048, "2023-01-02", 5, new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red bull", 6, 18.5 },
                    { 1046, "2023-02-02", 5, new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fanta", 8, 14.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Bread");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Dairy products");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Drink");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Fruit");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Meat products");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Pantry");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
