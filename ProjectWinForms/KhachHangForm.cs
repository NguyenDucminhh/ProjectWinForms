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
            string query2 = " SELECT TenThanhPho FROM ThanhPho";
            DataTable data = DataBaseManager.ExecuteQuery(query);
            DataTable data2 = DataBaseManager.ExecuteQuery(query2);
            dgvKhachHang.DataSource = data;
            cbbTP.DataSource = data2;
            cbbTP.DisplayMember= "TenThanhPho";
            cbbTP.ValueMember = "TenThanhPho";
            //panel1.Enabled = false;

        }
        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}

