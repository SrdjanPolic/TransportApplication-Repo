using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class PurchaceInvoiceHeaderTotalAmountLocalAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 806, DateTimeKind.Local).AddTicks(7699),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 542, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 553, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 813, DateTimeKind.Local).AddTicks(3338),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 555, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(6063),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 553, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.AddColumn<float>(
                name: "TotalAmountLocal",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 792, DateTimeKind.Local).AddTicks(1231),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 522, DateTimeKind.Local).AddTicks(258));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmountLocal",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 542, DateTimeKind.Local).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 806, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 553, DateTimeKind.Local).AddTicks(7478),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 555, DateTimeKind.Local).AddTicks(455),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 813, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 553, DateTimeKind.Local).AddTicks(9744),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 812, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 522, DateTimeKind.Local).AddTicks(258),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 16, 0, 8, 25, 792, DateTimeKind.Local).AddTicks(1231));
        }
    }
}
