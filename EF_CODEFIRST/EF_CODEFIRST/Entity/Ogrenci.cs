using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CODEFIRST.Entity
{

    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        [Column(Order = 3)]
        public string OgrenciAdSoyad { get; set; }

        [index]
        [MaxLength(300)]
        public string OgrenciAdres { get; set; }

        //[ForeignKey("OgrenciOgretmen")]
        //public int Ogretmen_FK { get; set; }

        public Ogretmen OgrenciOgretmen { get; set; }

        //Default ForeignKey
        //public int OgrenciOgretmen_ID { get; set; }

    }
}
