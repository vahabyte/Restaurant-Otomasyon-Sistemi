using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exa_restaurant
{
    public partial class Odeme : Form
    {
        Fonksiyonlar Con;
        public Odeme()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            UrunlerGoster();
           
        }
        public int secim = 0;
        private void UrunlerGoster()
        {
         try
            {

                string komut = "select * from urunler";
                UrunlerListe.DataSource = Con.GetData(komut);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }
        int n = 0;
        int OdemeToplam = 0;
        private void ekle_Click(object sender, EventArgs e)
        {
            if(UrunAdetTb.Text == "" || UrunFiyatTb.Text == "")
            {

                MessageBox.Show("Lütfen Ürün Seçiniz!");

            }
            else
            {
                int toplam = Convert.ToInt32(UrunAdetTb.Text) * Convert.ToInt32(UrunFiyatTb.Text);
               
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OdemeListe);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = UrunAdTb.Text;
                newRow.Cells[2].Value = UrunFiyatTb.Text;
                newRow.Cells[3].Value = UrunAdetTb.Text;
                newRow.Cells[4].Value = toplam;
                OdemeListe.Rows.Add(newRow);
                OdemeToplam = toplam + OdemeToplam;
                ToplamLbl.Text = OdemeToplam.ToString()+" ₺" ;
                n++;
            }

        }
        int anahtar = 0;
        private void UrunlerListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UrunAdTb.Text = UrunlerListe.SelectedRows[0].Cells[1].Value.ToString();
            UrunFiyatTb.Text = UrunlerListe.SelectedRows[0].Cells[2].Value.ToString();
            UrunAdetTb.Value = 1;
            if (UrunAdTb.Text == "")
            {

                anahtar = 0;

            }
            else
            {
                anahtar = Convert.ToInt32(UrunlerListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            UrunAdetTb.Value = 1;
            UrunFiyatTb.Clear();
            UrunAdTb.Clear();
            OdemeListe.Rows.Clear();
            ToplamLbl.Text = "0 ₺";
            OdemeToplam = 0;
            n = 0;
         
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullanicilarBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcılar Sadece Ödeme Alabilir!");
        }

        private void yeni_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            if (this.OdemeListe.SelectedRows.Count>0)
            {
            int SecilenSatir = OdemeListe.CurrentCell.RowIndex;
            int toplam = Convert.ToInt32(UrunAdetTb.Text) * Convert.ToInt32(UrunFiyatTb.Text);    
            OdemeListe.Rows.RemoveAt(SecilenSatir);
            OdemeToplam = OdemeToplam - toplam;
            ToplamLbl.Text = OdemeToplam.ToString()+ " ₺";
            OdemeListe.ClearSelection();
         
            }
            else
            {
          
                MessageBox.Show("Lütfen Seçim yapınız!");
            }

            
            
         
        }
        int ba = 0;
        private void OdemeListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UrunAdTb.Text = OdemeListe.SelectedRows[0].Cells[1].Value.ToString();
            UrunFiyatTb.Text = OdemeListe.SelectedRows[0].Cells[2].Value.ToString();
            UrunAdetTb.Text = OdemeListe.SelectedRows[0].Cells[3].Value.ToString();
            if (UrunAdTb.Text == "")
            {

                ba = 0;

            }
            else
            {
                ba = Convert.ToInt32(OdemeListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            if (OdemeListe.SelectedRows.Count > 0)
            {
                secim = 1;
            }
        }
    }
}
