using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai1that
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtUser.Text;
            string matkhau = txtPass.Text;

            string message = $"{tendangnhap},{matkhau}";
            if (chkNho.Checked )
            {
                message += "\nBan co ghi nho";
            }
            MessageBox.Show(message, "Thong bao");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
            chkNho.Checked = false;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}

