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
    public partial class Urunler : Form
    {
        Fonksiyonlar Con;
        public Urunler()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            UrunlerShow();
            KategoriGetir();
        }
    
        private void UrunlerShow()
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
        private void KategoriGetir()
        {

            string komut = "select * from kategoriler";
            UrunKatCb.ValueMember = Con.GetData(komut).Columns["KatKod"].ToString();
            UrunKatCb.DisplayMember = Con.GetData(komut).Columns["KatAdi"].ToString();
            UrunKatCb.DataSource = Con.GetData(komut);

        }


        private void ekle_Click(object sender, EventArgs e)
        {
            if (UrunAdTb.Text == "" || UrunFiyatTb.Text == "" || UrunKatCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız!");
            }
            else
            {
                try
                {
                    string UrunAd = UrunAdTb.Text;
                    int UrunFiyat = Convert.ToInt32(UrunFiyatTb.Text);
                    int UrunKategori = Convert.ToInt32(UrunKatCb.SelectedValue.ToString());
                   
                    string komut = "insert into urunler values('{0}',{1},{2})";
                    komut = string.Format(komut, UrunAd, UrunFiyat, UrunKategori);
                    Con.SetData(komut);
                    UrunlerShow();
                    MessageBox.Show("Ürün Başarıyla Eklendi!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }
        int anahtar = 0;


        private void duzenle_Click(object sender, EventArgs e)
        {
            if (UrunAdTb.Text == "" || UrunFiyatTb.Text == "" || UrunKatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız!");
            }
            else
            {
                try
                {
                    string UrunAd = UrunAdTb.Text;
                    int UrunFiyat = Convert.ToInt32(UrunFiyatTb.Text);
                    int UrunKategori = Convert.ToInt32(UrunKatCb.SelectedValue.ToString());
                    string komut = "update urunler set UrunAdi = '{0}', UrunFiyat =  {1}, urunKategori = {2} where UrunID = {3}";
                    komut = string.Format(komut, UrunAd, UrunFiyat,UrunKategori,anahtar);
                    Con.SetData(komut);
                    UrunlerShow();
                    MessageBox.Show("Ürün Başarıyla Güncellendi!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void UrunlerListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UrunAdTb.Text = UrunlerListe.SelectedRows[0].Cells[1].Value.ToString();
            UrunKatCb.Text = UrunlerListe.SelectedRows[0].Cells[3].Value.ToString();
            UrunFiyatTb.Text = UrunlerListe.SelectedRows[0].Cells[2].Value.ToString();
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
            if (anahtar == 0)
            {
                MessageBox.Show("Hata!");
            }
            else
            {
                try
                {

                    string komut = "delete from urunler where UrunID = {0}";
                    komut = string.Format(komut, anahtar);
                    Con.SetData(komut);
                    UrunlerShow();
                    UrunAdTb.Clear();
                    UrunFiyatTb.Clear();
                    UrunKatCb.Text = null;
                    MessageBox.Show("Ürün Başarıyla Silindi!");

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void OdemeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Ödeme Alamaz!");
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            Kategoriler kat = new Kategoriler();
            kat.Show();
            this.Hide();
        }

        private void UrunlerBtn_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Show();
            this.Hide();
        }

        private void KullanicilarBtn_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
