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
    public partial class frm_khachHang : Form
    {
        public string chuoi = "Select * from KHACHHANG";
       
        public frm_khachHang()
        {
            InitializeComponent();
            DBConnect.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

     
        public void clear()
        {
            dta1.Columns[0].HeaderText = "Mã khách hàng "; dta1.Columns[0].Width = 150;
            dta1.Columns[1].HeaderText = "Tên khách hàng"; dta1.Columns[1].Width = 160;
            dta1.Columns[2].HeaderText = "Địa chỉ";
            dta1.Columns[3].HeaderText = "Số điện thoại";
            
            txt_makh.Text = "";
            txt_hoten.Text = "";
            txt_diachi.Text = "";
           
            txt_sdt.Text = "";
            txt_makh.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_hoten.Text == "" || txt_diachi.Text == "" || txt_sdt.Text == "" )
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into KHACHHANG values('" + txt_makh.Text + "',N'" + txt_hoten.Text + "',N'" + txt_diachi.Text + "','" + txt_sdt.Text + "')";
                DBConnect.them_dl(sql1, dta1);
                DBConnect.Chuoiketnoi(chuoi, dta1);
                clear();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "update KHACHHANG set TENKH = N'" + txt_hoten.Text + "',DIACHI = N'"+txt_diachi.Text+"', SDT = '"+txt_sdt.Text +"' where MAKH = '"+txt_makh.Text+"'";
            DBConnect.Execute1(sql);
            DBConnect.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {

            clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from KHACHHANG where MAKH= '" + txt_makh.Text + "'";
            DBConnect.Execute(sql);
            DBConnect.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void dta1_Click(object sender, EventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_makh.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_hoten.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_diachi.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            txt_sdt.Text = dta1.Rows[curow].Cells[3].Value.ToString();

            txt_makh.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txt_congno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void btn_in_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select * from KHACHHANG where TENKH like N'%" + txt_search.Text + "%' ";
            DBConnect.timkiem(load1, dta1);
            clear();
        }

        private void frm_khachHang_Load(object sender, EventArgs e)
        {

        }

        private void dta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
