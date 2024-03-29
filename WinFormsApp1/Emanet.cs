using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Emanet
    {
        public string AlanKisiIsim {  get; set; }
        public string AlanKisiSoyisim {  get; set; }
        public int AlanKisiTC {  get; set; }
        public int AlanKisiTelefon { get; set; }
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }
        public int TeslimSuresi { get; set; }

        public Emanet() { }
        public void tabloEkle(DataTable dt)
        {
            dt.Rows.Add(new Object[] { AlanKisiIsim , AlanKisiSoyisim, AlanKisiTC , AlanKisiTelefon
                                       ,KitapAdi,KitapYazari,TeslimSuresi });
        }


    }
}
