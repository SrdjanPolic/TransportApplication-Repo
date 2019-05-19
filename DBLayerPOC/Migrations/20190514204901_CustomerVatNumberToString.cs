using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class CustomerVatNumberToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VatNumber",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 14, 22, 49, 0, 292, DateTimeKind.Local).AddTicks(626),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 14, 22, 34, 15, 293, DateTimeKind.Local).AddTicks(7240));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VatNumber",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 14, 22, 34, 15, 293, DateTimeKind.Local).AddTicks(7240),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 14, 22, 49, 0, 292, DateTimeKind.Local).AddTicks(626));
        }
    }
}
