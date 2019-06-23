using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class SalesInvoiceMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuoteLine",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "QuoteHeader",
                schema: "TransportDbNew");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 936, DateTimeKind.Local).AddTicks(7763),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 642, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 945, DateTimeKind.Local).AddTicks(3830),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 649, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 946, DateTimeKind.Local).AddTicks(7747),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 650, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 945, DateTimeKind.Local).AddTicks(8075),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 649, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 891, DateTimeKind.Local).AddTicks(9872),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 629, DateTimeKind.Local).AddTicks(5110));

            migrationBuilder.CreateTable(
                name: "SalesInvoiceHeader",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceNo = table.Column<string>(maxLength: 50, nullable: false),
                    PostingDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 966, DateTimeKind.Local).AddTicks(7457)),
                    ExternalReferenceNo = table.Column<string>(maxLength: 50, nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 966, DateTimeKind.Local).AddTicks(9177)),
                    SalesPerson = table.Column<string>(maxLength: 250, nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 967, DateTimeKind.Local).AddTicks(392)),
                    TotalAmount = table.Column<float>(nullable: false, defaultValue: 0f),
                    TotalAmountLocal = table.Column<float>(nullable: false, defaultValue: 0f),
                    Paid = table.Column<bool>(nullable: false, defaultValue: false),
                    Invoiced = table.Column<bool>(nullable: false, defaultValue: false),
                    CreditMemo = table.Column<bool>(nullable: false, defaultValue: false),
                    PaymentDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 969, DateTimeKind.Local).AddTicks(4552)),
                    CommodityType = table.Column<string>(maxLength: 250, nullable: true),
                    NumberOfPallets = table.Column<double>(nullable: false, defaultValue: 0.0),
                    NumberOfPalletsPlaces = table.Column<double>(nullable: false, defaultValue: 0.0),
                    BruttoWeight = table.Column<float>(nullable: false, defaultValue: 0f),
                    AdrNeeded = table.Column<bool>(nullable: false, defaultValue: false),
                    Remarks = table.Column<string>(maxLength: 50, nullable: true),
                    VechicleRegNumber = table.Column<string>(maxLength: 50, nullable: true),
                    DriverName = table.Column<string>(maxLength: 50, nullable: true),
                    RouteDistance = table.Column<float>(nullable: false, defaultValue: 0f),
                    LoadRepresentative = table.Column<string>(maxLength: 250, nullable: true),
                    PricePerKm = table.Column<float>(nullable: false, defaultValue: 0f),
                    CrmNumber = table.Column<string>(maxLength: 50, nullable: true),
                    CurrencyId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalSchema: "TransportDbNew",
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceHeader_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "TransportDbNew",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceLine",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoadDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 978, DateTimeKind.Local).AddTicks(8493)),
                    UnloadDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 978, DateTimeKind.Local).AddTicks(9195)),
                    LoadAddress = table.Column<string>(maxLength: 250, nullable: false),
                    UnloadAddress = table.Column<string>(nullable: true),
                    ExportCustoms = table.Column<string>(maxLength: 250, nullable: false),
                    ImportCustoms = table.Column<string>(maxLength: 250, nullable: false),
                    Quantity = table.Column<int>(nullable: false, defaultValue: 0),
                    UnitPrice = table.Column<float>(nullable: false, defaultValue: 0f),
                    DiscountPercent = table.Column<float>(nullable: false, defaultValue: 0f),
                    LineAmount = table.Column<float>(nullable: false, defaultValue: 0f),
                    Remark = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    VatPercent = table.Column<float>(nullable: false, defaultValue: 0f),
                    SalesHeaderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceLine_SalesInvoiceHeader_SalesHeaderId",
                        column: x => x.SalesHeaderId,
                        principalSchema: "TransportDbNew",
                        principalTable: "SalesInvoiceHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_CurrencyId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceHeader_CustomerId",
                schema: "TransportDbNew",
                table: "SalesInvoiceHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceLine_SalesHeaderId",
                schema: "TransportDbNew",
                table: "SalesInvoiceLine",
                column: "SalesHeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesInvoiceLine",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "SalesInvoiceHeader",
                schema: "TransportDbNew");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 642, DateTimeKind.Local).AddTicks(9057),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 936, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PostingDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 649, DateTimeKind.Local).AddTicks(4343),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 945, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 650, DateTimeKind.Local).AddTicks(2180),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 946, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceHeader",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 649, DateTimeKind.Local).AddTicks(5325),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 945, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 6, 20, 21, 41, 35, 629, DateTimeKind.Local).AddTicks(5110),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 6, 23, 23, 33, 32, 891, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.CreateTable(
                name: "QuoteHeader",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrencyCode = table.Column<string>(maxLength: 10, nullable: true),
                    CurrencyExchangeRate = table.Column<float>(nullable: false, defaultValue: 1f),
                    CustomerId = table.Column<int>(nullable: false),
                    Header = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteHeader", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuoteHeader_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "TransportDbNew",
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuoteLine",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    From = table.Column<string>(maxLength: 256, nullable: false),
                    QuoteHeaderId = table.Column<int>(nullable: false),
                    To = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuoteLine_QuoteHeader_QuoteHeaderId",
                        column: x => x.QuoteHeaderId,
                        principalSchema: "TransportDbNew",
                        principalTable: "QuoteHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuoteHeader_CustomerId",
                schema: "TransportDbNew",
                table: "QuoteHeader",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_QuoteLine_QuoteHeaderId",
                schema: "TransportDbNew",
                table: "QuoteLine",
                column: "QuoteHeaderId");
        }
    }
}
