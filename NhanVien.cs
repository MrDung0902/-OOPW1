using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace OOPW1
{
    internal class NhanVien
    {
        public string MaNv;
        public string HoTen;
        public string LuongCoBan;

        public NhanVien(string manv, string hoten, string luongcoban)
        {
            MaNv = manv;
            HoTen = hoten;
            LuongCoBan = luongcoban;
        }
        public virtual void TinhTongLuong()
        {
            if (int.TryParse(LuongCoBan, out int LuongCB))
            {
              
                Console.WriteLine($" Tong luong cua {HoTen} : {LuongCB}");
            }
            else
            {
                Console.WriteLine($"Loi : khong the chuyen doi luong co ban cua lap trinh vien {HoTen} sang so nguyen ");
            }

        }
    }
    internal class QuanLy : NhanVien
    {
        public int PhuCap;
        public QuanLy(string manv, string hoten, string luongcoban, int phucap) : base(manv, hoten, luongcoban)        {
            PhuCap = phucap;
        }       
      
        public override void TinhTongLuong()
        {
            if (int.TryParse(LuongCoBan, out int LuongCB))
            {
                int tongluong = LuongCB + PhuCap;
                Console.WriteLine($" Tong luongc cua {HoTen} ma nhan vien {MaNv} la  {tongluong}");
            }
            else
            {
                Console.WriteLine($"Loi : khong the chuyen doi luong co ban cua lap trinh vien {HoTen} sang so nguyen ");
            }

        }
    }
    class Laptrinhvien:NhanVien
    {
        public int SoGioLamThem;
        public int DonGialamThem;
        public Laptrinhvien(string manv, string hoten, string luongcoban, int giolamthem, int price) : base(manv, hoten, luongcoban) 
        {
            SoGioLamThem = giolamthem;
            DonGialamThem = price;
        }
      
        public  override void TinhTongLuong()
        {
            if (int.TryParse(LuongCoBan, out int LuongCB))
            {
                int tongluong = LuongCB + (SoGioLamThem * DonGialamThem);
                Console.WriteLine($" Tong luong cua {HoTen} la : {tongluong}");
            }
            else
            {
                Console.WriteLine($"Loi : khong the chuyen doi luong co ban cua lap trinh vien {HoTen} sang so nguyen ");
            }
          
        }
    }
    class Phan7Bai3
    {
        public static void Phan7Bai3Main()
        {
            List<NhanVien> nhanViens = new List<NhanVien> { new QuanLy("2112", "SLD Le Dong", "1500000", 30000), new Laptrinhvien("1212", " PGM PC", " 1900000", 10, 160) };
            foreach (var nhan in nhanViens)
            {
                Console.WriteLine($"=============== Loai nhan vien: {nhan.GetType().Name}==============");
                Console.WriteLine($" Ma nhan vien: {nhan.MaNv}");
                Console.WriteLine($" Ten nhan vien: {nhan.HoTen}");
                Console.WriteLine($" Luong co ban: {nhan.LuongCoBan}");
                if (nhan is QuanLy)
                {
                    nhan.TinhTongLuong();
                }
                else
                {
                    nhan.TinhTongLuong();
                }
            }
        }
    }
}    
