using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public string NgaySinh{ get; set; }
        public Nguoi(string hoten, string ngaysinh)
        { 
            HoTen = hoten;
            NgaySinh = ngaysinh;

        }

    }
    class Hocsinh : Nguoi
    {
        public Hocsinh(string hoten, string ngaysinh) : base(hoten, ngaysinh)
        {
        }
        public string Lop;
        public string MaHs;
        public string thongtin_hocsinh(string lop, string mahs)
        {
            Lop = lop;
            MaHs = mahs;
            return Lop;
            return MaHs;
        }
    }
    class Giaovien : Nguoi
    {
        public Giaovien(string hoten, string ngaysinh) : base(hoten, ngaysinh)  
        {
        }
        public string Monday;
        public string MaGiaoVien;
        public string Thong_tin_giao_Vien(string monday, string magiaovien)
        {
            Monday = monday;
            MaGiaoVien = magiaovien;
            return MaGiaoVien;
            return Monday;
        }

    }
}
