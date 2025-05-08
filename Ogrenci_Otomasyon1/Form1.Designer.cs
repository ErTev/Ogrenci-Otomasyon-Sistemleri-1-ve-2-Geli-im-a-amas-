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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_aekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_akad = new System.Windows.Forms.TextBox();
            this.txt_aksoyad = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_aekle);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_ara);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_akad);
            this.tabPage1.Controls.Add(this.txt_aksoyad);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KAYIT ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_aekle
            // 
            this.btn_aekle.Location = new System.Drawing.Point(148, 262);
            this.btn_aekle.Name = "btn_aekle";
            this.btn_aekle.Size = new System.Drawing.Size(86, 25);
            this.btn_aekle.TabIndex = 19;
            this.btn_aekle.Text = "Ekle";
            this.btn_aekle.UseVisualStyleBackColor = true;
            this.btn_aekle.Click += new System.EventHandler(this.btn_aekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ARANACAK NO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "DANIŞMAN ADI";
            // 
            // txt_ara
            // 
            this.txt_ara.Location = new System.Drawing.Point(142, 31);
            this.txt_ara.Name = "txt_ara";
            this.txt_ara.Size = new System.Drawing.Size(149, 20);
            this.txt_ara.TabIndex = 17;
            this.txt_ara.TextChanged += new System.EventHandler(this.txt_ara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "DANIŞMAN SOYADI";
            // 
            // txt_akad
            // 
            this.txt_akad.Location = new System.Drawing.Point(132, 137);
            this.txt_akad.Name = "txt_akad";
            this.txt_akad.Size = new System.Drawing.Size(149, 20);
            this.txt_akad.TabIndex = 19;
            // 
            // txt_aksoyad
            // 
            this.txt_aksoyad.Location = new System.Drawing.Point(132, 196);
            this.txt_aksoyad.Name = "txt_aksoyad";
            this.txt_aksoyad.Size = new System.Drawing.Size(149, 20);
            this.txt_aksoyad.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(317, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(439, 531);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btn_tmzl
            // 
            this.btn_tmzl.Location = new System.Drawing.Point(966, 398);
            this.btn_tmzl.Name = "btn_tmzl";
            this.btn_tmzl.Size = new System.Drawing.Size(86, 24);
            this.btn_tmzl.TabIndex = 13;
            this.btn_tmzl.Text = "Temizle";
            this.btn_tmzl.UseVisualStyleBackColor = true;
            this.btn_tmzl.Click += new System.EventHandler(this.btn_tmzl_Click);
            // 
            // btn_gncll
            // 
            this.btn_gncll.Location = new System.Drawing.Point(825, 398);
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
            this.label4.Location = new System.Drawing.Point(804, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ÖĞRENCİ NO";
            // 
            // txt_no
            // 
            this.txt_no.Location = new System.Drawing.Point(891, 88);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(149, 20);
            this.txt_no.TabIndex = 10;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(966, 337);
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
            this.label3.Location = new System.Drawing.Point(823, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CİNSİYET";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(825, 337);
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
            this.rbtn_kad.Location = new System.Drawing.Point(1003, 278);
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
            this.rbtn_erk.Location = new System.Drawing.Point(910, 278);
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
            this.label2.Location = new System.Drawing.Point(790, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÖĞRENCİ SOYAD";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(892, 178);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(149, 20);
            this.txt_soyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ AD";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(892, 135);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(149, 20);
            this.txt_ad.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(814, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DANIŞMAN";
            // 
            // cmbox_danısman
            // 
            this.cmbox_danısman.FormattingEnabled = true;
            this.cmbox_danısman.Location = new System.Drawing.Point(892, 230);
            this.cmbox_danısman.Name = "cmbox_danısman";
            this.cmbox_danısman.Size = new System.Drawing.Size(148, 21);
            this.cmbox_danısman.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 571);
            this.Controls.Add(this.btn_tmzl);
            this.Controls.Add(this.btn_gncll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmbox_danısman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_no);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtn_erk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtn_kad);
            this.Controls.Add(this.btn_ekle);
            this.Name = "Form1";
            this.Text = "Otomasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txt_ara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_aekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_aksoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_akad;
    }
}

