﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using data_access;

#nullable disable

namespace data_access.Migrations
{
    [DbContext(typeof(RegionCodeDbContext))]
    [Migration("20240527064046_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("data_access.Entities.CodeRegions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("CodeRegions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "АК",
                            Region = "АР Крим"
                        },
                        new
                        {
                            Id = 2,
                            Code = "АВ",
                            Region = "Вінницька область"
                        },
                        new
                        {
                            Id = 3,
                            Code = "АС",
                            Region = "Волинська область"
                        },
                        new
                        {
                            Id = 4,
                            Code = "АЕ",
                            Region = "Дніпропетровська область"
                        },
                        new
                        {
                            Id = 5,
                            Code = "АН",
                            Region = "Донецька область"
                        },
                        new
                        {
                            Id = 6,
                            Code = "АМ",
                            Region = "Житомирська область"
                        },
                        new
                        {
                            Id = 7,
                            Code = "АО",
                            Region = "Закарпатська область"
                        },
                        new
                        {
                            Id = 8,
                            Code = "АР",
                            Region = "Запорізька область"
                        },
                        new
                        {
                            Id = 9,
                            Code = "АТ",
                            Region = "Івано-Франківська область"
                        },
                        new
                        {
                            Id = 10,
                            Code = "АА",
                            Region = "Київ"
                        },
                        new
                        {
                            Id = 11,
                            Code = "АІ",
                            Region = "Київська область"
                        },
                        new
                        {
                            Id = 12,
                            Code = "ВА",
                            Region = "Кіровоградська область"
                        },
                        new
                        {
                            Id = 13,
                            Code = "ВВ",
                            Region = "Луганська область"
                        },
                        new
                        {
                            Id = 14,
                            Code = "ВС",
                            Region = "Львіська область"
                        },
                        new
                        {
                            Id = 15,
                            Code = "ВЕ",
                            Region = "Миколаївська область"
                        },
                        new
                        {
                            Id = 16,
                            Code = "ВН",
                            Region = "Одеська область"
                        },
                        new
                        {
                            Id = 17,
                            Code = "ВІ",
                            Region = "Полтавська область"
                        },
                        new
                        {
                            Id = 18,
                            Code = "ВК",
                            Region = "Рівненська область"
                        },
                        new
                        {
                            Id = 19,
                            Code = "СН",
                            Region = "Севастополь"
                        },
                        new
                        {
                            Id = 20,
                            Code = "ВМ",
                            Region = "Сумська область"
                        },
                        new
                        {
                            Id = 21,
                            Code = "ВО",
                            Region = "Тернопільська область"
                        },
                        new
                        {
                            Id = 22,
                            Code = "АХ",
                            Region = "Харківська область"
                        },
                        new
                        {
                            Id = 23,
                            Code = "ВТ",
                            Region = "Херсонська область"
                        },
                        new
                        {
                            Id = 24,
                            Code = "ВХ",
                            Region = "Хмельницька область"
                        },
                        new
                        {
                            Id = 25,
                            Code = "СА",
                            Region = "Черкаська область"
                        },
                        new
                        {
                            Id = 26,
                            Code = "СВ",
                            Region = "Чернігівська область"
                        },
                        new
                        {
                            Id = 27,
                            Code = "СЕ",
                            Region = "Чернівецька область"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
