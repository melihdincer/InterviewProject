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
    public partial class Islevsellik3 : Form
    {
        public Islevsellik3()
        {
            InitializeComponent();
        }
        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            if (TxtSayi.Text != "")
            {
                int sayi = int.Parse(TxtSayi.Text);
                string s = "";
                Lbx1.Items.Add("0" + "\t" + "1" + "\t" + "2" + "\t" + "3" + "\t" + "4");
                for (int i = 1; i <= sayi; i++)
                {
                    for (int j = 1; j < 5; j++)
                    {
                        s += (i * j) + "\t";
                    }
                    Lbx1.Items.Add(i+"\t"+s);
                    s = "";
                }
                BtnOlustur.Enabled = false;
            }
            else
                MessageBox.Show("Bir sayı girmelisiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BtnYenile_Click(object sender, EventArgs e)
        {
            Lbx1.Items.Clear();
            TxtSayi.Text = "";
            BtnOlustur.Enabled = true;
        }
    }
}
