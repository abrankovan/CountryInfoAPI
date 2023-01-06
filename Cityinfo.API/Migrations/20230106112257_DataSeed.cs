using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cityinfo.API.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "....", "Juznobanatski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, ".....", "Severnobanatski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, ".......", "Bor" });

            migrationBuilder.InsertData(
                table: "CitiesInProvinces",
                columns: new[] { "Id", "Description", "Name", "ProvinceId" },
                values: new object[] { 1, ".....", "Alibunar", 1 });

            migrationBuilder.InsertData(
                table: "CitiesInProvinces",
                columns: new[] { "Id", "Description", "Name", "ProvinceId" },
                values: new object[] { 2, ".....", "Bela Crkva", 1 });

            migrationBuilder.InsertData(
                table: "CitiesInProvinces",
                columns: new[] { "Id", "Description", "Name", "ProvinceId" },
                values: new object[] { 3, ".....", "Kanjiza", 2 });

            migrationBuilder.InsertData(
                table: "CitiesInProvinces",
                columns: new[] { "Id", "Description", "Name", "ProvinceId" },
                values: new object[] { 4, ".....", "Senta", 2 });

            migrationBuilder.InsertData(
                table: "CitiesInProvinces",
                columns: new[] { "Id", "Description", "Name", "ProvinceId" },
                values: new object[] { 5, ".....", "Majdanpek", 3 });

            migrationBuilder.InsertData(
                table: "CitiesInProvinces",
                columns: new[] { "Id", "Description", "Name", "ProvinceId" },
                values: new object[] { 6, ".....", "Donji Milanovac", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CitiesInProvinces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CitiesInProvinces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CitiesInProvinces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CitiesInProvinces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CitiesInProvinces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CitiesInProvinces",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
