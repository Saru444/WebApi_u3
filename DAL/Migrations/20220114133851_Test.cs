using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentProduct_Departments_DepartmentName",
                table: "DepartmentProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentProduct_Products_ProductBarcode",
                table: "DepartmentProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentProduct",
                table: "DepartmentProduct");

            migrationBuilder.RenameTable(
                name: "DepartmentProduct",
                newName: "DepartmentProducts");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentProduct_ProductBarcode",
                table: "DepartmentProducts",
                newName: "IX_DepartmentProducts_ProductBarcode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentProducts",
                table: "DepartmentProducts",
                columns: new[] { "DepartmentName", "ProductBarcode" });

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentProducts_Departments_DepartmentName",
                table: "DepartmentProducts",
                column: "DepartmentName",
                principalTable: "Departments",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentProducts_Products_ProductBarcode",
                table: "DepartmentProducts",
                column: "ProductBarcode",
                principalTable: "Products",
                principalColumn: "Barcode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentProducts_Departments_DepartmentName",
                table: "DepartmentProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentProducts_Products_ProductBarcode",
                table: "DepartmentProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentProducts",
                table: "DepartmentProducts");

            migrationBuilder.RenameTable(
                name: "DepartmentProducts",
                newName: "DepartmentProduct");

            migrationBuilder.RenameIndex(
                name: "IX_DepartmentProducts_ProductBarcode",
                table: "DepartmentProduct",
                newName: "IX_DepartmentProduct_ProductBarcode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentProduct",
                table: "DepartmentProduct",
                columns: new[] { "DepartmentName", "ProductBarcode" });

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentProduct_Departments_DepartmentName",
                table: "DepartmentProduct",
                column: "DepartmentName",
                principalTable: "Departments",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentProduct_Products_ProductBarcode",
                table: "DepartmentProduct",
                column: "ProductBarcode",
                principalTable: "Products",
                principalColumn: "Barcode");
        }
    }
}
