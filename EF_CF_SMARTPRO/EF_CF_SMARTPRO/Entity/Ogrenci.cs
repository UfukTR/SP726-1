using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_SMARTPRO.Entity
{
     public class Ogrenci
     {
          public int OgrenciID { get; set; }
          public string OgrenciTcKimlik { get; set; }
          public string OgrenciAdi { get; set; }
          public string OgrenciSoyadi { get; set; }
          public DateTime OgrenciKursBaslangicTarihi { get; set; }
          public DateTime OgrenciKursBitisTarihi { get; set; }

          // Varsayılan ForeignKey : OgrenciSinif_SinifID
          // Aşağıda FK'i otomatik ekler. Karşı tablonun PK;'i ile aynı isimli olduğu için.
          public int SinifID { get; set; }
          public Sinif OgrenciSinif { get; set; }
     }
}
