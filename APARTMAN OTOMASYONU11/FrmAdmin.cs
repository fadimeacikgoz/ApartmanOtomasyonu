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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(TxtKullanıcıAdı.Text == "fadime" && TxtSifre.Text== "0000")
            {
                FrmAnaSayfa fr = new FrmAnaSayfa();
                fr.Show();
                this.Hide();
            }
        }
    }
}
