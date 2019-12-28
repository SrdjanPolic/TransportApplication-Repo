using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class LoadUnloadAddresDatumMovedToHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine");

            migrationBuilder.DropColumn(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine");

            migrationBuilder.DropColumn(
                name: "UnloadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine");

            migrationBuilder.DropColumn(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 972, DateTimeKind.Local).AddTicks(9876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 898, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(6543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(1600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(1249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.AddColumn<string>(
                name: "LoadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 4, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.AddColumn<string>(
                name: "UnloadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 4, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 982, DateTimeKind.Local).AddTicks(6593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 906, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 983, DateTimeKind.Local).AddTicks(2386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 907, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 982, DateTimeKind.Local).AddTicks(7322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 906, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 19, DateTimeKind.Local).AddTicks(8813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 937, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 20, DateTimeKind.Local).AddTicks(1572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 938, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 19, DateTimeKind.Local).AddTicks(6282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 937, DateTimeKind.Local).AddTicks(8707));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "UnloadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 898, DateTimeKind.Local).AddTicks(34),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 972, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.AddColumn<string>(
                name: "LoadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 928, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.AddColumn<string>(
                name: "UnloadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 928, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(783),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(6593),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(2041),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(1699),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 2, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 906, DateTimeKind.Local).AddTicks(7577),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 982, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 907, DateTimeKind.Local).AddTicks(3900),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 983, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 906, DateTimeKind.Local).AddTicks(8590),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 51, 982, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 937, DateTimeKind.Local).AddTicks(9892),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 19, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 938, DateTimeKind.Local).AddTicks(433),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 20, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 937, DateTimeKind.Local).AddTicks(8707),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 23, 19, 53, 52, 19, DateTimeKind.Local).AddTicks(6282));
        }
    }
}
