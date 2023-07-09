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
    public partial class frm_TTHD : Form
    {
        public string chuoi = "Select * from HOADON";
        public frm_TTHD()
        {
            InitializeComponent();
            DBConnect.Chuoiketnoi(chuoi, dta1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clear()
        {
            dta1.Columns[0].HeaderText = "Mã khách hàng "; dta1.Columns[0].Width = 150;
            dta1.Columns[1].HeaderText = "Tên khách hàng"; dta1.Columns[1].Width = 160;
            dta1.Columns[2].HeaderText = "Địa chỉ";
            dta1.Columns[3].HeaderText = "Số điện thoại";
        }
    }
}
