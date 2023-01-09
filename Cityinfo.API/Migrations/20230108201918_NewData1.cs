using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cityinfo.API.Migrations
{
    public partial class NewData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Severnobački okrug se nalazi na severu Republike Srbije. Ima 186.906 stanovnika (Popis iz 2011), a sedište okruga je u gradu Subotici.....", "Severnobački okrug" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Srednjobanatski upravni okrug se nalazi u severoistočnom delu Srbije. Ima ukupno 187.667 stanovnika (popis iz 2011). Prema preliminarnim podacima popisa 2022. okrug ima 159.030 stanovnika. Sedište okruga je u gradu Zrenjaninu.\n.....", "Srednjobanatski okrug" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".....", "Severnobanatski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, ".....", "Južnobanatski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 5, ".....", "Zapadnobački okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 6, "....", "Sremski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 7, ".....", "Južnobački okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 8, ".....", "Mačvanski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 9, ".....", "Kolubarski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 10, ".....", "Podunavski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 11, "....", "Braničevski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 12, ".....", "Šumadijski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 13, ".....", "Pomoravski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 14, ".....", "Borski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 15, ".....", "Zaječarski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 16, "....", "Zlatiborski okrug\n\n" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 17, ".....", "Moravički okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 18, ".....", "Raški okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 19, ".....", "Rasinski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 20, "IDEMO NIIIIIŠ.....", "Nišavski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 21, "....", "Toplički okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 22, ".....", "Pirotski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 23, ".....", "Jablanički okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 24, ".....", "Pčinjski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 25, ".....", "Kosovski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 26, "....", "Pećki okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 27, ".....", "Prizrenski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 28, ".....", "Kosovsko-mitrovački okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 29, ".....", "Kosovsko-pomoravski okrug" });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 30, "Beograd, Beograd\ntri puta, po naški je.....", "Beograd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "....", "Juznobanatski okrug" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".....", "Severnobanatski okrug" });

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { ".......", "Bor" });
        }
    }
}
