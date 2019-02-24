using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_2.Entity
{
    // Db'de tablo oluşturmak istediğimiz sınıfları public yaptık.
    public class Ogretmen
    {
        public short OgretmenId { set; get; }
        public string OgretmenTcKimlik { set; get; }
        public string OgretmenAdi { set; get; }
        public string OgretmenSoyadi { set; get; }
        public DateTime OgretmenIsBasiTarihi { get; set; }
        public DateTime OgretmenIsFesihTarihi { get; set; }
        public bool OgretmenAktifMi { set; get; }

        // Tablo oluşturulabilmesi için boş constructer tanımladık.
        public Ogretmen() { }
    }
}
