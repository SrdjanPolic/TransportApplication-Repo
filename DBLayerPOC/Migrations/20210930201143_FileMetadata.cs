using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class FileMetadata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 932, DateTimeKind.Local).AddTicks(6286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 488, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 964, DateTimeKind.Local).AddTicks(9978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 517, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 961, DateTimeKind.Local).AddTicks(5326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 515, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 962, DateTimeKind.Local).AddTicks(7689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 516, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 961, DateTimeKind.Local).AddTicks(7734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 515, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 964, DateTimeKind.Local).AddTicks(7714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 517, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 961, DateTimeKind.Local).AddTicks(6888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 515, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 965, DateTimeKind.Local).AddTicks(2883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 517, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 965, DateTimeKind.Local).AddTicks(2417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 517, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 942, DateTimeKind.Local).AddTicks(9408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 497, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 943, DateTimeKind.Local).AddTicks(5021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 498, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 943, DateTimeKind.Local).AddTicks(105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 497, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 982, DateTimeKind.Local).AddTicks(9661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 530, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 983, DateTimeKind.Local).AddTicks(991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 530, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 982, DateTimeKind.Local).AddTicks(7842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 530, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.CreateTable(
                name: "UploadDownload",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastChangeDateTime = table.Column<DateTime>(nullable: true),
                    LastChangeUserId = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Extension = table.Column<string>(nullable: false),
                    Filename = table.Column<string>(nullable: false),
                    FilePath = table.Column<string>(nullable: false),
                    GeneratedFileName = table.Column<string>(nullable: false),
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
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 488, DateTimeKind.Local).AddTicks(7948),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 932, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 517, DateTimeKind.Local).AddTicks(7521),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 964, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 515, DateTimeKind.Local).AddTicks(6863),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 961, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 516, DateTimeKind.Local).AddTicks(3057),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 962, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 515, DateTimeKind.Local).AddTicks(8034),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 961, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 517, DateTimeKind.Local).AddTicks(5997),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 964, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 515, DateTimeKind.Local).AddTicks(7633),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 961, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ClienReceiptDocDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 517, DateTimeKind.Local).AddTicks(9510),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 965, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CheckIssueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 517, DateTimeKind.Local).AddTicks(9142),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 965, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 497, DateTimeKind.Local).AddTicks(8210),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 942, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 498, DateTimeKind.Local).AddTicks(7266),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 943, DateTimeKind.Local).AddTicks(5021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 497, DateTimeKind.Local).AddTicks(8948),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 943, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 530, DateTimeKind.Local).AddTicks(931),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 982, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 530, DateTimeKind.Local).AddTicks(1540),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 983, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 9, 30, 21, 58, 23, 530, DateTimeKind.Local).AddTicks(7),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 9, 30, 22, 11, 42, 982, DateTimeKind.Local).AddTicks(7842));
        }
    }
}
