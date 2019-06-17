using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APARTMAN_OTOMASYONU11
{
    public partial class FrmDaireler : Form
    {
        public FrmDaireler()
        {
            InitializeComponent();
        }
        private void renkler()
        {
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;
        }



        private void button6_Click(object sender, EventArgs e)
        {
            renkler();
            button6.BackColor = Color.CadetBlue;
            LblAdsoyad.Text = "Bilge EMİLLİ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            renkler();
            button1.BackColor = Color.CadetBlue;
            LblAdsoyad.Text = "Fadime AÇIKGÖZ";

        }
        private void FrmDaireler_Load(object sender, EventArgs e)
        {
            renkler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renkler();
            button2.BackColor = Color.CadetBlue;
            LblAdsoyad.Text= "Kübra TURAN";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            renkler();
            button3.BackColor = Color.CadetBlue;
            LblAdsoyad.Text = "Rabia ERDOGDU";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            renkler();
            button4.BackColor = Color.CadetBlue;
            LblAdsoyad.Text = "Gülçin DEMİR";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            renkler();
            button5.BackColor = Color.CadetBlue;
            LblAdsoyad.Text = "Öznur BAYRAM";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            renkler();
            button7.BackColor = Color.CadetBlue;
            LblAdsoyad.Text = "Cemile AÇIKGÖZ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            renkler();
            button8.BackColor = Color.CadetBlue;
            LblAdsoyad.Text = "Mert AÇIKGÖZ";
        }
    }
    }

