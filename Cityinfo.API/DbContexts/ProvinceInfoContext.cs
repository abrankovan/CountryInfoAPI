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
                new Province("Juznobanatski okrug")
                {
                    Id = 1,
                    Description = "..."
                },
                new Province("Severnobanatski okrug")
                {
                    Id = 2,
                    Description = "....."
                },
                new Province("Bor")
                {
                    Id = 3,
                    Description = "......."
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
