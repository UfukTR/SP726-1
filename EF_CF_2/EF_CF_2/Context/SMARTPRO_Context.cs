/// Mehmet DEMİR tarafından oluşturulmuştur. Sorularınız için: mail.mehmetdemir@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;

//Entity Framework Kullanımı için Gerekli
using System.Data.Entity;
//Klasörlerdeki sınıflara erişim için gerekli.
using EF_CF_2.Entity;

namespace EF_CF_2.Context
{
    public class SMARTPRO_Context:DbContext
    {
        // Connection string'i name parametresi ile verdik.
        // Database adını bu connection string'de tanımlayacağız.
        // base("SMARTPRO") deseydik. Sadece DB adını vermiş olacaktık.
        // Bağlantıyı Visual Studio üzerinden ayarlamamız gerekecekti.
        public SMARTPRO_Context() : base("name=SMARTPRO_ConnectionString")
        {
            // Disable initializer
            // Yani: Veritabanı oluşturmayı kapatmak için aşağıdaki satırı açabilirsiniz.
            // Database.SetInitializer<SMARTPRO_Context>(null);
        }

        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Derslik> Derslikler { get; set; }
    }
        
}
