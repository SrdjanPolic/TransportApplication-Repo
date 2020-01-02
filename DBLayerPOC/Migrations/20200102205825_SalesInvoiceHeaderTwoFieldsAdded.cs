using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class SalesInvoiceHeaderTwoFieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 636, DateTimeKind.Local).AddTicks(9503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 198, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 666, DateTimeKind.Local).AddTicks(830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 281, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 663, DateTimeKind.Local).AddTicks(9926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 275, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 664, DateTimeKind.Local).AddTicks(6176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 277, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 664, DateTimeKind.Local).AddTicks(1262),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 276, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 665, DateTimeKind.Local).AddTicks(9246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 280, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 664, DateTimeKind.Local).AddTicks(884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 276, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 666, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.AddColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 666, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 647, DateTimeKind.Local).AddTicks(1011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 220, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 647, DateTimeKind.Local).AddTicks(6838),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 221, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 647, DateTimeKind.Local).AddTicks(2072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 220, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 677, DateTimeKind.Local).AddTicks(8059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 317, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 677, DateTimeKind.Local).AddTicks(8660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 317, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 677, DateTimeKind.Local).AddTicks(7097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 316, DateTimeKind.Local).AddTicks(7531));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 198, DateTimeKind.Local).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 636, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 281, DateTimeKind.Local).AddTicks(1640),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 666, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 275, DateTimeKind.Local).AddTicks(9224),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 663, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 277, DateTimeKind.Local).AddTicks(5136),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 664, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 276, DateTimeKind.Local).AddTicks(1753),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 664, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 280, DateTimeKind.Local).AddTicks(7913),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 665, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 276, DateTimeKind.Local).AddTicks(867),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 664, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 220, DateTimeKind.Local).AddTicks(4765),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 647, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 221, DateTimeKind.Local).AddTicks(8914),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 647, DateTimeKind.Local).AddTicks(6838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 220, DateTimeKind.Local).AddTicks(6804),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 647, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 317, DateTimeKind.Local).AddTicks(637),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 677, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 317, DateTimeKind.Local).AddTicks(8545),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 677, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 316, DateTimeKind.Local).AddTicks(7531),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 2, 21, 58, 24, 677, DateTimeKind.Local).AddTicks(7097));
        }
    }
}
