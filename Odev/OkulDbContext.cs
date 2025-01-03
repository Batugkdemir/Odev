﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ananı
{
    internal class OkulDbContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-HBR8SIT;initial catalog=Ogrenci;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
    }
}

//DbContext classı: EF içerisinde veritabanı  işlemlerini yapmak için kullanılan class. Örn. CRUD işlemleri. Her projenin ayrı bir DbContext classı olmalıdır. Her projenin DB'si kendisine özgüdür.

//DbSet: DB'deki tabloları bellekte temsil eder. Generic yapılardır. Dolayısla hangi entity tipinde oluşturulursa, o tipteki alanları içerir. Db için sorguları çalıştırmak için kullanılır. Entity'ler bu yapı içerisinde tutulur. Örn. Ogrenci tipi için, OgrenciId, Ad,Soyad,Numara


//Migration Classları: EF Code First tekniğinde, kod ile yapılan işlemlerin DB'ye aktarılması için gerekli olan classlardır. Bu classlar her kod değişiminde oluşturulmalıdır. Migration class'ı oluşturmak için add-migration komutu kullanılır.