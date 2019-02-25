namespace EF_CF_SMARTPRO
{
     using Entity;
     using System;
     using System.Data.Entity;
     using System.Linq;

     public class SMARTPRO : DbContext
     {
          public SMARTPRO()
              : base("name=SmartproConnectionString")
          {
          }

          public DbSet<Ogretmen> Ogretmenler { get; set; }
          public DbSet<Ogrenci> Ogrencis { get; set; }
          public DbSet<Derslik> Dersliks { get; set; }
          public DbSet<Sinif> Sinifs { get; set; }
     }
}