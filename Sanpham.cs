using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPW1
{
    internal class Sanpham
    {
        private double _giaban;
        public string MaSP;
        public string TenSP;
        public double Gia
        {
            get { return _giaban; }
            set
            {
                if (value > 0)
                {
                    _giaban = value;
                }
                else
                {
                    Console.WriteLine("Gia Ban phai lon hon 0.");
                    _giaban = 0;
                }
            }
        }

        public Sanpham(string masp, string tenSp, double gia)
        {
            MaSP = masp;
            TenSP = tenSp;
            Gia = gia;

        }

    }
    class Sach : Sanpham
    {
        public string TacGia;
        public int Sotrang;
        public Sach(string masp, string tenSp, double gia, string tacgia, int sotrang) : base(masp, tenSp, gia)
        {
            TacGia = tacgia;
            Sotrang = sotrang;
        }
        
        public void thong_tin_Sach()
        {            
            Console.WriteLine($" Ma san pham: {MaSP}, Ten San Pham:{TenSP}, Ten Tac gia: {TacGia}, So trang: {Sotrang}");
        }
    }
    class Dianhac : Sanpham
    {
        public string Nghesi;
        public string TheLoaiNhac;
        public Dianhac(string masp, string tenSp, double gia, string Nghesi, string TheLoaiNhac) : base(masp, tenSp, gia)
        {
            this.Nghesi = Nghesi;
            this.TheLoaiNhac = TheLoaiNhac;
        }
      
        public void Thong_Tin_Dia_Nhac()
        {           
            Console.WriteLine($" Ten dia nhac: {TenSP} , Ma san pham: {MaSP}, Gia: {Gia}, Ten nghe si: {Nghesi}, The loai nhac: {TheLoaiNhac}");
        }
    }
}
