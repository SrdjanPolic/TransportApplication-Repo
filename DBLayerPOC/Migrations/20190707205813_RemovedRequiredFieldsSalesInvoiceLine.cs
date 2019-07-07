using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class RemovedRequiredFieldsSalesInvoiceLine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 50, DateTimeKind.Local).AddTicks(5472),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 936, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(8185),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 978, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(3727),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 978, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.AlterColumn<string>(
                name: "LoadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "ImportCustoms",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "ExportCustoms",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(4182),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 966, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 74, DateTimeKind.Local).AddTicks(2064),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 969, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5549),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 967, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5036),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 966, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.AddColumn<bool>(
                name: "PartiallyPayed",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 55, DateTimeKind.Local).AddTicks(9345),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 945, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(6817),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 946, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(129),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 945, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.AddColumn<bool>(
                name: "PartiallyPayed",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PurchaseSupplierNumber",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 15, DateTimeKind.Local).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 891, DateTimeKind.Local).AddTicks(9872));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartiallyPayed",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "PartiallyPayed",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "PurchaseSupplierNumber",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 936, DateTimeKind.Local).AddTicks(7763),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 50, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 978, DateTimeKind.Local).AddTicks(9195),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 978, DateTimeKind.Local).AddTicks(8493),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.AlterColumn<string>(
                name: "LoadAddress",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImportCustoms",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExportCustoms",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 966, DateTimeKind.Local).AddTicks(7457),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 969, DateTimeKind.Local).AddTicks(4552),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 74, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 967, DateTimeKind.Local).AddTicks(392),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 966, DateTimeKind.Local).AddTicks(9177),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 945, DateTimeKind.Local).AddTicks(3830),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 55, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 946, DateTimeKind.Local).AddTicks(7747),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 945, DateTimeKind.Local).AddTicks(8075),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 891, DateTimeKind.Local).AddTicks(9872),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 15, DateTimeKind.Local).AddTicks(8504));
        }
    }
}
