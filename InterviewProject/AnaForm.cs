using FifthProject;
using FourthProject;
using SecondProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThirdProject;

namespace InterviewProject
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            Islevsellik1 frm = new Islevsellik1();
            frm.Show();
        }

        private void BtnSecond_Click(object sender, EventArgs e)
        {
            Islevsellik2 frm = new Islevsellik2();
            frm.Show();
        }

        private void BtnThird_Click(object sender, EventArgs e)
        {
            Islevsellik3 frm = new Islevsellik3();
            frm.Show();
        }

        private void BtnFourth_Click(object sender, EventArgs e)
        {
            Islevsellik4 frm = new Islevsellik4();
            frm.Show();
        }

        private void BtnFifth_Click(object sender, EventArgs e)
        {
            Islevsellik5 frm = new Islevsellik5();    
            frm.Show();
        }
    }
}
