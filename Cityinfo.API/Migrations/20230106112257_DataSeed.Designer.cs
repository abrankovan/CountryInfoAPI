﻿// <auto-generated />
using Cityinfo.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cityinfo.API.Migrations
{
    [DbContext(typeof(ProvinceInfoContext))]
    [Migration("20230106112257_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Cityinfo.API.Entities.CitiesInProvince", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("CitiesInProvinces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = ".....",
                            Name = "Alibunar",
                            ProvinceId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = ".....",
                            Name = "Bela Crkva",
                            ProvinceId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = ".....",
                            Name = "Kanjiza",
                            ProvinceId = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = ".....",
                            Name = "Senta",
                            ProvinceId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = ".....",
                            Name = "Majdanpek",
                            ProvinceId = 3
                        },
                        new
                        {
                            Id = 6,
                            Description = ".....",
                            Name = "Donji Milanovac",
                            ProvinceId = 2
                        });
                });

            modelBuilder.Entity("Cityinfo.API.Entities.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Provinces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "....",
                            Name = "Juznobanatski okrug"
                        },
                        new
                        {
                            Id = 2,
                            Description = ".....",
                            Name = "Severnobanatski okrug"
                        },
                        new
                        {
                            Id = 3,
                            Description = ".......",
                            Name = "Bor"
                        });
                });

            modelBuilder.Entity("Cityinfo.API.Entities.CitiesInProvince", b =>
                {
                    b.HasOne("Cityinfo.API.Entities.Province", "Province")
                        .WithMany("CitiesInProvince")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Cityinfo.API.Entities.Province", b =>
                {
                    b.Navigation("CitiesInProvince");
                });
#pragma warning restore 612, 618
        }
    }
}
