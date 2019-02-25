using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_SMARTPRO.Entity
{
     public enum EgitimTipleri
     {
          Kurumsal,
          Özel,
          İşkur
     }
     public enum EgitimProgramlari
     {
          Mobil,
          Web,
          SiberGüvenlik,
          Sistem
     }
     public class Sinif
     {

          public int SinifID { get; set; }

          // Encapsülasyon özelliğini kolon olarak oluşturma.
          [NotMapped]
          private string _SinifKodu;
          public string SinifKodu { get { return _SinifKodu; } set { _SinifKodu = value; } }

          public EgitimProgramlari SinifEgitimProgrami { get; set; }
          public EgitimTipleri SinifEgitimTipleri { get; set; }

          // 4. Derslik sınıfında aşağıdaki özelliğin FK olduğunu belirttik.
          public int SinifDerslikID { get; set; }
          public Derslik SinifDerslik { get; set; }

          // 3. FK Yöntemi. Aşağıdaki özelliği SinifOgretmen nesnesinin FK sı yap.
          [ForeignKey("SinifOgretmen")]
          public int SinifOgretmenID { get; set; }
          public Ogretmen SinifOgretmen { get; set; }


          public ICollection<Ogrenci> SinifOgrencileri { get; set; }


     }
}
