using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class PurchaseInvoiceAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 18, 1, 9, 7, 808, DateTimeKind.Local).AddTicks(5833),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 17, 23, 6, 53, 519, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 18, 1, 9, 7, 793, DateTimeKind.Local).AddTicks(5334),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 17, 23, 6, 53, 506, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceHeader",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceNo = table.Column<string>(nullable: true),
                    PostingDate = table.Column<DateTime>(nullable: false),
                    ExternalReferenceNo = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    TotalAmount = table.Column<float>(nullable: false),
                    Paid = table.Column<bool>(nullable: false),
                    Invoiced = table.Column<bool>(nullable: false),
                    CreditMemo = table.Column<bool>(nullable: false),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceHeader_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalSchema: "TransportDbNew",
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceHeader_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalSchema: "TransportDbNew",
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceLine",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<float>(nullable: false),
                    DiscountPercent = table.Column<float>(nullable: false),
                    LineAmount = table.Column<float>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    VatPercent = table.Column<float>(nullable: false),
                    PurchaseHeaderId = table.Column<int>(nullable: false),
                    HeaderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceLine_PurchaseInvoiceHeader_HeaderId",
                        column: x => x.HeaderId,
                        principalSchema: "TransportDbNew",
                        principalTable: "PurchaseInvoiceHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceHeader_CurrencyId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceHeader_VendorId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceLine_HeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                column: "HeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseInvoiceLine",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceHeader",
                schema: "TransportDbNew");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 17, 23, 6, 53, 519, DateTimeKind.Local).AddTicks(9782),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 18, 1, 9, 7, 808, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 17, 23, 6, 53, 506, DateTimeKind.Local).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 18, 1, 9, 7, 793, DateTimeKind.Local).AddTicks(5334));
        }
    }
}
