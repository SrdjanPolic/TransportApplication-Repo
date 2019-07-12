using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class DriverVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 672, DateTimeKind.Local).AddTicks(7341),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 163, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 728, DateTimeKind.Local).AddTicks(7252),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 203, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 728, DateTimeKind.Local).AddTicks(1340),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 202, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(4664),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 717, DateTimeKind.Local).AddTicks(8885),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(8536),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(7263),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 683, DateTimeKind.Local).AddTicks(7527),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 169, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 685, DateTimeKind.Local).AddTicks(1009),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 170, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 684, DateTimeKind.Local).AddTicks(27),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 169, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 624, DateTimeKind.Local).AddTicks(8168),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 124, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.CreateTable(
                name: "Driver",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PersonalIdNummber = table.Column<string>(maxLength: 50, nullable: false),
                    PersonalIdExpDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 740, DateTimeKind.Local).AddTicks(8111)),
                    PassNumber = table.Column<string>(maxLength: 50, nullable: false),
                    PassExpDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 740, DateTimeKind.Local).AddTicks(8916)),
                    DriversLicenceNumber = table.Column<string>(maxLength: 50, nullable: false),
                    DriversLicenceExpDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 740, DateTimeKind.Local).AddTicks(6728)),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Remark = table.Column<string>(maxLength: 250, nullable: false),
                    IsInactive = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RegistrationNumber = table.Column<string>(maxLength: 50, nullable: false),
                    MaxWeight = table.Column<float>(nullable: false, defaultValue: 0f),
                    ChassisNumber = table.Column<string>(maxLength: 50, nullable: false),
                    FuelType = table.Column<string>(maxLength: 50, nullable: false),
                    VechicleType = table.Column<string>(maxLength: 50, nullable: false),
                    IsInactive = table.Column<bool>(nullable: false, defaultValue: false),
                    Remark = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "Vehicle",
                schema: "TransportDbNew");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 163, DateTimeKind.Local).AddTicks(2836),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 672, DateTimeKind.Local).AddTicks(7341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 203, DateTimeKind.Local).AddTicks(3818),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 728, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 202, DateTimeKind.Local).AddTicks(9471),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 728, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(94),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(8814),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 717, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(2283),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(1609),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 716, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 169, DateTimeKind.Local).AddTicks(1364),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 683, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 170, DateTimeKind.Local).AddTicks(380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 685, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 169, DateTimeKind.Local).AddTicks(2970),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 684, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 124, DateTimeKind.Local).AddTicks(5354),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 23, 50, 6, 624, DateTimeKind.Local).AddTicks(8168));
        }
    }
}
