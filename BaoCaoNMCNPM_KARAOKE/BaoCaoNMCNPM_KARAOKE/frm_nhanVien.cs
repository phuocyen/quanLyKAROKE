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
    public partial class frm_nhanVien : Form
    {
      
        public string chuoi = "select * from NHANVIEN";

        public frm_nhanVien()
        {
            InitializeComponent();
            DBConnect.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Mã nhân viên"; dta1.Columns[0].Width = 90;
            dta1.Columns[1].HeaderText = "Tên nhân viên"; dta1.Columns[1].Width = 90;
            dta1.Columns[2].HeaderText = "Ngày sinh"; dta1.Columns[2].Width = 110;
            

            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string uername = txt_manv.Text;
            string hoten = txt_hoten.Text;
         
            string date = txt_ns.Text;


          
            if (txt_manv.Text == "" || txt_hoten.Text == "" || date == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin! Vui lòng kiểm tra lại ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string select = "select count(*) from NHANVIEN where MANV='" + txt_manv.Text + "'";
                    string them1 = "insert into NHANVIEN Values ('" + uername + "','" + hoten + "','"  + date + "')";
                    DBConnect.Them(select, txt_manv.Text, txt_hoten.Text, them1, dta1);
                    DBConnect.Chuoiketnoi(chuoi, dta1);
                    dta1.Columns[0].HeaderText = "Mã nhân viên";
                    dta1.Columns[1].HeaderText = "Tên nhân viên";
                  
                    dta1.Columns[2].HeaderText = "Ngày sinh";
                   
                    txt_manv.Clear();
                    txt_hoten.Clear();
                    txt_ns.Clear();
                   


                    txt_manv.Focus();
                    btn_them.Enabled = true;
                    btn_xoa.Enabled = false;
                    btn_sua.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại! Vui lòng nhập lại", "Error", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_manv.Clear();
            txt_hoten.Clear();
            txt_ns.Clear();
           
            txt_manv.Focus();
            txt_manv.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string manv = txt_manv.Text.Trim();
            string hoten = txt_hoten.Text;
           
            string date = txt_ns.Text.Trim();
         

            string sql = "Update NHANVIEN set TENNV = 'N"+ hoten + "', NGAYSINH='" + date +
                "' where MANV = '" + txt_manv.Text + "'";
            DBConnect.Execute1(sql);
            DBConnect.Chuoiketnoi(chuoi, dta1);

            dta1.Columns[0].HeaderText = "Mã nhân viên";
            dta1.Columns[1].HeaderText = "Tên nhân viên";
          
            dta1.Columns[2].HeaderText = "Ngày sinh";
           
            txt_manv.Clear();
            txt_hoten.Clear();
            txt_ns.Clear();
            txt_manv.Focus();
            txt_manv.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from NHANVIEN  where MANV = '" + txt_manv.Text.Trim() + "'";
            DBConnect.Execute(sql);
            // MessageBox.Show("Bạn xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
            DBConnect.Chuoiketnoi(chuoi, dta1);
            dta1.Columns[0].HeaderText = "Mã nhân viên";
            dta1.Columns[1].HeaderText = "Tên nhân viên";
          
            dta1.Columns[2].HeaderText = "Ngày sinh";
          
            txt_manv.Clear();
            txt_hoten.Clear();
            txt_ns.Clear();
            txt_manv.Focus();
            txt_manv.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void dta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_manv.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_hoten.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_ns.Text = dta1.Rows[curow].Cells[2].Value.ToString();
          
            txt_manv.Enabled = false;
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

        private void frm_nhanVien_Load(object sender, EventArgs e)
        {

        }
    }
}
