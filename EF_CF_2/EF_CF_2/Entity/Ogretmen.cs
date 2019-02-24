/// Mehmet DEMİR tarafından oluşturulmuştur. Sorularınız için: mail.mehmetdemir@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

// Tablo isimlerini vs. elle vermek için gerekli kütüphane
using System.ComponentModel.DataAnnotations.Schema;

// Elle Primary Key belirlemek için gerekli
using System.ComponentModel.DataAnnotations;

namespace EF_CF_2.Entity
{
    // Db'de tablo oluşturmak istediğimiz sınıfları public yaptık.

    // Tablo ismini ve Şema adını aşağıdaki şekilde belirleyebiliriz.
    //[Table("Ogretmen",Schema="Admin")]
    public class Ogretmen
    {
        // PrimaryKey olarak belirttik.(Id veya OgretmenId varsayılan olarak PrimaryKey)
        //[Key]
        public int OgretmenId { set; get; }

        // Kolon sırasını aşağıdaki gibi belirleyebiliriz.
        //[Column(Order = 2)]
        public string OgretmenTcKimlik { set; get; }

        // Kolon adını aşağıdaki gibi belirleyebiliriz.
        //[Column("OgretmenAd")]
        public string OgretmenAdi { set; get; }

        // SQL'de NOT NULL checkbox'ını işaretler. Boş geçilemez.
        [Required]
        public string OgretmenSoyadi { set; get; }

        // Kolon tipini aşağıdaki gibi belirleyebiliriz.
        //[Column(TypeName = "DateTime2")]
        public DateTime OgretmenIsBasiTarihi { get; set; }
        public DateTime OgretmenIsFesihTarihi { get; set; }
        public bool OgretmenAktifMi { set; get; }

        // Aşağıdaki özellik için kolon oluşturulmasın dedik.
        //[NotMapped]
        //public string TestYazi { get; set; }

        // set ve get metotlarından birisi olmayan özellik de kolon olarak oluşturulmaz.
        //public int TestSayi { set { TestSayi = value; } }
        //public char TestChar { get; }



        public ICollection<Sinif> OgretmenSiniflari { get; set; }

        // Tablo oluşturulabilmesi için boş constructer tanımladık.
        public Ogretmen() { }
    }
}
