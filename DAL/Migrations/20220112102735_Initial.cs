using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrainerID = table.Column<int>(type: "int", nullable: true),
                    TrainedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_TrainerID",
                        column: x => x.TrainerID,
                        principalTable: "Employees",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeRefId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Departments_Employees_EmployeeRefId",
                        column: x => x.EmployeeRefId,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMails",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMails", x => new { x.Email, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeeMails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Barcode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "date", nullable: true),
                    InventoriedID = table.Column<int>(type: "int", nullable: false),
                    InventoriedDate = table.Column<DateTime>(type: "date", nullable: false),
                    CampaignId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Barcode);
                    table.ForeignKey(
                        name: "FK_Products_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Employees_InventoriedID",
                        column: x => x.InventoriedID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentProduct",
                columns: table => new
                {
                    DepartmentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductBarcode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentProduct", x => new { x.DepartmentName, x.ProductBarcode });
                    table.ForeignKey(
                        name: "FK_DepartmentProduct_Departments_DepartmentName",
                        column: x => x.DepartmentName,
                        principalTable: "Departments",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_DepartmentProduct_Products_ProductBarcode",
                        column: x => x.ProductBarcode,
                        principalTable: "Products",
                        principalColumn: "Barcode");
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ProductBarcode = table.Column<int>(type: "int", nullable: false),
                    Contains = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => new { x.Contains, x.ProductBarcode });
                    table.ForeignKey(
                        name: "FK_Ingredients_Products_ProductBarcode",
                        column: x => x.ProductBarcode,
                        principalTable: "Products",
                        principalColumn: "Barcode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Campaigns",
                columns: new[] { "Id", "Discount", "Name" },
                values: new object[,]
                {
                    { 1, 0.0, "No Campaign" },
                    { 2, 0.050000000000000003, "Christmas Campaign" },
                    { 3, 0.10000000000000001, "Winter Campaign" },
                    { 4, 0.10000000000000001, "Party Campaign " }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "JobTitle", "Name", "PersonNumber", "TelNr", "TrainedDate", "TrainerID" },
                values: new object[] { 1, "Manager", "Peter", 111, "07907821", null, null });

            migrationBuilder.InsertData(
                table: "EmployeeMails",
                columns: new[] { "Email", "EmployeeId" },
                values: new object[] { "Perter@yahoo.com", 1 });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "JobTitle", "Name", "PersonNumber", "TelNr", "TrainedDate", "TrainerID" },
                values: new object[,]
                {
                    { 2, "General staff", "Emma", 134, "07036271", new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "General staff", "Pelle", 126, "07807866", new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "General staff", "Maria", 154, "07007865", new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, "General staff", "Eric", 144, "07907943", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Name", "EmployeeRefId" },
                values: new object[,]
                {
                    { "Fruit", 2 },
                    { "Bread", 2 },
                    { "Pantry", 3 },
                    { "Meat products", 5 },
                    { "Drink", 5 },
                    { "Dairy products", 4 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeMails",
                columns: new[] { "Email", "EmployeeId" },
                values: new object[,]
                {
                    { "Pelle.karlsson@hotmail.com", 3 },
                    { "Pelle@hotmail.com", 3 },
                    { "Maria@sina.com", 4 },
                    { "Eric@yahoo.com", 5 },
                    { "Emma@msn.com", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Barcode", "CampaignId", "ExpirationDate", "InventoriedDate", "InventoriedID", "Name", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1044, 4, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Cola", 25, 14.5 },
                    { 1055, 1, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Toast", 5, 25.68 },
                    { 1018, 3, new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Cheese", 10, 89.900000000000006 },
                    { 1015, 1, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Butter", 3, 41.329999999999998 },
                    { 1062, 1, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Croissant", 6, 10.0 },
                    { 1057, 1, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Baguette", 9, 18.899999999999999 },
                    { 1038, 1, new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Fruit tea", 11, 28.949999999999999 },
                    { 1048, 4, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Red bull", 6, 18.5 },
                    { 1035, 1, null, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sugar", 5, 11.550000000000001 },
                    { 1032, 2, new DateTime(2922, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Flour", 8, 18.850000000000001 },
                    { 1077, 2, new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Chicken", 7, 55.5 },
                    { 1073, 1, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Pork", 8, 76.879999999999995 },
                    { 1068, 2, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Beef", 12, 396.89999999999998 },
                    { 1026, 1, null, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Orange", 20, 7.3499999999999996 },
                    { 1025, 1, null, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Pear", 15, 4.5 },
                    { 1023, 3, null, new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Apple", 12, 6.5 },
                    { 1010, 1, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Milk", 2, 13.25 },
                    { 1046, 1, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Fanta", 8, 14.5 }
                });

            migrationBuilder.InsertData(
                table: "DepartmentProduct",
                columns: new[] { "DepartmentName", "ProductBarcode" },
                values: new object[,]
                {
                    { "Fruit", 1023 },
                    { "Drink", 1048 },
                    { "Drink", 1044 },
                    { "Meat products", 1077 },
                    { "Meat products", 1073 },
                    { "Meat products", 1068 },
                    { "Bread", 1062 },
                    { "Bread", 1057 },
                    { "Bread", 1055 },
                    { "Dairy products", 1018 },
                    { "Drink", 1046 },
                    { "Dairy products", 1010 },
                    { "Pantry", 1038 },
                    { "Dairy products", 1015 },
                    { "Pantry", 1035 },
                    { "Pantry", 1032 },
                    { "Fruit", 1025 },
                    { "Fruit", 1026 }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Contains", "ProductBarcode" },
                values: new object[,]
                {
                    { "black tea aroma", 1038 },
                    { "caffeine taurine B-vitamins sugars water", 1048 },
                    { "apple", 1023 },
                    { "carbonated water sugar dye(E150d) natural aromas", 1044 },
                    { "pear", 1025 },
                    { "orange", 1026 },
                    { "wheat flour water salt sugar butter gluten yeast", 1062 },
                    { "wheat flour water salt gluten yeast", 1057 },
                    { "sucrose", 1035 },
                    { "pork", 1073 },
                    { "wheat flour water gluten rapeseed oil syrup", 1055 },
                    { "chicken", 1077 },
                    { "milk salt acidification culture enzyme", 1018 },
                    { "fat water salts protein lactose", 1015 },
                    { "wheat fiber", 1032 },
                    { "protein minerals vitamins", 1010 },
                    { "beef", 1068 },
                    { "carbonated water sugar orange juice of concentrate citric acid", 1046 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentProduct_ProductBarcode",
                table: "DepartmentProduct",
                column: "ProductBarcode");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeeRefId",
                table: "Departments",
                column: "EmployeeRefId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMails_EmployeeId",
                table: "EmployeeMails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TrainerID",
                table: "Employees",
                column: "TrainerID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_ProductBarcode",
                table: "Ingredients",
                column: "ProductBarcode");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CampaignId",
                table: "Products",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InventoriedID",
                table: "Products",
                column: "InventoriedID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentProduct");

            migrationBuilder.DropTable(
                name: "EmployeeMails");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
