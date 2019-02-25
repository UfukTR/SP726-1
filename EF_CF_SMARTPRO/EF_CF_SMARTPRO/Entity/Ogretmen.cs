using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF_SMARTPRO.Entity
{
     [Table("Ogretmenler")]
     public class Ogretmen
     {
          // Manuel PK tanımlama. Identity otomatik eklenir.
          [Key]
          public int OgretmenSiraNo { get; set; }

          // Default Primary Key
          //public int OgretmenID { get; set; }

          [Required]
          [Column("TC", TypeName = "varchar",Order = 6)]
          public string OgretmenTcKimlik { get; set; }

          [Index("INDEX_OgretmenAdi", IsClustered = false, IsUnique = false)]
          [MaxLength(30)] // ideksleme sınırını aşmasın(8000 byte)
          public string OgretmenAdi { get; set; }

          public DateTime OgretmenIsBasiTarihi { get; set; }
          public DateTime OgretmenIsFesihTarihi { get; set; }
          public bool OgretmenAktifMi { get; set; }

          [Timestamp]
          public byte[] OgretmenSonDegisiklik { get; set; }


          // Veri tabanında böyle bir kolon oluşturma.
          [NotMapped]
          public string HavadanOzellik { get; set; }

          public ICollection<Sinif> OgretmenSiniflari { get; set; }
     }
}
