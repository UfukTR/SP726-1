using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DbFirst_2
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               // Stored Proc Kullanımı
               Okul_VTEntities okul_ctx = new Okul_VTEntities();
               Notlar n1 = new Notlar();
               n1.Not1 = 17;
               n1.Not2 = 17;
               
               //------------------------------------------------
               // Design bölümünde Notlar tablosunda sağ tıkladık.
               // Stored Proc Mapping işlemi yaptık.
               // Bundan dolayı artık Add kullanınca da Stored Proc çalışacak.
               //------------------------------------------------
               //okul_ctx.Not_Kaydet(n1.Not1,n1.Not2);

               okul_ctx.Notlars.Add(n1);

               okul_ctx.SaveChanges();
               
          }
     }
}
