using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class HocSinh
    {
        private List<double> _danhSachDiem = new List<double>();
        public void ThemDiem(double diem)
        {
            if (diem > 0 && diem < 10)
            _danhSachDiem.Add(diem);
        }
    
        public double TinhDiemTrungBinh()
        {
            return _danhSachDiem.Count>0? _danhSachDiem.Average():0;
        }
        public  int LaySoLuongDiem()
        {
            return _danhSachDiem.Count;
        }

    }
    class Phan5Bai6
    {
        public static void Phan5Bai6Main()
        {
            HocSinh hocSinh = new HocSinh();    
            hocSinh.ThemDiem(4.5);
            hocSinh.ThemDiem(2.6);
            hocSinh.ThemDiem(6);
            hocSinh.ThemDiem(11);

            Console.WriteLine(" Diem trung binh : " + hocSinh.TinhDiemTrungBinh());
            Console.WriteLine(" Tong danh sach diem  la : " + hocSinh.LaySoLuongDiem());
        }
    }
}
