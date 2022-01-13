using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class ChangeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampaignCode",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1010,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1015,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1018,
                column: "CampaignCode",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1023,
                column: "CampaignCode",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1025,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1026,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1032,
                column: "CampaignCode",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1035,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1038,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1044,
                column: "CampaignCode",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1046,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1048,
                column: "CampaignCode",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1055,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1057,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1062,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1068,
                column: "CampaignCode",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1073,
                column: "CampaignCode",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Barcode",
                keyValue: 1077,
                column: "CampaignCode",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CampaignCode",
                table: "Products",
                column: "CampaignCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Campaigns_CampaignCode",
                table: "Products",
                column: "CampaignCode",
                principalTable: "Campaigns",
                principalColumn: "CampaignId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Campaigns_CampaignCode",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CampaignCode",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CampaignCode",
                table: "Products");
        }
    }
}
