using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class SalesInvoiceHeaderDriverVehicleKeyColumnsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 419, DateTimeKind.Local).AddTicks(1640),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 672, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 457, DateTimeKind.Local).AddTicks(4774),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 728, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 456, DateTimeKind.Local).AddTicks(9162),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 728, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 445, DateTimeKind.Local).AddTicks(8406),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 446, DateTimeKind.Local).AddTicks(7133),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 717, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 446, DateTimeKind.Local).AddTicks(311),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 445, DateTimeKind.Local).AddTicks(9719),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 425, DateTimeKind.Local).AddTicks(1886),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 683, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 426, DateTimeKind.Local).AddTicks(1015),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 685, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 425, DateTimeKind.Local).AddTicks(2830),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 684, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(5033),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 740, DateTimeKind.Local).AddTicks(8111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(5838),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 740, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(3966),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 740, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 375, DateTimeKind.Local).AddTicks(4978),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 624, DateTimeKind.Local).AddTicks(8168));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 672, DateTimeKind.Local).AddTicks(7341),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 419, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 728, DateTimeKind.Local).AddTicks(7252),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 457, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 728, DateTimeKind.Local).AddTicks(1340),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 456, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(4664),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 445, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 717, DateTimeKind.Local).AddTicks(8885),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 446, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(8536),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 446, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(7263),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 445, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 683, DateTimeKind.Local).AddTicks(7527),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 425, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 685, DateTimeKind.Local).AddTicks(1009),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 426, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 684, DateTimeKind.Local).AddTicks(27),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 425, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 740, DateTimeKind.Local).AddTicks(8111),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 740, DateTimeKind.Local).AddTicks(8916),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 740, DateTimeKind.Local).AddTicks(6728),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 468, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 624, DateTimeKind.Local).AddTicks(8168),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 13, 0, 4, 49, 375, DateTimeKind.Local).AddTicks(4978));
        }
    }
}
