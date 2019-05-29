using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class PurchaseInvoiceCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceLine_PurchaseInvoiceHeader_HeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseInvoiceLine_HeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.DropColumn(
                name: "HeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 542, DateTimeKind.Local).AddTicks(4119),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 25, 21, 30, 39, 657, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.AlterColumn<float>(
                name: "VatPercent",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<float>(
                name: "UnitPrice",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<float>(
                name: "LineAmount",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<float>(
                name: "DiscountPercent",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "TotalAmount",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 553, DateTimeKind.Local).AddTicks(7478),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 555, DateTimeKind.Local).AddTicks(455),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "Paid",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "Invoiced",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNo",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExternalReferenceNo",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 553, DateTimeKind.Local).AddTicks(9744),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "CreditMemo",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 522, DateTimeKind.Local).AddTicks(258),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 25, 21, 30, 39, 640, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceLine_PurchaseHeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                column: "PurchaseHeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceLine_PurchaseInvoiceHeader_PurchaseHeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                column: "PurchaseHeaderId",
                principalSchema: "TransportDbNew",
                principalTable: "PurchaseInvoiceHeader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseInvoiceLine_PurchaseInvoiceHeader_PurchaseHeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseInvoiceLine_PurchaseHeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 25, 21, 30, 39, 657, DateTimeKind.Local).AddTicks(818),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 542, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.AlterColumn<float>(
                name: "VatPercent",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                oldClrType: typeof(float),
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<float>(
                name: "UnitPrice",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                oldClrType: typeof(float),
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<float>(
                name: "LineAmount",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                oldClrType: typeof(float),
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<float>(
                name: "DiscountPercent",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: false,
                oldClrType: typeof(float),
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AddColumn<int>(
                name: "HeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                nullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "TotalAmount",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                oldClrType: typeof(float),
                oldDefaultValue: 0f);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 553, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 555, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.AlterColumn<bool>(
                name: "Paid",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "Invoiced",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNo",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ExternalReferenceNo",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 553, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.AlterColumn<bool>(
                name: "CreditMemo",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 25, 21, 30, 39, 640, DateTimeKind.Local).AddTicks(4743),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 29, 23, 1, 58, 522, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceLine_HeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                column: "HeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseInvoiceLine_PurchaseInvoiceHeader_HeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                column: "HeaderId",
                principalSchema: "TransportDbNew",
                principalTable: "PurchaseInvoiceHeader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
