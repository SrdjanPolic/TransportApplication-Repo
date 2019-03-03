using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class RenameProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuoteLine_QuoteHeader_TransportOfferId",
                schema: "TransportDb",
                table: "QuoteLine");

            migrationBuilder.RenameColumn(
                name: "TransportOfferId",
                schema: "TransportDb",
                table: "QuoteLine",
                newName: "QuoteHeaderId");

            migrationBuilder.RenameIndex(
                name: "IX_QuoteLine_TransportOfferId",
                schema: "TransportDb",
                table: "QuoteLine",
                newName: "IX_QuoteLine_QuoteHeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuoteLine_QuoteHeader_QuoteHeaderId",
                schema: "TransportDb",
                table: "QuoteLine",
                column: "QuoteHeaderId",
                principalSchema: "TransportDb",
                principalTable: "QuoteHeader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuoteLine_QuoteHeader_QuoteHeaderId",
                schema: "TransportDb",
                table: "QuoteLine");

            migrationBuilder.RenameColumn(
                name: "QuoteHeaderId",
                schema: "TransportDb",
                table: "QuoteLine",
                newName: "TransportOfferId");

            migrationBuilder.RenameIndex(
                name: "IX_QuoteLine_QuoteHeaderId",
                schema: "TransportDb",
                table: "QuoteLine",
                newName: "IX_QuoteLine_TransportOfferId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuoteLine_QuoteHeader_TransportOfferId",
                schema: "TransportDb",
                table: "QuoteLine",
                column: "TransportOfferId",
                principalSchema: "TransportDb",
                principalTable: "QuoteHeader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
