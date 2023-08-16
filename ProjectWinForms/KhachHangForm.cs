using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWinForms
{
    public partial class KhachHangForm : Form
    {
        public KhachHangForm()
        {
            InitializeComponent();

        }

        bool them;
        void loadData()
        {

            // câu lệnh dùng để fill data lên bảng
            string query = "SELECT * FROM KHACHHANG";
            string query2 = " SELECT ThanhPho,TenThanhPho FROM ThanhPho";
            DataTable data = DataBaseManager.ExecuteQuery(query);
            DataTable data2 = DataBaseManager.ExecuteQuery(query2);
            dgvKhachHang.DataSource = data;
            cbbTP.DataSource = data2;
            cbbTP.DisplayMember = "TenThanhPho";
            cbbTP.ValueMember = "ThanhPho";
            //panel1.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnReload.Enabled = false;


        }
        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.them = true;
            txtCty.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            txtMaKH.ResetText();
            txtMaKH.Focus();

            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnReload.Enabled = true;

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try
                {
                    string query = "INSERT INTO KHACHHANG VALUES (@MaKH,@TenCty,@DiaChi,@ThanhPho,@DienThoai)";
                    using (SqlConnection conn = DataBaseManager.GetConnection())
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                            cmd.Parameters.AddWithValue("@TenCty", txtCty.Text);
                            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@ThanhPho", cbbTP.SelectedValue);
                            cmd.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
                            cmd.ExecuteNonQuery();
                        }

                    }
                    MessageBox.Show("Them thanh cong");
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Console.WriteLine(ex);
                }
            }
            if (!them)
            {

                int r = dgvKhachHang.CurrentCell.RowIndex;
                string strKH = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
                string query = "UPDATE KHACHHANG SET TenCty = @TenCty," +
                    " DiaChi = @DiaChi, DienThoai = @DienThoai, ThanhPho = @ThanhPho WHERE MaKH = @MaKH";
                using (SqlConnection conn = DataBaseManager.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                        cmd.Parameters.AddWithValue("@TenCty", txtCty.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@ThanhPho", cbbTP.SelectedValue);
                        cmd.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                loadData();
                MessageBox.Show("Update Thanh cong");
            }

        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            this.btnReload.Enabled = true;
            int r = dgvKhachHang.CurrentCell.RowIndex;

            this.txtMaKH.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            this.txtCty.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            this.cbbTP.SelectedValue = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
            this.txtSDT.Text = dgvKhachHang.Rows[r].Cells[4].Value.ToString();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnReload.Enabled = true;

            this.txtMaKH.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtCty.Clear();
            txtDiaChi.Clear();
            txtMaKH.Clear();
            txtSDT.Clear();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon xoa khong?", "Thong bao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int r = dgvKhachHang.CurrentCell.RowIndex;
                    string strKH = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
                    string query = "DELETE FROM KHACHHANG WHERE MaKH = @MaKH";
                    using (SqlConnection conn = DataBaseManager.GetConnection())
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaKH", strKH);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    loadData();
                    MessageBox.Show("Da xoa thanh cong");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        }
    
}

