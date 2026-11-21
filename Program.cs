using System;
using System.Windows.Forms;

namespace QuanLyBanBanh
{
    internal static class Program
    {
        // Điểm bắt đầu của chương trình: mở Form1
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDanhMucBanh());
        }
    }
}
