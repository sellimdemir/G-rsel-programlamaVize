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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void butonEkleUye_Click(object sender, EventArgs e)
        {
            Uye uye=new Uye();
            uye.Adi = textBox1.Text;
            uye.Soyadi = textBox2.Text;
            uye.dogumTarihi = Convert.ToInt32(textBox3.Text);
            uye.Telefon=Convert.ToInt32(textBox4.Text);
            uye.TC=Convert.ToInt32(textBox5.Text);

            Uye.UyeList.Add(uye);

        }
    }
}
