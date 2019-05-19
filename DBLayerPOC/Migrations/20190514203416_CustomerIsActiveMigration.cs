using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class CustomerIsActiveMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "TransportDbNew",
                table: "Customer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 14, 22, 34, 15, 293, DateTimeKind.Local).AddTicks(7240),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 13, 23, 45, 12, 415, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.AddColumn<bool>(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "Customer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 13, 23, 45, 12, 415, DateTimeKind.Local).AddTicks(9847),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 14, 22, 34, 15, 293, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: true);
        }
    }
}
