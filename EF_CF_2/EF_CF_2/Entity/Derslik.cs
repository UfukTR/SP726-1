/// Mehmet DEMİR tarafından oluşturulmuştur. Sorularınız için: mail.mehmetdemir@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Aşağıdaki kütüphane [ForeignKey] tanımlaması için gereklidir.
using System.ComponentModel.DataAnnotations.Schema;

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
        public int DerslikId { get; set; }
        public Yerleskeler DerslikYerleskesi { get; set; }
        public byte DerslikKati { get; set; }
        public string DerslikAdi { get; set; }

        // Karşıdaki tabloda Foreign Key isminin ne olacağını belirler.
        [ForeignKey("SinifDerslikId")]
        public ICollection<Sinif> DerslikSiniflari { get; set; }

        // Tablo oluşturulabilmesi için boş constructer tanımladık.
        public Derslik() {}
    }
}
