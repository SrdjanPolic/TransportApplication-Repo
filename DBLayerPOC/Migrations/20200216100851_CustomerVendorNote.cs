using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class CustomerVendorNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 188, DateTimeKind.Local).AddTicks(4091),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 883, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                schema: "TransportDbNew",
                table: "Vendor",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 216, DateTimeKind.Local).AddTicks(3656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 214, DateTimeKind.Local).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 215, DateTimeKind.Local).AddTicks(282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 910, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 214, DateTimeKind.Local).AddTicks(5300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 216, DateTimeKind.Local).AddTicks(2195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 214, DateTimeKind.Local).AddTicks(4856),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 216, DateTimeKind.Local).AddTicks(5569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 216, DateTimeKind.Local).AddTicks(5227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 197, DateTimeKind.Local).AddTicks(5296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 892, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 198, DateTimeKind.Local).AddTicks(1062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 893, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 197, DateTimeKind.Local).AddTicks(6033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 893, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 227, DateTimeKind.Local).AddTicks(2248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 227, DateTimeKind.Local).AddTicks(2772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 227, DateTimeKind.Local).AddTicks(1277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                schema: "TransportDbNew",
                table: "Customer",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "Note",
                schema: "TransportDbNew",
                table: "Customer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 883, DateTimeKind.Local).AddTicks(7096),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 188, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(5304),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 216, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(5372),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 214, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 910, DateTimeKind.Local).AddTicks(1747),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 215, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(6505),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 214, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(3808),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 216, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(6071),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 214, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(7590),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 216, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(7227),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 216, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 892, DateTimeKind.Local).AddTicks(9812),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 197, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 893, DateTimeKind.Local).AddTicks(5349),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 198, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 893, DateTimeKind.Local).AddTicks(635),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 197, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(2588),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 227, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(3118),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 227, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(1603),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 2, 16, 11, 8, 51, 227, DateTimeKind.Local).AddTicks(1277));
        }
    }
}
