
namespace Bilgi_Yarışması
{
    partial class yarismaci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yarismaci));
            this.secenekA = new System.Windows.Forms.Label();
            this.secenekC = new System.Windows.Forms.Label();
            this.secenekB = new System.Windows.Forms.Label();
            this.secenekD = new System.Windows.Forms.Label();
            this.soru = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // secenekA
            // 
            this.secenekA.AutoSize = true;
            this.secenekA.BackColor = System.Drawing.Color.Transparent;
            this.secenekA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.secenekA.Location = new System.Drawing.Point(188, 757);
            this.secenekA.Name = "secenekA";
            this.secenekA.Size = new System.Drawing.Size(108, 26);
            this.secenekA.TabIndex = 0;
            this.secenekA.Text = "secenekA";
            // 
            // secenekC
            // 
            this.secenekC.AutoSize = true;
            this.secenekC.BackColor = System.Drawing.Color.Transparent;
            this.secenekC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.secenekC.Location = new System.Drawing.Point(188, 858);
            this.secenekC.Name = "secenekC";
            this.secenekC.Size = new System.Drawing.Size(70, 26);
            this.secenekC.TabIndex = 1;
            this.secenekC.Text = "label1";
            // 
            // secenekB
            // 
            this.secenekB.AutoSize = true;
            this.secenekB.BackColor = System.Drawing.Color.Transparent;
            this.secenekB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.secenekB.Location = new System.Drawing.Point(811, 757);
            this.secenekB.Name = "secenekB";
            this.secenekB.Size = new System.Drawing.Size(70, 26);
            this.secenekB.TabIndex = 2;
            this.secenekB.Text = "label2";
            // 
            // secenekD
            // 
            this.secenekD.AutoSize = true;
            this.secenekD.BackColor = System.Drawing.Color.Transparent;
            this.secenekD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.secenekD.Location = new System.Drawing.Point(811, 858);
            this.secenekD.Name = "secenekD";
            this.secenekD.Size = new System.Drawing.Size(70, 26);
            this.secenekD.TabIndex = 3;
            this.secenekD.Text = "label3";
            // 
            // soru
            // 
            this.soru.BackColor = System.Drawing.Color.Transparent;
            this.soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.soru.Location = new System.Drawing.Point(169, 487);
            this.soru.Name = "soru";
            this.soru.Size = new System.Drawing.Size(930, 172);
            this.soru.TabIndex = 4;
            this.soru.Text = "label1";
            // 
            // sure
            // 
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.sure.Location = new System.Drawing.Point(1038, 76);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(207, 123);
            this.sure.TabIndex = 5;
            this.sure.Text = "KALAN SÜRE : 60";
            this.sure.UseVisualStyleBackColor = true;
            // 
            // yarismaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bilgi_Yarışması.Properties.Resources.bilgi_yarışması_sorulu1280_960;
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.soru);
            this.Controls.Add(this.secenekD);
            this.Controls.Add(this.secenekB);
            this.Controls.Add(this.secenekC);
            this.Controls.Add(this.secenekA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yarismaci";
            this.Text = "yarismaci";
            this.Load += new System.EventHandler(this.yarismaci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secenekA;
        private System.Windows.Forms.Label secenekC;
        private System.Windows.Forms.Label secenekB;
        private System.Windows.Forms.Label secenekD;
        private System.Windows.Forms.Label soru;
        private System.Windows.Forms.Button sure;
        private System.Windows.Forms.Timer timer1;
    }
}