using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class SalesInvoiceHeaderPartialyPayed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 670, DateTimeKind.Local).AddTicks(2194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 39, 978, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(2152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 4, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(6413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 2, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 701, DateTimeKind.Local).AddTicks(3651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 3, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.AlterColumn<float>(
                name: "PartiallyPayed",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(8117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 3, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 702, DateTimeKind.Local).AddTicks(9512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 4, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(7485),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 2, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(6457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 5, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(5761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 5, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 39, 987, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(7172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 39, 987, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(1584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 39, 987, DateTimeKind.Local).AddTicks(4047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(2345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 16, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(2905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 16, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(1338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 16, DateTimeKind.Local).AddTicks(2698));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 39, 978, DateTimeKind.Local).AddTicks(5609),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 670, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 4, DateTimeKind.Local).AddTicks(8183),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 2, DateTimeKind.Local).AddTicks(9201),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(6413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 3, DateTimeKind.Local).AddTicks(4590),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 701, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.AlterColumn<bool>(
                name: "PartiallyPayed",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(float),
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 3, DateTimeKind.Local).AddTicks(258),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 4, DateTimeKind.Local).AddTicks(6600),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 702, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 2, DateTimeKind.Local).AddTicks(9937),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 700, DateTimeKind.Local).AddTicks(7485));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 5, DateTimeKind.Local).AddTicks(470),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 5, DateTimeKind.Local).AddTicks(145),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 703, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 39, 987, DateTimeKind.Local).AddTicks(3310),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 39, 987, DateTimeKind.Local).AddTicks(8915),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 39, 987, DateTimeKind.Local).AddTicks(4047),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 680, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 16, DateTimeKind.Local).AddTicks(3630),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 16, DateTimeKind.Local).AddTicks(4138),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 2, 22, 21, 40, 16, DateTimeKind.Local).AddTicks(2698),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 4, 22, 2, 1, 719, DateTimeKind.Local).AddTicks(1338));
        }
    }
}
