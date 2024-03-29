using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ana_ekran : Form
    {
        DataTable Uyelerdt;
        public ana_ekran()
        {
            InitializeComponent();
            Uyelerdt = new DataTable();
            Uyelerdt.Columns.Add("isim");
            Uyelerdt.Columns.Add("Soyisim");
            Uyelerdt.Columns.Add("Cinsiyet");
            Uyelerdt.Columns.Add("DogumTarihi");
            Uyelerdt.Columns.Add("Telefon");
            Uyelerdt.Columns.Add("TC");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle form = new UyeEkle();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapEkle form = new KitapEkle();
            form.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            emanet_işlemleri form = new emanet_işlemleri();
            form.Show();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Uye>>(Uye.UyeList);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSon Dosyasi|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                string dosyaYolu = dialog.FileName;
                File.WriteAllText(dosyaYolu, yazilacak, Encoding.UTF8);

            }
        }

        private void yuklebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSon Dosyasi|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                Uye.UyeList = JsonSerializer.Deserialize<List<Uye>>(data);
                foreach (Uye uye in Uye.UyeList)
                {
                    uye.tabloEkle(Uyelerdt);
                }
            }
        }
    }
}
