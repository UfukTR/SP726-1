namespace EF3_CodeFirst_1
{
     using System;
     using System.Data.Entity;
     using System.Linq;

     public class OKUL : DbContext
     {
          // Your context has been configured to use a 'OKUL' connection string from your application's 
          // configuration file (App.config or Web.config). By default, this connection string targets the 
          // 'EF3_CodeFirst_1.OKUL' database on your LocalDb instance. 
          // 
          // If you wish to target a different database and/or database provider, modify the 'OKUL' 
          // connection string in the application configuration file.
          public OKUL()
              : base("name=OKUL")
          {
          }

          // Add a DbSet for each entity type that you want to include in your model. For more information 
          // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

          // public virtual DbSet<MyEntity> MyEntities { get; set; }

          public DbSet<Ogrenci> Ogrencis { get; set; }
          public DbSet<Veli> Velis { get; set; }
     }


     //public class MyEntity
     //{
     //    public int Id { get; set; }
     //    public string Name { get; set; }
     //}
}