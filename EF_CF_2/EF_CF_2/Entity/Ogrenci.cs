/// Mehmet DEMİR tarafından oluşturulmuştur. Sorularınız için: mail.mehmetdemir@gmail.com
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// indexleme için gerekli [Index]
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_2.Entity
{
    // Db'de tablo oluşturmak istediğimiz sınıfları public yaptık.
    public class Ogrenci
    {
        public int OgrenciId { get; set; }

        // IX_OgrenciTcKimlik isminde index oluşturur.
        [Index(IsClustered = false,IsUnique = true)]
        [MaxLength(11)] // uzunluğu ksııtlamayınca hata verdi. 8000 byte'dan fazla olamaz açıklamasını buldum.
        public string OgrenciTcKimlik { get; set; }

        // aşağıdaki şekilde indekse isim verebiliriz. Clustered non-clustered olma durumunu ve
        // uniq olma durumunu ayarlayabiliriz.
        //[Index("INDEX_OgrenciAdi", IsClustered = true, IsUnique = false)]
        public string OgrenciAdi { get; set; }

        public string OgrenciSoyadi { set; get; }
        public DateTime OgrenciKursBaslangicTarihi { set; get; }
        public DateTime OgrenciKursBitisTarihi { set; get; }

        // Foreign key -> Sinif
        // Sinif tablosundaki primary key ile aynı adlı özellik tanımlanırsa
        // Otomatik olarak foreign key olur.
        public int SinifId { get; set; }
        public Sinif OgrenciSinifi{ get; set; }

        // Tablo oluşturulabilmesi için boş constructer tanımladık.
        public Ogrenci() { }
    }
}
