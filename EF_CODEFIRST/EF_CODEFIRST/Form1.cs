using EF_CODEFIRST.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CODEFIRST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Ogretmen Ogr1 = new Ogretmen();
            Ogr1.OgretmenAdres = "Sarıyer";
            Ogr1.OgretmenAdSoyad = "kemal Ahmet";

            Ogrenci o1 = new Ogrenci();
            o1.OgrenciAdSoyad = "Smartpro";
            o1.OgrenciAdres = "Taksim";
            o1.OgrenciOgretmen = Ogr1;

            SMARTPRO ctx = new SMARTPRO();
            ctx.Ogretmens.Add(Ogr1);
            ctx.Ogrencis.Add(o1);
            ctx.SaveChanges();

        }
    }
}
