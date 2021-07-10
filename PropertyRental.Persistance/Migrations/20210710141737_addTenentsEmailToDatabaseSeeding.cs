using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyRental.Persistance.Migrations
{
    public partial class addTenentsEmailToDatabaseSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 880, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 880, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 880, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 880, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 880, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 878, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 878, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 878, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 878, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 879, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 875, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 877, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 10, 16, 17, 36, 877, DateTimeKind.Local).AddTicks(900));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 55, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 55, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 55, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 55, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 52, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 54, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 9, 23, 6, 39, 54, DateTimeKind.Local).AddTicks(2811));
        }
    }
}
