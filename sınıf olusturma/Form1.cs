using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnGoster_Click(object sender, EventArgs e)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Ad = txtAd.Text;
            oyuncu1.Soyad = txtSoyad.Text;
            oyuncu1.Posta = txtEposta.Text;
            oyuncu1.Puan = 100;
            if (radioButton1.Checked)
            {
                MessageBox.Show("aktifsiniz");
            }
            else
            {
                MessageBox.Show("aktif değilsiniz");
            }
            MessageBox.Show("ad:" + oyuncu1.Ad
                           + "\n soyad: " + oyuncu1.Soyad
                           + "\n posta:" + oyuncu1.Posta
                           + "\n puan:" + oyuncu1.Puan);


        }
    }
}
