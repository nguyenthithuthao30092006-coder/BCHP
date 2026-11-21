using System;

namespace QuanLyBanBanh
{
    // BƯỚC 0: Mô hình dữ liệu - 1 đối tượng = 1 chiếc bánh
    // (đặt ở file riêng vì Designer yêu cầu class đầu tiên của Form1.cs phải là Form1)
    public class Cake
    {
        public string Ma { get; set; }
        public string TenBanh { get; set; }
        public string Loai { get; set; }
        public string KichCo { get; set; }
        public decimal DonGia { get; set; }
        public int Ton { get; set; }
        public DateTime HanDung { get; set; }
    }
}
