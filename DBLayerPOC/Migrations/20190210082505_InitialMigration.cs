using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TransportDb");

            migrationBuilder.CreateTable(
                name: "TransportOffers",
                schema: "TransportDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Header = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOffers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportRoutes",
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
                    table.PrimaryKey("PK_TransportRoutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportRoutes_TransportOffers_TransportOfferId",
                        column: x => x.TransportOfferId,
                        principalSchema: "TransportDb",
                        principalTable: "TransportOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransportRoutes_TransportOfferId",
                schema: "TransportDb",
                table: "TransportRoutes",
                column: "TransportOfferId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransportRoutes",
                schema: "TransportDb");

            migrationBuilder.DropTable(
                name: "TransportOffers",
                schema: "TransportDb");
        }
    }
}
