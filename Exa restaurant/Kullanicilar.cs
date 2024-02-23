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
    public partial class Kullanicilar : Form
    {
        public Kullanicilar()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
            KullaniciShow();
        }
        Fonksiyonlar Con;

        private void KullaniciShow()
        {
            try
            {
                string komut = "select * from kullancilar";
                KullaniciListe.DataSource = Con.GetData(komut);
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }


        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (KadiTb.Text == "" || KsifreTb.Text == "" || KtelTb.Text == "" || KadresTb.Text == "" || GenCb.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız!");
            }
            else
            {
                try
                {
                   string ad = KadiTb.Text;
                   string sifre = KsifreTb.Text;
                   string tel = KtelTb.Text;
                   string adres = KadresTb.Text;
                   string gen = GenCb.Text;
                   string komut = "insert into kullancilar values('{0}','{1}','{2}','{3}','{4}')";
                   komut = string.Format(komut,ad,sifre,gen,tel,adres);
                   Con.SetData(komut);
                   KullaniciShow();
                   MessageBox.Show("Kullanıcı Başarıyla Eklendi!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }

        }
        int anahtar = 0;
        private void KullaniciListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KadiTb.Text = KullaniciListe.SelectedRows[0].Cells[1].Value.ToString();
            KsifreTb.Text = KullaniciListe.SelectedRows[0].Cells[2].Value.ToString();
            GenCb.Text = KullaniciListe.SelectedRows[0].Cells[3].Value.ToString();
            KtelTb.Text = KullaniciListe.SelectedRows[0].Cells[4].Value.ToString();
            KadresTb.Text = KullaniciListe.SelectedRows[0].Cells[5].Value.ToString();
            if (KadiTb.Text == "")
            {

                anahtar = 0;

            }
            else
            {
                anahtar = Convert.ToInt32(KullaniciListe.SelectedRows[0].Cells[0].Value.ToString());
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
                  
                    string komut = "delete from kullancilar where Kid = {0}";
                    komut = string.Format(komut, anahtar);
                    Con.SetData(komut);
                    KullaniciShow();
                    KadiTb.Clear();
                    KsifreTb.Clear();
                    KsifreTb.Clear();
                    KadresTb.Clear();
                    KtelTb.Clear();
                    GenCb.Text = null;
                    MessageBox.Show("Kullanıcı Başarıyla Silindi!");

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void duzenle_Click(object sender, EventArgs e)
        {
            if (KadiTb.Text == "" || KsifreTb.Text == "" || KtelTb.Text == "" || KadresTb.Text == "" || GenCb.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız!");
            }
            else
            {
                try
                {
                    string Kadi = KadiTb.Text;
                    string Kgen = GenCb.Text;
                    string Ksifre = KsifreTb.Text;
                    string Ktel = KtelTb.Text;
                    string Kadres = KadresTb.Text;
                    string komut = "update kullancilar set Kadi = '{0}', Ksifre = '{1}', Kgen = '{2}', Ktel = '{3}', Kadres = '{4}' where Kid = '{5}'";
                    komut = string.Format(komut,Kadi,Ksifre,Kgen,Ktel,Kadres,anahtar);
                    Con.SetData(komut);
                    KullaniciShow();
                    MessageBox.Show("Kullanıcı Başarıyla Güncellendi!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OdemeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin Ödeme Alamaz!");
        }
    }
}
