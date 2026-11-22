using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCHP.DAL;

namespace QuanLyBanBanh
{
    // frmDanhMucBanh.cs chỉ chứa phần XỬ LÝ (logic).
    // Phần GIAO DIỆN (các control) nằm trong frmDanhMucBanh.Designer.cs - bạn kéo thả trong cửa sổ Designer.
    public partial class frmDanhMucBanh : Form
    {
        // ----- Dữ liệu -----
        private readonly List<Cake> _allCakes = new List<Cake>();
        private bool _isBinding = false; // cờ: đang nạp bảng thì bỏ qua SelectionChanged
        private bool _ready = false;     // cờ: form dựng xong chưa (tránh event chạy sớm)
        private Font _boldFont;          // font đậm dùng để tô dòng tồn kho thấp

        public frmDanhMucBanh()
        {
            InitializeComponent(); // dựng giao diện (code do Designer sinh ra)

            _boldFont = new Font(Font, FontStyle.Bold);
            dgvCakes.AutoGenerateColumns = false;
            colDonGia.DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN"); // 180000 -> 180.000
            cboFilterLoai.SelectedIndex = 0;
            dtpHanDung.Value = DateTime.Today;

            _ready = true;
            TaiLai();
        }

        // Đọc lại danh sách từ SQL Server rồi vẽ lại bảng (cũng được frmMain gọi sau khi bán bánh)
        public void TaiLai()
        {
            try
            {
                _allCakes.Clear();
                _allCakes.AddRange(BanhDAL.LayTatCa());
                RefreshGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không đọc được danh mục bánh từ CSDL.\n" + ex.Message, "Lỗi CSDL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // Dữ liệu và hiển thị
        // =====================================================
        // Lọc theo ô tìm kiếm và loại, rồi đổ lên bảng
        private void RefreshGrid()
        {
            if (!_ready) return;

            string keyword = txtSearch.Text.Trim().ToLower();
            string loai = cboFilterLoai.SelectedIndex > 0 ? cboFilterLoai.SelectedItem.ToString() : null;

            var data = _allCakes
                .Where(c => (keyword.Length == 0 || c.TenBanh.ToLower().Contains(keyword))
                         && (loai == null || c.Loai == loai))
                .OrderBy(c => c.HanDung)
                .ToList();

            _isBinding = true;
            dgvCakes.DataSource = data;
            dgvCakes.ClearSelection();
            _isBinding = false;
        }

        // =====================================================
        // BƯỚC 4: Các sự kiện (event) - tên khớp với frmDanhMucBanh.Designer.cs
        // =====================================================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cboFilterLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        // Tô màu dòng theo quy tắc nghiệp vụ
        private void dgvCakes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var cake = dgvCakes.Rows[e.RowIndex].DataBoundItem as Cake;
            if (cake == null) return;

            DateTime today = DateTime.Today;
            bool expired = cake.HanDung.Date < today;
            bool nearExpiry = !expired && (cake.HanDung.Date - today).TotalDays <= 30;
            bool lowStock = cake.Ton < 10;

            if (expired) e.CellStyle.BackColor = Color.FromArgb(244, 200, 210);
            if (nearExpiry) e.CellStyle.ForeColor = Color.DarkOrange;
            if (lowStock) e.CellStyle.Font = _boldFont;
        }

        // Bấm vào dòng thì đổ dữ liệu xuống khung nhập
        private void dgvCakes_SelectionChanged(object sender, EventArgs e)
        {
            if (!_ready || _isBinding || dgvCakes.CurrentRow == null || !dgvCakes.CurrentRow.Selected) return;
            var c = dgvCakes.CurrentRow.DataBoundItem as Cake;
            if (c == null) return;

            txtMaBanh.Text = c.Ma;
            txtTenBanh.Text = c.TenBanh;
            cboKichCo.SelectedItem = c.KichCo;
            cboLoai.SelectedItem = c.Loai;
            txtDonGia.Text = ((long)c.DonGia).ToString();
            nudTon.Value = Math.Min(nudTon.Maximum, Math.Max(nudTon.Minimum, (decimal)c.Ton));
            dtpHanDung.Value = c.HanDung;
        }

        // Ô đơn giá: chỉ cho gõ số
        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true; // nuốt ký tự không phải số
        }

        // Ô đơn giá: báo lỗi tức thì
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            decimal v;
            bool bad = txtDonGia.Text.Length > 0 &&
                       (!decimal.TryParse(txtDonGia.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out v)
                        || v % 100 != 0);
            lblDonGiaError.Visible = bad;
        }

