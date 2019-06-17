using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace APARTMAN_OTOMASYONU11
{
    public partial class FrmBilgileriGoster : Form
    {
        public FrmBilgileriGoster()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@" Data Source=TOSHIBA;Initial Catalog=apartmanuygulaması;Integrated Security=True");


        private void verilerigoster()
        {
            baglanti.Open();
            string kayit = "select * from DaireBilgilerii";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView2.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }
        private void BtnBilgileriGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand comut = new SqlCommand(" SELECT kisibilgileri.tcno, kisibilgileri.Ad, kisibilgileri.Soyad, kisibilgileri.Telefon, kisibilgileri.Mail, kisibilgileri.Borclar,DaireBilgilerii.MetreKare,DaireBilgilerii.DaireNo  from DaireBilgilerii, kisibilgileri WHERE kisibilgileri.tcno = DaireBilgilerii.tcno", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(comut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView2.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
//Data Source = TOSHIBA; Initial Catalog = apartmanuygulaması; Integrated Security = True