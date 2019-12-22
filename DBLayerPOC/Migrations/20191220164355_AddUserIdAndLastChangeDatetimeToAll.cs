using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class AddUserIdAndLastChangeDatetimeToAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 455, DateTimeKind.Local).AddTicks(8842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 372, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Vehicle",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Settings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Settings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 483, DateTimeKind.Local).AddTicks(3326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 399, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 483, DateTimeKind.Local).AddTicks(1114),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 399, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 476, DateTimeKind.Local).AddTicks(9972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 392, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(5686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 461, DateTimeKind.Local).AddTicks(9501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 376, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 462, DateTimeKind.Local).AddTicks(6868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 377, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 462, DateTimeKind.Local).AddTicks(604),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 376, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 490, DateTimeKind.Local).AddTicks(77),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 490, DateTimeKind.Local).AddTicks(608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 489, DateTimeKind.Local).AddTicks(9045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 427, DateTimeKind.Local).AddTicks(1503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 350, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Currency",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Currency",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate");

            migrationBuilder.DropColumn(
                name: "LastChangeDateTime",
                schema: "TransportDbNew",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "LastChangeUserId",
                schema: "TransportDbNew",
                table: "Currency");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 372, DateTimeKind.Local).AddTicks(5304),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 455, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 399, DateTimeKind.Local).AddTicks(8181),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 483, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 399, DateTimeKind.Local).AddTicks(6105),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 483, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 392, DateTimeKind.Local).AddTicks(9523),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 476, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(6298),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(487),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(176),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 477, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 376, DateTimeKind.Local).AddTicks(5627),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 461, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 377, DateTimeKind.Local).AddTicks(9138),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 462, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 376, DateTimeKind.Local).AddTicks(8384),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 462, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(5634),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 490, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(6149),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 490, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(4738),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 489, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 350, DateTimeKind.Local).AddTicks(9297),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 43, 55, 427, DateTimeKind.Local).AddTicks(1503));
        }
    }
}
