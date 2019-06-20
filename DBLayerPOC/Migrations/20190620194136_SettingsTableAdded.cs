using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class SettingsTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 642, DateTimeKind.Local).AddTicks(9057),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 806, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 649, DateTimeKind.Local).AddTicks(4343),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 650, DateTimeKind.Local).AddTicks(2180),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 813, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 649, DateTimeKind.Local).AddTicks(5325),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 629, DateTimeKind.Local).AddTicks(5110),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 792, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.CreateTable(
                name: "Settings",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ObjectName = table.Column<string>(nullable: false),
                    Prefix = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    LastUsedNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings",
                schema: "TransportDbNew");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 806, DateTimeKind.Local).AddTicks(7699),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 642, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 649, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 813, DateTimeKind.Local).AddTicks(3338),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 650, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(6063),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 649, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 792, DateTimeKind.Local).AddTicks(1231),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 629, DateTimeKind.Local).AddTicks(5110));
        }
    }
}
