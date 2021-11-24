using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations.AuthenticationDb
{
    public partial class InsertRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e997f0f-6146-4319-86cc-67234d8f674e", "627be373-19fe-4270-918b-38af9878e189", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a84326d-99fe-4f93-94c9-4b57e9cf68c4", "4811a6b7-c51a-4f42-b3f4-6195c60cd82c", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e997f0f-6146-4319-86cc-67234d8f674e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a84326d-99fe-4f93-94c9-4b57e9cf68c4");
        }
    }
}
