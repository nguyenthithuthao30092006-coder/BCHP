using System;
using System.Windows.Forms;

namespace BCHP
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool tiepTuc = true;
            while (tiepTuc)
            {
                frmDangNhap dn = new frmDangNhap();
                if (dn.ShowDialog() != DialogResult.OK)
                {
                    tiepTuc = false;
                }
                else
                {
                    frmMain main = new frmMain();
                    Application.Run(main);
                    if (!main.DangXuat) tiepTuc = false;
                }
            }
        }
    }
}