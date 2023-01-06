using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cityinfo.API.Migrations
{
    public partial class AddCitiesInProvinceDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitiesInProvinces_Provinces_ProvinceId",
                table: "CitiesInProvinces");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinceId",
                table: "CitiesInProvinces",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CitiesInProvinces",
                type: "TEXT",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CitiesInProvinces_Provinces_ProvinceId",
                table: "CitiesInProvinces",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitiesInProvinces_Provinces_ProvinceId",
                table: "CitiesInProvinces");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CitiesInProvinces");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinceId",
                table: "CitiesInProvinces",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_CitiesInProvinces_Provinces_ProvinceId",
                table: "CitiesInProvinces",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id");
        }
    }
}
