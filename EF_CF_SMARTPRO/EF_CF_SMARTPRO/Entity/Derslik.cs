using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_SMARTPRO.Entity
{
     public enum Yerleskeler
     {
          Kadikoy,
          Sancaktepe
     }
     public class Derslik
     {
          public int DerslikID { get; set; }
          public Yerleskeler DerslikYerleskesi { get; set; }
          public byte DerslikKati { get; set; }
          public string DerslikAdi { get; set; }

          // Sinif sınıfından SinifDerslikID isimli özelliği ForeignKey yap
          [ForeignKey("SinifDerslikID")]
          public ICollection<Sinif> DerslikSiniflari { get; set; }

     }
}
