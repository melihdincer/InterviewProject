using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject
{
    public partial class Islevsellik2 : Form
    {
        public Islevsellik2()
        {
            InitializeComponent();
        }

        private void BtnSonuc_Click(object sender, EventArgs e)
        {
            string zig = "zig";
            string zag = "zag";
            string zigzag = "zigzag";
            string zagzig = "zagzig";         

            for (int i = 1; i <= 200; i++)
            {
                Lbx1.Items.Add(i);

                //Sayı 3'ün tam katı ise o sayının yerine "zig" yaz.               
                if (i % 3 == 0 && i%5 != 0)
                {
                    Lbx1.Items.Remove(i);
                    Lbx1.Items.Add(zig);
                }
                //Sayı 5'in tam katı ise o sayının yerine "zig" yaz. 
                if (i % 5 == 0 && i % 3 != 0)
                {
                    Lbx1.Items.Remove(i);
                    Lbx1.Items.Add(zag);
                }
                //100'e kadar olan sayılar için, hem 3'ün hem de 5'in tam katı ise o sayının yerine "zigzag" yaz. 
                if (i <= 100 && i % 3 == 0 && i % 5 == 0)
                {
                    Lbx1.Items.Remove(i);
                    Lbx1.Items.Add(zigzag);
                }               
                //100'den sonraki sayılar için "zigzag" yerine "zagzig" yaz.
                if (i > 100 && i % 3 == 0 && i % 5 == 0)
                {
                    Lbx1.Items.Add(zagzig);
                }
            }




        }
    }
}
