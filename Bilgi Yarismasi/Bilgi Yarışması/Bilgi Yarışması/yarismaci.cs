using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class yarismaci : Form
    {
        int dogru_secenek = new int();
        List<string> list = new List<string>();
        public yarismaci()
        {
            InitializeComponent();
        }

        private void yarismaci_Load(object sender, EventArgs e)
        {
            ekranitemizle();
        }
        public void ekranigetir(bool secenek)
        {
            sure.Visible = true; 
            soru.Visible = true;
            secenekA.Visible = secenek;
            secenekB.Visible = secenek;
            secenekC.Visible = secenek;
            secenekD.Visible = secenek;
        }
        public void ekranitemizle()
        {
            sure.Visible = false;
            soru.Visible = false;
            secenekA.Visible = false;
            secenekB.Visible = false;
            secenekC.Visible = false;
            secenekD.Visible = false;
        }
        public void soru_sor(string soru_, string cevap1, string cevap2, string cevap3, string cevap4, ref int dogru,bool secenek= true)
        {
            ekranigetir(secenek);
            Soru_yaz(soru_, cevap1, cevap2, cevap3, cevap4);
            dogru = dogru_secenek;
        }
        public void sayac(string a)
        {
            sure.Text = a;
        }
        public List<string> secenek_dondur(List<string> cevap)
        {
            Random rnd = new Random();
            List<String> secenek = new List<string>();
            int x = new int();
            for (int i = 0; i < 4; i++)
            {
                x = rnd.Next(0, cevap.Count);
                secenek.Add(cevap[x]);
                cevap.RemoveAt(x);
            }
            return secenek;
        }
        public void Soru_yaz(string a, string b, string c, string d, string e)
        {
            List<string> cevap = new List<string>();
            cevap.Add(b);
            cevap.Add(c);
            cevap.Add(d);
            cevap.Add(e);
            list = secenek_dondur(cevap);
            soru.Text = a;
            secenekA.Text = list[0];
            secenekB.Text = list[1];
            secenekC.Text = list[2];
            secenekD.Text = list[3];
            int i = 0;
            foreach (string text in list)
            {
                if (b == text)
                {
                    dogru_secenek = i;
                }
                else
                {
                    i++;
                }
            }
        }
        public List<string> secenek_al()
        {
            return list;
        }
    }
}
