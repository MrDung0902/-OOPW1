using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class PhuongTienGiaoThong
    {
        public string HangSanXuat;
        public int NamSanXuat;
        public PhuongTienGiaoThong(string hangSanXuat, int namSanXuat)

        {
            HangSanXuat = hangSanXuat;
            NamSanXuat = namSanXuat;
        }

        public virtual void Dichuyen()
        {

        }
    }
    class Phan7Bai4
    {
        public static void Phan7Bai4Main()

        {

            List<PhuongTienGiaoThong> phuongTienGiaoThongs = new List<PhuongTienGiaoThong> { new Oto(" Toyota", 2007), new Xemay("Yamaha", 2023), new Oto("HonDa", 2018), new Oto("Mecedec", 2022) };
            foreach (var Phuongtien in phuongTienGiaoThongs)
            {
                Console.WriteLine($"================= Loai phuong tien: {Phuongtien.GetType().Name}========================");
                Console.WriteLine($" Hang san xuat: {Phuongtien.HangSanXuat}");
                Console.WriteLine($" Nam san xuat: {Phuongtien.NamSanXuat}");
                Phuongtien.Dichuyen();
                //if (Phuongtien is Oto) {Phuongtien.Dichuyen();  }
                //else {Phuongtien.Dichuyen(); }   
            }

        }
    }
}

