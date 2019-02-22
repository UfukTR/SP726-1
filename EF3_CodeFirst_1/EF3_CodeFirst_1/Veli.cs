using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF3_CodeFirst_1
{
     public class Veli
     {
          public int VeliId { get; set; }
          public string VeliAd { get; set; }
          public string VeliAdres { get; set; }

          public ICollection<Ogrenci> Ogrenciler { get; set; }
     }
}
