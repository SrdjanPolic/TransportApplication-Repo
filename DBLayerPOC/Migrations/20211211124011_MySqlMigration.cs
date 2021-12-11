using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class MySqlMigration : Migration
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(10) CHARACTER SET utf8mb4", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PhoneNo = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PaymentCurrency = table.Column<int>(type: "int", nullable: false),
                    VatNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsInactive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Note = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    PersonalIdNumber = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PersonalIdNummber = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PersonalIdExpDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 600, DateTimeKind.Local).AddTicks(6220)),
                    PassNumber = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PassExpDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 600, DateTimeKind.Local).AddTicks(7676)),
                    DriversLicenceNumber = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    DriversLicenceExpDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 600, DateTimeKind.Local).AddTicks(4162)),
                    Address = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Remark = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: false),
                    IsInactive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ObjectName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Prefix = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    LastUsedNumber = table.Column<int>(type: "int", nullable: false),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UploadDownload",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Discriminator = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Extension = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Filename = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    FilePath = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    GeneratedFileName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: true),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadDownload", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    IsInactive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RegistrationNumber = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    MaxWeight = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    ChassisNumber = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VechicleType = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    IsInactive = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Remark = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: false),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PhoneNo = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PaymentTermsCode = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PaymentCurrency = table.Column<int>(type: "int", nullable: false),
                    VatNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsInactive = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    LastChangeDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 542, DateTimeKind.Local).AddTicks(6631)),
                    Note = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExchangeRateAmount = table.Column<float>(type: "float", nullable: false, defaultValue: 1f),
                    StartingDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TravelOrder = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    InvoiceNo = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PostingDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 576, DateTimeKind.Local).AddTicks(2991)),
                    ExternalReferenceNo = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 576, DateTimeKind.Local).AddTicks(4489)),
                    SalesPerson = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 576, DateTimeKind.Local).AddTicks(5769)),
                    TotalAmount = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    TotalAmountLocal = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    Paid = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Invoiced = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    CreditMemo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 577, DateTimeKind.Local).AddTicks(8496)),
                    PartiallyPayed = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    CommodityType = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    NumberOfPallets = table.Column<double>(type: "double", nullable: false, defaultValue: 0.0),
                    NumberOfPalletsPlaces = table.Column<double>(type: "double", nullable: false, defaultValue: 0.0),
                    BruttoWeight = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    AdrNeeded = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Remarks = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    RouteDistance = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    LoadRepresentative = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    PricePerKm = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    CrmNumber = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    CheckIssueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 581, DateTimeKind.Local).AddTicks(933)),
                    ClienReceiptDocDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 581, DateTimeKind.Local).AddTicks(2041)),
                    TaxLawText = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 5000, nullable: true),
                    OwnTransport = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DriverName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    VechicleRegistration = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LoadDate = table.Column<DateTime>(type: "datetime(6)", nullable: true, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 580, DateTimeKind.Local).AddTicks(3613)),
                    UnloadDate = table.Column<DateTime>(type: "datetime(6)", nullable: true, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 580, DateTimeKind.Local).AddTicks(7071)),
                    LoadAddress = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    UnloadAddress = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    CalculatonExchangeRate = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SupplierInvoiceNo = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    InvoiceNo = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    PostingDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 550, DateTimeKind.Local).AddTicks(6025)),
                    ExternalReferenceNo = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 550, DateTimeKind.Local).AddTicks(7830)),
                    TotalAmount = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    TotalAmountLocal = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    Paid = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Invoiced = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    CreditMemo = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2021, 12, 11, 13, 40, 10, 551, DateTimeKind.Local).AddTicks(5768)),
                    PurchaseSupplierNumber = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: true),
                    PartiallyPayed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UnitPrice = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    DiscountPercent = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    LineAmount = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    Remark = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: false),
                    VatPercent = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    SalesHeaderId = table.Column<int>(type: "int", nullable: false),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TravelOrder = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UnitPrice = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    DiscountPercent = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    LineAmount = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    Remark = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "varchar(250) CHARACTER SET utf8mb4", maxLength: 250, nullable: false),
                    VatPercent = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    PurchaseHeaderId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: true),
                    LastChangeDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastChangeUserId = table.Column<int>(type: "int", nullable: true)
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
                name: "Driver",
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
                name: "UploadDownload",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "User",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "Vehicle",
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
