using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class RemoveDriverVechicleFKFromSales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesInvoiceHeader_Driver_DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesInvoiceHeader_Vehicle_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropIndex(
                name: "IX_SalesInvoiceHeader_DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropIndex(
                name: "IX_SalesInvoiceHeader_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 372, DateTimeKind.Local).AddTicks(5304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 865, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 399, DateTimeKind.Local).AddTicks(8181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 892, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 399, DateTimeKind.Local).AddTicks(6105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 892, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 392, DateTimeKind.Local).AddTicks(9523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(6298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 376, DateTimeKind.Local).AddTicks(5627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 868, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 377, DateTimeKind.Local).AddTicks(9138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 869, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 376, DateTimeKind.Local).AddTicks(8384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 868, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(5634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 899, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(6149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 899, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(4738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 898, DateTimeKind.Local).AddTicks(9837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 350, DateTimeKind.Local).AddTicks(9297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 842, DateTimeKind.Local).AddTicks(3358));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 865, DateTimeKind.Local).AddTicks(231),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 372, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 892, DateTimeKind.Local).AddTicks(7021),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 399, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 892, DateTimeKind.Local).AddTicks(4830),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 399, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 392, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(8966),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(3984),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 884, DateTimeKind.Local).AddTicks(3648),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 393, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 868, DateTimeKind.Local).AddTicks(8299),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 376, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 869, DateTimeKind.Local).AddTicks(3985),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 377, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 868, DateTimeKind.Local).AddTicks(8999),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 376, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 899, DateTimeKind.Local).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 899, DateTimeKind.Local).AddTicks(1529),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 898, DateTimeKind.Local).AddTicks(9837),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 406, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2019, 12, 20, 17, 24, 13, 842, DateTimeKind.Local).AddTicks(3358),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 12, 20, 17, 30, 29, 350, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesInvoiceHeader_Driver_DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "DriverId",
                principalSchema: "TransportDbNew",
                principalTable: "Driver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesInvoiceHeader_Vehicle_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "VehicleId",
                principalSchema: "TransportDbNew",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
