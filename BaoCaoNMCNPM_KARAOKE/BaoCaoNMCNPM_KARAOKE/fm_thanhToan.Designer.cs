namespace BaoCaoNMCNPM_KARAOKE
{
    partial class fm_thanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_tien = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_thoiGian = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tenPhong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_quyen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh toán";
            // 
            // dt1
            // 
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Location = new System.Drawing.Point(412, 81);
            this.dt1.Name = "dt1";
            this.dt1.RowTemplate.Height = 24;
            this.dt1.Size = new System.Drawing.Size(625, 347);
            this.dt1.TabIndex = 1;
            this.dt1.Click += new System.EventHandler(this.db1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhân viên";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(187, 81);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(171, 22);
            this.txt_timkiem.TabIndex = 5;
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // txt_maphong
            // 
            this.txt_maphong.Location = new System.Drawing.Point(187, 240);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(178, 22);
            this.txt_maphong.TabIndex = 5;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(187, 340);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(178, 22);
            this.txt_manv.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thành tiền";
            // 
            // lb_tien
            // 
            this.lb_tien.AutoSize = true;
            this.lb_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tien.Location = new System.Drawing.Point(672, 461);
            this.lb_tien.Name = "lb_tien";
            this.lb_tien.Size = new System.Drawing.Size(47, 25);
            this.lb_tien.TabIndex = 8;
            this.lb_tien.Text = ".......";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thời gian";
            // 
            // txt_thoiGian
            // 
            this.txt_thoiGian.Location = new System.Drawing.Point(187, 383);
            this.txt_thoiGian.Name = "txt_thoiGian";
            this.txt_thoiGian.Size = new System.Drawing.Size(178, 22);
            this.txt_thoiGian.TabIndex = 5;
            this.txt_thoiGian.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thoiGian_KeyPress);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(62, 536);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(296, 54);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_nhapLai_Click);
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.Location = new System.Drawing.Point(515, 536);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(307, 54);
            this.btn_thanhToan.TabIndex = 9;
            this.btn_thanhToan.Text = "Thanh toán";
            this.btn_thanhToan.UseVisualStyleBackColor = true;
            this.btn_thanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tên phòng";
            // 
            // txt_tenPhong
            // 
            this.txt_tenPhong.Location = new System.Drawing.Point(187, 282);
            this.txt_tenPhong.Name = "txt_tenPhong";
            this.txt_tenPhong.Size = new System.Drawing.Size(178, 22);
            this.txt_tenPhong.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Đơn giá";
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(187, 433);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(178, 22);
            this.txt_gia.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1049, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "Thoát";
            this.toolStripLabel1.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(187, 188);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(171, 22);
            this.txt_makh.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mã hóa đơn";
            // 
            // txt_maHD
            // 
            this.txt_maHD.Location = new System.Drawing.Point(187, 141);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.Size = new System.Drawing.Size(171, 22);
            this.txt_maHD.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(611, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Xin chào :";
            // 
            // lb_quyen
            // 
            this.lb_quyen.AutoSize = true;
            this.lb_quyen.Location = new System.Drawing.Point(688, 31);
            this.lb_quyen.Name = "lb_quyen";
            this.lb_quyen.Size = new System.Drawing.Size(20, 17);
            this.lb_quyen.TabIndex = 13;
            this.lb_quyen.Text = "...";
            // 
            // fm_thanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 614);
            this.Controls.Add(this.lb_quyen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_maHD);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btn_thanhToan);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lb_tien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_thoiGian);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.txt_tenPhong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.label1);
            this.Name = "fm_thanhToan";
            this.Text = "fm_thanhToan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fm_thanhToan_FormClosing);
            this.Load += new System.EventHandler(this.fm_thanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_tien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_thoiGian;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tenPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_quyen;
    }
}