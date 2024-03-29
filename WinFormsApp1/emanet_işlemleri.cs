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
    public partial class emanet_işlemleri : Form
    {
        public emanet_işlemleri()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void emanet_işlemleri_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //AlanKisiIsim , AlanKisiSoyisim, AlanKisiTC , AlanKisiTelefon
                                      //A ,KitapAdi,KitapYazari,TeslimSuresi
            Emanet emanet = new Emanet();
            emanet.AlanKisiIsim = textBox1.Text;
            emanet.TeslimSuresi = Convert.ToInt32(textBox4.Text);
            emanet.AlanKisiTC= Convert.ToInt32(textBox5.Text);

            Emanet.Emanetlist.Add(emanet);

        }
    }
}
