using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class LastChangedDateAndUserIdNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer");

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 898, DateTimeKind.Local).AddTicks(34),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 455, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Vehicle",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Vehicle",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "User",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "User",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Settings",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Settings",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 928, DateTimeKind.Local).AddTicks(4240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 483, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 928, DateTimeKind.Local).AddTicks(2551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 483, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 476, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(6593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(2041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(1699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 906, DateTimeKind.Local).AddTicks(7577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 461, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 907, DateTimeKind.Local).AddTicks(3900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 462, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 906, DateTimeKind.Local).AddTicks(8590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 462, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 937, DateTimeKind.Local).AddTicks(9892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 490, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 938, DateTimeKind.Local).AddTicks(433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 490, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 937, DateTimeKind.Local).AddTicks(8707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 489, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Currency",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Currency",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 455, DateTimeKind.Local).AddTicks(8842),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 898, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Vehicle",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Vehicle",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "User",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Settings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 483, DateTimeKind.Local).AddTicks(3326),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 928, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 483, DateTimeKind.Local).AddTicks(1114),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 928, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 476, DateTimeKind.Local).AddTicks(9972),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(5686),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(994),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(663),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 922, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 461, DateTimeKind.Local).AddTicks(9501),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 906, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 462, DateTimeKind.Local).AddTicks(6868),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 907, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 462, DateTimeKind.Local).AddTicks(604),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 906, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 490, DateTimeKind.Local).AddTicks(77),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 937, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 490, DateTimeKind.Local).AddTicks(608),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 938, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Driver",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 489, DateTimeKind.Local).AddTicks(9045),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 22, 15, 45, 9, 937, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Customer",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 427, DateTimeKind.Local).AddTicks(1503));

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Currency",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
