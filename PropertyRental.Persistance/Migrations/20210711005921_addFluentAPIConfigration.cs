using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyRental.Persistance.Migrations
{
    public partial class addFluentAPIConfigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name_LastName",
                table: "Tenants",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Name_FirstName",
                table: "Tenants",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Email_UserName",
                table: "Tenants",
                newName: "EmailUserName");

            migrationBuilder.RenameColumn(
                name: "Email_DomainName",
                table: "Tenants",
                newName: "EmailDomainName");

            migrationBuilder.RenameColumn(
                name: "AddressDetail_ZipCode",
                table: "PropertyAddresses",
                newName: "ZipCode");

            migrationBuilder.RenameColumn(
                name: "AddressDetail_StreetName",
                table: "PropertyAddresses",
                newName: "StreetName");

            migrationBuilder.RenameColumn(
                name: "AddressDetail_FlatNumber",
                table: "PropertyAddresses",
                newName: "FlatNumber");

            migrationBuilder.RenameColumn(
                name: "AddressDetail_CountryName",
                table: "PropertyAddresses",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "AddressDetail_CityName",
                table: "PropertyAddresses",
                newName: "CityName");

            migrationBuilder.RenameColumn(
                name: "AddressDetail_BuildingNumber",
                table: "PropertyAddresses",
                newName: "BuildingNumber");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Tenants",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Tenants",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "PropertyAddresses",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StreetName",
                table: "PropertyAddresses",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "PropertyAddresses",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "PropertyAddresses",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Properties",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SourcePath",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Images",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 678, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 678, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 678, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 678, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 678, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 676, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 676, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 676, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 676, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 677, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 673, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 675, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 59, 20, 675, DateTimeKind.Local).AddTicks(701));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Tenants",
                newName: "Name_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Tenants",
                newName: "Name_FirstName");

            migrationBuilder.RenameColumn(
                name: "EmailUserName",
                table: "Tenants",
                newName: "Email_UserName");

            migrationBuilder.RenameColumn(
                name: "EmailDomainName",
                table: "Tenants",
                newName: "Email_DomainName");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "PropertyAddresses",
                newName: "AddressDetail_ZipCode");

            migrationBuilder.RenameColumn(
                name: "StreetName",
                table: "PropertyAddresses",
                newName: "AddressDetail_StreetName");

            migrationBuilder.RenameColumn(
                name: "FlatNumber",
                table: "PropertyAddresses",
                newName: "AddressDetail_FlatNumber");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "PropertyAddresses",
                newName: "AddressDetail_CountryName");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "PropertyAddresses",
                newName: "AddressDetail_CityName");

            migrationBuilder.RenameColumn(
                name: "BuildingNumber",
                table: "PropertyAddresses",
                newName: "AddressDetail_BuildingNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Name_LastName",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name_FirstName",
                table: "Tenants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "AddressDetail_ZipCode",
                table: "PropertyAddresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressDetail_StreetName",
                table: "PropertyAddresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressDetail_CountryName",
                table: "PropertyAddresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AddressDetail_CityName",
                table: "PropertyAddresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Properties",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SourcePath",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 776, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 776, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "PropertyAddresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "PropertyRents",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(4543));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 773, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 775, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 11, 2, 57, 46, 775, DateTimeKind.Local).AddTicks(4174));
        }
    }
}
