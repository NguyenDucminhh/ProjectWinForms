namespace ProjectWinForms
{
    partial class DanhMucForm
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
            lblDanhMuc = new Label();
            dgvDanhMuc = new DataGridView();
            btnTroVe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();
            // 
            // lblDanhMuc
            // 
            lblDanhMuc.AutoSize = true;
            lblDanhMuc.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDanhMuc.ForeColor = Color.FromArgb(128, 128, 255);
            lblDanhMuc.Location = new Point(115, 9);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.Size = new Size(231, 30);
            lblDanhMuc.TabIndex = 0;
            lblDanhMuc.Text = "Danh Mục Khách Hàng";
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMuc.Location = new Point(76, 42);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.RowTemplate.Height = 25;
            dgvDanhMuc.Size = new Size(316, 160);
            dgvDanhMuc.TabIndex = 1;
            dgvDanhMuc.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(395, 232);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(75, 23);
            btnTroVe.TabIndex = 2;
            btnTroVe.Text = "Trở Về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // DanhMucForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 296);
            Controls.Add(btnTroVe);
            Controls.Add(dgvDanhMuc);
            Controls.Add(lblDanhMuc);
            Name = "DanhMucForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DanhMucForm";
            Load += DanhMucForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDanhMuc;
        private DataGridView dgvDanhMuc;
        private Button btnTroVe;
    }
}