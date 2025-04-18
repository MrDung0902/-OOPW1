using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class DatVeMayBay
    {
        private string _maChuyenBay;
        private string _soGhe;
        private string _tenKhachHang;
        public string MaChuyenBay => _maChuyenBay;
        public string SoGhe => _soGhe;
        public string TenKhachHang => _tenKhachHang;
        public DatVeMayBay() { }
        public DatVeMayBay(string maChuyenBay, string soGhe, string tenKhachHang)
        {
            _maChuyenBay = maChuyenBay;
            _soGhe = soGhe;
            _tenKhachHang = tenKhachHang;
        }
        public void InThongTin()
        {
            Console.WriteLine("======= Thong Tin Ve May Bay =========");
            Console.WriteLine($" Ma chuyen bay: {MaChuyenBay}");
            Console.WriteLine(($" So Ghe: {SoGhe}"));
            Console.WriteLine($"Ten Khach hang: {TenKhachHang}");
        }
    }
    class Phan5Bai8
    {
        public static void Phan5Bai8Main()
        {
            DatVeMayBay veMayBay = new DatVeMayBay(null, "22", " Van B");

            if (veMayBay.MaChuyenBay != null)

            {
                veMayBay.InThongTin();
            }
            else
            {
                Console.WriteLine(" Ma Chuyen bay khong hop le !!!");
            }
            /// Commet khong can thiet
            /// them thong tin ve may bay
        }
    }
}
