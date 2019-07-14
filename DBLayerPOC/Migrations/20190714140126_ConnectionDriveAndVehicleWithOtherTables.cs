using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class ConnectionDriveAndVehicleWithOtherTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 428, DateTimeKind.Local).AddTicks(9745),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 419, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 490, DateTimeKind.Local).AddTicks(7688),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 457, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 489, DateTimeKind.Local).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 456, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 475, DateTimeKind.Local).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 445, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 477, DateTimeKind.Local).AddTicks(1930),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 446, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 476, DateTimeKind.Local).AddTicks(2697),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 446, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 476, DateTimeKind.Local).AddTicks(2036),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 445, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 438, DateTimeKind.Local).AddTicks(361),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 425, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 443, DateTimeKind.Local).AddTicks(4115),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 426, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 438, DateTimeKind.Local).AddTicks(1863),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 425, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(5490),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(7596),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(2321),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 367, DateTimeKind.Local).AddTicks(7007),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 375, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesInvoiceHeader_Driver_DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "DriverId",
                principalSchema: "TransportDbNew",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesInvoiceHeader_Vehicle_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "VehicleId",
                principalSchema: "TransportDbNew",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesInvoiceHeader_Driver_DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesInvoiceHeader_Vehicle_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropIndex(
                name: "IX_SalesInvoiceHeader_DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropIndex(
                name: "IX_SalesInvoiceHeader_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 419, DateTimeKind.Local).AddTicks(1640),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 428, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 457, DateTimeKind.Local).AddTicks(4774),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 490, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 456, DateTimeKind.Local).AddTicks(9162),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 489, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 445, DateTimeKind.Local).AddTicks(8406),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 475, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 446, DateTimeKind.Local).AddTicks(7133),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 477, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 446, DateTimeKind.Local).AddTicks(311),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 476, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 445, DateTimeKind.Local).AddTicks(9719),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 476, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 425, DateTimeKind.Local).AddTicks(1886),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 438, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 426, DateTimeKind.Local).AddTicks(1015),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 443, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 425, DateTimeKind.Local).AddTicks(2830),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 438, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(5033),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(5838),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(3966),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 375, DateTimeKind.Local).AddTicks(4978),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 367, DateTimeKind.Local).AddTicks(7007));
        }
    }
}
