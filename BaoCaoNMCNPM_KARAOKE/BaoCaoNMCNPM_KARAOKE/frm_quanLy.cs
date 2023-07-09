using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoNMCNPM_KARAOKE
{
    public partial class frm_quanLy : Form
    {
        public frm_quanLy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            fm_thanhToan ql = new fm_thanhToan();
            ql.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frm_khachHang ql = new frm_khachHang();
            ql.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            frm_nhanVien ql = new frm_nhanVien();
            ql.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            fm_taiKhoan ql = new fm_taiKhoan();
            ql.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            frm_phong ql = new frm_phong();
            ql.Show();
        }

        private void frm_quanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                form_DangNhap a = new form_DangNhap();
                a.Show();
                this.Close();
            }
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            frm_TTHD a = new frm_TTHD();
            a.Show();
            this.Close();
        }
    }
}
