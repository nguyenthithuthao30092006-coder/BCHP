using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using BCHP.Reports;
using BCHP.Reports.Data;

namespace BCHP
{
    // Form báo cáo độc lập: thành viên nhóm tự gọi form từ menu/chức năng phù hợp.
    public partial class frmBaoCaoDoanhThu : Form
    {
        private readonly BaoCaoDoanhThuRepository _repository;
        private DataTable _duLieuBieuDo;
        public frmBaoCaoDoanhThu()
        {
            _repository = DesignModeSafeRepo();
            InitializeComponent();
        }

        private static BaoCaoDoanhThuRepository DesignModeSafeRepo()
        {
            // Trong chế độ thiết kế (Designer) không đụng tới App.config / SQL.
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return null;
            return new BaoCaoDoanhThuRepository();
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            dtpDenNgay.Value = DateTime.Today;
            dtpTuNgay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            TaiDuLieu();
        }

        private void btnLoc_Click(object sender, EventArgs e) { TaiDuLieu(); }

        private void btnXuat_Click(object sender, EventArgs e) { XuatCsv(); }

        private void pnlBieuDo_Resize(object sender, EventArgs e) { pnlBieuDo.Invalidate(); }

        private void pnlBieuDo_Paint(object sender, PaintEventArgs e) { VeBieuDo(sender, e); }

        private void TaiDuLieu()
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Kiểm tra dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date;
                BaoCaoTongQuan kq = _repository.LayTongQuan(tuNgay, denNgay);
                lblDoanhThu.Text = kq.TongDoanhThu.ToString("N0") + " đ";
                lblHoaDon.Text = kq.TongHoaDon.ToString("N0");
                lblGiamGia.Text = kq.TongGiamGia.ToString("N0") + " đ";
                lblTruocGiam.Text = kq.TongTruocGiam.ToString("N0") + " đ";
                dgvHoaDon.DataSource = _repository.LayDanhSachHoaDon(tuNgay, denNgay);
                dgvSanPham.DataSource = _repository.LaySanPhamBanChay(tuNgay, denNgay);
                _duLieuBieuDo = _repository.LayDoanhThuTheoNgay(tuNgay, denNgay);
                pnlBieuDo.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải báo cáo. Hãy kiểm tra kết nối SQL Server và cấu trúc bảng.\n\nChi tiết: " + ex.Message,
                    "Lỗi báo cáo doanh thu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VeBieuDo(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle area = pnlBieuDo.ClientRectangle;
            g.DrawString("DOANH THU THEO NGÀY", new Font("Segoe UI", 12F, FontStyle.Bold), new SolidBrush(BaoCaoMauSac.XanhDam), 22, 18);
            if (_duLieuBieuDo == null || _duLieuBieuDo.Rows.Count == 0)
            {
                g.DrawString("Không có dữ liệu trong khoảng thời gian đã chọn.", Font, Brushes.Gray, 25, 65);
                return;
            }
            decimal max = 0;
            foreach (DataRow row in _duLieuBieuDo.Rows) max = Math.Max(max, Convert.ToDecimal(row["DoanhThu"]));
            if (max <= 0) max = 1;
            int left = 75, top = 65, bottom = area.Height - 65, right = area.Width - 35;
            g.DrawLine(Pens.Gray, left, top, left, bottom);
            g.DrawLine(Pens.Gray, left, bottom, right, bottom);
            int count = _duLieuBieuDo.Rows.Count;
            float slot = Math.Max(8F, (right - left - 20) / (float)count);
            float barWidth = Math.Max(5F, slot * 0.58F);
            using (Brush bar = new SolidBrush(BaoCaoMauSac.XanhLa))
            using (Font small = new Font("Segoe UI", 8F))
            {
                for (int i = 0; i < count; i++)
                {
                    DataRow row = _duLieuBieuDo.Rows[i];
                    decimal value = Convert.ToDecimal(row["DoanhThu"]);
                    float h = (float)(value / max * (bottom - top - 12));
                    float x = left + 12 + i * slot;
                    float y = bottom - h;
                    g.FillRectangle(bar, x, y, barWidth, h);
                    string date = Convert.ToDateTime(row["Ngay"]).ToString("dd/MM");
                    g.DrawString(date, small, Brushes.DimGray, x - 4, bottom + 8);
                    if (count <= 12) g.DrawString((value / 1000m).ToString("N0") + "k", small, new SolidBrush(BaoCaoMauSac.XanhDam), x - 4, Math.Max(top, y - 18));
                }
            }
            g.DrawString("Đơn vị: nghìn đồng đối với nhãn trên cột", new Font("Segoe UI", 8F), Brushes.Gray, 22, area.Height - 25);
        }

        private void XuatCsv()
        {
            DataTable table = dgvHoaDon.DataSource as DataTable;
            if (table == null || table.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (SaveFileDialog dialog = new SaveFileDialog { Filter = "CSV UTF-8 (*.csv)|*.csv", FileName = "BaoCaoHoaDon_" + DateTime.Now.ToString("yyyyMMdd") + ".csv" })
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                StringBuilder sb = new StringBuilder();
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    if (c > 0) sb.Append(',');
                    sb.Append(EscapeCsv(table.Columns[c].ColumnName));
                }
                sb.AppendLine();
                foreach (DataRow row in table.Rows)
                {
                    for (int c = 0; c < table.Columns.Count; c++)
                    {
                        if (c > 0) sb.Append(',');
                        object value = row[c];
                        if (value is DateTime) value = ((DateTime)value).ToString("dd/MM/yyyy HH:mm:ss");
                        sb.Append(EscapeCsv(Convert.ToString(value, CultureInfo.InvariantCulture)));
                    }
                    sb.AppendLine();
                }
                File.WriteAllText(dialog.FileName, "\uFEFF" + sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Đã xuất báo cáo tại:\n" + dialog.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string EscapeCsv(string value)
        {
            if (value == null) return "\"\"";
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
    }
}
