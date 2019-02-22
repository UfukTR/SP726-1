using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF3_CodeFirst_1
{
     //Entity Sınıfı Ekledik.
     // Sınıf adıyla bir tablo oluşacak.
     public class Ogrenci
     {
          // SınıfAdı+Id şeklinde int özellik otomatik olarak
          // PK(primary key) olur.
          public int OgrenciId { get; set; }
          public string OgrenciNumara { get; set; }
          public string OgrenciAd { get; set; }
          public string OgrenciAdres { get; set; }

          // Foreign Key(FK) için başka sınıftan bir nesne türettik.
          // Bu nesneye ait Id otomatik olarak FK olacak.
          public Veli OgrenciVeli { get; set; }
     }
}
