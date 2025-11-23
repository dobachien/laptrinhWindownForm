using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace BTH1_Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSo.Text);
            cboSo.Items.Add(txtSo.Text);
            txtSo.Clear();
            
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int so = int.Parse(cboSo.SelectedItem.ToString());

            lstTinh.Items.Clear(); // xóa kết quả cũ

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    lstTinh.Items.Add(i);
                }
            }
        }


        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for(int i = 0; i < lstTinh.Items.Count; i++)
            {
                tong += (int)lstTinh.Items[i];
            }
            MessageBox.Show(tong.ToString());
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                if ((int)lstTinh.Items[i] % 2 == 0)
                {
                    dem++;
                }
            }
            MessageBox.Show(dem.ToString());
        }
        bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        private void btnDemSoNguyenTo_Click(object sender, EventArgs e)
        {
            int dem2 = 0;
            for (int i = 0; i < lstTinh.Items.Count; i++)
            {
                if (LaSoNguyenTo((int)lstTinh.Items[i]))
                {
                    dem2++;
                }
            }
            MessageBox.Show(dem2.ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

