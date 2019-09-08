using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class UserFieldsExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 226, DateTimeKind.Local).AddTicks(8526),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 636, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.AddColumn<bool>(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "User",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "TransportDbNew",
                table: "User",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 261, DateTimeKind.Local).AddTicks(5864),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 670, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 261, DateTimeKind.Local).AddTicks(232),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 670, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 249, DateTimeKind.Local).AddTicks(8730),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 250, DateTimeKind.Local).AddTicks(6611),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 661, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 250, DateTimeKind.Local).AddTicks(180),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 249, DateTimeKind.Local).AddTicks(9633),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 231, DateTimeKind.Local).AddTicks(8314),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 641, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 232, DateTimeKind.Local).AddTicks(5793),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 642, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 231, DateTimeKind.Local).AddTicks(9188),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 641, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(8731),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(9497),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(7710),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 193, DateTimeKind.Local).AddTicks(9816),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 600, DateTimeKind.Local).AddTicks(2927));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "TransportDbNew",
                table: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 636, DateTimeKind.Local).AddTicks(2583),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 226, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 670, DateTimeKind.Local).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 261, DateTimeKind.Local).AddTicks(5864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 670, DateTimeKind.Local).AddTicks(747),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 261, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(7486),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 249, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 661, DateTimeKind.Local).AddTicks(5101),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 250, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(8860),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 250, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(8351),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 249, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 641, DateTimeKind.Local).AddTicks(5964),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 231, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 642, DateTimeKind.Local).AddTicks(3710),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 232, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 641, DateTimeKind.Local).AddTicks(6781),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 231, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(6235),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(7030),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(5230),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 270, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 600, DateTimeKind.Local).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 6, 22, 47, 45, 193, DateTimeKind.Local).AddTicks(9816));
        }
    }
}
