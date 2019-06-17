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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void BtnDaireler_Click(object sender, EventArgs e)
        {
            FrmBilgileriGoster fr = new FrmBilgileriGoster();
            fr.Show();
        }

        private void BtnKisiBilgileri (object sender, EventArgs e)
        {
            FrmVerilerGoster fr = new FrmVerilerGoster();
            fr.Show();
            this.Hide();
        }

        private void BtnBorclar_Click(object sender, EventArgs e)
        {

        }

        private void BtnHakında_Click(object sender, EventArgs e)
        {

        }
    }

    



    }


    

