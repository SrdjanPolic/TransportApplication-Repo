using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class FilePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 560, DateTimeKind.Local).AddTicks(9846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 719, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                schema: "TransportDbNew",
                table: "UploadDownload",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 589, DateTimeKind.Local).AddTicks(4910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 587, DateTimeKind.Local).AddTicks(3202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 588, DateTimeKind.Local).AddTicks(151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 767, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 587, DateTimeKind.Local).AddTicks(4603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 589, DateTimeKind.Local).AddTicks(3300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 587, DateTimeKind.Local).AddTicks(4074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 589, DateTimeKind.Local).AddTicks(7143),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 589, DateTimeKind.Local).AddTicks(6674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 570, DateTimeKind.Local).AddTicks(2210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 734, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 570, DateTimeKind.Local).AddTicks(8429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 735, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 570, DateTimeKind.Local).AddTicks(3091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 734, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 601, DateTimeKind.Local).AddTicks(3973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 601, DateTimeKind.Local).AddTicks(4597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 601, DateTimeKind.Local).AddTicks(2856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(4141));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                schema: "TransportDbNew",
                table: "UploadDownload");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 719, DateTimeKind.Local).AddTicks(6126),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 560, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(4150),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 589, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(1321),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 587, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 767, DateTimeKind.Local).AddTicks(2242),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 588, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(3516),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 587, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(1727),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 589, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(2752),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 587, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(6729),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 589, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(6273),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 589, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 734, DateTimeKind.Local).AddTicks(6628),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 570, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 735, DateTimeKind.Local).AddTicks(7425),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 570, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 734, DateTimeKind.Local).AddTicks(8026),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 570, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(6121),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 601, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(7237),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 601, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(4141),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 29, 21, 51, 56, 601, DateTimeKind.Local).AddTicks(2856));
        }
    }
}
