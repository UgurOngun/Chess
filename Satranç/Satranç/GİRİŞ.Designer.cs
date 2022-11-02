namespace Satranç
{
    partial class GİRİŞ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GİRİŞ));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Kayit_Form = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Kaydol_Ekrani = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Giris = new System.Windows.Forms.Button();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.Kullanici_Adi_Eposta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATRANÇ OYUNUNA HOŞ GELDİN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.Kayit_Form);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.Kaydol_Ekrani);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.Giris);
            this.groupBox1.Controls.Add(this.Sifre);
            this.groupBox1.Controls.Add(this.Kullanici_Adi_Eposta);
            this.groupBox1.Location = new System.Drawing.Point(269, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 300);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Kayit_Form
            // 
            this.Kayit_Form.Location = new System.Drawing.Point(130, 260);
            this.Kayit_Form.Name = "Kayit_Form";
            this.Kayit_Form.Size = new System.Drawing.Size(85, 23);
            this.Kayit_Form.TabIndex = 14;
            this.Kayit_Form.Text = "Kaydol";
            this.Kayit_Form.UseVisualStyleBackColor = true;
            this.Kayit_Form.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Kaydol_Ekrani
            // 
            this.Kaydol_Ekrani.BackColor = System.Drawing.Color.Teal;
            this.Kaydol_Ekrani.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Kaydol_Ekrani.Location = new System.Drawing.Point(20, 208);
            this.Kaydol_Ekrani.Name = "Kaydol_Ekrani";
            this.Kaydol_Ekrani.Size = new System.Drawing.Size(195, 37);
            this.Kaydol_Ekrani.TabIndex = 7;
            this.Kaydol_Ekrani.Text = "Şifreni mi unuttun?";
            this.Kaydol_Ekrani.UseVisualStyleBackColor = false;
            this.Kaydol_Ekrani.Click += new System.EventHandler(this.Kaydol_Ekrani_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hesabın yok mu?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 139);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Beni hatırla";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Giris
            // 
            this.Giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Giris.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Giris.Location = new System.Drawing.Point(20, 162);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(195, 40);
            this.Giris.TabIndex = 7;
            this.Giris.Text = "GİRİŞ";
            this.Giris.UseVisualStyleBackColor = false;
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(46, 103);
            this.Sifre.Name = "Sifre";
            this.Sifre.PasswordChar = '*';
            this.Sifre.Size = new System.Drawing.Size(169, 20);
            this.Sifre.TabIndex = 6;
            this.Sifre.UseSystemPasswordChar = true;
            // 
            // Kullanici_Adi_Eposta
            // 
            this.Kullanici_Adi_Eposta.Location = new System.Drawing.Point(46, 50);
            this.Kullanici_Adi_Eposta.Name = "Kullanici_Adi_Eposta";
            this.Kullanici_Adi_Eposta.Size = new System.Drawing.Size(169, 20);
            this.Kullanici_Adi_Eposta.TabIndex = 5;
            this.toolTip1.SetToolTip(this.Kullanici_Adi_Eposta, "Kullanıcı Adı veya E-postanızı giriniz");
            this.Kullanici_Adi_Eposta.TextChanged += new System.EventHandler(this.Kullanici_Adi_Eposta_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // GİRİŞ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "GİRİŞ";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Giris;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.TextBox Kullanici_Adi_Eposta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Kaydol_Ekrani;
        private System.Windows.Forms.Button Kayit_Form;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

