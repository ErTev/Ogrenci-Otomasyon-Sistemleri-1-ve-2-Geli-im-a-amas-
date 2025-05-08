namespace Otomasyon_Ödev
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_akaEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_bolum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ders = new System.Windows.Forms.TextBox();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_tmzl = new System.Windows.Forms.Button();
            this.btn_gncll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.rbtn_kad = new System.Windows.Forms.RadioButton();
            this.rbtn_erk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbox_danısman = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1608, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_tmzl);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_gncll);
            this.tabPage1.Controls.Add(this.btn_akaEkle);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbox_danısman);
            this.tabPage1.Controls.Add(this.txt_bolum);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btn_sil);
            this.tabPage1.Controls.Add(this.txt_ders);
            this.tabPage1.Controls.Add(this.txt_ad);
            this.tabPage1.Controls.Add(this.txt_ara);
            this.tabPage1.Controls.Add(this.txt_no);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_ekle);
            this.tabPage1.Controls.Add(this.txt_soyad);
            this.tabPage1.Controls.Add(this.rbtn_kad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rbtn_erk);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1600, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KAYIT ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_akaEkle
            // 
            this.btn_akaEkle.Location = new System.Drawing.Point(98, 269);
            this.btn_akaEkle.Name = "btn_akaEkle";
            this.btn_akaEkle.Size = new System.Drawing.Size(86, 25);
            this.btn_akaEkle.TabIndex = 23;
            this.btn_akaEkle.Text = "Ekle";
            this.btn_akaEkle.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "DERS KODU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ARANACAK NO";
            // 
            // txt_bolum
            // 
            this.txt_bolum.Location = new System.Drawing.Point(98, 217);
            this.txt_bolum.Name = "txt_bolum";
            this.txt_bolum.Size = new System.Drawing.Size(149, 20);
            this.txt_bolum.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "DERS ADI";
            // 
            // txt_ders
            // 
            this.txt_ders.Location = new System.Drawing.Point(98, 156);
            this.txt_ders.Name = "txt_ders";
            this.txt_ders.Size = new System.Drawing.Size(149, 20);
            this.txt_ders.TabIndex = 25;
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(98, 50);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(149, 20);
            this.txt_ara.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(281, 13);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(835, 534);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btn_tmzl
            // 
            this.btn_tmzl.Location = new System.Drawing.Point(1335, 370);
            this.btn_tmzl.Name = "btn_tmzl";
            this.btn_tmzl.Size = new System.Drawing.Size(86, 24);
            this.btn_tmzl.TabIndex = 13;
            this.btn_tmzl.Text = "Temizle";
            this.btn_tmzl.UseVisualStyleBackColor = true;
            this.btn_tmzl.Click += new System.EventHandler(this.btn_tmzl_Click);
            // 
            // btn_gncll
            // 
            this.btn_gncll.Location = new System.Drawing.Point(1194, 370);
            this.btn_gncll.Name = "btn_gncll";
            this.btn_gncll.Size = new System.Drawing.Size(86, 24);
            this.btn_gncll.TabIndex = 12;
            this.btn_gncll.Text = "Güncelle";
            this.btn_gncll.UseVisualStyleBackColor = true;
            this.btn_gncll.Click += new System.EventHandler(this.btn_gncll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1173, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ÖĞRENCİ NO";
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(1260, 60);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(149, 20);
            this.txt_no.TabIndex = 10;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(1335, 309);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(86, 25);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1192, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CİNSİYET";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(1194, 309);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(86, 25);
            this.btn_ekle.TabIndex = 6;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // rbtn_kad
            // 
            this.rbtn_kad.AutoSize = true;
            this.rbtn_kad.Location = new System.Drawing.Point(1372, 250);
            this.rbtn_kad.Name = "rbtn_kad";
            this.rbtn_kad.Size = new System.Drawing.Size(52, 17);
            this.rbtn_kad.TabIndex = 5;
            this.rbtn_kad.TabStop = true;
            this.rbtn_kad.Text = "Kadın";
            this.rbtn_kad.UseVisualStyleBackColor = true;
            // 
            // rbtn_erk
            // 
            this.rbtn_erk.AutoSize = true;
            this.rbtn_erk.Location = new System.Drawing.Point(1279, 250);
            this.rbtn_erk.Name = "rbtn_erk";
            this.rbtn_erk.Size = new System.Drawing.Size(53, 17);
            this.rbtn_erk.TabIndex = 4;
            this.rbtn_erk.TabStop = true;
            this.rbtn_erk.Text = "Erkek";
            this.rbtn_erk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1159, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÖĞRENCİ SOYAD";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(1261, 150);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(149, 20);
            this.txt_soyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1173, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ AD";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(1261, 107);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(149, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1183, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DERS";
            // 
            // cmbox_danısman
            // 
            this.cmbox_danısman.FormattingEnabled = true;
            this.cmbox_danısman.Location = new System.Drawing.Point(1261, 202);
            this.cmbox_danısman.Name = "cmbox_danısman";
            this.cmbox_danısman.Size = new System.Drawing.Size(148, 21);
            this.cmbox_danısman.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbtn_kad;
        private System.Windows.Forms.RadioButton rbtn_erk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Button btn_gncll;
        private System.Windows.Forms.Button btn_tmzl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbox_danısman;
        private System.Windows.Forms.Button btn_akaEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bolum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ders;
        private System.Windows.Forms.TextBox txt_ara;
    }
}

