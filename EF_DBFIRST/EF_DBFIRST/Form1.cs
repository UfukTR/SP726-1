using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DBFIRST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabloGuncelle();
        }

        private void TabloGuncelle()
        {
            SINEMAEntities sinema_context = new SINEMAEntities();

            dataGridView1.DataSource = sinema_context.Films.ToList();
        }

        private void button_FilmKaydet_Click(object sender, EventArgs e)
        {
            SINEMAEntities sinema_ctx = new SINEMAEntities();

            Film film1 = new Film();

            film1.FilmAdi = textBox_FilmAdi.Text;
            film1.FilmKisaBilgi = textBox_FilmKB.Text;
            film1.FilmFragmanLink = textBox1_Fragman.Text;

            sinema_ctx.Films.Add(film1);
            sinema_ctx.SaveChanges();
            TabloGuncelle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_FilmAdi.Text = dataGridView1.CurrentRow.Cells["FilmAdi"].Value.ToString();
            textBox_FilmKB.Text = dataGridView1.CurrentRow.Cells["FilmKisaBilgi"].Value.ToString();
            textBox1_Fragman.Text = dataGridView1.CurrentRow.Cells["FilmFragmanLink"].Value.ToString();
            textBox_FilmAdi.Tag = dataGridView1.CurrentRow.Cells["FilmID"].Value;
        }

        private void button_FilmGuncelle_Click(object sender, EventArgs e)
        {
            SINEMAEntities ctx = new SINEMAEntities();

            Film film1 = new Film();

            int ID = Convert.ToInt32(textBox_FilmAdi.Tag);

            film1 = ctx.Films.Find(ID);


            film1.FilmAdi = textBox_FilmAdi.Text;
            film1.FilmKisaBilgi = textBox_FilmKB.Text;
            film1.FilmFragmanLink = textBox1_Fragman.Text;

            ctx.SaveChanges();
            TabloGuncelle();
        }

        private void button_FilmSil_Click(object sender, EventArgs e)
        {
            SINEMAEntities ctx = new SINEMAEntities();

            Film film1 = new Film();

            int ID = Convert.ToInt32(textBox_FilmAdi.Tag);

            film1 = ctx.Films.Find(ID);

            ctx.Films.Remove(film1);
            ctx.SaveChanges();

            TabloGuncelle();
            
        }
    }
}
