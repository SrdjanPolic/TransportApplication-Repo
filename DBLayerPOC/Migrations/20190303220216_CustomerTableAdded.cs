using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class CustomerTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                schema: "TransportDb",
                table: "QuoteHeader",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customer",
                schema: "TransportDb",
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
                    VatGroup = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuoteHeader_CustomerId",
                schema: "TransportDb",
                table: "QuoteHeader",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuoteHeader_Customer_CustomerId",
                schema: "TransportDb",
                table: "QuoteHeader",
                column: "CustomerId",
                principalSchema: "TransportDb",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuoteHeader_Customer_CustomerId",
                schema: "TransportDb",
                table: "QuoteHeader");

            migrationBuilder.DropTable(
                name: "Customer",
                schema: "TransportDb");

            migrationBuilder.DropIndex(
                name: "IX_QuoteHeader_CustomerId",
                schema: "TransportDb",
                table: "QuoteHeader");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                schema: "TransportDb",
                table: "QuoteHeader");
        }
    }
}
