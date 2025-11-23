using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai11
{
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Lấy thông tin nhập vào
            string mssv = txtMa.Text;
            string hoten = txtTen.Text;
            string nienKhoa = txtNamHoc.Text;
            string lop = txtLop.Text;

            // Lấy học kỳ
            string hocKy = "";
            if (rad1.Checked) hocKy = "I";
            else if (rad2.Checked) hocKy = "II";
            else if (rad3.Checked) hocKy = "III";
            else if (rad4.Checked) hocKy = "IV";

            // Lấy danh sách môn học đã chọn
            string mon = "";
            int stt = 1;
            if (chk1.Checked) mon += $"{stt}. {chk1.Text}\n"; stt++;
            if (chk2.Checked) mon += $"{stt}. {chk2.Text}\n"; stt++;
            if (chk3.Checked) mon += $"{stt}. {chk3.Text}\n"; stt++;
            if (chk4.Checked) mon += $"{stt}. {chk4.Text}\n"; stt++;


            // Tạo chuỗi để hiển thị
            string thongbao =
                $"Sinh viên: {hoten}\n" +
                $"Lớp: {lop}\n" +
                $"Niên khóa: {nienKhoa}\n" +
                $"Đăng ký học kỳ: {hocKy}\n" +
                $"Các môn học sau:\n{mon}";

            // Hiện MessageBox
            MessageBox.Show(thongbao, "Kết quả đăng ký");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtNamHoc.Clear();
            txtLop.Clear();
            rad1.Checked = false;
            rad2.Checked = false;
            rad3.Checked = false;
            rad4.Checked = false;
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            txtMa.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

