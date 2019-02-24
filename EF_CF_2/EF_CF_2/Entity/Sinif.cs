using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_2.Entity
{
    public enum EgitimTipleri
    {
        Kurumsal,
        Özel,
        İşkur
    }
    public enum EgitimProgramlari
    {
        MobilYazilimEgitimi,
        WebYazilimEgitimi,
        YazilimEgitimi,
        VeriTabaniEgitimi,
        SiberGuvenlikEgitimi,
        AgveSistemEgitimi

    }
    // Db'de tablo oluşturmak istediğimiz sınıfları public yaptık.
    public class Sinif
    {
        public int SinifId { get; set; }
        public string SinifKodu { set; get; }
        public short SinifDerslikNo { set; get; }
        public EgitimTipleri SinifEgitimTipi { set; get;}
        public EgitimProgramlari SinifEgitimProgrami { set; get; }

        public Derslik SinifDerslik { get; set; }
        public Ogretmen SinifOgretmeni { set; get; }

        // Tablo oluşturulabilmesi için boş constructer tanımladık.
        public Sinif() { }
    }
}
