/// Mehmet DEMİR tarafından oluşturulmuştur. Sorularınız için: mail.mehmetdemir@gmail.com
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        // string ve byte[] tiplerde maksimum uzunluk belirleme.
        //  [StringLength(50)] sadece strinde(nvarchar)
        [MaxLength(10)]
        public string SinifKodu { set; get; }
        public short SinifDerslikNo { set; get; }

        // Timastap zaman mührü koyar. 1 tabloda en fazla 1 tane olabilir.
        // byte[] tipinde olur. SQL bunu son editlenme bilgisini tutmak için kullanır(eşzamanlı update kontrolü için)
        [Timestamp]
        public byte[] OgrenciSonEditTarihi { get; set; }

        public EgitimTipleri SinifEgitimTipi { set; get;}
        public EgitimProgramlari SinifEgitimProgrami { set; get; }


        // Derslik sınıfının ForeignKey ismini doğrudan verdik.
        // (Derslik sınıfından da aynı tanımı yaptığım için bu satırı kapattım.)
        //[ForeignKey("SinifDerslikId")]

        public int SinifDerslikId { get; set; }
        public Derslik SinifDerslik { get; set; }

        // Altındaki özellik SinifOgretmeni nesnesinin foreign keyi olsun demektir(dolaylı).
        [ForeignKey("SinifOgretmeni")]
        public int SinifOgretmenId { get; set; }
        public Ogretmen SinifOgretmeni { set; get; }
    
        // Ogrenci sınıfında foreign key tanımladık. Karşılığında koleksiyon tanımlaması yaptık.
        public ICollection<Ogrenci> SinifOgrencileri { get; set; }

        // Tablo oluşturulabilmesi için boş constructer tanımladık.
        public Sinif() { }
    }
}
