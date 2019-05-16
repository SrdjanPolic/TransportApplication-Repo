using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class VendorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 16, 22, 43, 36, 695, DateTimeKind.Local).AddTicks(3187),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 14, 22, 49, 0, 292, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.CreateTable(
                name: "Vendor",
                schema: "TransportDbNew",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PaymentTermsCode = table.Column<string>(nullable: true),
                    VatGroup = table.Column<int>(nullable: false),
                    VatNumber = table.Column<string>(nullable: true),
                    IsInactive = table.Column<bool>(nullable: false),
                    LastChangeDate = table.Column<DateTime>(nullable: false),
                    CurrencyExchangeRateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendor_CurrencyExchangeRate_CurrencyExchangeRateId",
                        column: x => x.CurrencyExchangeRateId,
                        principalSchema: "TransportDbNew",
                        principalTable: "CurrencyExchangeRate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_CurrencyExchangeRateId",
                schema: "TransportDbNew",
                table: "Vendor",
                column: "CurrencyExchangeRateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendor",
                schema: "TransportDbNew");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 14, 22, 49, 0, 292, DateTimeKind.Local).AddTicks(626),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 16, 22, 43, 36, 695, DateTimeKind.Local).AddTicks(3187));
        }
    }
}
