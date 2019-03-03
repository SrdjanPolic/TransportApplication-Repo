using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TransportDb");

            migrationBuilder.CreateTable(
                name: "QuoteHeader",
                schema: "TransportDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Header = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuoteLine",
                schema: "TransportDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    From = table.Column<string>(maxLength: 256, nullable: false),
                    To = table.Column<string>(maxLength: 256, nullable: false),
                    TransportOfferId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuoteLine_QuoteHeader_TransportOfferId",
                        column: x => x.TransportOfferId,
                        principalSchema: "TransportDb",
                        principalTable: "QuoteHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuoteLine_TransportOfferId",
                schema: "TransportDb",
                table: "QuoteLine",
                column: "TransportOfferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuoteLine",
                schema: "TransportDb");

            migrationBuilder.DropTable(
                name: "QuoteHeader",
                schema: "TransportDb");
        }
    }
}
