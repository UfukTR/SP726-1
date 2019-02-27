using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST.Entity
{
    public class Ogretmen
    {
        public int ID { get; set; }
        public string OgretmenAdSoyad { get; set; }
        [Required]
        public string OgretmenAdres { get; set; }

        public IList<Ogrenci> OgretmenOgrenciListe { get; set; }
    }
}
