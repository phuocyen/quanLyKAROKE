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
    public partial class fm_thanhToan : Form
    {
      
        public int a = 0;
        public int y = 0;

        public string chuoi = "Select * from PHONG";

        public fm_thanhToan()
        {
            InitializeComponent();
            Load_dta1();

            txt_tenPhong.Enabled = false;
            txt_maphong.Enabled = false;
            txt_gia.Enabled = false;
            
        }

        private void frm_banHang_Load(object sender, EventArgs e)
        {

        }

        public void Load_dta1()
        {
            DBConnect.Chuoiketnoi(chuoi, dt1);
            dt1.Columns[0].HeaderText = "Mã Phòng"; dt1.Columns[0].Width = 120;
            dt1.Columns[1].HeaderText = "Tên phòng"; dt1.Columns[1].Width = 120;
            dt1.Columns[2].HeaderText = "Loại phòng"; dt1.Columns[3].Width = 120;
            
            dt1.Columns[3].HeaderText = "Đơn giá"; dt1.Columns[2].Width = 120;
       }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select * from PHONG where TENPHONG like N'%" + txt_timkiem.Text + "%' ";
            DBConnect.timkiem(load1, dt1);
            dt1.Columns[0].HeaderText = "Mã Phòng"; dt1.Columns[0].Width = 120;
            dt1.Columns[1].HeaderText = "Tên phòng"; dt1.Columns[1].Width = 120;
            dt1.Columns[2].HeaderText = "Loại phòng"; dt1.Columns[3].Width = 120;

            dt1.Columns[3].HeaderText = "Đơn giá"; dt1.Columns[2].Width = 120;
       
        }

        private void db1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void db1_Click(object sender, EventArgs e)
        {
            int curow = dt1.CurrentRow.Index;
            txt_maphong.Text = dt1.Rows[curow].Cells[0].Value.ToString();
            txt_tenPhong.Text = dt1.Rows[curow].Cells[1].Value.ToString();
           
            txt_gia.Text = dt1.Rows[curow].Cells[3].Value.ToString();
           
   
        }

        private void dta2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if ( txt_gia.Text == "" || txt_maphong.Text == "" || txt_tenPhong.Text == ""  || txt_thoiGian.Text == "")
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ", "Thông Báo", MessageBoxButtons.OK);
            else
            {
                int a = int.Parse(txt_gia.Text);
                int b = int.Parse(txt_thoiGian.Text);
                
                if (txt_thoiGian.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập thời gian sử dụng ! ", "Thông báo", MessageBoxButtons.OK);
                }

                

                else
                {
                    //int x = d - b;

                    double s = a * b;
                   
                   
                   
                    //string sql1 = "Update PHONG set solg ='" + x.ToString() + "'   WHERE MAPHONG ='" + dta2.Rows[n].Cells[0].Value.ToString() + "'";
                    //DBConnect.luu(sql1);
                    //string load1 = "Select MAPHONG,TENPHONG,donvitinh,solg,giaban from  PHONG where  MAPHONG ='" + dta2.Rows[n].Cells[0].Value.ToString() + "' ";
                    //DBConnect.Chuoiketnoi(load1, dt1);
                   
                    txt_gia.Text = "";
                    txt_maphong.Text = "";
                    txt_tenPhong.Text = "";
                    txt_manv.Text = "";
                    txt_maHD.Text = "";
                    txt_makh.Text = "";
                    txt_tenPhong.Text = "";
                    
                    txt_thoiGian.Text = "1";

                  

                    Load_dta1();

                   
                    lb_tien.Text = s.ToString() ;
                }

                string str1 = "Insert into HOADON Values('" + txt_maHD.Text + "','" + txt_maphong.Text + "','"  +txt_manv.Text + "','"+txt_makh.Text+ "','"+txt_thoiGian.Text+"','"+lb_tien.Text+"')";
                 DBConnect.them_dl1(str1);
            }
        }

        //private void btn_Xoa_Click(object sender, EventArgs e)
        //{
        //    try
        //    {


        //        int h = a + y;
        //        string sql1 = "Update PHONG set Solg ='" + h.ToString() + "' WHERE MAPHONG ='" + txt_maphong.Text + "'";
        //        DBConnect.Execute(sql1);
        //        string load1 = "Select MAPHONG,TENPHONG,donvitinh,solg,giaban from PHONG  where  MAPHONG ='" + txt_maphong.Text + "' ";
        //        DBConnect.Chuoiketnoi(load1, dt1);
        //        int seleRow = dta2.CurrentCell.RowIndex;
        //        dta2.Rows.RemoveAt(seleRow);
        //        double thanhtien = 0;
        //        int sc = dta2.Rows.Count;
        //        txt_donvitinh.Text = "";
        //        txt_gia.Text = "";
        //        txt_maphong.Text = "";
        //        txt_tenPhong.Text = "";
        //        txt_hangtrongkho.Text = "";

        //        txt_thoiGian.Text = "1";
        //        btn_Xoa.Enabled = false;

        //        for (int i = 0; i < sc - 1; i++)
        //        {
        //            thanhtien += float.Parse(dta2.Rows[i].Cells[5].Value.ToString());
        //        }
        //        btn_Add.Enabled = true;
        //        txt_thoiGian.Enabled = true;
        //        btn_Xoa.Enabled = false;
        //        double g = double.Parse(txt_chietKhau.Text.ToString());
        //        double m = thanhtien + thanhtien * g / 100;
        //        lb_tien.Text = m.ToString();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Ban chua chọn thuoc sản phẩm để xóa ! ", "Thong bao", MessageBoxButtons.OK);
        //    }
        //    Load_dta1();
        //}

        private void btn_nhapLai_Click(object sender, EventArgs e)
        {

            txt_gia.Text = "";
            txt_maphong.Text = "";
            txt_tenPhong.Text = "";
            txt_manv.Text = "";
            txt_maHD.Text = "";
            txt_makh.Text = "";
            txt_tenPhong.Text = "";

            txt_thoiGian.Text = "1";
           
            txt_thoiGian.Enabled = true;
          
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        //private void TongTien_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (dta2.RowCount == 1)
        //        {
        //            MessageBox.Show("Danh sách trống không thể xuất file!");
        //        }
        //        else
        //        {
        //            DateTime nagy = DateTime.Now;
        //            string tim = nagy.ToString();
        //            string randomNameFile = tim.Replace(" ", "_").Replace("/", "-").Replace(":", "-");
        //            double thanhtien = 0;
        //            string s = "";
        //            int sc = dta2.Rows.Count;
        //            for (int i = 0; i < sc - 1; i++)
        //            {
        //                s += dta2.Rows[i].Cells[1].Value.ToString() + " : " + dta2.Rows[i].Cells[4].Value.ToString() + ",  ";
        //                thanhtien += double.Parse(dta2.Rows[i].Cells[5].Value.ToString());

        //            }
        //            double g = double.Parse(txt_chietKhau.Text.ToString());
        //            double m = thanhtien + thanhtien * g / 100;

        //            string date = date1.Text.Trim();

        //            string str1 = "Insert into chitietdonhang Values('" + s.ToString() + "','" + date + "','" + m.ToString() + "',N'" + lb_quyen.Text + "')";
        //            DBConnect.them_dl1(str1);

        //            string duongdan = "";

        //            //XuatExecl.nhapnhieu(dta2, duongdan, randomNameFile, lb_tien.Text, lb_Tile.Text, txt_chietKhau.Text);
        //            MessageBox.Show("Thực hiện thành công ", "Thông báo ", MessageBoxButtons.OK);
        //            dta2.Rows.Clear();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void txt_slgban_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_thoiGian_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        
        }

       

        private void date1_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void Menu_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                form_DangNhap a = new form_DangNhap();
                a.Show();
                this.Close();
            }
        }

        private void fm_thanhToan_Load(object sender, EventArgs e)
        {

        }

        private void fm_thanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               
                this.Close();

            }
        }

      
      
    }
}
