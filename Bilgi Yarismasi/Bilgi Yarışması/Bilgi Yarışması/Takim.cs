using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Yarışması
{
    class Takim
    {
        private string ad;
        private int puan=0;
        public void isim(string x)
        {
            ad = x;
        }
        public string isim()
        {
            return ad;
        }
        public int puan_()
        {
            return puan;
        }
        public void puan_ekle(int x)
        {
            puan += x;
        }
    }
}
