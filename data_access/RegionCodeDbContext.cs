using data_access.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access
{
    public class RegionCodeDbContext : DbContext
    {
        public RegionCodeDbContext()
        {
            
        }
        public DbSet<CodeRegions> CodeRegions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=LEGION5\SQLEXPRESS;
                                          Initial Catalog = Regions;
                                          Integrated Security=True;
                                          Connect Timeout=30;
                                          Encrypt=False;
                                          Trust Server Certificate=False;
                                          Application Intent=ReadWrite;
                                          Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CodeRegions>().Property(e => e.Code).HasMaxLength(10);
            modelBuilder.Entity<CodeRegions>().Property(e => e.Region).HasMaxLength(150);
            modelBuilder.Entity<CodeRegions>().Property(e => e.Region).IsRequired();

            modelBuilder.Entity<CodeRegions>().HasData(new CodeRegions[]
            {
                new CodeRegions
                {
                    Id =1,
                    Code = "АК",
                    Region = "АР Крим"
                },
                new CodeRegions
                {
                    Id=2,
                    Code = "АВ",
                    Region = "Вінницька область"
                },
                new CodeRegions
                {
                    Id=3,
                    Code = "АС",
                    Region = "Волинська область"
                },
                new CodeRegions
                {
                    Id=4,
                    Code = "АЕ",
                    Region = "Дніпропетровська область"
                },
                new CodeRegions
                {
                    Id=5,
                    Code = "АН",
                    Region = "Донецька область"
                },
                new CodeRegions
                {
                    Id=6,
                    Code = "АМ",
                    Region = "Житомирська область"
                },
                new CodeRegions
                {
                    Id=7,
                    Code = "АО",
                    Region = "Закарпатська область"
                },
                new CodeRegions
                {
                    Id=8,
                    Code = "АР",
                    Region = "Запорізька область"
                },
                new CodeRegions
                {
                    Id=9,
                    Code = "АТ",
                    Region = "Івано-Франківська область"
                },
                new CodeRegions
                {
                    Id=10,
                    Code = "АА",
                    Region = "Київ"
                },
                new CodeRegions
                {
                    Id=11,
                    Code = "АІ",
                    Region = "Київська область"
                },
                new CodeRegions
                {
                    Id=12,
                    Code = "ВА",
                    Region = "Кіровоградська область"
                },
                new CodeRegions
                {
                    Id=13,
                    Code = "ВВ",
                    Region = "Луганська область"
                },
                new CodeRegions
                {
                    Id=14,
                    Code = "ВС",
                    Region = "Львіська область"
                },
                new CodeRegions
                {
                    Id=15,
                    Code = "ВЕ",
                    Region = "Миколаївська область"
                },
                new CodeRegions
                {
                    Id=16,
                    Code = "ВН",
                    Region = "Одеська область"
                },
                new CodeRegions
                {
                    Id=17,
                    Code = "ВІ",
                    Region = "Полтавська область"
                },
                new CodeRegions
                {
                    Id=18,
                    Code = "ВК",
                    Region = "Рівненська область"
                },
                new CodeRegions
                {
                    Id=19,
                    Code = "СН",
                    Region = "Севастополь"
                },
                new CodeRegions
                {
                    Id=20,
                    Code = "ВМ",
                    Region = "Сумська область"
                },
                new CodeRegions
                {
                    Id=21,
                    Code = "ВО",
                    Region = "Тернопільська область"
                },
                new CodeRegions
                {
                    Id=22,
                    Code = "АХ",
                    Region = "Харківська область"
                },
                new CodeRegions
                {
                    Id=23,
                    Code = "ВТ",
                    Region = "Херсонська область"
                },
                new CodeRegions
                {
                    Id=24,
                    Code = "ВХ",
                    Region = "Хмельницька область"
                },
                new CodeRegions
                {
                    Id=25,
                    Code = "СА",
                    Region = "Черкаська область"
                },
                new CodeRegions
                {
                    Id=26,
                    Code = "СВ",
                    Region = "Чернігівська область"
                },
                new CodeRegions
                {
                    Id=27,
                    Code = "СЕ",
                    Region = "Чернівецька область"
                }
            });
        }
    }
}

