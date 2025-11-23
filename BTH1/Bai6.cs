using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai6
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            radArial.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UpdateFont()
        {
            Font selectedFont = txtChu.Font; // Lấy font hiện tại

            if (radArial.Checked)
                selectedFont = new Font("Arial", txtChu.Font.Size, txtChu.Font.Style);
            else if (radTimesNewRoman.Checked)
                selectedFont = new Font("Times New Roman", txtChu.Font.Size, txtChu.Font.Style);
            else if (radTahoma.Checked)
                selectedFont = new Font("Tahoma", txtChu.Font.Size, txtChu.Font.Style);
            else
                selectedFont = new Font("Courier New", txtChu.Font.Size, txtChu.Font.Style);
            txtChu.Font = selectedFont;
        }

        private void radTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }

        private void radCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFont();
        }
    }
}

