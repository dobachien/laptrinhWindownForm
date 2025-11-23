using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai10
{
    public partial class Bai10 : Form
    {
        public Bai10()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtNhap.Text.Trim();

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.Focus();
                return;
            }

            lst1.Items.Add(ten);   
            txtNhap.Clear();         
            txtNhap.Focus();         
        }

        private void btnPhai1_Click(object sender, EventArgs e)
        {
            List<object> selected = new List<object>();
            foreach (var item in lst1.SelectedItems)
                selected.Add(item);

            // Chuyển sang list phải
            foreach (var item in selected)
            {
                lst2.Items.Add(item);
                lst1.Items.Remove(item);
            }
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            List<object> selected = new List<object>();
            foreach (var item in lst2.SelectedItems)
                selected.Add(item);

            // Chuyển sang list phải
            foreach (var item in selected)
            {
                lst1.Items.Add(item);
                lst2.Items.Remove(item);
            }
        }

        private void btnPhaiTat_Click(object sender, EventArgs e)
        {
            foreach (var item in lst1.Items)
                lst2.Items.Add(item);

            lst1.Items.Clear();   
        }

        private void btnTraiTat_Click(object sender, EventArgs e)
        {
            foreach (var item in lst2.Items)
                lst1.Items.Add(item);

            lst2.Items.Clear();   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tên cần xóa!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Lưu các mục được chọn vào danh sách tạm
            List<object> removeList = new List<object>();
            foreach (var item in lst1.SelectedItems)
            {
                removeList.Add(item);
            }

            // Xóa từng mục
            foreach (var item in removeList)
            {
                lst1.Items.Remove(item);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

