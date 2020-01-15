using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class DiferentFieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuelType",
                schema: "TransportDbNew",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "TravelOrder",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 732, DateTimeKind.Local).AddTicks(6115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 670, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                schema: "TransportDbNew",
                table: "Vehicle",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(6488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(6181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 761, DateTimeKind.Local).AddTicks(2418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 701, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(7431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(5028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 702, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(7069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(8608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(8231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.AddColumn<string>(
                name: "TravelOrder",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 742, DateTimeKind.Local).AddTicks(9584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 743, DateTimeKind.Local).AddTicks(5675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 743, DateTimeKind.Local).AddTicks(509),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(7208),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(8133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(6089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.AddColumn<string>(
                name: "PersonalIdNumber",
                schema: "TransportDbNew",
                table: "Customer",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                schema: "TransportDbNew",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "TravelOrder",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.DropColumn(
                name: "PersonalIdNumber",
                schema: "TransportDbNew",
                table: "Customer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 670, DateTimeKind.Local).AddTicks(2194),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 732, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.AddColumn<string>(
                name: "FuelType",
                schema: "TransportDbNew",
                table: "Vehicle",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(2152),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(6413),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 701, DateTimeKind.Local).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 761, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(8117),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 702, DateTimeKind.Local).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(7485),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(6457),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(5761),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(766),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 742, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(7172),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 743, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(1584),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 743, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.AddColumn<string>(
                name: "TravelOrder",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(2345),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(2905),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(6089));
        }
    }
}
