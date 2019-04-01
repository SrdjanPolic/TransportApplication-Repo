using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class CustomerColumnRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentTermsCode",
                schema: "TransportDb",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentTermsCode",
                schema: "TransportDb",
                table: "Customer",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
