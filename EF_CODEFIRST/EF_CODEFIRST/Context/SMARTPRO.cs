namespace EF_CODEFIRST
{
    using Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SMARTPRO : DbContext
    {
        public SMARTPRO()
            : base("name=SmartproConnectionString")
        {

        }

        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Ogretmen> Ogretmens { get; set; }
    }
}