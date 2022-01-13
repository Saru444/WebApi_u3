using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddIngredientAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Code", "Contains" },
                values: new object[,]
                {
                    { 1010, "protein minerals vitamins" },
                    { 1068, "beef" },
                    { 1062, "wheat flour water salt sugar butter gluten yeast" },
                    { 1057, "wheat flour water salt gluten yeast" },
                    { 1055, "wheat flour water gluten rapeseed oil syrup" },
                    { 1046, "carbonated water sugar orange juice of concentrate citric acid" },
                    { 1048, "caffeine taurine B-vitamins sugars water" },
                    { 1044, "carbonated water sugar dye(E150d) natural aromas" },
                    { 1038, "black tea aroma" },
                    { 1035, "sucrose" },
                    { 1032, "wheat fiber" },
                    { 1026, null },
                    { 1025, null },
                    { 1023, null },
                    { 1018, "milk salt acidification culture enzyme" },
                    { 1015, "fat water salts protein lactose" },
                    { 1073, "pork" },
                    { 1077, "chicken" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Code",
                keyValue: 1077);
        }
    }
}
