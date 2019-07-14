using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class EverythingBeforeVechicleAndDriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TransportDbNew");

            migrationBuilder.CreateTable(
                name: "Currency",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNo = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    VatGroup = table.Column<int>(nullable: false),
                    VatNumber = table.Column<string>(nullable: true),
                    IsInactive = table.Column<bool>(nullable: false, defaultValue: false),
                    LastChangeDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 124, DateTimeKind.Local).AddTicks(5354))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Vendor",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNo = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PaymentTermsCode = table.Column<string>(maxLength: 50, nullable: false),
                    VatGroup = table.Column<int>(nullable: false),
                    VatNumber = table.Column<string>(nullable: true),
                    IsInactive = table.Column<bool>(nullable: true, defaultValue: false),
                    LastChangeDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 163, DateTimeKind.Local).AddTicks(2836))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyExchangeRate",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExchangeRateAmount = table.Column<float>(nullable: false, defaultValue: 1f),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyExchangeRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrencyExchangeRate_Currency_CurrencyId",
                        column: x => x.CurrencyId,
                        principalSchema: "TransportDbNew",
                        principalTable: "Currency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceHeader",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceNo = table.Column<string>(maxLength: 50, nullable: false),
                    PostingDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(94)),
                    ExternalReferenceNo = table.Column<string>(maxLength: 50, nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(1609)),
                    SalesPerson = table.Column<string>(maxLength: 250, nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(2283)),
                    TotalAmount = table.Column<float>(nullable: false, defaultValue: 0f),
                    TotalAmountLocal = table.Column<float>(nullable: false, defaultValue: 0f),
                    Paid = table.Column<bool>(nullable: false, defaultValue: false),
                    Invoiced = table.Column<bool>(nullable: false, defaultValue: false),
                    CreditMemo = table.Column<bool>(nullable: false, defaultValue: false),
                    PaymentDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 192, DateTimeKind.Local).AddTicks(8814)),
                    PartiallyPayed = table.Column<bool>(nullable: false, defaultValue: false),
                    CommodityType = table.Column<string>(maxLength: 250, nullable: true),
                    NumberOfPallets = table.Column<double>(nullable: false, defaultValue: 0.0),
                    NumberOfPalletsPlaces = table.Column<double>(nullable: false, defaultValue: 0.0),
                    BruttoWeight = table.Column<float>(nullable: false, defaultValue: 0f),
                    AdrNeeded = table.Column<bool>(nullable: false, defaultValue: false),
                    Remarks = table.Column<string>(maxLength: 50, nullable: true),
                    RouteDistance = table.Column<float>(nullable: false, defaultValue: 0f),
                    LoadRepresentative = table.Column<string>(maxLength: 250, nullable: true),
                    PricePerKm = table.Column<float>(nullable: false, defaultValue: 0f),
                    CrmNumber = table.Column<string>(maxLength: 50, nullable: true),
                    CurrencyId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: false)
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
                name: "PurchaseInvoiceHeader",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceNo = table.Column<string>(maxLength: 50, nullable: false),
                    PostingDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 169, DateTimeKind.Local).AddTicks(1364)),
                    ExternalReferenceNo = table.Column<string>(maxLength: 50, nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 169, DateTimeKind.Local).AddTicks(2970)),
                    TotalAmount = table.Column<float>(nullable: false, defaultValue: 0f),
                    TotalAmountLocal = table.Column<float>(nullable: false, defaultValue: 0f),
                    Paid = table.Column<bool>(nullable: false, defaultValue: false),
                    Invoiced = table.Column<bool>(nullable: false, defaultValue: false),
                    CreditMemo = table.Column<bool>(nullable: false, defaultValue: false),
                    PaymentDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 170, DateTimeKind.Local).AddTicks(380)),
                    PurchaseSupplierNumber = table.Column<string>(maxLength: 50, nullable: true),
                    PartiallyPayed = table.Column<bool>(nullable: false, defaultValue: false),
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
                name: "SalesInvoiceLine",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LoadDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 202, DateTimeKind.Local).AddTicks(9471)),
                    UnloadDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2019, 7, 12, 23, 47, 56, 203, DateTimeKind.Local).AddTicks(3818)),
                    LoadAddress = table.Column<string>(maxLength: 250, nullable: true),
                    UnloadAddress = table.Column<string>(nullable: true),
                    ExportCustoms = table.Column<string>(maxLength: 250, nullable: true),
                    ImportCustoms = table.Column<string>(maxLength: 250, nullable: true),
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

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceLine",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false, defaultValue: 0),
                    UnitPrice = table.Column<float>(nullable: false, defaultValue: 0f),
                    DiscountPercent = table.Column<float>(nullable: false, defaultValue: 0f),
                    LineAmount = table.Column<float>(nullable: false, defaultValue: 0f),
                    Remark = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    VatPercent = table.Column<float>(nullable: false, defaultValue: 0f),
                    PurchaseHeaderId = table.Column<int>(nullable: false),
                    VehicleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceLine_PurchaseInvoiceHeader_PurchaseHeaderId",
                        column: x => x.PurchaseHeaderId,
                        principalSchema: "TransportDbNew",
                        principalTable: "PurchaseInvoiceHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrencyExchangeRate_CurrencyId",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate",
                column: "CurrencyId");

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
                name: "IX_PurchaseInvoiceLine_PurchaseHeaderId",
                schema: "TransportDbNew",
                table: "PurchaseInvoiceLine",
                column: "PurchaseHeaderId");

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
                name: "CurrencyExchangeRate",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceLine",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "SalesInvoiceLine",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "Settings",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceHeader",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "SalesInvoiceHeader",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "Vendor",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "TransportDbNew");
        }
    }
}
