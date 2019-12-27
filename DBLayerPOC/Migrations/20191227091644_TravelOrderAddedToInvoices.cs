using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class TravelOrderAddedToInvoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 198, DateTimeKind.Local).AddTicks(7660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 436, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 281, DateTimeKind.Local).AddTicks(1640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 464, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 275, DateTimeKind.Local).AddTicks(9224),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 277, DateTimeKind.Local).AddTicks(5136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 463, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 276, DateTimeKind.Local).AddTicks(1753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 280, DateTimeKind.Local).AddTicks(7913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 464, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 276, DateTimeKind.Local).AddTicks(867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.AddColumn<string>(
                name: "TravelOrder",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 220, DateTimeKind.Local).AddTicks(4765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 221, DateTimeKind.Local).AddTicks(8914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 220, DateTimeKind.Local).AddTicks(6804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.AddColumn<string>(
                name: "TravelOrder",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 317, DateTimeKind.Local).AddTicks(637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 317, DateTimeKind.Local).AddTicks(8545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 316, DateTimeKind.Local).AddTicks(7531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(3622));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TravelOrder",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "TravelOrder",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 436, DateTimeKind.Local).AddTicks(8104),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 198, DateTimeKind.Local).AddTicks(7660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 464, DateTimeKind.Local).AddTicks(6341),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 281, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(5165),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 275, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 463, DateTimeKind.Local).AddTicks(1771),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 277, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(6901),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 276, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 464, DateTimeKind.Local).AddTicks(4796),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 280, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 462, DateTimeKind.Local).AddTicks(6513),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 276, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(387),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 220, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(6696),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 221, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 446, DateTimeKind.Local).AddTicks(1185),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 220, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(5621),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 317, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(6407),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 317, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 22, 2, 37, 477, DateTimeKind.Local).AddTicks(3622),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 27, 10, 16, 43, 316, DateTimeKind.Local).AddTicks(7531));
        }
    }
}
