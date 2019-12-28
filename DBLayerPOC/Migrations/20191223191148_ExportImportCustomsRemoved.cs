using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class ExportImportCustomsRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExportCustoms",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine");

            migrationBuilder.DropColumn(
                name: "ImportCustoms",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 691, DateTimeKind.Local).AddTicks(7578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 972, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 717, DateTimeKind.Local).AddTicks(2049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 4, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(2205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(7618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(3190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 717, DateTimeKind.Local).AddTicks(254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 4, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(2876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 982, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(6466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 983, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(1381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 982, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(6930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 19, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(7450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 20, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(5954),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 19, DateTimeKind.Local).AddTicks(6282));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 972, DateTimeKind.Local).AddTicks(9876),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 691, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.AddColumn<string>(
                name: "ExportCustoms",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportCustoms",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 4, DateTimeKind.Local).AddTicks(9796),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 717, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(476),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(6543),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(1600),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 4, DateTimeKind.Local).AddTicks(7209),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 717, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(1249),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 982, DateTimeKind.Local).AddTicks(6593),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 983, DateTimeKind.Local).AddTicks(2386),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 982, DateTimeKind.Local).AddTicks(7322),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 19, DateTimeKind.Local).AddTicks(8813),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 20, DateTimeKind.Local).AddTicks(1572),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 19, DateTimeKind.Local).AddTicks(6282),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(5954));
        }
    }
}
