using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class DriverVehicleTablesAndColumnsAdded : Migration
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
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 409, DateTimeKind.Local).AddTicks(4842),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 50, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 448, DateTimeKind.Local).AddTicks(451),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 447, DateTimeKind.Local).AddTicks(4654),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 437, DateTimeKind.Local).AddTicks(159),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 437, DateTimeKind.Local).AddTicks(9978),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 74, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 437, DateTimeKind.Local).AddTicks(1678),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 437, DateTimeKind.Local).AddTicks(1103),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 415, DateTimeKind.Local).AddTicks(5235),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 55, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 416, DateTimeKind.Local).AddTicks(3626),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 415, DateTimeKind.Local).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 364, DateTimeKind.Local).AddTicks(195),
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
                    PersonalIdExpDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 457, DateTimeKind.Local).AddTicks(8687)),
                    PassNumber = table.Column<string>(maxLength: 50, nullable: false),
                    PassExpDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 457, DateTimeKind.Local).AddTicks(9426)),
                    DriversLicenceNumber = table.Column<string>(maxLength: 50, nullable: false),
                    DriversLicenceExpDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 457, DateTimeKind.Local).AddTicks(7427)),
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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesInvoiceHeader_Vehicle_VehicleId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "VehicleId",
                principalSchema: "TransportDbNew",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.DropColumn(
                name: "VehicleId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 50, DateTimeKind.Local).AddTicks(5472),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 409, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UnloadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(8185),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 448, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoadDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                nullable: true,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 83, DateTimeKind.Local).AddTicks(3727),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 447, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(4182),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 437, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 74, DateTimeKind.Local).AddTicks(2064),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 437, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5549),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 437, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 73, DateTimeKind.Local).AddTicks(5036),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 437, DateTimeKind.Local).AddTicks(1103));

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
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 415, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(6817),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 416, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 56, DateTimeKind.Local).AddTicks(129),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 415, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 7, 7, 22, 58, 13, 15, DateTimeKind.Local).AddTicks(8504),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 7, 12, 22, 37, 27, 364, DateTimeKind.Local).AddTicks(195));
        }
    }
}
