namespace ProjectWinForms
{
    partial class ThanhPhoForm
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
            dgvThanhPho = new DataGridView();
            panel1 = new Panel();
            txtTTP = new TextBox();
            txtTP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnReLoad = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnTroVe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThanhPho).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvThanhPho
            // 
            dgvThanhPho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhPho.Location = new Point(37, 89);
            dgvThanhPho.Name = "dgvThanhPho";
            dgvThanhPho.RowTemplate.Height = 25;
            dgvThanhPho.Size = new Size(222, 205);
            dgvThanhPho.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTTP);
            panel1.Controls.Add(txtTP);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(37, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 72);
            panel1.TabIndex = 1;
            // 
            // txtTTP
            // 
            txtTTP.Location = new Point(109, 38);
            txtTTP.Name = "txtTTP";
            txtTTP.Size = new Size(162, 23);
            txtTTP.TabIndex = 3;
            // 
            // txtTP
            // 
            txtTP.Location = new Point(107, 2);
            txtTP.Name = "txtTP";
            txtTP.Size = new Size(164, 23);
            txtTP.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 43);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Thành Phố";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 5);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Thành Phố";
            // 
            // btnReLoad
            // 
            btnReLoad.Location = new Point(353, 137);
            btnReLoad.Name = "btnReLoad";
            btnReLoad.Size = new Size(75, 23);
            btnReLoad.TabIndex = 2;
            btnReLoad.Text = "ReLoad";
            btnReLoad.UseVisualStyleBackColor = true;
            btnReLoad.Click += btnReLoad_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(353, 89);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(265, 186);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 23);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(353, 186);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(265, 137);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(265, 89);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(265, 245);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(166, 49);
            btnTroVe.TabIndex = 8;
            btnTroVe.Text = "Trở Về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // ThanhPhoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 351);
            Controls.Add(btnTroVe);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnThem);
            Controls.Add(btnReLoad);
            Controls.Add(panel1);
            Controls.Add(dgvThanhPho);
            Name = "ThanhPhoForm";
            Text = "ThanhPhoForm";
            Load += ThanhPhoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThanhPho).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvThanhPho;
        private Panel panel1;
        private TextBox txtTP;
        private Label label2;
        private Label label1;
        private TextBox txtTTP;
        private Button btnReLoad;
        private Button btnThem;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTroVe;
    }
}