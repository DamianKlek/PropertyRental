using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyRental.Persistance.Migrations
{
    public partial class changeNameOfPropertyAddressTableToAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyAddresses_Properties_PropertyId",
                table: "PropertyAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyAddresses",
                table: "PropertyAddresses");

            migrationBuilder.RenameTable(
                name: "PropertyAddresses",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyAddresses_PropertyId",
                table: "Addresses",
                newName: "IX_Addresses_PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 328, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 327, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 327, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 323, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 325, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 24, 1, 42, 3, 325, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Properties_PropertyId",
                table: "Addresses",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Properties_PropertyId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "PropertyAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_PropertyId",
                table: "PropertyAddresses",
                newName: "IX_PropertyAddresses_PropertyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyAddresses",
                table: "PropertyAddresses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 771, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 771, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 771, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 771, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 771, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 769, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 769, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 769, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 769, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 770, DateTimeKind.Local).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 771, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 771, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 771, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 771, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 766, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 768, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 14, 10, 36, 30, 768, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyAddresses_Properties_PropertyId",
                table: "PropertyAddresses",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
