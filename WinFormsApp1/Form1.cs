using System.Data;

namespace WinFormsApp1
{
    public partial class KitapEkle : Form
    {
        DataTable kitaplardt;
        public KitapEkle()
        {
            InitializeComponent();
            kitaplardt = new DataTable();
            //Kitapismi, Yazari, sayfaSayisi, SeriNo
            kitaplardt.Columns.Add("kitap ismi");
            kitaplardt.Columns.Add("yazari");
            kitaplardt.Columns.Add("sayfa Sayisi");
            kitaplardt.Columns.Add("Seri No");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.Kitapismi=textBox2.Text;
            kitap.Yazari=textBox1.Text;
            kitap.sayfaSayisi =Convert.ToInt32(textBox3.Text);
            kitap.SeriNo=Convert.ToInt32(textBox5.Text);

            Kitap.KitapList.Add(kitap);
        }
    }
}
