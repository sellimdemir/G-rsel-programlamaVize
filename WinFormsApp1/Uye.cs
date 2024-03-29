using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Uye
    {
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Cinsiyet { get; set; }
        public int dogumTarihi { get; set; }
        public int Telefon {  get; set; }
        public int TC { get; set; } 

        public Uye() { }
        public void tabloEkle(DataTable dt)
        {
            dt.Rows.Add(new Object[] { Adi, Soyadi,Cinsiyet,dogumTarihi,Telefon,TC }) ;
        }

    }
}
