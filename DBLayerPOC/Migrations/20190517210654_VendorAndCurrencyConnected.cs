using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBLayerPOC.Migrations
{
    public partial class VendorAndCurrencyConnected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_CurrencyExchangeRate_CurrencyExchangeRateId",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.RenameColumn(
                name: "CurrencyExchangeRateId",
                schema: "TransportDbNew",
                table: "Vendor",
                newName: "CurrencyId");

            migrationBuilder.RenameIndex(
                name: "IX_Vendor_CurrencyExchangeRateId",
                schema: "TransportDbNew",
                table: "Vendor",
                newName: "IX_Vendor_CurrencyId");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNo",
                schema: "TransportDbNew",
                table: "Vendor",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTermsCode",
                schema: "TransportDbNew",
                table: "Vendor",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "TransportDbNew",
                table: "Vendor",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 17, 23, 6, 53, 519, DateTimeKind.Local).AddTicks(9782),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "TransportDbNew",
                table: "Vendor",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                schema: "TransportDbNew",
                table: "Vendor",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                schema: "TransportDbNew",
                table: "Vendor",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "TransportDbNew",
                table: "Vendor",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 17, 23, 6, 53, 506, DateTimeKind.Local).AddTicks(5765),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 16, 22, 43, 36, 695, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_Currency_CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor",
                column: "CurrencyId",
                principalSchema: "TransportDbNew",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_Currency_CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor");

            migrationBuilder.RenameColumn(
                name: "CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor",
                newName: "CurrencyExchangeRateId");

            migrationBuilder.RenameIndex(
                name: "IX_Vendor_CurrencyId",
                schema: "TransportDbNew",
                table: "Vendor",
                newName: "IX_Vendor_CurrencyExchangeRateId");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNo",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentTermsCode",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 17, 23, 6, 53, 519, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.AlterColumn<bool>(
                name: "IsInactive",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "TransportDbNew",
                table: "Vendor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastChangeDate",
                schema: "TransportDbNew",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(2019, 5, 16, 22, 43, 36, 695, DateTimeKind.Local).AddTicks(3187),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2019, 5, 17, 23, 6, 53, 506, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_CurrencyExchangeRate_CurrencyExchangeRateId",
                schema: "TransportDbNew",
                table: "Vendor",
                column: "CurrencyExchangeRateId",
                principalSchema: "TransportDbNew",
                principalTable: "CurrencyExchangeRate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
