using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bilgi_Yarışması
{
    public partial class modorator : Form
    {
        public modorator()
        {
            InitializeComponent();
        }
        private void modorator_Load(object sender, EventArgs e)
        {
            Yarismaci.Show();
            Seyirci.Show();
        }
        #region değişkenler
        int soru_sayisi = 0;
        int sayac = 0;
        int dogru = 0;
        int t1d, t1y, t2d, t2y, t3d, t3y, t4d, t4y;
        bool meydanokuma=false;
        Takim[] Takimlar = new Takim[4];
        Takim takim_1 = new Takim();
        Takim takim_2 = new Takim();
        Takim takim_3 = new Takim();
        Takim takim_4 = new Takim();
        yarismaci Yarismaci = new yarismaci();
        seyirci Seyirci = new seyirci();
        string soru_,cevap1, cevap2, cevap3, cevap4, sira1, sira2, sira3, sira4;
        #endregion
        #region butonlar
        #region diğer tuşlar
        private void puanlama_bitir_Click(object sender, EventArgs e)
        {
            sorusecmeekraniac();
            puanekraninikapat();
            Seyirci.soru_ekrani_kapat();
        }
        private void takim_olustur_Click(object sender, EventArgs e)
        {
            takim_1.isim(textBox1.Text);
            takim_2.isim(textBox2.Text);
            takim_3.isim(textBox3.Text);
            takim_4.isim(textBox4.Text);
            takim_olustur.Visible = false;
            label_takim1.Visible = false;
            label_takim2.Visible = false;
            label_takim3.Visible = false;
            label_takim4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            Takimleri_ekle();
            soru.Visible = true;
        }
        private void soru_Click(object sender, EventArgs e)
        {
            Soru_dosyasi();
            soru.Visible = false;
            sorusecmeekraniac();
            //InitializeDataGridView();
        }
        private void soru_sor_Click(object sender, EventArgs e)
        {
            meydanokuma = false;
            pozitifpuan();
            negatifpuan();
            sorusecmeekranikapat();
            soru_sayisi++;
            string sayi = Convert.ToString(soru_sayisi) + ". Soru";
            label_soru.Text = sayi;
            Soru_yaz();
            Siralama();
            Seyirci.sure_ac();
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dataGridView1.Rows.RemoveAt(selectedIndex);
                dataGridView1.Refresh();
            }
            sayac = 45;
            timer1.Start();
            Yarismaci.soru_sor("Soru : "+Convert.ToString(soru_sayisi)+")\n"+soru_, cevap1, cevap2, cevap3, cevap4, ref dogru);//, sira1, sira2, sira3, sira4
            Seyirci.soru_("Soru : " + Convert.ToString(soru_sayisi) + ")\n" + soru_, Yarismaci.secenek_al(), cevap_());
            Seyirci.siralama_(sira1, sira2, sira3, sira4);
        }
        private void meydan_oku_Click(object sender, EventArgs e)
        {
            meydanokuma = true;
            pozitifpuan();
            negatifpuan();
            sorusecmeekranikapat();
            soru_sayisi++;
            string sayi = Convert.ToString(soru_sayisi) + ". Soru";
            label_soru.Text = sayi;
            Soru_yaz();
            Siralama();
            Seyirci.sure_ac();
            takim1_meydanokuma.Visible = true;
            takim2_meydanokuma.Visible = true;
            takim3_meydanokuma.Visible = true;
            takim4_meydanokuma.Visible = true;
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dataGridView1.Rows.RemoveAt(selectedIndex);
                dataGridView1.Refresh();
            }
            sayac = 60;
            timer1.Start();
            Yarismaci.soru_sor("Soru : " + Convert.ToString(soru_sayisi) + ")\n" + soru_, cevap1, cevap2, cevap3, cevap4, ref dogru,false);//, sira1, sira2, sira3, sira4
            Seyirci.soru_("Soru : " + Convert.ToString(soru_sayisi) + ")\n" + soru_, Yarismaci.secenek_al(), cevap_(),true);
            Seyirci.siralama_(sira1, sira2, sira3, sira4);
        }
        #region seyirci
        private void soruyu_goster_Click(object sender, EventArgs e)
        {
            siralama_yaz();
            puanekraniniac();
            Seyirci.soru_ekrani_ac(true);//!meydanokuma);
            soruyu_goster.Visible = false;
        }
        private void cevap_goster_Click(object sender, EventArgs e)
        {
            Seyirci.cevap_goster();
        }
        #endregion
        #endregion
        #region puan tuşları
        private void takim1_dogru_Click(object sender, EventArgs e)
        {
            takim_1.puan_ekle(t1d);Siralama();Seyirci.siralama_(sira1, sira2, sira3, sira4);
            takim1_puan.Text = "Puan : "+Convert.ToString(takim_1.puan_());
        }

        private void takim1_yanlis_Click(object sender, EventArgs e)
        {

            takim_1.puan_ekle(t1y);Siralama();Seyirci.siralama_(sira1, sira2, sira3, sira4);
            takim1_puan.Text = "Puan : "+Convert.ToString(takim_1.puan_());
        }

        private void takim1_meydanokuma_Click(object sender, EventArgs e)
        {
            takim1_meydanokuma.Visible = false;
            t1y = -10;
            t1d = 30;
        }

        private void takim2_dogru_Click(object sender, EventArgs e)
        {
            takim_2.puan_ekle(t2d);Siralama();Seyirci.siralama_(sira1, sira2, sira3, sira4);
            takim2_puan.Text = "Puan : "+Convert.ToString(takim_2.puan_());
        }

        private void takim2_yanlis_Click(object sender, EventArgs e)
        {

            takim_2.puan_ekle(t2y);Siralama();Seyirci.siralama_(sira1, sira2, sira3, sira4);
            takim2_puan.Text = "Puan : "+Convert.ToString(takim_2.puan_());
        }

        private void takim2_meydanokuma_Click(object sender, EventArgs e)
        {
            takim2_meydanokuma.Visible = false;
            t2y = -10;
            t2d = 30;
        }

        private void takim3_dogru_Click(object sender, EventArgs e)
        {
            takim_3.puan_ekle(t3d);Siralama();Seyirci.siralama_(sira1, sira2, sira3, sira4);
            takim3_puan.Text = "Puan : "+Convert.ToString(takim_3.puan_());
        }

        private void takim3_yanlis_Click(object sender, EventArgs e)
        {

            takim_3.puan_ekle(t3y);Siralama();Seyirci.siralama_(sira1, sira2, sira3, sira4);
            takim3_puan.Text = "Puan : "+Convert.ToString(takim_3.puan_());
        }

        private void takim3_meydanokuma_Click(object sender, EventArgs e)
        {
            takim3_meydanokuma.Visible = false;
            t3y = -10;
            t3d = 30;
        }

        private void takim4_dogru_Click(object sender, EventArgs e)
        {
            takim_4.puan_ekle(t4d);Siralama();Seyirci.siralama_(sira1, sira2, sira3, sira4);
            takim4_puan.Text = "Puan : "+Convert.ToString(takim_4.puan_());
        }

        private void takim4_yanlis_Click(object sender, EventArgs e)
        {

            takim_4.puan_ekle(t4y);Siralama();Seyirci.siralama_(sira1, sira2, sira3, sira4);
            takim4_puan.Text = "Puan : "+Convert.ToString(takim_4.puan_());
        }

        private void takim4_meydanokuma_Click(object sender, EventArgs e)
        {
            takim4_meydanokuma.Visible = false;
            t4y = -10;
            t4d = 30;
        }
        #endregion
        #endregion
        #region datagrid
        public void Soru_dosyasi()
        {
            OpenFileDialog soru_file = new OpenFileDialog();
            soru_file.Filter = "Excel Dosyası |*.xlsx";
            soru_file.ShowDialog();
            string sorudosyasi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + soru_file.FileName + ";Extended Properties='Excel 12.0;IMEX=1;'";
            OleDbConnection baglanti_soru = new OleDbConnection(sorudosyasi);
            baglanti_soru.Open();
            OleDbCommand komut = new OleDbCommand("Select * From [" + "Sayfa1" + "$]", baglanti_soru);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridView1.DataSource = data;
        }
        private void InitializeDataGridView()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }
        #endregion
        #region ekranlar
        private void sorusecmeekraniac()
        {
            dataGridView1.Visible = true;
            soru_sor.Visible = true;
            if (soru_sayisi == 7 || soru_sayisi == 8 || soru_sayisi == 9)
            {
                meydan_oku.Visible = true;
            }
        }
        private void sorusecmeekranikapat()
        {
            dataGridView1.Visible = false;
            soru_sor.Visible = false;
            meydan_oku.Visible = false;
        }
        private void puanekraninikapat()
        {
            takim1.Visible = false;
            takim2.Visible = false;
            takim3.Visible = false;
            takim4.Visible = false;
            puanlama_bitir.Visible = false;
            cevap_goster.Visible = false;
        }
        private void puanekraniniac()
        {
            takim1.Visible = true;
            takim2.Visible = true;
            takim3.Visible = true;
            takim4.Visible = true;
            puanlama_bitir.Visible = true;
            cevap_goster.Visible = true;
            takim1isim.Text = takim_1.isim();
            takim1_puan.Text = "Puan : " + takim_1.puan_();
            takim2isim.Text = takim_2.isim();
            takim2_puan.Text = "Puan : " + takim_2.puan_();
            takim3isim.Text = takim_3.isim();
            takim3_puan.Text = "Puan : " + takim_3.puan_();
            takim4isim.Text = takim_4.isim();
            takim4_puan.Text = "Puan : " + takim_4.puan_();
        }
        #endregion
        #region yarışma fonkisyonları
        // Soruları data gridden okumayı sağlayan program;
        public void Soru_yaz()
        {
            soru_ = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cevap1 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cevap2 = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cevap3 = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cevap4 = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void Takimleri_ekle()
        {
            Takimlar[0] = takim_4;
            Takimlar[1] = takim_3;
            Takimlar[2] = takim_2;
            Takimlar[3] = takim_1;
        }
        public void Siralama()
        {
            Takim temp = new Takim();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (Takimlar[j].puan_() > Takimlar[i].puan_())
                    {
                        temp = Takimlar[i];
                        Takimlar[i] = Takimlar[j];
                        Takimlar[j] = temp;
                    }
                }
            }
            sira1 = "1. " + Takimlar[0].isim() + " takımı " + Convert.ToString(Takimlar[0].puan_()) + " puan";
            sira2 = "2. " + Takimlar[1].isim() + " takımı " + Convert.ToString(Takimlar[1].puan_()) + " puan";
            sira3 = "3. " + Takimlar[2].isim() + " takımı " + Convert.ToString(Takimlar[2].puan_()) + " puan";
            sira4 = "4. " + Takimlar[3].isim() + " takımı " + Convert.ToString(Takimlar[3].puan_()) + " puan";
        }
        public void siralama_yaz()
        {
            Siralama();
            label_takim1.Text = sira1;
            label_takim2.Text = sira2;
            label_takim3.Text = sira3;
            label_takim4.Text = sira4;
            //Seyirci.Siralama(sira1, sira2, sira3, sira4);
        }
        private string cevap_()
        {
            string c;
            switch (dogru)
            {
                case 0: c = "A"; break;
                case 1: c = "B"; break;
                case 2: c = "C"; break;
                case 3: c = "D"; break;
                default: c = ""; break;
            }
            return c;
        }
        private void pozitifpuan()
        {
            t1d = 10;
            t2d = 10;
            t3d = 10;
            t4d = 10;
        }
        private void negatifpuan()
        {
            t1y = 0;
            t2y = 0;
            t3y = 0;
            t4y = 0;
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure.Visible = true;
            sure.Text = "KALAN SÜRE : " + Convert.ToString(sayac);
            Yarismaci.sayac("KALAN SÜRE : " + Convert.ToString(sayac));
            Seyirci.sayac("KALAN SÜRE : " + Convert.ToString(sayac));
            if (sayac==0)
            {
                sure.Visible = false;
                timer1.Stop();
                Yarismaci.ekranitemizle();
                soruyu_goster.Visible=true;

            }
            timer1.Interval = 10;
            sayac--;
        }
        
    }
}
