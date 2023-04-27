
namespace Bilgi_Yarışması
{
    partial class modorator
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modorator));
            this.soru = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soru_sor = new System.Windows.Forms.Button();
            this.meydan_oku = new System.Windows.Forms.Button();
            this.sure = new System.Windows.Forms.Button();
            this.takim1 = new System.Windows.Forms.GroupBox();
            this.takim1_puan = new System.Windows.Forms.Label();
            this.takim1_meydanokuma = new System.Windows.Forms.Button();
            this.takim1_dogru = new System.Windows.Forms.Button();
            this.takim1_yanlis = new System.Windows.Forms.Button();
            this.takim1isim = new System.Windows.Forms.Label();
            this.takim2 = new System.Windows.Forms.GroupBox();
            this.takim2_puan = new System.Windows.Forms.Label();
            this.takim2_meydanokuma = new System.Windows.Forms.Button();
            this.takim2_dogru = new System.Windows.Forms.Button();
            this.takim2_yanlis = new System.Windows.Forms.Button();
            this.takim2isim = new System.Windows.Forms.Label();
            this.takim3 = new System.Windows.Forms.GroupBox();
            this.takim3_puan = new System.Windows.Forms.Label();
            this.takim3_dogru = new System.Windows.Forms.Button();
            this.takim3_meydanokuma = new System.Windows.Forms.Button();
            this.takim3_yanlis = new System.Windows.Forms.Button();
            this.takim3isim = new System.Windows.Forms.Label();
            this.takim4 = new System.Windows.Forms.GroupBox();
            this.takim4_puan = new System.Windows.Forms.Label();
            this.takim4_dogru = new System.Windows.Forms.Button();
            this.takim4_yanlis = new System.Windows.Forms.Button();
            this.takim4_meydanokuma = new System.Windows.Forms.Button();
            this.takim4isim = new System.Windows.Forms.Label();
            this.puanlama_bitir = new System.Windows.Forms.Button();
            this.cevap_goster = new System.Windows.Forms.Button();
            this.soruyu_goster = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_takim1 = new System.Windows.Forms.Label();
            this.label_takim2 = new System.Windows.Forms.Label();
            this.label_takim3 = new System.Windows.Forms.Label();
            this.label_takim4 = new System.Windows.Forms.Label();
            this.takim_olustur = new System.Windows.Forms.Button();
            this.label_soru = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.takim1.SuspendLayout();
            this.takim2.SuspendLayout();
            this.takim3.SuspendLayout();
            this.takim4.SuspendLayout();
            this.SuspendLayout();
            // 
            // soru
            // 
            this.soru.Location = new System.Drawing.Point(32, 853);
            this.soru.Name = "soru";
            this.soru.Size = new System.Drawing.Size(126, 77);
            this.soru.TabIndex = 0;
            this.soru.Text = "Soruları al";
            this.soru.UseVisualStyleBackColor = true;
            this.soru.Visible = false;
            this.soru.Click += new System.EventHandler(this.soru_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 449);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 398);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // soru_sor
            // 
            this.soru_sor.Location = new System.Drawing.Point(1131, 853);
            this.soru_sor.Name = "soru_sor";
            this.soru_sor.Size = new System.Drawing.Size(126, 53);
            this.soru_sor.TabIndex = 2;
            this.soru_sor.Text = "SORU SOR";
            this.soru_sor.UseVisualStyleBackColor = true;
            this.soru_sor.Visible = false;
            this.soru_sor.Click += new System.EventHandler(this.soru_sor_Click);
            // 
            // meydan_oku
            // 
            this.meydan_oku.Location = new System.Drawing.Point(972, 853);
            this.meydan_oku.Name = "meydan_oku";
            this.meydan_oku.Size = new System.Drawing.Size(126, 53);
            this.meydan_oku.TabIndex = 3;
            this.meydan_oku.Text = "MEYDAN OKUMA SORUSU SOR";
            this.meydan_oku.UseVisualStyleBackColor = true;
            this.meydan_oku.Visible = false;
            this.meydan_oku.Click += new System.EventHandler(this.meydan_oku_Click);
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(1054, 65);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(218, 140);
            this.sure.TabIndex = 4;
            this.sure.Text = "button3";
            this.sure.UseVisualStyleBackColor = true;
            this.sure.Visible = false;
            // 
            // takim1
            // 
            this.takim1.Controls.Add(this.takim1_puan);
            this.takim1.Controls.Add(this.takim1_meydanokuma);
            this.takim1.Controls.Add(this.takim1_dogru);
            this.takim1.Controls.Add(this.takim1_yanlis);
            this.takim1.Controls.Add(this.takim1isim);
            this.takim1.Location = new System.Drawing.Point(13, 449);
            this.takim1.Name = "takim1";
            this.takim1.Size = new System.Drawing.Size(282, 333);
            this.takim1.TabIndex = 5;
            this.takim1.TabStop = false;
            this.takim1.Visible = false;
            // 
            // takim1_puan
            // 
            this.takim1_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.takim1_puan.Location = new System.Drawing.Point(6, 107);
            this.takim1_puan.Name = "takim1_puan";
            this.takim1_puan.Size = new System.Drawing.Size(239, 40);
            this.takim1_puan.TabIndex = 4;
            this.takim1_puan.Text = "label5";
            // 
            // takim1_meydanokuma
            // 
            this.takim1_meydanokuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim1_meydanokuma.Location = new System.Drawing.Point(77, 213);
            this.takim1_meydanokuma.Name = "takim1_meydanokuma";
            this.takim1_meydanokuma.Size = new System.Drawing.Size(109, 58);
            this.takim1_meydanokuma.TabIndex = 3;
            this.takim1_meydanokuma.Text = "Meydan okuma";
            this.takim1_meydanokuma.UseVisualStyleBackColor = true;
            this.takim1_meydanokuma.Visible = false;
            this.takim1_meydanokuma.Click += new System.EventHandler(this.takim1_meydanokuma_Click);
            // 
            // takim1_dogru
            // 
            this.takim1_dogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim1_dogru.Location = new System.Drawing.Point(191, 284);
            this.takim1_dogru.Name = "takim1_dogru";
            this.takim1_dogru.Size = new System.Drawing.Size(85, 28);
            this.takim1_dogru.TabIndex = 2;
            this.takim1_dogru.Text = "DOĞRU";
            this.takim1_dogru.UseVisualStyleBackColor = true;
            this.takim1_dogru.Click += new System.EventHandler(this.takim1_dogru_Click);
            // 
            // takim1_yanlis
            // 
            this.takim1_yanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim1_yanlis.Location = new System.Drawing.Point(9, 284);
            this.takim1_yanlis.Name = "takim1_yanlis";
            this.takim1_yanlis.Size = new System.Drawing.Size(83, 28);
            this.takim1_yanlis.TabIndex = 1;
            this.takim1_yanlis.Text = "YANLIŞ";
            this.takim1_yanlis.UseVisualStyleBackColor = true;
            this.takim1_yanlis.Click += new System.EventHandler(this.takim1_yanlis_Click);
            // 
            // takim1isim
            // 
            this.takim1isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.takim1isim.Location = new System.Drawing.Point(6, 26);
            this.takim1isim.Name = "takim1isim";
            this.takim1isim.Size = new System.Drawing.Size(239, 40);
            this.takim1isim.TabIndex = 0;
            this.takim1isim.Text = "label1";
            // 
            // takim2
            // 
            this.takim2.Controls.Add(this.takim2_puan);
            this.takim2.Controls.Add(this.takim2_meydanokuma);
            this.takim2.Controls.Add(this.takim2_dogru);
            this.takim2.Controls.Add(this.takim2_yanlis);
            this.takim2.Controls.Add(this.takim2isim);
            this.takim2.Location = new System.Drawing.Point(330, 450);
            this.takim2.Name = "takim2";
            this.takim2.Size = new System.Drawing.Size(283, 333);
            this.takim2.TabIndex = 6;
            this.takim2.TabStop = false;
            this.takim2.Visible = false;
            // 
            // takim2_puan
            // 
            this.takim2_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.takim2_puan.Location = new System.Drawing.Point(6, 107);
            this.takim2_puan.Name = "takim2_puan";
            this.takim2_puan.Size = new System.Drawing.Size(239, 40);
            this.takim2_puan.TabIndex = 5;
            this.takim2_puan.Text = "label6";
            // 
            // takim2_meydanokuma
            // 
            this.takim2_meydanokuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim2_meydanokuma.Location = new System.Drawing.Point(92, 211);
            this.takim2_meydanokuma.Name = "takim2_meydanokuma";
            this.takim2_meydanokuma.Size = new System.Drawing.Size(109, 59);
            this.takim2_meydanokuma.TabIndex = 6;
            this.takim2_meydanokuma.Text = "Meydan okuma";
            this.takim2_meydanokuma.UseVisualStyleBackColor = true;
            this.takim2_meydanokuma.Visible = false;
            this.takim2_meydanokuma.Click += new System.EventHandler(this.takim2_meydanokuma_Click);
            // 
            // takim2_dogru
            // 
            this.takim2_dogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim2_dogru.Location = new System.Drawing.Point(193, 284);
            this.takim2_dogru.Name = "takim2_dogru";
            this.takim2_dogru.Size = new System.Drawing.Size(84, 28);
            this.takim2_dogru.TabIndex = 5;
            this.takim2_dogru.Text = "DOĞRU";
            this.takim2_dogru.UseVisualStyleBackColor = true;
            this.takim2_dogru.Click += new System.EventHandler(this.takim2_dogru_Click);
            // 
            // takim2_yanlis
            // 
            this.takim2_yanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim2_yanlis.Location = new System.Drawing.Point(9, 284);
            this.takim2_yanlis.Name = "takim2_yanlis";
            this.takim2_yanlis.Size = new System.Drawing.Size(83, 28);
            this.takim2_yanlis.TabIndex = 4;
            this.takim2_yanlis.Text = "YANLIŞ";
            this.takim2_yanlis.UseVisualStyleBackColor = true;
            this.takim2_yanlis.Click += new System.EventHandler(this.takim2_yanlis_Click);
            // 
            // takim2isim
            // 
            this.takim2isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.takim2isim.Location = new System.Drawing.Point(6, 26);
            this.takim2isim.Name = "takim2isim";
            this.takim2isim.Size = new System.Drawing.Size(239, 40);
            this.takim2isim.TabIndex = 1;
            this.takim2isim.Text = "label2";
            // 
            // takim3
            // 
            this.takim3.Controls.Add(this.takim3_puan);
            this.takim3.Controls.Add(this.takim3_dogru);
            this.takim3.Controls.Add(this.takim3_meydanokuma);
            this.takim3.Controls.Add(this.takim3_yanlis);
            this.takim3.Controls.Add(this.takim3isim);
            this.takim3.Location = new System.Drawing.Point(646, 450);
            this.takim3.Name = "takim3";
            this.takim3.Size = new System.Drawing.Size(283, 333);
            this.takim3.TabIndex = 6;
            this.takim3.TabStop = false;
            this.takim3.Visible = false;
            // 
            // takim3_puan
            // 
            this.takim3_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.takim3_puan.Location = new System.Drawing.Point(6, 107);
            this.takim3_puan.Name = "takim3_puan";
            this.takim3_puan.Size = new System.Drawing.Size(239, 40);
            this.takim3_puan.TabIndex = 7;
            this.takim3_puan.Text = "label7";
            // 
            // takim3_dogru
            // 
            this.takim3_dogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim3_dogru.Location = new System.Drawing.Point(189, 284);
            this.takim3_dogru.Name = "takim3_dogru";
            this.takim3_dogru.Size = new System.Drawing.Size(88, 28);
            this.takim3_dogru.TabIndex = 9;
            this.takim3_dogru.Text = "DOĞRU";
            this.takim3_dogru.UseVisualStyleBackColor = true;
            this.takim3_dogru.Click += new System.EventHandler(this.takim3_dogru_Click);
            // 
            // takim3_meydanokuma
            // 
            this.takim3_meydanokuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim3_meydanokuma.Location = new System.Drawing.Point(85, 211);
            this.takim3_meydanokuma.Name = "takim3_meydanokuma";
            this.takim3_meydanokuma.Size = new System.Drawing.Size(109, 59);
            this.takim3_meydanokuma.TabIndex = 8;
            this.takim3_meydanokuma.Text = "Meydan okuma";
            this.takim3_meydanokuma.UseVisualStyleBackColor = true;
            this.takim3_meydanokuma.Visible = false;
            this.takim3_meydanokuma.Click += new System.EventHandler(this.takim3_meydanokuma_Click);
            // 
            // takim3_yanlis
            // 
            this.takim3_yanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim3_yanlis.Location = new System.Drawing.Point(9, 284);
            this.takim3_yanlis.Name = "takim3_yanlis";
            this.takim3_yanlis.Size = new System.Drawing.Size(83, 28);
            this.takim3_yanlis.TabIndex = 7;
            this.takim3_yanlis.Text = "YANLIŞ";
            this.takim3_yanlis.UseVisualStyleBackColor = true;
            this.takim3_yanlis.Click += new System.EventHandler(this.takim3_yanlis_Click);
            // 
            // takim3isim
            // 
            this.takim3isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.takim3isim.Location = new System.Drawing.Point(6, 26);
            this.takim3isim.Name = "takim3isim";
            this.takim3isim.Size = new System.Drawing.Size(239, 40);
            this.takim3isim.TabIndex = 1;
            this.takim3isim.Text = "label3";
            // 
            // takim4
            // 
            this.takim4.Controls.Add(this.takim4_puan);
            this.takim4.Controls.Add(this.takim4_dogru);
            this.takim4.Controls.Add(this.takim4_yanlis);
            this.takim4.Controls.Add(this.takim4_meydanokuma);
            this.takim4.Controls.Add(this.takim4isim);
            this.takim4.Location = new System.Drawing.Point(972, 450);
            this.takim4.Name = "takim4";
            this.takim4.Size = new System.Drawing.Size(283, 333);
            this.takim4.TabIndex = 7;
            this.takim4.TabStop = false;
            this.takim4.Visible = false;
            // 
            // takim4_puan
            // 
            this.takim4_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.takim4_puan.Location = new System.Drawing.Point(6, 107);
            this.takim4_puan.Name = "takim4_puan";
            this.takim4_puan.Size = new System.Drawing.Size(239, 40);
            this.takim4_puan.TabIndex = 10;
            this.takim4_puan.Text = "label8";
            // 
            // takim4_dogru
            // 
            this.takim4_dogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim4_dogru.Location = new System.Drawing.Point(194, 284);
            this.takim4_dogru.Name = "takim4_dogru";
            this.takim4_dogru.Size = new System.Drawing.Size(83, 28);
            this.takim4_dogru.TabIndex = 12;
            this.takim4_dogru.Text = "DOĞRU";
            this.takim4_dogru.UseVisualStyleBackColor = true;
            this.takim4_dogru.Click += new System.EventHandler(this.takim4_dogru_Click);
            // 
            // takim4_yanlis
            // 
            this.takim4_yanlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim4_yanlis.Location = new System.Drawing.Point(9, 284);
            this.takim4_yanlis.Name = "takim4_yanlis";
            this.takim4_yanlis.Size = new System.Drawing.Size(82, 28);
            this.takim4_yanlis.TabIndex = 11;
            this.takim4_yanlis.Text = "YANLIŞ";
            this.takim4_yanlis.UseVisualStyleBackColor = true;
            this.takim4_yanlis.Click += new System.EventHandler(this.takim4_yanlis_Click);
            // 
            // takim4_meydanokuma
            // 
            this.takim4_meydanokuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.takim4_meydanokuma.Location = new System.Drawing.Point(92, 211);
            this.takim4_meydanokuma.Name = "takim4_meydanokuma";
            this.takim4_meydanokuma.Size = new System.Drawing.Size(109, 59);
            this.takim4_meydanokuma.TabIndex = 10;
            this.takim4_meydanokuma.Text = "Meydan okuma";
            this.takim4_meydanokuma.UseVisualStyleBackColor = true;
            this.takim4_meydanokuma.Visible = false;
            this.takim4_meydanokuma.Click += new System.EventHandler(this.takim4_meydanokuma_Click);
            // 
            // takim4isim
            // 
            this.takim4isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.takim4isim.Location = new System.Drawing.Point(6, 26);
            this.takim4isim.Name = "takim4isim";
            this.takim4isim.Size = new System.Drawing.Size(239, 40);
            this.takim4isim.TabIndex = 2;
            this.takim4isim.Text = "label4";
            // 
            // puanlama_bitir
            // 
            this.puanlama_bitir.Location = new System.Drawing.Point(1123, 789);
            this.puanlama_bitir.Name = "puanlama_bitir";
            this.puanlama_bitir.Size = new System.Drawing.Size(126, 53);
            this.puanlama_bitir.TabIndex = 8;
            this.puanlama_bitir.Text = "Puanlamayı bitir";
            this.puanlama_bitir.UseVisualStyleBackColor = true;
            this.puanlama_bitir.Visible = false;
            this.puanlama_bitir.Click += new System.EventHandler(this.puanlama_bitir_Click);
            // 
            // cevap_goster
            // 
            this.cevap_goster.Location = new System.Drawing.Point(972, 789);
            this.cevap_goster.Name = "cevap_goster";
            this.cevap_goster.Size = new System.Drawing.Size(126, 53);
            this.cevap_goster.TabIndex = 9;
            this.cevap_goster.Text = "Cevabı göster";
            this.cevap_goster.UseVisualStyleBackColor = true;
            this.cevap_goster.Visible = false;
            this.cevap_goster.Click += new System.EventHandler(this.cevap_goster_Click);
            // 
            // soruyu_goster
            // 
            this.soruyu_goster.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.soruyu_goster.Location = new System.Drawing.Point(295, 460);
            this.soruyu_goster.Name = "soruyu_goster";
            this.soruyu_goster.Size = new System.Drawing.Size(677, 323);
            this.soruyu_goster.TabIndex = 10;
            this.soruyu_goster.Text = "SEYİRCİYE SORUYU GÖSTER";
            this.soruyu_goster.UseVisualStyleBackColor = true;
            this.soruyu_goster.Visible = false;
            this.soruyu_goster.Click += new System.EventHandler(this.soruyu_goster_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(301, 481);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 32);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox2.Location = new System.Drawing.Point(301, 545);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 32);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox3.Location = new System.Drawing.Point(301, 609);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 32);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox4.Location = new System.Drawing.Point(301, 673);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(252, 32);
            this.textBox4.TabIndex = 8;
            // 
            // label_takim1
            // 
            this.label_takim1.AutoSize = true;
            this.label_takim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_takim1.Location = new System.Drawing.Point(302, 452);
            this.label_takim1.Name = "label_takim1";
            this.label_takim1.Size = new System.Drawing.Size(158, 26);
            this.label_takim1.TabIndex = 8;
            this.label_takim1.Text = "1. Takımın ismi";
            // 
            // label_takim2
            // 
            this.label_takim2.AutoSize = true;
            this.label_takim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_takim2.Location = new System.Drawing.Point(301, 516);
            this.label_takim2.Name = "label_takim2";
            this.label_takim2.Size = new System.Drawing.Size(158, 26);
            this.label_takim2.TabIndex = 9;
            this.label_takim2.Text = "2. Takımın ismi";
            // 
            // label_takim3
            // 
            this.label_takim3.AutoSize = true;
            this.label_takim3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_takim3.Location = new System.Drawing.Point(301, 580);
            this.label_takim3.Name = "label_takim3";
            this.label_takim3.Size = new System.Drawing.Size(158, 26);
            this.label_takim3.TabIndex = 10;
            this.label_takim3.Text = "3. Takımın ismi";
            // 
            // label_takim4
            // 
            this.label_takim4.AutoSize = true;
            this.label_takim4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_takim4.Location = new System.Drawing.Point(301, 644);
            this.label_takim4.Name = "label_takim4";
            this.label_takim4.Size = new System.Drawing.Size(158, 26);
            this.label_takim4.TabIndex = 11;
            this.label_takim4.Text = "4. Takımın ismi";
            // 
            // takim_olustur
            // 
            this.takim_olustur.Location = new System.Drawing.Point(301, 824);
            this.takim_olustur.Name = "takim_olustur";
            this.takim_olustur.Size = new System.Drawing.Size(126, 53);
            this.takim_olustur.TabIndex = 12;
            this.takim_olustur.Text = "TAKIMLARI OLUŞTUR";
            this.takim_olustur.UseVisualStyleBackColor = true;
            this.takim_olustur.Click += new System.EventHandler(this.takim_olustur_Click);
            // 
            // label_soru
            // 
            this.label_soru.AutoSize = true;
            this.label_soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_soru.Location = new System.Drawing.Point(35, 65);
            this.label_soru.Name = "label_soru";
            this.label_soru.Size = new System.Drawing.Size(115, 26);
            this.label_soru.TabIndex = 13;
            this.label_soru.Text = "İLK SORU";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // modorator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilgi_Yarışması.Properties.Resources.BİLGİ_YARIŞMASI_1260920;
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.label_soru);
            this.Controls.Add(this.takim_olustur);
            this.Controls.Add(this.soruyu_goster);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label_takim4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cevap_goster);
            this.Controls.Add(this.label_takim3);
            this.Controls.Add(this.puanlama_bitir);
            this.Controls.Add(this.label_takim2);
            this.Controls.Add(this.takim4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_takim1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.takim3);
            this.Controls.Add(this.takim2);
            this.Controls.Add(this.takim1);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.meydan_oku);
            this.Controls.Add(this.soru_sor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.soru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modorator";
            this.Text = "MODORATÖR EKRANI";
            this.Load += new System.EventHandler(this.modorator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.takim1.ResumeLayout(false);
            this.takim2.ResumeLayout(false);
            this.takim3.ResumeLayout(false);
            this.takim4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button soru;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button soru_sor;
        private System.Windows.Forms.Button meydan_oku;
        private System.Windows.Forms.Button sure;
        private System.Windows.Forms.GroupBox takim1;
        private System.Windows.Forms.Label takim1_puan;
        private System.Windows.Forms.Button takim1_meydanokuma;
        private System.Windows.Forms.Button takim1_dogru;
        private System.Windows.Forms.Button takim1_yanlis;
        private System.Windows.Forms.Label takim1isim;
        private System.Windows.Forms.GroupBox takim2;
        private System.Windows.Forms.Label takim2_puan;
        private System.Windows.Forms.Button takim2_meydanokuma;
        private System.Windows.Forms.Button takim2_dogru;
        private System.Windows.Forms.Button takim2_yanlis;
        private System.Windows.Forms.Label takim2isim;
        private System.Windows.Forms.GroupBox takim3;
        private System.Windows.Forms.Label takim3_puan;
        private System.Windows.Forms.Button takim3_dogru;
        private System.Windows.Forms.Button takim3_yanlis;
        private System.Windows.Forms.Label takim3isim;
        private System.Windows.Forms.GroupBox takim4;
        private System.Windows.Forms.Label takim4_puan;
        private System.Windows.Forms.Button takim4_dogru;
        private System.Windows.Forms.Button takim4_yanlis;
        private System.Windows.Forms.Button takim4_meydanokuma;
        private System.Windows.Forms.Label takim4isim;
        private System.Windows.Forms.Button puanlama_bitir;
        private System.Windows.Forms.Button cevap_goster;
        private System.Windows.Forms.Button soruyu_goster;
        private System.Windows.Forms.Label label_takim4;
        private System.Windows.Forms.Label label_takim3;
        private System.Windows.Forms.Label label_takim2;
        private System.Windows.Forms.Label label_takim1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button takim_olustur;
        private System.Windows.Forms.Label label_soru;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button takim3_meydanokuma;
    }
}

