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
    public partial class seyirci : Form
    {
        bool meydanokuma=false;
        public seyirci()
        {
            InitializeComponent();
            soru_ekrani_kapat();
        }

        private void seyirci_Load(object sender, EventArgs e)
        {

        }
        public void sure_ac()
        {
            sure.Visible = true;
        }
        public void siralama_(string a, string b, string c,string d)
        {
            label1.Text = a;
            label2.Text = b;
            label3.Text = c;
            label4.Text = d;
        }
        public void soru_(string soru_, List<string> list , string cevap_,bool meydanokuma_=false)
        {
            soru.Text = soru_;
            secenekA.Text = list[0];
            secenekB.Text = list[1];
            secenekC.Text = list[2];
            secenekD.Text = list[3];
            cevap.Text = cevap_;
            meydanokuma = meydanokuma_;
        }
        public void soru_ekrani_ac(bool secenek=true)
        {
            if (meydanokuma == false)
            {
                siralama.Visible = true;
                soru.Visible = true;
                secenekA.Visible = secenek;
                secenekB.Visible = secenek;
                secenekC.Visible = secenek;
                secenekD.Visible = secenek;
                cevap.Visible = false;
                sure.Visible = false;
            }
            else
            {

                siralama.Visible = true;
                soru.Visible = true;
                if (cevap.Text == "A")
                {
                    secenekA.Visible = secenek;
                }
                else if (cevap.Text == "B")
                {
                    secenekB.Visible = secenek;
                }
                else if (cevap.Text == "C")
                {
                    secenekC.Visible = secenek;
                }
                else if (cevap.Text == "D")
                {
                    secenekD.Visible = secenek;
                }
                cevap.Visible = false;
                sure.Visible = false;
            }
        }
        public void soru_ekrani_kapat()
        {
            siralama.Visible = false;
            soru.Visible = false;
            secenekA.Visible = false;
            secenekB.Visible = false;
            secenekC.Visible = false;
            secenekD.Visible = false;
            cevap.Visible = false;
            sure.Visible = false;
        }
        public void cevap_goster()
        {
            cevap.Visible = true;
        }
        internal void sayac(string sayac)
        {
            sure.Text=sayac;
        }
    }
}
