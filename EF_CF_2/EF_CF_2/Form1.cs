using EF_CF_2.Context;
using EF_CF_2.Entity;
/// Mehmet DEMİR tarafından oluşturulmuştur. Sorularınız için: mail.mehmetdemir@gmail.com
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
            // 4: Sınıf özelliklerine nitelik değiştirme yaptık(ad,boyut,foreignkey,primarykey vs..)

            // 5: [inverseproperty] : başka bir sınıftan 2 nesne(2 foreign key) tanımlarken linkten açıklanacak.
            // http://www.entityframeworktutorial.net/code-first/inverseproperty-dataannotations-attribute-in-code-first.aspx

            // 6: [ConcurrencyCheck] aşağıdaki linkten açıklanacak.
            //http://www.entityframeworktutorial.net/code-first/concurrencycheck-dataannotations-attribute-in-code-first.aspx

            // 7: [ConcurrencyCheck]

            // Migration linkten anlatılacak.
            // 8: http://www.entityframeworktutorial.net/code-first/migration-in-code-first.aspx

            // Otomatik migration için: Herşeyi tamamldıktan sonra aşağıdaki komutları sıra ile girdik.
            // Tools -> NuGet Package Manager -> Nuget Package Manager Console
            // enable-migrations –EnableAutomaticMigration:$true -Force
            // PM> Update-Database

            SMARTPRO_Context ctx = new SMARTPRO_Context();
            Ogretmen o1 = new Ogretmen();
        }
    }
}
