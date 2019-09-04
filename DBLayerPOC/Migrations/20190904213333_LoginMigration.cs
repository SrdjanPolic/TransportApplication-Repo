using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class LoginMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 636, DateTimeKind.Local).AddTicks(2583),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 428, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 670, DateTimeKind.Local).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 490, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 670, DateTimeKind.Local).AddTicks(747),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 489, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(7486),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 475, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 661, DateTimeKind.Local).AddTicks(5101),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 477, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(8860),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 476, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(8351),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 476, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 641, DateTimeKind.Local).AddTicks(5964),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 438, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 642, DateTimeKind.Local).AddTicks(3710),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 443, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 641, DateTimeKind.Local).AddTicks(6781),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 438, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(6235),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(7030),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(5230),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 600, DateTimeKind.Local).AddTicks(2927),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 367, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.CreateTable(
                name: "User",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 50, nullable: true),
                    Password = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User",
                schema: "TransportDbNew");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 428, DateTimeKind.Local).AddTicks(9745),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 636, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 490, DateTimeKind.Local).AddTicks(7688),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 670, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 489, DateTimeKind.Local).AddTicks(3931),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 670, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 475, DateTimeKind.Local).AddTicks(1929),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 477, DateTimeKind.Local).AddTicks(1930),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 661, DateTimeKind.Local).AddTicks(5101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 476, DateTimeKind.Local).AddTicks(2697),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 476, DateTimeKind.Local).AddTicks(2036),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 660, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 438, DateTimeKind.Local).AddTicks(361),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 641, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 443, DateTimeKind.Local).AddTicks(4115),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 642, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 438, DateTimeKind.Local).AddTicks(1863),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 641, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PersonalIdExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(5490),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PassExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(7596),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DriversLicenceExpDate",
                schema: "TransportDbNew",
                table: "Driver",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 505, DateTimeKind.Local).AddTicks(2321),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 679, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 14, 16, 1, 25, 367, DateTimeKind.Local).AddTicks(7007),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 9, 4, 23, 33, 32, 600, DateTimeKind.Local).AddTicks(2927));
        }
    }
}
