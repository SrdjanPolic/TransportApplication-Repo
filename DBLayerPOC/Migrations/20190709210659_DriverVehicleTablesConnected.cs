using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class DriverVehicleTablesConnected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 83, DateTimeKind.Local).AddTicks(5384),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 902, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 118, DateTimeKind.Local).AddTicks(9577),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 118, DateTimeKind.Local).AddTicks(4831),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(7889),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 109, DateTimeKind.Local).AddTicks(6108),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 928, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(9277),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(8702),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(995),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(8237),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(1771),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(8884),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(9627),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(7866),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 46, DateTimeKind.Local).AddTicks(4553),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 865, DateTimeKind.Local).AddTicks(5863));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 902, DateTimeKind.Local).AddTicks(9592),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 83, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(7709),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 118, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(2914),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 118, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 928, DateTimeKind.Local).AddTicks(3123),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 109, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5643),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5097),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(535),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(8405),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(1455),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(2680),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(3411),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(1399),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 865, DateTimeKind.Local).AddTicks(5863),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 46, DateTimeKind.Local).AddTicks(4553));
        }
    }
}
