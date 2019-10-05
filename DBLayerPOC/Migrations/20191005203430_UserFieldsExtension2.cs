using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class UserFieldsExtension2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 939, DateTimeKind.Local).AddTicks(1042),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 226, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                schema: "TransportDbNew",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 971, DateTimeKind.Local).AddTicks(876),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 261, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 970, DateTimeKind.Local).AddTicks(7059),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 261, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 961, DateTimeKind.Local).AddTicks(9874),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 249, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(7456),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 250, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(1212),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 250, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(659),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 249, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(843),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 231, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(8349),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 232, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(1668),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 231, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(5374),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(6207),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(4157),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 904, DateTimeKind.Local).AddTicks(3411),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 193, DateTimeKind.Local).AddTicks(9816));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                schema: "TransportDbNew",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 226, DateTimeKind.Local).AddTicks(8526),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 939, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 261, DateTimeKind.Local).AddTicks(5864),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 971, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 261, DateTimeKind.Local).AddTicks(232),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 970, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 249, DateTimeKind.Local).AddTicks(8730),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 961, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 250, DateTimeKind.Local).AddTicks(6611),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 250, DateTimeKind.Local).AddTicks(180),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 249, DateTimeKind.Local).AddTicks(9633),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 962, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 231, DateTimeKind.Local).AddTicks(8314),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 232, DateTimeKind.Local).AddTicks(5793),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 231, DateTimeKind.Local).AddTicks(9188),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 944, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(8731),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(9497),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(7710),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 980, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 193, DateTimeKind.Local).AddTicks(9816),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 10, 5, 22, 34, 29, 904, DateTimeKind.Local).AddTicks(3411));
        }
    }
}
