using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewProject
{
    public partial class Islevsellik1 : Form
    {
        public Islevsellik1()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, sonuc;

            if (TxtSayi1.Text == "" || TxtSayi2.Text == "" || TxtSayi3.Text == "")
            {
                MessageBox.Show("Bir sayı girmelisiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sayi1 = Convert.ToInt32(TxtSayi1.Text);
                sayi2 = Convert.ToInt32(TxtSayi2.Text);
                sayi3 = Convert.ToInt32(TxtSayi3.Text);
                sonuc = ((sayi1 + sayi2) * sayi3);
                TxtSonuc.Text = sonuc.ToString();
                MessageBox.Show("İşlem Tamamlandı.");
            }

            // MessageBox kutusunda tamam a bastıktan sonra textboxları temizle.
            TxtSayi1.Text = "";
            TxtSayi2.Text = "";
            TxtSayi3.Text = "";
            TxtSonuc.Text = "";
        }
    }
}
