using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class PaymentCurrencyCustomerVEndor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VatGroup",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "VatGroup",
                schema: "TransportDbNew",
                table: "Customer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 883, DateTimeKind.Local).AddTicks(7096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 624, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.AddColumn<int>(
                name: "PaymentCurrency",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(5304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(5372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 910, DateTimeKind.Local).AddTicks(1747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(6505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(3808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(6071),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(7590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(7227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 892, DateTimeKind.Local).AddTicks(9812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 634, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 893, DateTimeKind.Local).AddTicks(5349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 635, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 893, DateTimeKind.Local).AddTicks(635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 634, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(2588),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 675, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(3118),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 675, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(1603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 674, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.AddColumn<int>(
                name: "PaymentCurrency",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentCurrency",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "PaymentCurrency",
                schema: "TransportDbNew",
                table: "Customer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 624, DateTimeKind.Local).AddTicks(3339),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 883, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.AddColumn<int>(
                name: "VatGroup",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(2058),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(736),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(7466),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 910, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(1871),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(477),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 658, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 909, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(4102),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 660, DateTimeKind.Local).AddTicks(3736),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 911, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 634, DateTimeKind.Local).AddTicks(3832),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 892, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 635, DateTimeKind.Local).AddTicks(2354),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 893, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 634, DateTimeKind.Local).AddTicks(4791),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 893, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 675, DateTimeKind.Local).AddTicks(642),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 675, DateTimeKind.Local).AddTicks(1191),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 22, 38, 47, 674, DateTimeKind.Local).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 18, 23, 2, 25, 923, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.AddColumn<int>(
                name: "VatGroup",
                schema: "TransportDbNew",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
