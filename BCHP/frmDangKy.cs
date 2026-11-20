using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCHP.DAL;

namespace BCHP.Forms
{
    public partial class frmDangKy : Form
    {
        public string UsernameMoi = "";   // form đăng nhập sẽ đọc để điền sẵn

        public frmDangKy()
        {
            InitializeComponent();
        }

        // ----- Mỗi hàm kiểm tra trả về "" nếu đúng, còn sai thì trả về câu báo lỗi -----
        private string LoiUsername()
        {
            string u = txtUsername.Text.Trim();
            if (u.Length < 4 || u.Length > 30) return "Tên đăng nhập phải từ 4 đến 30 ký tự";
            if (u.Contains(" ")) return "Tên đăng nhập không được có khoảng trắng";
            return "";
        }

        private string LoiPassword()
        {
            string p = txtPassword.Text;
            if (p.Length < 6) return "Mật khẩu phải từ 6 ký tự trở lên";

            bool coSo = false;                  // phải có ít nhất 1 chữ số
            foreach (char c in p)
                if (char.IsDigit(c)) coSo = true;

            return coSo ? "" : "Mật khẩu phải có ít nhất 1 chữ số";
        }

        private string LoiNhapLai()
        {
            return txtNhapLai.Text != txtPassword.Text ? "Mật khẩu nhập lại không khớp" : "";
        }

        private string LoiHoTen()
        {
            return txtHoTen.Text.Trim().Length < 2 ? "Họ tên phải từ 2 ký tự trở lên" : "";
        }

        private string LoiEmail()
        {
            string em = txtEmail.Text.Trim();
            if (em.Length == 0) return "Chưa nhập email";
            int viTriAt = em.IndexOf("@");
            if (viTriAt <= 0) return "Email phải có @ và phần tên phía trước";
            if (em.IndexOf(".", viTriAt) < 0) return "Email phải có dấu chấm sau @ (ví dụ: ten@gmail.com)";
            if (em.Contains(" ")) return "Email không được có khoảng trắng";
            return "";
        }

        // Hiện (hoặc xoá) dấu chấm than đỏ, trả về true nếu hợp lệ
        private bool HienLoi(Control o, string loi)
        {
            errorProvider1.SetError(o, loi);
            return loi == "";
        }

        // ----- Kiểm tra ngay khi rời ô: sự kiện Leave -----
        private void txtUsername_Leave(object sender, EventArgs e) { HienLoi(txtUsername, LoiUsername()); }
        private void txtPassword_Leave(object sender, EventArgs e) { HienLoi(txtPassword, LoiPassword()); }
        private void txtNhapLai_Leave(object sender, EventArgs e) { HienLoi(txtNhapLai, LoiNhapLai()); }
        private void txtHoTen_Leave(object sender, EventArgs e) { HienLoi(txtHoTen, LoiHoTen()); }
        private void txtEmail_Leave(object sender, EventArgs e) { HienLoi(txtEmail, LoiEmail()); }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra lại toàn bộ; dùng & để chạy đủ 5 lần, hiện hết lỗi cùng lúc
            bool hopLe = HienLoi(txtUsername, LoiUsername())
                       & HienLoi(txtPassword, LoiPassword())
                       & HienLoi(txtNhapLai, LoiNhapLai())
                       & HienLoi(txtHoTen, LoiHoTen())
                       & HienLoi(txtEmail, LoiEmail());
            if (!hopLe) return;

            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();

            try
            {
                if (DatabaseHelper.DaCoUsername(username))
                {
                    errorProvider1.SetError(txtUsername, "Tên đăng nhập đã tồn tại");
                    return;
                }
                if (DatabaseHelper.DaCoEmail(email))
                {
                    errorProvider1.SetError(txtEmail, "Email đã được dùng");
                    return;
                }

                string ma = DatabaseHelper.SinhMaTK();
                DatabaseHelper.ThemTaiKhoan(ma, username, txtPassword.Text,
                                            txtHoTen.Text.Trim(), rdoNam.Checked, email);

                MessageBox.Show("Đăng ký thành công! Mã tài khoản: " + ma, "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsernameMoi = username;
                DialogResult = DialogResult.OK;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi CSDL: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CheckBox "Hiện mật khẩu": hiện / ẩn cả hai ô mật khẩu
        private void chkHien_CheckedChanged(object sender, EventArgs e)
        {
            char c = chkHien.Checked ? '\0' : '*';
            txtPassword.PasswordChar = c;
            txtNhapLai.PasswordChar = c;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
