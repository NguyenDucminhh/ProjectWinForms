namespace ProjectWinForms
{
    partial class KhachHangForm
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
            label5 = new Label();
            label4 = new Label();
            txtSDT = new TextBox();
            cbbTP = new ComboBox();
            txtDiaChi = new TextBox();
            txtCty = new TextBox();
            txtMaKH = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvKhachHang = new DataGridView();
            btnReload = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnXoa = new Button();
            btnTrove = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(cbbTP);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtCty);
            panel1.Controls.Add(txtMaKH);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(42, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(719, 111);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(495, 54);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 9;
            label5.Text = "SDT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(495, 10);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 8;
            label4.Text = "Đia Chi";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(570, 52);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(121, 23);
            txtSDT.TabIndex = 7;
            // 
            // cbbTP
            // 
            cbbTP.FormattingEnabled = true;
            cbbTP.Location = new Point(570, 12);
            cbbTP.Name = "cbbTP";
            cbbTP.Size = new Size(121, 23);
            cbbTP.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(101, 81);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(222, 23);
            txtDiaChi.TabIndex = 5;
            // 
            // txtCty
            // 
            txtCty.Location = new Point(101, 50);
            txtCty.Name = "txtCty";
            txtCty.Size = new Size(222, 23);
            txtCty.TabIndex = 4;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(100, 15);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(222, 23);
            txtMaKH.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 81);
            label3.Name = "label3";
            label3.Size = new Size(60, 21);
            label3.TabIndex = 2;
            label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 48);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên Cty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã KH";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvKhachHang);
            panel2.Location = new Point(42, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 228);
            panel2.TabIndex = 1;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(68, 0);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowTemplate.Height = 25;
            dgvKhachHang.Size = new Size(541, 203);
            dgvKhachHang.TabIndex = 0;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(42, 375);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(75, 23);
            btnReload.TabIndex = 2;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(143, 375);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(248, 375);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(359, 375);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(467, 375);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(576, 375);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTrove
            // 
            btnTrove.Location = new Point(686, 375);
            btnTrove.Name = "btnTrove";
            btnTrove.Size = new Size(75, 23);
            btnTrove.TabIndex = 8;
            btnTrove.Text = "Trở về";
            btnTrove.UseVisualStyleBackColor = true;
            btnTrove.Click += btnTrove_Click;
            // 
            // KhachHangForm
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
            Name = "KhachHangForm";
            Text = "Quản Lý Danh Mục Khách Hàng";
            Load += KhachHangForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnReload;
        private Button btnThem;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnXoa;
        private Button btnTrove;
        private TextBox txtDiaChi;
        private TextBox txtCty;
        private TextBox txtMaKH;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox txtSDT;
        private ComboBox cbbTP;
        private DataGridView dgvKhachHang;
    }
}