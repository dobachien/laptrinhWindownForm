using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai8
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void KiemTraDuLieu()
        {
            bool hopLe = true;
            errorProvider1.Clear();

            double a, b;

            if (!double.TryParse(txtA.Text, out a))
            {
                errorProvider1.SetError(txtA, "A phải là số!");
                hopLe = false;
            }

            if (!double.TryParse(txtB.Text, out b))
            {
                errorProvider1.SetError(txtB, "B phải là số!");
                hopLe = false;
            }

            // Nếu hợp lệ thì bật nút Giải và Xóa, ngược lại tắt
            btnGiai.Enabled = hopLe;
            
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            if (a == 0)
            {
                if (b == 0)
                    txtNghiem.Text = "Phương trình vô số nghiệm";
                else
                    txtNghiem.Text = "Phương trình vô nghiệm";
            }
            else
            {
                double x = -b / a;
                txtNghiem.Text = x.ToString();
                btnXoa.Enabled = true;
                btnGiai.Enabled = false;
            }
        }
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            KiemTraDuLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtNghiem.Clear();
            errorProvider1.Clear();
            btnXoa.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

