using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai7
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();  // Xóa lỗi cũ
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Tên không được để trống!");
                isValid = false;
            }

            int yearOfBirth;
            if (!int.TryParse(txtYear.Text, out yearOfBirth))
            {
                errorProvider1.SetError(txtYear, "Năm sinh phải là số!");
                isValid = false;
            }

            // Nếu có lỗi thì dừng
            if (!isValid) return;
            int year=int.Parse(txtYear.Text);
            int age = DateTime.Now.Year - year;
            string name=txtName.Text;
            string year2=txtYear.Text;
            string message = $" {name},{age.ToString()},{year2}";
            MessageBox.Show(message);
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtYear.Clear();
            errorProvider1.Clear();
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

