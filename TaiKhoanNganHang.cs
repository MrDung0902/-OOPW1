using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class TaiKhoanNganHang
    {
        private double _SoDu;
        public string TenChuTaiKhoan { get; set; }
        public string SoTaiKhoan { get; }
        public TaiKhoanNganHang(double soDu, string tenChuTaiKhoan, string soTaiKhoan)
        {
            _SoDu = soDu;
            TenChuTaiKhoan = tenChuTaiKhoan;
            SoTaiKhoan = soTaiKhoan;
        }
        public double Sodu
        {
            get { return _SoDu; }
        }
        public void GuiTien(double sotien)
        {
            if (sotien < 0)
            {
                Console.WriteLine($" Ban vua gui vao tai khoan so tien la: {sotien}");
                Console.WriteLine(" So tien gui cao khong hop le");
            }
            else
            {
                _SoDu += sotien;
                Console.WriteLine($" Ban vua gui vao tai khoan so tien la: {sotien}");

                Console.WriteLine($" So du hien tai la: {_SoDu} ");
            }
        }
        public void RutTien(double sotien)
        {
            if (sotien < 0)
            {
                Console.WriteLine(" So tien rut khong hop le . Can phai rut so lon 0");
            }
            else if (sotien > _SoDu)
            {
                Console.WriteLine($" ban vua rut: {sotien}");
                Console.WriteLine($" So Du khong du . Vui long nhap lai so tien can rut nho hon {_SoDu}");
            }
            else
            {
                _SoDu -= sotien;
                 Console.WriteLine($" ban vua rut: {sotien}");
                Console.WriteLine($" So du con lai la: {_SoDu}");
            }
        }
    }
    class Phan5_bai2
    {
        public static void phan5_bai2_main()
        {
            TaiKhoanNganHang acc = new TaiKhoanNganHang(1000, " Nguyen Trong Dung", " Abc123");
            acc.GuiTien(500);
            acc.GuiTien(-23);
            Console.WriteLine("\n=========================================");
            acc.RutTien(300);
            acc.RutTien(780000);
        }
    }
}
