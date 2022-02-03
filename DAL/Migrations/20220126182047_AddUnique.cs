using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class AddUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "Products",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1010,
                column: "UnitPrice",
                value: 13.25m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1015,
                column: "UnitPrice",
                value: 41.33m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1018,
                column: "UnitPrice",
                value: 89.90m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1023,
                column: "UnitPrice",
                value: 6.50m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1025,
                column: "UnitPrice",
                value: 4.50m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1026,
                column: "UnitPrice",
                value: 7.35m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1032,
                column: "UnitPrice",
                value: 18.85m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1035,
                column: "UnitPrice",
                value: 11.55m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1038,
                column: "UnitPrice",
                value: 28.95m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1044,
                column: "UnitPrice",
                value: 14.50m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1046,
                column: "UnitPrice",
                value: 14.50m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1048,
                column: "UnitPrice",
                value: 18.50m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1055,
                column: "UnitPrice",
                value: 25.68m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1057,
                column: "UnitPrice",
                value: 18.90m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1062,
                column: "UnitPrice",
                value: 10.00m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1068,
                column: "UnitPrice",
                value: 396.90m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1073,
                column: "UnitPrice",
                value: 76.88m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1077,
                column: "UnitPrice",
                value: 55.50m);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PersonNumber",
                table: "Employees",
                column: "PersonNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_PersonNumber",
                table: "Employees");

            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1010,
                column: "UnitPrice",
                value: 13.25);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1015,
                column: "UnitPrice",
                value: 41.329999999999998);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1018,
                column: "UnitPrice",
                value: 89.900000000000006);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1023,
                column: "UnitPrice",
                value: 6.5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1025,
                column: "UnitPrice",
                value: 4.5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1026,
                column: "UnitPrice",
                value: 7.3499999999999996);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1032,
                column: "UnitPrice",
                value: 18.850000000000001);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1035,
                column: "UnitPrice",
                value: 11.550000000000001);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1038,
                column: "UnitPrice",
                value: 28.949999999999999);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1044,
                column: "UnitPrice",
                value: 14.5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1046,
                column: "UnitPrice",
                value: 14.5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1048,
                column: "UnitPrice",
                value: 18.5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1055,
                column: "UnitPrice",
                value: 25.68);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1057,
                column: "UnitPrice",
                value: 18.899999999999999);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1062,
                column: "UnitPrice",
                value: 10.0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1068,
                column: "UnitPrice",
                value: 396.89999999999998);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1073,
                column: "UnitPrice",
                value: 76.879999999999995);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1077,
                column: "UnitPrice",
                value: 55.5);
        }
    }
}
