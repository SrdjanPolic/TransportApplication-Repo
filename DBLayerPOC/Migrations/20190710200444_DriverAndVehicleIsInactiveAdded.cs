using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class DriverAndVehicleIsInactiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 261, DateTimeKind.Local).AddTicks(4810),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 83, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.AddColumn<bool>(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "Vehicle",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 294, DateTimeKind.Local).AddTicks(6497),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 118, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 294, DateTimeKind.Local).AddTicks(2251),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 118, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 285, DateTimeKind.Local).AddTicks(1308),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(7889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 285, DateTimeKind.Local).AddTicks(9452),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 109, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 285, DateTimeKind.Local).AddTicks(2703),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 285, DateTimeKind.Local).AddTicks(2178),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 267, DateTimeKind.Local).AddTicks(2641),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 268, DateTimeKind.Local).AddTicks(60),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 267, DateTimeKind.Local).AddTicks(3992),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 303, DateTimeKind.Local).AddTicks(5023),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 303, DateTimeKind.Local).AddTicks(5709),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 303, DateTimeKind.Local).AddTicks(3939),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.AddColumn<bool>(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 227, DateTimeKind.Local).AddTicks(4072),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 46, DateTimeKind.Local).AddTicks(4553));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "Driver");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 83, DateTimeKind.Local).AddTicks(5384),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 261, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 118, DateTimeKind.Local).AddTicks(9577),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 294, DateTimeKind.Local).AddTicks(6497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 118, DateTimeKind.Local).AddTicks(4831),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 294, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(7889),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 285, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 109, DateTimeKind.Local).AddTicks(6108),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 285, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(9277),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 285, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 108, DateTimeKind.Local).AddTicks(8702),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 285, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(995),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 267, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(8237),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 268, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 89, DateTimeKind.Local).AddTicks(1771),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 267, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(8884),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 303, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(9627),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 303, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 127, DateTimeKind.Local).AddTicks(7866),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 303, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 6, 59, 46, DateTimeKind.Local).AddTicks(4553),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 10, 22, 4, 44, 227, DateTimeKind.Local).AddTicks(4072));
        }
    }
}
