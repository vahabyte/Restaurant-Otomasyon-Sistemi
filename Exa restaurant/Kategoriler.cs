using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace Exa_restaurant
{
    public partial class Kategoriler : Form
    {
        Fonksiyonlar Con;

        public Kategoriler()
        {
            InitializeComponent();

            Con = new Fonksiyonlar();
            CategoryShow();
     
        }

        
        private void CategoryShow()
        {
            try
            {
            
                string komut = "select * from kategoriler";
                KategoriListe.DataSource = Con.GetData(komut);
            
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
            
            
        }
        private void EkleBtn_Click(object sender, EventArgs e)
        {

           if(CatNameTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız!");
            }
            else
            {
                try
                {
                    string kategori = CatNameTb.Text;
                    string aciklama = DescTb.Text;
                    string komut = "insert into kategoriler values('{0}','{1}')";
                    komut = string.Format(komut, kategori, aciklama);
                    Con.SetData(komut);
                    CategoryShow();
                    MessageBox.Show("Kategori Başarıyla Eklendi!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                   
                }
            }
        }
        int anahtar = 0;
        private void KategoriListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            CatNameTb.Text = KategoriListe.SelectedRows[0].Cells[1].Value.ToString();
            DescTb.Text = KategoriListe.SelectedRows[0].Cells[2].Value.ToString();

            if(CatNameTb.Text == "")
            {

                anahtar = 0;
               
            }
            else
            {
                anahtar = Convert.ToInt32(KategoriListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DuzenleBtn_Click(object sender, EventArgs e)
        {
            if (CatNameTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız!");
            }
            else
            {
                try
                {
                    string kategori = CatNameTb.Text;
                    string aciklama = DescTb.Text;
                    string komut = "update kategoriler set KatAdi = '{0}', KatAciklama = '{1}' where KatKod = '{2}'";
                    komut = string.Format(komut, kategori, aciklama,anahtar);
                    Con.SetData(komut);
                    CategoryShow();
                    MessageBox.Show("Kategori Başarıyla Güncellendi!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (anahtar == 0)
            {
                MessageBox.Show("Hata!");
            }
            else
            {
                try
                {
           ;
                    string komut = "delete from kategoriler where KatKod = {0}";
                    komut = string.Format(komut,anahtar);
                    Con.SetData(komut);
                    CategoryShow();
                    CatNameTb.Clear();
                    DescTb.Clear();
                    MessageBox.Show("Kategori Başarıyla Silindi!");

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void KullanicilarBtn_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.Show();
            this.Hide();
        }

        private void UrunlerBtn_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Kategoriler kat = new Kategoriler();
            kat.Show();
            this.Hide();
        }

        private void CikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OdemeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Ödeme Alamaz!");
        }
    }
}
