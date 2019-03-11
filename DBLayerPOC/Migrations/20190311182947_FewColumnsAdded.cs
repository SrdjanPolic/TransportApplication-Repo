using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class FewColumnsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CurrencyCode",
                schema: "TransportDb",
                table: "QuoteHeader",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "CurrencyExchangeRate",
                schema: "TransportDb",
                table: "QuoteHeader",
                nullable: false,
                defaultValue: 1f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyCode",
                schema: "TransportDb",
                table: "QuoteHeader");

            migrationBuilder.DropColumn(
                name: "CurrencyExchangeRate",
                schema: "TransportDb",
                table: "QuoteHeader");
        }
    }
}
