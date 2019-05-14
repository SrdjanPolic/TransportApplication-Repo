using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class InitalMigrationWithOneDbContext : Migration
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
                    VatNumber = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    LastChangeDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 5, 13, 23, 45, 12, 415, DateTimeKind.Local).AddTicks(9847))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
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
                name: "QuoteHeader",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Header = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    CurrencyCode = table.Column<string>(maxLength: 10, nullable: true),
                    CurrencyExchangeRate = table.Column<float>(nullable: false, defaultValue: 1f)
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
                    To = table.Column<string>(maxLength: 256, nullable: false),
                    QuoteHeaderId = table.Column<int>(nullable: false)
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
                name: "IX_CurrencyExchangeRate_CurrencyId",
                schema: "TransportDbNew",
                table: "CurrencyExchangeRate",
                column: "CurrencyId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrencyExchangeRate",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "QuoteLine",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "Currency",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "QuoteHeader",
                schema: "TransportDbNew");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "TransportDbNew");
        }
    }
}
