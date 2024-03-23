using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ana_ekran : Form
    {
        public ana_ekran()
        {
            InitializeComponent();
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
            emanet_işlemleri form =new emanet_işlemleri();
            form.Show();
        }
    }
}
