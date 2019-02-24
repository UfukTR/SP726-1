using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_2.Entity
{
    // Db'de tablo oluşturmak istediğimiz sınıfları public yaptık.
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string OgrenciTcKimlik { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { set; get; }
        public DateTime OgrenciKursBaslangicTarihi { set; get; }
        public DateTime OgrenciKursBitisTarihi { set; get; }

        public Sinif OgrenciSinifi{ get; set; }

        // Tablo oluşturulabilmesi için boş constructer tanımladık.
        public Ogrenci() { }
    }
}
