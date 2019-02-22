namespace EF3_CodeFirst_1
{
     using System;
     using System.Data.Entity;
     using System.Linq;

     public class OKUL : DbContext
     {
          public OKUL()
              : base("name=OKUL") //App.Config'den connectionString i �ek.
          {
          }

          // Context 'leri tan�mlad�k.
          public DbSet<Ogrenci> Ogrencis { get; set; }
          public DbSet<Veli> Velis { get; set; }
     }
}