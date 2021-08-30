using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyRental.Persistance.Migrations
{
    public partial class changeNameOfPropertyRentTableToOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_PropertyRents_PropertyRentId",
                table: "Availabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_PropertyRents_PropertyRentId",
                table: "Contracts");

            migrationBuilder.DropTable(
                name: "PropertyRents");

            migrationBuilder.RenameColumn(
                name: "PropertyRentId",
                table: "Contracts",
                newName: "OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_Contracts_PropertyRentId",
                table: "Contracts",
                newName: "IX_Contracts_OfferId");

            migrationBuilder.RenameColumn(
                name: "PropertyRentId",
                table: "Availabilities",
                newName: "OfferId");

            migrationBuilder.RenameIndex(
                name: "IX_Availabilities_PropertyRentId",
                table: "Availabilities",
                newName: "IX_Availabilities_OfferId");

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Created", "CreatedBy", "DayCost", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PropertyId", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(4003), null, 100m, null, null, null, null, 1, 1 },
                    { 2, new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(4499), null, 49m, null, null, null, null, 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 536, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 537, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 538, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 534, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 535, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 7, 25, 22, 15, 20, 535, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.CreateIndex(
                name: "IX_Offers_PropertyId",
                table: "Offers",
                column: "PropertyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_Offers_OfferId",
                table: "Availabilities",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Offers_OfferId",
                table: "Contracts",
                column: "OfferId",
                principalTable: "Offers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Availabilities_Offers_OfferId",
                table: "Availabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Offers_OfferId",
                table: "Contracts");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.RenameColumn(
                name: "OfferId",
                table: "Contracts",
                newName: "PropertyRentId");

            migrationBuilder.RenameIndex(
                name: "IX_Contracts_OfferId",
                table: "Contracts",
                newName: "IX_Contracts_PropertyRentId");

            migrationBuilder.RenameColumn(
                name: "OfferId",
                table: "Availabilities",
                newName: "PropertyRentId");

            migrationBuilder.RenameIndex(
                name: "IX_Availabilities_OfferId",
                table: "Availabilities",
                newName: "IX_Availabilities_PropertyRentId");

            migrationBuilder.CreateTable(
                name: "PropertyRents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyRents_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "PropertyRents",
                columns: new[] { "Id", "Created", "CreatedBy", "DayCost", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "PropertyId", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(3300), null, 100m, null, null, null, null, 1, 1 },
                    { 2, new DateTime(2021, 7, 24, 1, 42, 3, 329, DateTimeKind.Local).AddTicks(3862), null, 49m, null, null, null, null, 2, 1 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRents_PropertyId",
                table: "PropertyRents",
                column: "PropertyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Availabilities_PropertyRents_PropertyRentId",
                table: "Availabilities",
                column: "PropertyRentId",
                principalTable: "PropertyRents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_PropertyRents_PropertyRentId",
                table: "Contracts",
                column: "PropertyRentId",
                principalTable: "PropertyRents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
