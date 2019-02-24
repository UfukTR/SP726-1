using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CF_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1: CodeFirst Conventions and Data(type) Mapping
            // http://www.entityframeworktutorial.net/code-first/code-first-conventions.aspx
            // C#'tan SQL'e varsayılan aktarım şekilleri.(PrimaryKey, Şema, VT adı vs.)


            // 2: Aşağıdaki linkten kalıtım mantığı ile ilgili detaylı bilgi alınabilir.
            // http://www.entityframeworktutorial.net/code-first/inheritance-strategy-in-code-first.aspx
            // CodeFirst'de varsayılan olarak kalıtım ile türeyen sınıflar için tek tablo üretilir.
            // En alttaki sınıfa ait tabloda tüm özellikler oluşturulur.
            // Table per Hierarchy (TPH) (1 hiyeraşi = 1 tablo)
            // Diğer seçenekler:
            // Table per Type (TPT): (1 sınıf(abstract dahil) = 1 tablo)
            // Table per Concrete Class (TPC): (1 sınıf(abstract hariç) = 1 tablo)(abstract sınıflara ait özellikler alt sınıf tablolarında oluşturulur.)


            // 3: Context ve Entity sınıflarını oluşturduk.

        }
    }
}
