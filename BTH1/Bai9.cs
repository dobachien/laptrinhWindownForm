using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai9
{
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
            txtNhap.Focus();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhap.Text, out int so))
            {
                lst1.Items.Add(so); 
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                txtNhap.SelectAll();
                txtNhap.Focus();
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (var item in lst1.Items)
            {
                tong += int.Parse(item.ToString());
            }
        MessageBox.Show(tong.ToString());
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            int count = lst1.Items.Count;

            if (count == 0)
            {
                MessageBox.Show("ListBox đang trống!");
                return;
            }

            // Xóa phần tử cuối trước, tránh ảnh hưởng chỉ số khi xóa
            if (count > 1)
            {
                lst1.Items.RemoveAt(count - 1); // Xóa cuối
            }

            // Xóa phần tử đầu
            lst1.Items.RemoveAt(0);
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lst1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử nào!");
                return;
            }

            // Xóa các phần tử được chọn
            // Lưu ý: phải lặp từ cuối lên đầu để tránh lỗi khi xóa
            for (int i = lst1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lst1.Items.RemoveAt(lst1.SelectedIndices[i]);
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst1.Items.Count; i++)
            {
                int giaTri = int.Parse(lst1.Items[i].ToString());
                giaTri += 2;
                lst1.Items[i] = giaTri;

            }
        }

        private void btnThay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst1.Items.Count; i++)
            {
                int giaTri = int.Parse(lst1.Items[i].ToString());
                giaTri = giaTri * giaTri;
                lst1.Items[i] = giaTri;

            }
        }

        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            lst1.ClearSelected();

            for (int i = 0; i < lst1.Items.Count; i++)
            {
                if (int.TryParse(lst1.Items[i].ToString(), out int giaTri))
                {
                    if (giaTri % 2 == 0) 
                    {
                        lst1.SetSelected(i, true); 
                    }
                }
            }
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            lst1.ClearSelected();

            for (int i = 0; i < lst1.Items.Count; i++)
            {
                if (int.TryParse(lst1.Items[i].ToString(), out int giaTri))
                {
                    if (giaTri % 2 == 1)
                    {
                        lst1.SetSelected(i, true);
                    }
                }
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

