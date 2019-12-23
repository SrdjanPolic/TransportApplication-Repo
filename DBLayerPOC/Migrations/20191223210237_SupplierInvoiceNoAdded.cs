using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class SupplierInvoiceNoAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 436, DateTimeKind.Local).AddTicks(8104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 691, DateTimeKind.Local).AddTicks(7578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 464, DateTimeKind.Local).AddTicks(6341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 717, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(5165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 463, DateTimeKind.Local).AddTicks(1771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(6901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 464, DateTimeKind.Local).AddTicks(4796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 717, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(6513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(6696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(1185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.AddColumn<string>(
                name: "SupplierInvoiceNo",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(5621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(6407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(3622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(5954));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierInvoiceNo",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 691, DateTimeKind.Local).AddTicks(7578),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 436, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 717, DateTimeKind.Local).AddTicks(2049),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 464, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(2205),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(7618),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 463, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(3190),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 717, DateTimeKind.Local).AddTicks(254),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 464, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 715, DateTimeKind.Local).AddTicks(2876),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(619),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(6466),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 700, DateTimeKind.Local).AddTicks(1381),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(6930),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(7450),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 20, 11, 47, 728, DateTimeKind.Local).AddTicks(5954),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(3622));
        }
    }
}
