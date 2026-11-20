using System.Data.SqlClient;
using System.Configuration;

namespace BCHP
{
    // Lớp trợ giúp CSDL (đề bài BT7.2: viết lớp DatabaseHelper)
    public static class DatabaseHelper
    {
        // Thông tin người vừa đăng nhập, form chính sẽ đọc lại (static: Buổi 3)
        public static string HoTen = "";
        public static string VaiTro = "";

        // Chuỗi kết nối lấy từ App.config, không viết cứng trong code (Buổi 7)
        private static string chuoiKetNoi =
            ConfigurationManager.ConnectionStrings["KetNoi"].ConnectionString;

        // 1. ExecuteScalar: kiểm tra đăng nhập, trả về true nếu đúng
        public static bool DangNhap(string username, string matKhau)
        {
            // COLLATE ... CS: phân biệt chữ hoa/thường trong mật khẩu
            string sql = "SELECT COUNT(*) FROM TaiKhoan " +
                         "WHERE Username = @u AND MatKhau = @p COLLATE Latin1_General_CS_AS";
            using (SqlConnection cn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@u", username);   // SqlParameter: chống SQL Injection
                cmd.Parameters.AddWithValue("@p", matKhau);
                cn.Open();
                int soDong = (int)cmd.ExecuteScalar();
                return soDong > 0;
            }
        }

        // 2. ExecuteReader: đọc họ tên và vai trò của người đã đăng nhập
        public static void LayThongTin(string username)
        {
            string sql = "SELECT HoTen, VaiTro FROM TaiKhoan WHERE Username = @u";
            using (SqlConnection cn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        HoTen = reader["HoTen"].ToString();
                        VaiTro = reader["VaiTro"].ToString().Trim();
                    }
                }
            }
        }

        // 3. ExecuteScalar: đếm xem username / email đã có chưa
        public static bool DaCoUsername(string username)
        {
            return Dem("SELECT COUNT(*) FROM TaiKhoan WHERE Username = @v", username) > 0;
        }

        public static bool DaCoEmail(string email)
        {
            return Dem("SELECT COUNT(*) FROM TaiKhoan WHERE Email = @v", email) > 0;
        }

        private static int Dem(string sql, string giaTri)
        {
            using (SqlConnection cn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@v", giaTri);
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        // 4. Sinh mã tự động: TK001, TK002, TK003...
        public static string SinhMaTK()
        {
            string sql = "SELECT COUNT(*) FROM TaiKhoan";
            using (SqlConnection cn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cn.Open();
                int soTaiKhoan = (int)cmd.ExecuteScalar();
                return "TK" + (soTaiKhoan + 1).ToString("000");
            }
        }

        // 5. ExecuteNonQuery: thêm tài khoản mới (vai trò mặc định NhanVien)
        public static void ThemTaiKhoan(string ma, string username, string matKhau,
                                        string hoTen, bool laNam, string email)
        {
            string sql = "INSERT INTO TaiKhoan (MaTK, Username, MatKhau, HoTen, GioiTinh, Email, VaiTro) " +
                         "VALUES (@ma, @u, @p, @ht, @gt, @em, 'NhanVien')";
            using (SqlConnection cn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", matKhau);
                cmd.Parameters.AddWithValue("@ht", hoTen);
                cmd.Parameters.AddWithValue("@gt", laNam);
                cmd.Parameters.AddWithValue("@em", email);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ExecuteNonQuery: đổi mật khẩu nếu đúng username + email, trả về true nếu đổi được
        public static bool DoiMatKhau(string username, string email, string matKhauMoi)
        {
            string sql = "UPDATE TaiKhoan SET MatKhau = @p WHERE Username = @u AND Email = @e";
            using (SqlConnection cn = new SqlConnection(chuoiKetNoi))
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@p", matKhauMoi);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@e", email);
                cn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
