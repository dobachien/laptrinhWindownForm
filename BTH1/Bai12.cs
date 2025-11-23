using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai12
{
    public partial class Bai12 : Form
    {
        public Bai12()
        {
            InitializeComponent();
        }
        string chuoitam = "";
        char toantu;
        double[] toanhang = new double[2]; 
        double ketqua;
        int buoc = 1;
        private void NumberButtons(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b == null) return;

            chuoitam += b.Text;
            txtManHinh.Text = chuoitam;
        }



        private void btnCongTru_Click(object sender, EventArgs e)
        {
            if (chuoitam.Contains('-'))
            {
                chuoitam = chuoitam.Replace("-", "");
            }
            else
            {
                chuoitam = "-" + chuoitam;
            }
            txtManHinh.Text = chuoitam;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!chuoitam.Contains('.'))
            {
                chuoitam = chuoitam + "."; txtManHinh.Text = chuoitam;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            buoc = 1;
            toanhang[0] = toanhang[1] = 0.0;
            ketqua = 0.0;
            toantu = ' ';
            chuoitam = "";
            txtManHinh.Text = "0";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (chuoitam.Length != 0)
            {
                toanhang[1] = Double.Parse(chuoitam);
            }

            switch (toantu)
            {
                case '+': ketqua = toanhang[0] + toanhang[1]; break;
                case '-': ketqua = toanhang[0] - toanhang[1]; break;
                case '*': ketqua = toanhang[0] * toanhang[1]; break;
                case '/': ketqua = toanhang[0] / toanhang[1]; break;
            }

            txtManHinh.Text = ketqua.ToString();
            chuoitam = "";
            buoc = 1;
        }
        private void Operations(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (chuoitam.Length > 0)
                toanhang[buoc - 1] = Double.Parse(chuoitam);
            else
                toanhang[buoc - 1] = ketqua;

            if (buoc == 2)
            {
                btnBang_Click(null, null);
                toanhang[0] = ketqua;
                buoc = 1;
            }
            else
            {
                buoc++;
            }

            toantu = b.Text[0];
            chuoitam = "";
            txtManHinh.Text = toanhang[0].ToString();
        }

    }
}

