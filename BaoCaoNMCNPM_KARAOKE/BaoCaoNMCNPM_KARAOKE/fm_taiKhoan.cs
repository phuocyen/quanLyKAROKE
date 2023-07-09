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
    public partial class fm_taiKhoan : Form
    {
        public string chuoi = "select * from TAIKHOAN";
  
        public fm_taiKhoan()
        {
            InitializeComponent();
            DBConnect.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Tài khoản"; dta1.Columns[0].Width = 90;
            dta1.Columns[1].HeaderText = "Mật khẩu"; dta1.Columns[1].Width = 90;
            dta1.Columns[2].HeaderText = "Mã nhân viên"; dta1.Columns[2].Width = 110;    
            dta1.Columns[3].HeaderText = "Quyền"; dta1.Columns[3].Width = 70;

            cbbRole.SelectedIndex = 0;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string uername = txt_user.Text;
            string password = txt_pwd.Text;
            string manv = txt_manv.Text;
           


            string role = cbbRole.SelectedIndex.ToString();
            if (txt_user.Text == "" || txt_pwd.Text == "" || txt_manv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin! Vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string select = "select count(*) from TAIKHOAN where username='" + txt_user.Text + "'";
                    string them1 = "insert into TAIKHOAN Values ('" + uername + "','" + password + "','" + manv + "','" + role + "')";
                    DBConnect.Them(select, txt_user.Text, txt_pwd.Text, them1, dta1);
                    DBConnect.Chuoiketnoi(chuoi, dta1);
                    dta1.Columns[0].HeaderText = "Tài khoản";
                    dta1.Columns[1].HeaderText = "Mật khẩu";
                    dta1.Columns[2].HeaderText = "Mã nhân viên";
                  
                    dta1.Columns[3].HeaderText = "Quyền";
                    txt_user.Clear();
                    txt_pwd.Clear();
                    txt_manv.Clear();
                    cbbRole.SelectedIndex = 0;


                    txt_user.Focus();
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
            txt_user.Clear();
            txt_pwd.Clear();
            txt_manv.Clear();
            cbbRole.SelectedIndex = 0;
            txt_user.Focus();
            txt_user.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_pwd.Text;
            string manv = txt_manv.Text;
           
            string role = cbbRole.SelectedIndex.ToString();

            string sql = "Update TAIKHOAN set password ='" + password + "', manv='" + manv + "', isAdmin='" + role +
                "' where username = '" + txt_user.Text + "'";
            DBConnect.Execute1(sql);
            DBConnect.Chuoiketnoi(chuoi, dta1);

            dta1.Columns[0].HeaderText = "Tài khoản";
            dta1.Columns[1].HeaderText = "Mật khẩu";
            dta1.Columns[2].HeaderText = "Họ và tên";
         
            dta1.Columns[3].HeaderText = "Quyền";
            txt_user.Clear();
            txt_pwd.Clear();
            txt_manv.Clear();
            txt_user.Focus();
            txt_user.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from TAIKHOAN  where username = '" + txt_user.Text + "'";
            DBConnect.Execute(sql);
            // MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
            DBConnect.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Tài khoản";
            dta1.Columns[1].HeaderText = "Mật khẩu";
            dta1.Columns[2].HeaderText = "Họ và tên";
          
            dta1.Columns[3].HeaderText = "Quyền";
            txt_user.Clear();
            txt_pwd.Clear();
            txt_manv.Clear();
            txt_user.Focus();
            txt_user.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void dta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_user.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_pwd.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_manv.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            cbbRole.Text = dta1.Rows[curow].Cells[3].Value.ToString();
            txt_user.Enabled = false;
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
