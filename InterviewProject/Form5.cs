using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifthProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] fibonacci = { 0, 1, 1, 2, 3, 5 };
        }

        private void BtnButton_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 1;
            int sonuc = 0;
            
            if(Txt1.Text != "") 
            {
                int girilensayi = int.Parse(Txt1.Text);
                Lbx1.Items.Add("0");
                Lbx1.Items.Add("1");
                Lbx1.Items.Add("1");
                for (int i = 0; i <= girilensayi - 4; i++)
                {
                    sonuc = a + b;
                    a = b;
                    b = sonuc;
                    Lbx1.Items.Add(sonuc);
                }
                LblFibonacci.Text = sonuc.ToString();
                BtnButton.Enabled = false;
            }
            else
                MessageBox.Show("Bir sayı girmelisiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            BtnButton.Enabled = true;
            Txt1.Text = "";
            Lbx1.Items.Clear();
            LblFibonacci.Text = "0";
            Txt1.Focus();
        }
    }
}
