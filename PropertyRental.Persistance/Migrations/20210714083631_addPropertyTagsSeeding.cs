using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PropertyRental.Persistance.Migrations
{
    public partial class addPropertyTagsSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyTag");

            migrationBuilder.CreateTable(
                name: "PropertyTags",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTags", x => new { x.PropertyId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PropertyTags_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "PropertyTags",
                columns: new[] { "PropertyId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 1, 4 },
                    { 1, 3 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTags_TagId",
                table: "PropertyTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyTags");

            migrationBuilder.CreateTable(
                name: "PropertyTag",
                columns: table => new
                {
                    PropertiesId = table.Column<int>(type: "int", nullable: false),
                    TagsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTag", x => new { x.PropertiesId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_PropertyTag_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTag_TagsId",
                table: "PropertyTag",
                column: "TagsId");
        }
    }
}
