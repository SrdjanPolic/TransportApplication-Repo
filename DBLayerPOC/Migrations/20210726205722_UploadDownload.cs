using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class UploadDownload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 719, DateTimeKind.Local).AddTicks(6126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 871, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(4150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 912, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(1321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 903, DateTimeKind.Local).AddTicks(1400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 767, DateTimeKind.Local).AddTicks(2242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 909, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(3516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 907, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(1727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 912, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(2752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 907, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(6729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 912, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(6273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 912, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 734, DateTimeKind.Local).AddTicks(6628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 883, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 735, DateTimeKind.Local).AddTicks(7425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 884, DateTimeKind.Local).AddTicks(1502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 734, DateTimeKind.Local).AddTicks(8026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 883, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(6121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 930, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(7237),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 931, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(4141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 930, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.CreateTable(
                name: "UploadDownload",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangeDateTime = table.Column<DateTime>(nullable: true),
                    LastChangeUserId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(maxLength: 50, nullable: false),
                    Extension = table.Column<string>(maxLength: 50, nullable: false),
                    Filename = table.Column<string>(maxLength: 50, nullable: false),
                    GeneratedFileName = table.Column<string>(maxLength: 50, nullable: false),
                    DocumentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadDownload", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UploadDownload",
                schema: "TransportDbNew");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 871, DateTimeKind.Local).AddTicks(9108),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 719, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 912, DateTimeKind.Local).AddTicks(4548),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 903, DateTimeKind.Local).AddTicks(1400),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 909, DateTimeKind.Local).AddTicks(6011),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 767, DateTimeKind.Local).AddTicks(2242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 907, DateTimeKind.Local).AddTicks(2757),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 912, DateTimeKind.Local).AddTicks(1134),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 907, DateTimeKind.Local).AddTicks(1717),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 766, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 912, DateTimeKind.Local).AddTicks(8248),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 912, DateTimeKind.Local).AddTicks(7559),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 769, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 883, DateTimeKind.Local).AddTicks(3578),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 734, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 884, DateTimeKind.Local).AddTicks(1502),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 735, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 883, DateTimeKind.Local).AddTicks(4340),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 734, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 930, DateTimeKind.Local).AddTicks(9685),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 931, DateTimeKind.Local).AddTicks(511),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 26, 22, 13, 18, 930, DateTimeKind.Local).AddTicks(8385),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 26, 22, 57, 21, 790, DateTimeKind.Local).AddTicks(4141));
        }
    }
}
