using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class DriverVehicleTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverName",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropColumn(
                name: "VechicleRegNumber",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 902, DateTimeKind.Local).AddTicks(9592),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 50, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(7709),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(2914),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 928, DateTimeKind.Local).AddTicks(3123),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 74, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5643),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5097),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(535),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 55, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(8405),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(1455),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 865, DateTimeKind.Local).AddTicks(5863),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 15, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.CreateTable(
                name: "Driver",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PersonalIdNummber = table.Column<string>(maxLength: 50, nullable: false),
                    PersonalIdExpDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(2680)),
                    PassNumber = table.Column<string>(maxLength: 50, nullable: false),
                    PassExpDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(3411)),
                    DriversLicenceNumber = table.Column<string>(maxLength: 50, nullable: false),
                    DriversLicenceExpDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 946, DateTimeKind.Local).AddTicks(1399)),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Remark = table.Column<string>(maxLength: 250, nullable: false)
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
                    VechicleType = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesInvoiceHeader_Driver_DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesInvoiceHeader_Vehicle_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader");

            migrationBuilder.DropTable(
                name: "Driver",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "Vehicle",
                schema: "TransportDbNew");

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
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 50, DateTimeKind.Local).AddTicks(5472),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 902, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(8185),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(3727),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 937, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(4182),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 74, DateTimeKind.Local).AddTicks(2064),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 928, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5549),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5036),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 927, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VechicleRegNumber",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 55, DateTimeKind.Local).AddTicks(9345),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(6817),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(129),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 909, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 15, DateTimeKind.Local).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 9, 23, 2, 12, 865, DateTimeKind.Local).AddTicks(5863));
        }
    }
}
