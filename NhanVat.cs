using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class NhanVat
    {
        private double _mau;
        private double _nangluong;
        public double Mau => _mau;
        public double NangLuong => _nangluong;
        public NhanVat() { }
        public NhanVat(double mau, double nangluong)
        {
            _mau = mau;
            _nangluong = nangluong;
        }
        public void NhanSatThuong(int satThuong)
        {
            if (satThuong < 0)
            {
                satThuong = 0;                
            }
            else if (satThuong > 0 && satThuong < _mau)
            {
                _mau -= satThuong;
                Console.WriteLine($"Đã nhận {satThuong} sát thương. Máu còn lại: {_mau}");
            }
            else
            {
                _mau = 0;
                Console.WriteLine(" Sat luong qua lon => Die !!!");
            }
           
        }
        public void HoiPhuc(int luonghoiphuc)
        {
            

            if (luonghoiphuc >=0 && luonghoiphuc <100)
            {
                _mau += luonghoiphuc;
                Console.WriteLine($" Da Nhan {luonghoiphuc} luong hoi phuc. Mau bay gio la: {_mau}");
            }
            else                
            {
                luonghoiphuc = 0;
                Console.WriteLine(" Luong hoi phuc khong hop le !!!");
            }
        }
        
    }
    class Phan5Bai10
    {
        public static void Phan5Bai10Main()
        {
            NhanVat nhanVat = new NhanVat(555, 365);
            nhanVat.NhanSatThuong(300);
            nhanVat.NhanSatThuong(600);
            nhanVat.HoiPhuc(6200);
        }
    }
}
