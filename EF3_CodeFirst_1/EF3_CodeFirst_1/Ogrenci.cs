using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF3_CodeFirst_1
{
     public class Ogrenci
     {
          public int OgrenciId { get; set; }
          public string OgrenciNumara { get; set; }
          public string OgrenciAd { get; set; }
          public string OgrenciAdres { get; set; }

          public Veli OgrenciVeli { get; set; }
     }
}
