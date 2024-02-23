using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Exa_restaurant
{
    public partial class giris : Form
    {
        SqlConnection Conn;
        SqlDataReader dr;
        SqlCommand com;

        Fonksiyonlar Con = new Fonksiyonlar();
        public giris()
        {
            InitializeComponent();
            Con = new Fonksiyonlar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            if(KadiTb.Text == "" || Ksifre.Text == "")
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız!");

            }
            else if(KadiTb.Text == "admin" && Ksifre.Text == "admin")
            {
                Kullanicilar kullanicilar = new Kullanicilar();
                kullanicilar.Show();
                this.Hide();
            }
            else
            {
                Conn = new SqlConnection("Data Source=DESKTOP-C7QRC56\\BARTENDER;Initial Catalog=exarestaurant;Integrated Security=True");
                com = new SqlCommand();
                Conn.Open();
                com.Connection = Conn;
                com.CommandText = "select * from kullancilar where Kadi = '" + KadiTb.Text + "' and Ksifre = '" + Ksifre.Text + "'";
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    Odeme odeme = new Odeme();
                    odeme.Show();
                    this.Hide();
                }     
                else
                {
                    HataLbl.Text = "HATALI KULLANICI ADI VEYA ŞİFRE !";
                }
            }

        }
    }
}
