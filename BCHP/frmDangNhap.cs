using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using BCHP.DAL;

namespace BCHP.Forms
{
    public partial class frmDangNhap : Form
    {
        private int saiLienTiep = 0;   // đếm số lần nhập sai liên tiếp
        private int giayConLai = 0;    // đếm ngược 30 giây khi bị khoá

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void chkHien_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkHien.Checked ? '\0' : '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string username = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text;

            bool thieu = false;
            if (string.IsNullOrEmpty(username))
            {
                errorProvider1.SetError(txtUsername, "Chưa nhập tên đăng nhập");
                thieu = true;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                errorProvider1.SetError(txtPassword, "Chưa nhập mật khẩu");
                thieu = true;
            }
            if (thieu) return;

            bool dungTaiKhoan;
            try
            {
                dungTaiKhoan = DatabaseHelper.DangNhap(username, matKhau);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL.\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dungTaiKhoan)
            {
                DatabaseHelper.LayThongTin(username);
                DialogResult = DialogResult.OK;
                return;
            }

            saiLienTiep++;
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu (" + saiLienTiep + "/3)",
                "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear();
            txtPassword.Focus();

            if (saiLienTiep >= 3)
            {
                giayConLai = 30;
                btnDangNhap.Enabled = false;
                lblDem.Text = "Sai 3 lần! Thử lại sau " + giayConLai + " giây";
                timer1.Start();
            }
        }

        // Timer: mỗi 1 giây chạy một lần (Interval = 1000)
        private void timer1_Tick(object sender, EventArgs e)
        {
            giayConLai--;
            lblDem.Text = "Sai 3 lần! Thử lại sau " + giayConLai + " giây";

            if (giayConLai <= 0)
            {
                timer1.Stop();
                btnDangNhap.Enabled = true;
                saiLienTiep = 0;
                lblDem.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // Mở form đăng ký bằng ShowDialog
        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy f = new frmDangKy();
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtUsername.Text = f.UsernameMoi;   // điền sẵn tên vừa đăng ký
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        // Designer đang gắn hàm này vào pnlPhai.Paint nên phải giữ lại
        private void pnlPhai_Paint(object sender, PaintEventArgs e) { }

        // Quên mật khẩu: xác minh bằng tên đăng nhập + email, rồi đặt mật khẩu mới
        private void lnkQuen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string u = Interaction.InputBox("Nhập tên đăng nhập:", "Quên mật khẩu", txtUsername.Text).Trim();
            if (u == "") return;

            string em = Interaction.InputBox("Nhập email đã đăng ký:", "Quên mật khẩu").Trim();
            if (em == "") return;

            string mk = Interaction.InputBox("Nhập mật khẩu mới (từ 6 ký tự, có ít nhất 1 chữ số):", "Quên mật khẩu");
            if (mk.Length < 6 || mk.IndexOfAny("0123456789".ToCharArray()) < 0)
            {
                MessageBox.Show("Mật khẩu mới phải từ 6 ký tự và có ít nhất 1 chữ số", "Quên mật khẩu");
                return;
            }

            try
            {
                if (DatabaseHelper.DoiMatKhau(u, em, mk))
                {
                    MessageBox.Show("Đổi mật khẩu thành công, hãy đăng nhập lại", "Quên mật khẩu",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Text = u;
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc email không đúng", "Quên mật khẩu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được CSDL.\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
