using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1_Bai5
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            radRed.Checked = true;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblLapTrinh.ForeColor = Color.Red;
                txtNhapTen.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblLapTrinh.ForeColor = Color.Green;
                txtNhapTen.ForeColor = Color.Green;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblLapTrinh.ForeColor = Color.Blue;
                txtNhapTen.ForeColor = Color.Blue;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblLapTrinh.ForeColor = Color.Black;
                txtNhapTen.ForeColor = Color.Black;
            }
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }
        private void UpdateFontStyle()
        {
            FontStyle style = FontStyle.Regular;

            if (chkBoiDam.Checked)
                style |= FontStyle.Bold;
            if (chkNghieng.Checked)
                style |= FontStyle.Italic;
            if (chkGachChan.Checked)
                style |= FontStyle.Underline;

            txtNhapTen.Font = new Font(txtNhapTen.Font.FontFamily, txtNhapTen.Font.Size, style);
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.FontFamily, lblLapTrinh.Font.Size, style);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkBoiDam_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void chkNghieng_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFontStyle();
        }
    }
}

