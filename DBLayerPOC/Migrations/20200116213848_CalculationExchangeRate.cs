using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class CalculationExchangeRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 624, DateTimeKind.Local).AddTicks(3339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 732, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(2058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(7466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 761, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(1871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(4102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(3736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.AddColumn<float>(
                name: "CalculatonExchangeRate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 634, DateTimeKind.Local).AddTicks(3832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 742, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 635, DateTimeKind.Local).AddTicks(2354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 743, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 634, DateTimeKind.Local).AddTicks(4791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 743, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 675, DateTimeKind.Local).AddTicks(642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 675, DateTimeKind.Local).AddTicks(1191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 674, DateTimeKind.Local).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(6089));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CalculatonExchangeRate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 732, DateTimeKind.Local).AddTicks(6115),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 624, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(6488),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(6181),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 761, DateTimeKind.Local).AddTicks(2418),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(7431),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(5028),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 760, DateTimeKind.Local).AddTicks(7069),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(8608),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 762, DateTimeKind.Local).AddTicks(8231),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 742, DateTimeKind.Local).AddTicks(9584),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 634, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 743, DateTimeKind.Local).AddTicks(5675),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 635, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 743, DateTimeKind.Local).AddTicks(509),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 634, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(7208),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 675, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(8133),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 675, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 22, 28, 41, 775, DateTimeKind.Local).AddTicks(6089),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 674, DateTimeKind.Local).AddTicks(9580));
        }
    }
}
