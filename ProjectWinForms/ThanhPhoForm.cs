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
    public partial class ThanhPhoForm : Form
    {
        public ThanhPhoForm()
        {
            InitializeComponent();
        }
        string strConnectionString = "Data Source=DESKTOP-FILOATR\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123";
        SqlConnection conn = null;
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho = null;
        bool them;
        void loadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daThanhPho = new SqlDataAdapter("SELECT * FROM THANHPHO", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                dgvThanhPho.DataSource = dtThanhPho;
                dgvThanhPho.AutoResizeColumns();

                this.txtTP.ResetText();
                this.txtTTP.ResetText();
                this.btnHuy.Enabled = false;
                this.btnLuu.Enabled = false;
                this.btnReLoad.Enabled = false;

                this.btnSua.Enabled = true;
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {

            this.Close();
            /*dtThanhPho.Dispose();
            dtThanhPho = null;
            conn = null;*/
        }

        private void ThanhPhoForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            loadData();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            this.txtTP.ResetText();
            this.txtTTP.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnReLoad.Enabled = true;

            txtTP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            them = false;
            this.btnReLoad.Enabled = true;
            int r = dgvThanhPho.CurrentCell.RowIndex;

            this.txtTP.Text = dgvThanhPho.Rows[r].Cells[0].Value.ToString();
            this.txtTTP.Text = dgvThanhPho.Rows[r].Cells[1].Value.ToString();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.btnReLoad.Enabled = true;

            this.txtTP.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                int r = dgvThanhPho.CurrentCell.RowIndex;
                string strThanhPho =
                dgvThanhPho.Rows[r].Cells[1].Value.ToString();
                cmd.CommandText="DELETE FROM THANHPHO WHERE THANHPHO = @THANHPHO";
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Đã Xóa Xong");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
            conn.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtTP.ResetText();
            this.txtTTP.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.btnReLoad.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (them)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO THANHPHO VALUES(@ThanhPho ,@TenThanhPho)";
                    cmd.Parameters.AddWithValue("@ThanhPho", this.txtTP.Text);
                    cmd.Parameters.AddWithValue("@TenThanhPho", this.txtTTP.Text);
                    cmd.ExecuteNonQuery();
                    loadData();
                    MessageBox.Show("Thêm thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo");
                }
            }
            if (!them)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType= CommandType.Text;

                int r = dgvThanhPho.CurrentCell.RowIndex;
                string strThanhPho =
                dgvThanhPho.Rows[r].Cells[0].Value.ToString();
                cmd.CommandText = System.String.Concat("Update ThanhPho set TenThanhPho =' " +
                    this.txtTTP.Text.ToString() + "'WHERE THANHPHO ='" + strThanhPho + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                loadData();
                MessageBox.Show("Sửa thành công");
            }
            conn.Close();
        }
    }
}
