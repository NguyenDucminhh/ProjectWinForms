namespace ProjectWinForms
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }
        Form frm = new LoginForm();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            frm.ShowDialog();
        }

        private void cấuHìnhHệToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcNhânVIênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm.ShowDialog(this);

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        void xemDanhMuc(int intDanhMuc)
        {
            Form frm = new DanhMucForm();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemDanhMuc(1);
        }

        private void danhMụcThànhPhốToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new ThanhPhoForm();
            frm.Text = "Quản Lý Danh Mục Thành Phố";
            frm.ShowDialog();

        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemDanhMuc(2);
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemDanhMuc(3);
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemDanhMuc(4);
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemDanhMuc(5);
        }

        private void danhMụcChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemDanhMuc(6);
        }

        private void danhMụcKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form kh = new KhachHangForm();
            kh.Text = "Quản Lý Danh Mục Khách Hàng";
            kh.ShowDialog();
        }
    }
}