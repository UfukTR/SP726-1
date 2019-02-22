namespace EF3_CodeFirst_1
{
     using System;
     using System.Data.Entity;
     using System.Linq;

     public class OKUL : DbContext
     {
          public OKUL()
              : base("name=OKUL") //App.Config'den connectionString i çek.
          {
          }

          // Context 'leri tanýmladýk.
          public DbSet<Ogrenci> Ogrencis { get; set; }
          public DbSet<Veli> Velis { get; set; }
     }
}