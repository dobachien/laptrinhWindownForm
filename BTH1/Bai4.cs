using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            
            int kq = 0;
            int so1=int.Parse(txtSo1.Text);
            int so2=int.Parse(txtSo2.Text);
            if (radCong.Checked)
            {
                kq = so1 + so2;
            }
            else if(radTru.Checked)
            {
                kq = so1 - so2;
            }
            else if (radNhan.Checked)
            {
                kq = so1 * so2;
            }
            else
            {
                kq = so1 / so2;
            }

            txtKQ.Text = kq.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