        // =====================================================
        // BƯỚC 5: Kiểm tra dữ liệu - trả về nội dung lỗi (null nếu hợp lệ)
        // =====================================================
        private string ValidateInput(bool isAdd, out Control focusTo)
        {
            focusTo = null;
            string ma = txtMaBanh.Text.Trim().ToUpper();

            if (!Regex.IsMatch(ma, @"^B\d{4}$"))
            { focusTo = txtMaBanh; return "Mã bánh phải gồm chữ B và 4 chữ số (ví dụ: B0001)."; }

            bool exists = _allCakes.Any(c => c.Ma == ma);
            if (isAdd && exists)
            { focusTo = txtMaBanh; return "Mã bánh " + ma + " đã tồn tại."; }
            if (!isAdd && !exists)
            { focusTo = txtMaBanh; return "Không tìm thấy bánh có mã " + ma + "."; }

            if (txtTenBanh.Text.Trim().Length == 0)
            { focusTo = txtTenBanh; return "Vui lòng nhập tên bánh."; }

            if (cboKichCo.SelectedIndex < 0)
            { focusTo = cboKichCo; return "Vui lòng chọn kích cỡ."; }

            if (cboLoai.SelectedIndex < 0)
            { focusTo = cboLoai; return "Vui lòng chọn loại bánh."; }

            decimal gia;
            if (!decimal.TryParse(txtDonGia.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out gia) || gia <= 0)
            { focusTo = txtDonGia; return "Đơn giá phải là số lớn hơn 0."; }
            if (gia % 100 != 0)
            { focusTo = txtDonGia; return "Đơn giá phải là bội số của 100."; }

            if (isAdd && dtpHanDung.Value.Date < DateTime.Today)
            { focusTo = dtpHanDung; return "Không thể thêm bánh đã hết hạn dùng."; }

            return null;
        }

        private void ShowWarning(string msg)
        {
            MessageBox.Show(msg, "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowError(Exception ex)
        {
            MessageBox.Show("Có lỗi không mong muốn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearInputs()
        {
            txtMaBanh.Clear(); txtTenBanh.Clear(); txtDonGia.Clear();
            cboKichCo.SelectedIndex = -1; cboLoai.SelectedIndex = -1;
            nudTon.Value = 0; dtpHanDung.Value = DateTime.Today;
            lblDonGiaError.Visible = false;
            txtMaBanh.Focus();
        }

        // =====================================================
        // Nút Thêm / Sửa / Xóa
        // =====================================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Control focusTo;
                string err = ValidateInput(true, out focusTo);
                if (err != null) { ShowWarning(err); focusTo.Focus(); return; }

                BanhDAL.Them(new Cake
                {
                    Ma = txtMaBanh.Text.Trim().ToUpper(),
                    TenBanh = txtTenBanh.Text.Trim(),
                    Loai = cboLoai.SelectedItem.ToString(),
                    KichCo = cboKichCo.SelectedItem.ToString(),
                    DonGia = decimal.Parse(txtDonGia.Text, CultureInfo.InvariantCulture),
                    Ton = (int)nudTon.Value,
                    HanDung = dtpHanDung.Value.Date
                });
                TaiLai();
                ClearInputs();
                MessageBox.Show("Đã thêm bánh.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Control focusTo;
                string err = ValidateInput(false, out focusTo);
                if (err != null) { ShowWarning(err); focusTo.Focus(); return; }

                string ma = txtMaBanh.Text.Trim().ToUpper();
                BanhDAL.Sua(new Cake
                {
                    Ma = ma,
                    TenBanh = txtTenBanh.Text.Trim(),
                    Loai = cboLoai.SelectedItem.ToString(),
                    KichCo = cboKichCo.SelectedItem.ToString(),
                    DonGia = decimal.Parse(txtDonGia.Text, CultureInfo.InvariantCulture),
                    Ton = (int)nudTon.Value,
                    HanDung = dtpHanDung.Value.Date
                });
                TaiLai();
                MessageBox.Show("Đã cập nhật bánh.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ShowError(ex); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaBanh.Text.Trim().ToUpper();
                var cake = _allCakes.FirstOrDefault(c => c.Ma == ma);
                if (cake == null)
                {
                    ShowWarning("Hãy chọn một bánh trong bảng để xóa.");
                    return;
                }

                var rs = MessageBox.Show("Xóa bánh \"" + cake.TenBanh + "\"?", "Xác nhận xóa",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs != DialogResult.Yes) return;

                if (!BanhDAL.Xoa(cake.Ma))
                {
                    ShowWarning("Bánh này đã có trong hóa đơn nên không thể xóa.");
                    return;
                }
                TaiLai();
                ClearInputs();
            }
            catch (Exception ex) { ShowError(ex); }
        }
    }
}
