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
    public partial class NhanVienForm : Form
    {
        public NhanVienForm()
        {
            InitializeComponent();
        }
        bool them;
        void loadData()
        {

            // câu lệnh dùng để fill data lên bảng
            string query = "SELECT * FROM NhanVien";
            DataTable data = DataBaseManager.ExecuteQuery(query);
            dgvNhanVien.DataSource = data;
            panel1.Enabled = false;
            //panel1.Enabled = false;
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
         
            this.dgvNhanVien.Enabled = false;
        }

        private void NhanVienForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            this.them = true;
            dgvNhanVien.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            
            int r = dgvNhanVien.CurrentCell.RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            txtHo.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            txtTen.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            cbNu.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();

            // fill dữ liệu ngày tháng lên Date Time Picker
            string dateString = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
           
            DateTime dateValue;
            if(DateTime.TryParse(dateString,out dateValue))
            {
                dtpNgayNV.Value = dateValue;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                try
                {
                String query = "INSERT INTO NHANVIEN (MANV, HO, TEN, NU, NGAYNV, DIACHI, DIENTHOAI) VALUES " +
                "(@MANV, @HO, @TEN, @NU, @NGAYNV, @DIACHI, @DIENTHOAI)";
                    using (SqlConnection conn = DataBaseManager.GetConnection())
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                            cmd.Parameters.AddWithValue("@HO", txtHo.Text);
                            cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                            cmd.Parameters.AddWithValue("@Nu", cbNu.Checked);
                            cmd.Parameters.AddWithValue("@NGAYNV", dtpNgayNV.Value);
                            cmd.Parameters.AddWithValue("@DIACHI", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Thêm Thành Công!");
                        loadData();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    int r = dgvNhanVien.CurrentCell.RowIndex;
                    string strNV = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                    string query = "UPDATE NHANVIEN SET HO = @HO, TEN = @TEN, NU = @NU, NGAYNV = @NGAYNV, DIACHI = @DIACHI, DIENTHOAI = @DIENTHOAI WHERE MANV = @MANV";
                    using (SqlConnection conn = DataBaseManager.GetConnection())
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                            cmd.Parameters.AddWithValue("@Ho", txtHo.Text);
                            cmd.Parameters.AddWithValue("@Ten", txtTen.Text);
                            cmd.Parameters.AddWithValue("@Nu", cbNu.Checked);
                            cmd.Parameters.AddWithValue("@NgayNv", dtpNgayNV.Value);
                            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                            cmd.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
                            cmd.ExecuteNonQuery();
                        }
                        loadData();
                        MessageBox.Show("Update thanh cong");

                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtHo.Clear();
            txtMaNV.Clear();
            dtpNgayNV.Refresh();
            txtTen.Clear();
            txtMaNV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa không?","Thông báo",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int r = dgvNhanVien.CurrentCell.RowIndex;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
