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


namespace ProjectWinForms
{

    public partial class DanhMucForm : Form
    {

        public DanhMucForm()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string strConnectionString = "Data Source=DESKTOP-FILOATR\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;User ID=sa;Password=123";
        SqlConnection conn = null;
        SqlDataAdapter daTable = null;
        DataTable dtTable = null;
        private void DanhMucForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                int intDM = Convert.ToInt32(this.Text);
                switch (intDM)
                {
                    case 1:
                        lblDanhMuc.Text = "Danh mục Thành Phố";
                        daTable = new SqlDataAdapter("  SELECT ThanhPho,TENTHANHPHO FROM ThanhPho",
                            conn);
                        break;
                    case 2:
                        lblDanhMuc.Text = "Danh mục Khách Hàng";
                        daTable = new SqlDataAdapter("SELECT MaKH,TENCTY FROM KHACHHANG",
                            conn);
                        break;
                    case 3:
                        lblDanhMuc.Text = "Danh mục Nhân Viên";
                        daTable = new SqlDataAdapter("SELECT MANV,HO,TEN FROM NHANVIEN",
                            conn);
                        break;
                    case 4:
                        lblDanhMuc.Text = "Danh mục Sản Phẩm";
                        daTable = new SqlDataAdapter("SELECT MaSanPham,TenSanPham,DONGIA FROM SANPHAM",
                            conn);
                        break;
                    case 5:
                        lblDanhMuc.Text = "Danh mục Hóa Đơn";
                        daTable = new SqlDataAdapter("SELECT MAHD,MAKH,MANV FROM HOADON",
                            conn);
                        break;
                    case 6:
                        lblDanhMuc.Text = "Danh mục Hóa Đơn Chi Tiết";
                        daTable = new SqlDataAdapter("SELECT * FROM CHITIETHOADON",
                            conn);
                        break;
                    default: break;
                }
                dtTable = new DataTable();
                dtTable.Clear();
                daTable.Fill(dtTable);
                dgvDanhMuc.DataSource = dtTable;
                dgvDanhMuc.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");

                Console.WriteLine(ex.ToString);
            }
        }
    }
}
