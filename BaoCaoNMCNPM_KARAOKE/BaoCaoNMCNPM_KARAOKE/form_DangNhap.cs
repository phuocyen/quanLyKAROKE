using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaoCaoNMCNPM_KARAOKE
{
    public partial class form_DangNhap : Form
    {
       public static string sqlcon = @"Data Source=DESKTOP-BH4JOH6;Initial Catalog=QL_KARAOKE;User ID=sa;Password=123456;Integrated Security= True";

        public static SqlConnection mycon;
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        public static SqlCommandBuilder bd;
        public form_DangNhap()
        {
            InitializeComponent();
        }
        public static string getNameUser(string fullname)
        {
            return fullname;
        }

        public static string username;

        public static void Chuoiketnoi(string chuoi, DataGridView db1)
        {
            try
            {

                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

        

       

        //public static string GetFullname(int isAdmin, string username)
        //{
        //    string sqlGetFullname = "Select fullname from taikhoan where isAdmin=" + isAdmin + " and username='" + username + "'";
        //    mycon = new SqlConnection(sqlcon);
        //    mycon.Open();
        //    SqlCommand getFullname = new SqlCommand(sqlGetFullname, mycon);
        //    string Fullname = getFullname.ExecuteScalar().ToString();

        //    return Fullname;
        //}

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            string sql1 = "Select count(*) from taikhoan where username='" + txt_user.Text.Trim() + "' and password='" + txt_pwd.Text.Trim() + "' ";
            if (txt_user.Text == "" || txt_pwd.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin! ", "Thông báo", MessageBoxButtons.OK);
            }

            else
            {
                int a = 0;
                mycon = new SqlConnection(sqlcon);
                mycon.Open();

                com = new SqlCommand(sql1, mycon);
                a = (int)com.ExecuteScalar();





                if (a == 0)
                {
                    string t = "Username hoặc password sai !,Bạn vui lòng kiểm tra lại ";
                    MessageBox.Show((t), "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = "Select isAdmin from taikhoan where username='" + txt_user.Text.Trim() + "'";
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    SqlCommand getIsAdmin = new SqlCommand(sql, mycon);
                    int getRole = (int)getIsAdmin.ExecuteScalar();

                    if (getRole == 0)
                    {

                        MessageBox.Show("Bạn đang đăng nhập dưới quyền của Admin", "Thông báo ", MessageBoxButtons.OK);
                        frm_quanLy a1 = new frm_quanLy();
                        fm_thanhToan bh = new fm_thanhToan();

                      a1.Show();
                     
                      
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đang đăng nhập dưới quyền của Nhân Vien", "Thông báo ", MessageBoxButtons.OK);

                        fm_thanhToan bh = new fm_thanhToan();
                        bh.Show();
                        this.Hide();

                    }
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               
                this.Close();
            }
        }

        private void form_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
