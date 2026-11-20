using System;
using System.Windows.Forms;

namespace BCHP
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        bool tiepTuc = true;
        while (tiepTuc)                       // vòng lặp while (Buổi 1)
        {
            frmDangNhap dn = new frmDangNhap();
            if (dn.ShowDialog() != DialogResult.OK)
            {
                tiepTuc = false;              // thoát hoặc đóng form đăng nhập: kết thúc chương trình
            }
            else
            {
                frmMain main = new frmMain();
                Application.Run(main);        // mở trang chính
                if (!main.DangXuat) tiepTuc = false;   // chỉ quay lại đăng nhập khi bấm Đăng xuất
            }
        }
    }
}
  
