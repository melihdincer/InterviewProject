using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace FourthProject
{
    public partial class Islevsellik4 : Form
    {
        public Islevsellik4()
        {
            InitializeComponent();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            //Txt dosyasında son satırdan sonra boşluk varsa onu silmeli.
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //openfiledialog açılıp tamam ' a basarsak 
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string sayidosyasi = sr.ReadToEnd(); //satır sonuna kadar oku.
                string[] sayilar = sayidosyasi.Split(' ', '\n');
                foreach (string item in sayilar)
                {
                    listBox1.Items.Remove("");
                    listBox1.Items.Add(item);
                    sayidosyasi = sr.ReadLine();
                }
                //sayıları double türündeki diziye aktarma
                double sayi;
                double[] dizi = new double[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sayi = Convert.ToDouble(listBox1.Items[i]);
                    dizi[i] = sayi;       
                }
                foreach (double item in Siralama(dizi))
                {
                    listBox2.Items.Add(item);
                }
            }
        }
        public double[] Siralama(double[] sayilar)
        {
            double  gecici;
            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                for (int j = i; j < sayilar.Length; j++)
                {
                    if (sayilar[i] < sayilar[j]) // büyükten küçüğe sıralama
                    {
                        gecici = sayilar[j]; 
                        sayilar[j] = sayilar[i]; 
                        sayilar[i] = gecici;
                    }
                }
            }
            return sayilar;
        }
    }
}
