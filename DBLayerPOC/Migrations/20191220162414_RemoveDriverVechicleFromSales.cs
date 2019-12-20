using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class RemoveDriverVechicleFromSales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 865, DateTimeKind.Local).AddTicks(231),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 939, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 892, DateTimeKind.Local).AddTicks(7021),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 971, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 892, DateTimeKind.Local).AddTicks(4830),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 970, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 961, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(8966),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(3984),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(3648),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VechicleRegistration",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 868, DateTimeKind.Local).AddTicks(8299),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 869, DateTimeKind.Local).AddTicks(3985),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 868, DateTimeKind.Local).AddTicks(8999),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 899, DateTimeKind.Local).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 899, DateTimeKind.Local).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 898, DateTimeKind.Local).AddTicks(9837),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 842, DateTimeKind.Local).AddTicks(3358),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 904, DateTimeKind.Local).AddTicks(3411));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverName",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "VechicleRegistration",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 939, DateTimeKind.Local).AddTicks(1042),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 865, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 971, DateTimeKind.Local).AddTicks(876),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 892, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 970, DateTimeKind.Local).AddTicks(7059),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 892, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.AlterColumn<int>(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 961, DateTimeKind.Local).AddTicks(9874),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(7456),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(1212),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(659),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(843),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 868, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(8349),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 869, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(1668),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 868, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(5374),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 899, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(6207),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 899, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(4157),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 898, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 904, DateTimeKind.Local).AddTicks(3411),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 842, DateTimeKind.Local).AddTicks(3358));
        }
    }
}
