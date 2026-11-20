using System;
using System.Drawing;
using System.Windows.Forms;
using BCHP.DAL;

namespace BCHP.Forms
{
    public partial class frmMain : Form
    {
        public bool DangXuat = false;   // true nếu người dùng chọn Hệ thống > Đăng xuất

        public frmMain()
        {
            InitializeComponent();

            // StatusStrip: ô 1 hiện người đang đăng nhập
            string vaiTro = DatabaseHelper.VaiTro == "Admin" ? "Quản trị viên" : "Nhân viên";
            tslNguoiDung.Text = "Người dùng: " + DatabaseHelper.HoTen + " (" + vaiTro + ")";

            tslSapHet.Text = "Sắp hết hàng: 0";   // sẽ đọc từ SQL ở phần sau
            tslDongHo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // ---------- StatusStrip ----------
        // Đồng hồ: Timer chạy mỗi 1 giây (Interval = 1000)
        private void timer1_Tick(object sender, EventArgs e)
        {
            tslDongHo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // Ô 2: tên form con đang hoạt động; chạy mỗi khi mở / đổi / đóng form con
        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            tslForm.Text = ActiveMdiChild != null ? "Form: " + ActiveMdiChild.Text : "Form: (chưa mở)";
        }

        // ---------- Mở form con, KHÔNG mở trùng ----------
        // Tạm tạo form con bằng code để thử MDI; sau này thay bằng form thật (frmBanh...)
        private void MoFormCon(string tieuDe)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Text == tieuDe)      // đã có thì chỉ đưa lên phía trước
                {
                    f.Activate();
                    return;
                }
            }

            Form con = new Form();
            con.Text = tieuDe;
            con.MdiParent = this;          // đặt form cha MDI
            con.BackColor = Color.White;

            Label lbl = new Label();
            lbl.Text = "Đây là form: " + tieuDe + "\n(sẽ thay bằng form thật ở phần sau)";
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 11F);
            lbl.Location = new Point(20, 20);
            con.Controls.Add(lbl);

            con.Show();
        }

        // ---------- Một chức năng, nhiều nơi gọi: menu, toolbar và phím tắt cùng dùng 1 hàm ----------
        private void mnuBanh_Click(object sender, EventArgs e) { MoFormCon("Danh mục bánh"); }              // Ctrl+1
        private void mnuBanBanh_Click(object sender, EventArgs e) { MoFormCon("Bán bánh - lập hoá đơn"); }  // Ctrl+2
        private void toolStripButton1_Click(object sender, EventArgs e) { mnuBanh_Click(sender, e); }

        private void mnuMoCSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Mở CSV sẽ làm ở phần sau.", "Thông báo");
        }
        private void mnuLuuCSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Lưu CSV sẽ làm ở phần sau.", "Thông báo");
        }
        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Báo cáo Doanh thu sẽ làm ở phần sau.", "Thông báo");
        }

        // ---------- Menu Cửa sổ: sắp xếp form con ----------
        private void mnuCascade_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.Cascade); }
        private void mnuTileH_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileHorizontal); }
        private void mnuTileV_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileVertical); }

        // ---------- Menu Hệ thống ----------
        private void mnuDangXuat_Click(object sender, EventArgs e) { }   // chưa có chức năng

        private void mnuThoat_Click(object sender, EventArgs e)   // Ctrl+Q
        {
            Close();                // DangXuat = false nên chương trình kết thúc
        }

        private void mnuGioiThieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm Quản lý Tiệm bánh Le Gaute\nSinh viên: Phạm Phương Thảo", "Giới thiệu");
        }
    }
}
