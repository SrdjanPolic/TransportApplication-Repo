using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class VendorRemoveCurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_Currency_CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.DropIndex(
                name: "IX_Vendor_CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 25, 21, 30, 39, 657, DateTimeKind.Local).AddTicks(818),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 18, 1, 9, 7, 808, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 25, 21, 30, 39, 640, DateTimeKind.Local).AddTicks(4743),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 18, 1, 9, 7, 793, DateTimeKind.Local).AddTicks(5334));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 18, 1, 9, 7, 808, DateTimeKind.Local).AddTicks(5833),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 25, 21, 30, 39, 657, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 18, 1, 9, 7, 793, DateTimeKind.Local).AddTicks(5334),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 25, 21, 30, 39, 640, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_Currency_CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor",
                column: "CurrencyId",
                principalSchema: "TransportDbNew",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
