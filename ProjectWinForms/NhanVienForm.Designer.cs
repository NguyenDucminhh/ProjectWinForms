namespace ProjectWinForms
{
    partial class NhanVienForm
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
            panel1 = new Panel();
            cbNu = new CheckBox();
            label6 = new Label();
            txtDiaChi = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            txtHo = new TextBox();
            txtMaNV = new TextBox();
            label3 = new Label();
            txtHoaaa = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvNhanVien = new DataGridView();
            btnTrove = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnReload = new Button();
            dtpNgayNV = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpNgayNV);
            panel1.Controls.Add(cbNu);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(txtHo);
            panel1.Controls.Add(txtMaNV);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtHoaaa);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 111);
            panel1.TabIndex = 1;
            // 
            // cbNu
            // 
            cbNu.AutoSize = true;
            cbNu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbNu.Location = new Point(349, 8);
            cbNu.Name = "cbNu";
            cbNu.Size = new Size(50, 25);
            cbNu.TabIndex = 14;
            cbNu.Text = "Nữ";
            cbNu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(260, 46);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 12;
            label6.Text = "Ngày NV";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(349, 83);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(149, 23);
            txtDiaChi.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(260, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 10;
            label2.Text = "Địa Chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(510, 12);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 9;
            label5.Text = "SDT";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(563, 12);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(141, 23);
            txtSDT.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(101, 81);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(134, 23);
            txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(101, 50);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(134, 23);
            txtHo.TabIndex = 4;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(100, 15);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(88, 23);
            txtMaNV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 81);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 2;
            label3.Text = "Tên";
            // 
            // txtHoaaa
            // 
            txtHoaaa.AutoSize = true;
            txtHoaaa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoaaa.Location = new Point(26, 48);
            txtHoaaa.Name = "txtHoaaa";
            txtHoaaa.Size = new Size(56, 21);
            txtHoaaa.TabIndex = 1;
            txtHoaaa.Text = "Họ Lót";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 14);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvNhanVien);
            panel2.Location = new Point(31, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 228);
            panel2.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(0, 0);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowTemplate.Height = 25;
            dgvNhanVien.Size = new Size(719, 228);
            dgvNhanVien.TabIndex = 0;
            // 
            // btnTrove
            // 
            btnTrove.Location = new Point(673, 379);
            btnTrove.Name = "btnTrove";
            btnTrove.Size = new Size(75, 23);
            btnTrove.TabIndex = 15;
            btnTrove.Text = "Trở về";
            btnTrove.UseVisualStyleBackColor = true;
            btnTrove.Click += btnTrove_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(563, 379);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(454, 379);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(346, 379);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(235, 379);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(130, 379);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(29, 379);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(75, 23);
            btnReload.TabIndex = 9;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // dtpNgayNV
            // 
            dtpNgayNV.Location = new Point(349, 48);
            dtpNgayNV.Name = "dtpNgayNV";
            dtpNgayNV.Size = new Size(149, 23);
            dtpNgayNV.TabIndex = 15;
            // 
            // NhanVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 405);
            Controls.Add(btnTrove);
            Controls.Add(btnXoa);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnReload);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NhanVienForm";
            Text = "Quản Lý Danh Mục Nhân Viên";
            Load += NhanVienForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TextBox txtSDT;
        private TextBox txtTen;
        private TextBox txtHo;
        private TextBox txtMaNV;
        private Label label3;
        private Label txtHoaaa;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvNhanVien;
        private Button btnTrove;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private Button btnReload;
        private CheckBox cbNu;
        private Label label6;
        private TextBox txtDiaChi;
        private Label label2;
        private DateTimePicker dtpNgayNV;
    }
}