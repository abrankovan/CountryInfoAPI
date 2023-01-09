using Cityinfo.API.Entities;
using Microsoft.EntityFrameworkCore;
namespace Cityinfo.API.DbContexts
{
    public class ProvinceInfoContext : DbContext
    {
        public DbSet<Province> Provinces { get; set; } = null!;

        public DbSet<CitiesInProvince> CitiesInProvinces { get; set; } = null!;


        public ProvinceInfoContext(DbContextOptions<ProvinceInfoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>()
                .HasData(
                new Province("Severnobački okrug")
                {
                    Id = 1,
                    Description = "Severnobački okrug se nalazi na severu Republike Srbije. Ima 186.906 stanovnika (Popis iz 2011), a sedište okruga je u gradu Subotici....."
                },
                new Province("Srednjobanatski okrug")
                {
                    Id = 2,
                    Description = "Srednjobanatski upravni okrug se nalazi u severoistočnom delu Srbije. Ima ukupno 187.667 stanovnika (popis iz 2011). Prema preliminarnim podacima popisa 2022. okrug ima 159.030 stanovnika. Sedište okruga je u gradu Zrenjaninu.\n....."
                },
                new Province("Severnobanatski okrug")
                {
                    Id = 3,
                    Description = "....."
                },
                new Province("Južnobanatski okrug")
                {
                    Id = 4,
                    Description = "....."
                },
                new Province("Zapadnobački okrug")
                {
                    Id = 5,
                    Description = "....."
                },
                new Province("Sremski okrug")
                {
                    Id = 6,
                    Description = "...."
                },
                new Province("Južnobački okrug")
                {
                    Id = 7,
                    Description = "....."
                },
                new Province("Mačvanski okrug")
                {
                    Id = 8,
                    Description = "....."
                },
                new Province("Kolubarski okrug")
                {
                    Id = 9,
                    Description = "....."
                },
                new Province("Podunavski okrug")
                {
                    Id = 10,
                    Description = "....."
                },
                new Province("Braničevski okrug")
                {
                    Id = 11,
                    Description = "...."
                },
                new Province("Šumadijski okrug")
                {
                    Id = 12,
                    Description = "....."
                },
                new Province("Pomoravski okrug")
                {
                    Id = 13,
                    Description = "....."
                },
                new Province("Borski okrug")
                {
                    Id = 14,
                    Description = "....."
                },
                new Province("Zaječarski okrug")
                {
                    Id = 15,
                    Description = "....."
                },
                new Province("Zlatiborski okrug\n\n")
                {
                    Id = 16,
                    Description = "...."
                },
                new Province("Moravički okrug")
                {
                    Id = 17,
                    Description = "....."
                },
                new Province("Raški okrug")
                {
                    Id = 18,
                    Description = "....."
                },
                new Province("Rasinski okrug")
                {
                    Id = 19,
                    Description = "....."
                },
                new Province("Nišavski okrug")
                {
                    Id = 20,
                    Description = "IDEMO NIIIIIŠ....."
                },
                new Province("Toplički okrug")
                {
                    Id = 21,
                    Description = "...."
                },
                new Province("Pirotski okrug")
                {
                    Id = 22,
                    Description = "....."
                },
                new Province("Jablanički okrug")
                {
                    Id = 23,
                    Description = "....."
                },
                new Province("Pčinjski okrug")
                {
                    Id = 24,
                    Description = "....."
                },
                new Province("Kosovski okrug")
                {
                    Id = 25,
                    Description = "....."
                },
                new Province("Pećki okrug")
                {
                    Id = 26,
                    Description = "...."
                },
                new Province("Prizrenski okrug")
                {
                    Id = 27,
                    Description = "....."
                },
                new Province("Kosovsko-mitrovački okrug")
                {
                    Id = 28,
                    Description = "....."
                },
                new Province("Kosovsko-pomoravski okrug")
                {
                    Id = 29,
                    Description = "....."
                },
                new Province("Beograd")
                {
                    Id = 30,
                    Description = "Beograd, Beograd\ntri puta, po naški je....."
                });
            modelBuilder.Entity<CitiesInProvince>()
                .HasData(
                new CitiesInProvince("Alibunar")
                {
                    Id = 1,
                    ProvinceId = 1,
                    Description = "....."
                },
                new CitiesInProvince("Bela Crkva")
                {
                    Id = 2,
                    ProvinceId = 1,
                    Description = "....."
                },
                new CitiesInProvince("Kanjiza")
                {
                    Id = 3,
                    ProvinceId = 2,
                    Description = "....."
                },
                new CitiesInProvince("Senta")
                {
                    Id = 4,
                    ProvinceId = 2,
                    Description = "....."
                },
                 new CitiesInProvince("Majdanpek")
                 {
                     Id = 5,
                     ProvinceId = 3,
                     Description = "....."
                 },
                  new CitiesInProvince("Donji Milanovac")
                  {
                      Id = 6,
                      ProvinceId = 2,
                      Description = "....."
                  }
                );
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite();
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
