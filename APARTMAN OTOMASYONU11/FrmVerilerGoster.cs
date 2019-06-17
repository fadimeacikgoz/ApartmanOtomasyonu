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
    public partial class FrmVerilerGoster : Form
    {
        public FrmVerilerGoster()
        {
            InitializeComponent();

        }



                            SqlConnection baglanti = new SqlConnection("server=FADIMEPC\\FADIME; Initial Catalog=apartmanuygulaması; Integrated Security=SSPI");
                   
        
        private void verilerigoster()// sql serverdaki verileri cektik ve listeledik
        {

            //baglanti.Open();
            string kayit = "SELECT * from kisibilgileri";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
           
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);

            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;

            baglanti.Close();
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            //dataGridView1.Columns.Clear();
            //baglanti.Open();
            //SqlCommand komut = new SqlCommand("Select * from kisibilgileri", baglanti);
            //SqlDataReader oku = komut.ExecuteReader();
            //while (oku.Read())
            //{

            //    dataGridView1.Columns[0].Add = oku["id"].ToString();
            //    dataGridView1.Columns.Add(oku["Ad"].ToString());
            //    dataGridView1.Columns.Add((oku["Soyad"].ToString());
            //    ekle.SubItems.Add(oku["Telefon"].ToString());

            //    ekle.SubItems.Add(oku["Mail"].ToString());


            //   ekle);
            //}

            //baglanti.Close();
        }
                 
        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            verilerigoster();
        }



        private void BtnKaydet_Click(object sender, EventArgs e)// veriler kaydedilir
        {
            baglanti.Open();
            SqlCommand komutt = new SqlCommand("insert into kisibilgileri(tcno,Ad,Soyad,Telefon,Borclar,Mail) values ('" + textEdit4.Text.ToString() + "','" + textEdit1.Text.ToString() + "','" + textEdit2.Text.ToString() + "', '" + textEdit3.Text.ToString() + "' , '" + textEdit6.Text.ToString() + "','" + textEdit5.Text.ToString() + "')", baglanti);
            komutt.ExecuteNonQuery();
            baglanti.Close();

            verilerigoster();

        }



        private void BtnSil_Click(object sender, EventArgs e)// eklenen yada kaydedilen veriler silinir.
        {
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("delete from kisibilgileri where tcno=@tcnoo",baglanti);
            komut.Parameters.AddWithValue("@tcnoo", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
           
            verilerigoster();
       
           baglanti.Close();

        }

         
                 


        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("server=FADIMEPC\\FADIME; Initial Catalog=apartmanuygulaması; Integrated Security=SSPI");
            cnn.Open();




            SqlCommand sc = new SqlCommand("update kisibilgileri set  Ad=' " + textEdit1.Text + " ',Soyad = '" + textEdit2.Text + "', Telefon = '" + textEdit3.Text + "', Mail = '" + textEdit6.Text + "', Borclar ='" + textEdit5.Text + "' where tcno='" + textEdit4.EditValue + "'", cnn);
            

            sc.ExecuteNonQuery();
            MessageBox.Show("secili kayıt güncellendi");
           verilerigoster();
            
            cnn.Close();
    }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int tcnoo = dataGridView1.SelectedCells[0].RowIndex;
            string tcno = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Ad = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Soyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string Telefon = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string Mail = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string Borclar = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            textEdit4.EditValue = tcno;
            textEdit1.Text = Ad;
            textEdit2.Text = Soyad;
            textEdit3.Text = Telefon;
            textEdit6.Text = Mail;
            textEdit5.Text = Borclar;

        }
    }
}
//private void FrmVerilerGoster_Load(object sender, EventArgs e)
//{

//}

//private void FrmVerilerGoster_Load(object sender, EventArgs e)
//{

//}


///Data Source=TOSHIBA;Initial Catalog=apartmanuygulaması;Integrated Security=True;