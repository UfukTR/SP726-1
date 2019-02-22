using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF3_CodeFirst_1
{
     public class Veli
     {    // SınıfAdı+Id şeklinde int özellik otomatik olarak
          // PK(primary key) olur.
          public int VeliId { get; set; }
          public string VeliAd { get; set; }
          public string VeliAdres { get; set; }

          // Foreign Key(FK) için başka sınıftan bir nesne türettik.
          // Bu nesneye ait Id otomatik olarak FK olacak.
          // Bir velinin birden fazla öğrencisi olabilir.
          // Bu yüzden Generic List şeklinde yaptık.
          public ICollection<Ogrenci> Ogrenciler { get; set; }
     }
}
