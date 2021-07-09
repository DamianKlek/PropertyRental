using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyRental.Persistance.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndRentTime",
                table: "Contracts",
                newName: "EndRentDate");

            migrationBuilder.AlterColumn<decimal>(
                name: "RentCost",
                table: "Contracts",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 9, 23, 6, 39, 55, DateTimeKind.Local).AddTicks(4563), null, "Cozy masion situated outside the town", null, null, null, null, "Cozy masion", 1 },
                    { 2, new DateTime(2021, 7, 9, 23, 6, 39, 55, DateTimeKind.Local).AddTicks(5076), null, "Flat placed in city centre", null, null, null, null, "Student flat", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(2025), null, null, null, null, null, "Mansion", 1 },
                    { 2, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(2297), null, null, null, null, null, "Flat", 1 },
                    { 3, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(2307), null, null, null, null, null, "House", 1 },
                    { 4, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(2309), null, null, null, null, null, "High standard", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "Name_FirstName", "Name_LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 9, 23, 6, 39, 52, DateTimeKind.Local).AddTicks(6425), null, null, null, null, null, 1, "Mike", "Parker" },
                    { 2, new DateTime(2021, 7, 9, 23, 6, 39, 54, DateTimeKind.Local).AddTicks(2755), null, null, null, null, null, 1, "Ann", "Brown" },
                    { 3, new DateTime(2021, 7, 9, 23, 6, 39, 54, DateTimeKind.Local).AddTicks(2811), null, null, null, null, null, 1, "Oliver", "Garcia" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "Name", "PropertyId", "SourcePath", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(4649), null, null, null, null, null, "CozyMansionPrimary", 1, "TBA", 1 },
                    { 2, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(5402), null, null, null, null, null, "CozyMansionOutside", 1, "TBA", 1 },
                    { 3, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(5413), null, null, null, null, null, "CozyMansionInside", 1, "TBA", 1 },
                    { 4, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(5416), null, null, null, null, null, "StudentFlatPrimary", 2, "TBA", 1 },
                    { 5, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(5418), null, null, null, null, null, "StudentFlatLivingroom", 2, "TBA", 1 }
                });

            migrationBuilder.InsertData(
                table: "PropertyAddresses",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PropertyId", "StatusId", "AddressDetail_BuildingNumber", "AddressDetail_CityName", "AddressDetail_CountryName", "AddressDetail_FlatNumber", "AddressDetail_StreetName", "AddressDetail_ZipCode" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 9, 23, 6, 39, 55, DateTimeKind.Local).AddTicks(8604), null, null, null, null, null, 1, 1, 34, "Tennessee", "United States", null, "Willow Grove Hwy", "38541" },
                    { 2, new DateTime(2021, 7, 9, 23, 6, 39, 55, DateTimeKind.Local).AddTicks(8884), null, null, null, null, null, 2, 1, 147, "California", "United States", null, "Linwood avenue", "90017" }
                });

            migrationBuilder.InsertData(
                table: "PropertyRents",
                columns: new[] { "Id", "Created", "CreatedBy", "DayCost", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PropertyId", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(9579), null, 100m, null, null, null, null, 1, 1 },
                    { 2, new DateTime(2021, 7, 9, 23, 6, 39, 57, DateTimeKind.Local).AddTicks(111), null, 49m, null, null, null, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "AvailabilityStatus", "Created", "CreatedBy", "Day", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PropertyRentId", "StatusId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(3524), null, new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, 1 },
                    { 2, 1, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4261), null, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, 1 },
                    { 3, 1, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4273), null, new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, 1 },
                    { 4, 1, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4276), null, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 1, 1 },
                    { 5, 1, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4278), null, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2, 1 },
                    { 6, 0, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4280), null, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2, 1 },
                    { 7, 0, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4283), null, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2, 1 },
                    { 8, 1, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4285), null, new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2, 1 },
                    { 9, 1, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(4287), null, new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "Created", "CreatedBy", "EndRentDate", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PropertyRentId", "RentCost", "StartRentDate", "StatusId", "TenantId" },
                values: new object[] { 1, new DateTime(2021, 7, 9, 23, 6, 39, 56, DateTimeKind.Local).AddTicks(6197), null, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, 2, 98m, new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "EndRentDate",
                table: "Contracts",
                newName: "EndRentTime");

            migrationBuilder.AlterColumn<int>(
                name: "RentCost",
                table: "Contracts",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
