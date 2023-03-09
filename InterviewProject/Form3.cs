using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int[] dizi;
        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            if (TxtSayi.Text != "") 
            {                
            int sayi = int.Parse(TxtSayi.Text);
            int sonuc;
            for (int i = 1; i < sayi; i++)
            {
                ListView1.Columns.Add(i + "'ler", 50);              
            }
         
            for (int i = 1; i < sayi; i++)
            {
                for (int j = 1; j <= 10; j++)
                {                
                    sonuc = i * j;
                    ListView1.Items.Add(sonuc.ToString());
                }
            }
            
            BtnOlustur.Enabled = false;
            }
            else
                MessageBox.Show("Bir sayı girmelisiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnYenile_Click(object sender, EventArgs e)
        {
            ListView1.Columns.Clear();
            TxtSayi.Text = "";
            BtnOlustur.Enabled = true;
        }
    }
}
