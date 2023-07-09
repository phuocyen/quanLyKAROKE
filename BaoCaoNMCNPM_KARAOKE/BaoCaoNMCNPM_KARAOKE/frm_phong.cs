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
    public partial class frm_phong : Form
    {
        public string chuoi = "select * from PHONG";

        public frm_phong()
        {
            InitializeComponent();
            DBConnect.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Mã phòng"; dta1.Columns[0].Width = 90;
            dta1.Columns[1].HeaderText = "Tên Phòng"; dta1.Columns[1].Width = 90;
            dta1.Columns[2].HeaderText = "Loại Phòng"; dta1.Columns[2].Width = 110;
            dta1.Columns[3].HeaderText = "Đơn Giá"; dta1.Columns[3].Width = 110;
            

            cbo_loai.SelectedIndex = 0;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string MAPHONG = txt_maphong.Text;
            string TENPHONG = txt_tenphong.Text;
         
            string dg = txt_dongia.Text.Trim();


            string role = cbo_loai.SelectedIndex.ToString();
            if (txt_maphong.Text == "" || txt_tenphong.Text == "" || txt_dongia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin! Vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string select = "select count(*) from PHONG where MAPHONG='" + txt_maphong.Text + "'";
                    string them1 = "insert into PHONG Values ('" + MAPHONG + "','" + TENPHONG + "','" + role + "','"+dg+"')";
                    DBConnect.Them(select, txt_maphong.Text, txt_tenphong.Text, them1, dta1);
                    DBConnect.Chuoiketnoi(chuoi, dta1);
                    dta1.Columns[0].HeaderText = "Mã phòng"; 
                    dta1.Columns[1].HeaderText = "Tên Phòng";
                    dta1.Columns[2].HeaderText = "Loại Phòng"; 
                    dta1.Columns[3].HeaderText = "Đơn Giá"; 
                    txt_maphong.Clear();
                    txt_tenphong.Clear();
                    txt_dongia.Clear();
                    cbo_loai.SelectedIndex = 0;


                    txt_maphong.Focus();
                    btn_them.Enabled = true;
                    btn_xoa.Enabled = false;
                    btn_sua.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Tài khoản đã tồn tại! Vui lòng nhập lại", "Error", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_maphong.Clear();
            txt_tenphong.Clear();
         
            cbo_loai.SelectedIndex = 0;
            txt_maphong.Focus();
            txt_maphong.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string MAPHONG = txt_maphong.Text.Trim();
            string TENPHONG = txt_tenphong.Text.Trim();
            string dg = txt_dongia.Text.Trim();
            string role = cbo_loai.SelectedIndex.ToString();

            string sql = "Update PHONG set TENPHONG ='" + TENPHONG + "', MALP='" + role + "', DONGIA='" + txt_dongia.Text +"' where MAPHONG = '" + txt_maphong.Text + "'";
            DBConnect.Execute1(sql);
            DBConnect.Chuoiketnoi(chuoi, dta1);

            dta1.Columns[0].HeaderText = "Mã phòng";
            dta1.Columns[1].HeaderText = "Tên Phòng";
            dta1.Columns[2].HeaderText = "Loại Phòng";
            dta1.Columns[3].HeaderText = "Đơn Giá"; 
            txt_maphong.Clear();
            txt_tenphong.Clear();
         
            txt_maphong.Focus();
            txt_maphong.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from PHONG  where MAPHONG = '" + txt_maphong.Text + "'";
            DBConnect.Execute(sql);
            // MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
            DBConnect.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Mã phòng";
            dta1.Columns[1].HeaderText = "Tên Phòng";
            dta1.Columns[2].HeaderText = "Loại Phòng";
            dta1.Columns[3].HeaderText = "Đơn Giá"; 
            txt_maphong.Clear();
            txt_tenphong.Clear();
            
            txt_maphong.Focus();
            txt_maphong.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void dta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_maphong.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_tenphong.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            cbo_loai.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            txt_maphong.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
