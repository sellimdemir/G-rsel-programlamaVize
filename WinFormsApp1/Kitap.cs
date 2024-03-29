using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Kitap
    {

        public string Kitapismi { get; set; }
        public string Yazari {  get; set; }
        public int sayfaSayisi {  get; set; }
        public int SeriNo {  get; set; }

        public Kitap() { }
        public void tabloEkle(DataTable dt)
        {
            dt.Rows.Add(new Object[] { Kitapismi, Yazari, sayfaSayisi, SeriNo });
        }
    }
}
