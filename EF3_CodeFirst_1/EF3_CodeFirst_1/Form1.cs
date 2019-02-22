using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF3_CodeFirst_1
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               OKUL ctx = new OKUL();
               Veli v1 = new Veli();
               v1.VeliAd = "Veli";
               v1.VeliAdres = "asdasd";
               

               Ogrenci o1 = new Ogrenci();
               o1.OgrenciAd = "Mehmet";
               o1.OgrenciAdres = "asdasd";
               o1.OgrenciNumara = "asdasd";
               o1.OgrenciVeli = v1;

               //v1.Ogrenciler.Add(o1);

               ctx.Ogrencis.Add(o1);
               ctx.Velis.Add(v1);
               ctx.SaveChanges();
          }
     }
}
