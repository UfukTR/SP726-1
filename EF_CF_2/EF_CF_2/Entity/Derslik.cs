using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_2.Entity
{
    public enum Yerleskeler
    {
        Kadiköy,
        SancakTepe
    }
    // Db'de tablo oluşturmak istediğimiz sınıfları public yaptık.
    public class Derslik
    {
        public short DerslikId { get; set; }
        public Yerleskeler DerslikYerleskesi { get; set; }
        public byte DerslikKati { get; set; }
        public string DerslikAdi { get; set; }

        // Tablo oluşturulabilmesi için boş constructer tanımladık.
        public Derslik() {}
    }
}
