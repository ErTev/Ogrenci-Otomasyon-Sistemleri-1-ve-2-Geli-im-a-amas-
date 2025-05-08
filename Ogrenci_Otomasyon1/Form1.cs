using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Otomasyon_Ödev
{
    public partial class Form1 : Form
    {
        DataTable ogrenciTablosu;
        public Form1()
        {
            InitializeComponent();
           

        }
        List<ogrencı> ogrenciTablosuList = new List<ogrencı> ();

        int seçim;
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            ogrenciTablosu = new DataTable();
            ogrenciTablosu.Columns.Add("Öğrenci No", typeof(string));
            ogrenciTablosu.Columns.Add("Öğrenci Adı", typeof(string));
            ogrenciTablosu.Columns.Add("Öğrenci Soyadı", typeof(string));
            ogrenciTablosu.Columns.Add("Öğrenci Cinsiyeti", typeof(string));
            ogrenciTablosu.Columns.Add("Öğrenci Danışmanı", typeof(string));

            dataGridView1.DataSource = ogrenciTablosu;

        }
        string cinsiyet = string.Empty;
        private void rbtn_erkek (object sender, EventArgs e)
        {
            if(rbtn_erk.Checked)
            {
                cinsiyet = "Erkek";

            }
            else
            {
                cinsiyet = "Kadın";
            }
        }


        public bool Ogrencı_Ekle()
        {
            ogrencı ogrencı_ = new ogrencı(txt_ad.Text, txt_no.Text, txt_soyad.Text, cinsiyet,cmbox_danısman.Text);
            ogrenciTablosuList.Add(ogrencı_);
            return true;
        }


        public bool Kontrol()
        {
            if (!string.IsNullOrEmpty(txt_ad.Text) && !string.IsNullOrEmpty(txt_soyad.Text) && !string.IsNullOrEmpty(txt_no.Text) && !string.IsNullOrEmpty(cmbox_danısman.Text) && !string.IsNullOrEmpty(rbtn_erk.Text) && !string.IsNullOrEmpty(rbtn_kad.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");
                return false;
            }
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            if (txt_ad.Text.Length > 0 && txt_soyad.Text.Length > 0 && txt_no.Text.Length > 0 && rbtn_erk.Checked || rbtn_kad.Checked)
            {
                ogrenciTablosu.Rows.Add(txt_no.Text, txt_ad.Text, txt_soyad.Text, (rbtn_erk.Checked) ? ("Erkek") : ("Kadın"), cmbox_danısman.Text);
                
            }
           
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_no.Clear();
            cmbox_danısman.Text = string.Empty;
            rbtn_erk.Checked = false;
            rbtn_kad.Checked = false;
            dataGridView1.ClearSelection();

            if (Kontrol())
            {
                Ogrencı_Ekle();
                MessageBox.Show("Kaydınız Oluşturuldu.");

            }


        }
       
        public void verilerigoster(string veriler)
        {

            DataSet ds = new DataSet();
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            seçim = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(seçim);


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_no.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string cinsiyet = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (cinsiyet == "Erkek")
                rbtn_erk.Checked = true;
            else
                rbtn_kad.Checked = true;
            cmbox_danısman.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            



        }

        private void btn_tmzl_Click(object sender, EventArgs e)
        {
            txt_ad.Text = string.Empty;
            txt_akad.Text = string.Empty;
            txt_soyad.Text = string.Empty;
            txt_aksoyad.Text = string.Empty;
            txt_no.Text = string.Empty;
            cmbox_danısman.Text = string.Empty;
            rbtn_kad.Checked = false;
            rbtn_erk.Checked = false;
            txt_ara.Text = string.Empty;
           
            txt_no.Focus();
            dataGridView1.ClearSelection();


        }

        private void btn_gncll_Click(object sender, EventArgs e)
        {
            seçim = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[seçim];
            
            newDataRow.Cells[0].Value = txt_no.Text; 
            newDataRow.Cells[1].Value = txt_ad.Text;
            newDataRow.Cells[2].Value = txt_soyad.Text;
           
           
            
            if (rbtn_kad.Checked)
                newDataRow.Cells[3].Value = rbtn_kad.Text;
            else
                newDataRow.Cells[3].Value = rbtn_erk.Text;
            newDataRow.Cells[4].Value = cmbox_danısman.Text;



        }

      

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            if (txt_ara.Text == "")
            {
                dataGridView1.ClearSelection();
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[0].Index;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().ToLower().Equals(txt_ara.Text.ToString().Trim().ToLower()))
                        {
                            row.Selected = true; dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; break;
                        }
                    }
                }
                catch (Exception) { }

               
            }

        }
        List<danısman> danısman = new List<danısman>();
        public bool akaEkle()
        {
            danısman akademısyen =new danısman(txt_akad.Text,txt_aksoyad.Text);
            danısman.Add(akademısyen);
            return true;
        }
        public bool akaKontrol()
        {
            if (!string.IsNullOrEmpty(txt_akad.Text) && !string.IsNullOrEmpty(txt_aksoyad.Text) )
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }
        private void btn_aekle_Click(object sender, EventArgs e)
        {
           
                if (txt_akad.Text.Length > 0 && txt_aksoyad.Text.Length > 0)
                {
                    cmbox_danısman.Items.Add(txt_akad.Text + "  " + txt_aksoyad.Text);
                    MessageBox.Show("Kaydınız Oluşturuldu.");
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");
                }
                txt_akad.Clear();
                txt_aksoyad.Clear();

                cmbox_danısman.Text = string.Empty;

            
        }
    }
}
