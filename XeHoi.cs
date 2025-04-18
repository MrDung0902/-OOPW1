using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class XeHoi
    {
        private double _tocDoHienTai = 0;
        public double tocDoHienTai { get { return _tocDoHienTai; } }
        public double TangToc(double giatoc)
        {
            if (giatoc > 0 && (giatoc + _tocDoHienTai) < 200) { return _tocDoHienTai += giatoc; }
            return _tocDoHienTai;
            
        }
        public double GiamToc(double giamtoc)
        {
            if (_tocDoHienTai - giamtoc >= 0 && giamtoc >0)
            {
                return _tocDoHienTai -= giamtoc;
            }
            return _tocDoHienTai;
        }
    }   
    class Phan5bai3
    {
        public static void Phan5bai3Main() 
        {
            XeHoi xeHoi = new XeHoi();

            Console.WriteLine(" Tang toc 50: " + xeHoi.TangToc(50));
            Console.WriteLine(" Tang toc 30:" + xeHoi.TangToc(30));
            Console.WriteLine(" Toc do hien tai:  " + xeHoi.tocDoHienTai);

            Console.WriteLine(" Giam toc 20: " + xeHoi.GiamToc(20));
            Console.WriteLine(" Giam toc 70: " + xeHoi.GiamToc(70));
            Console.WriteLine("Toc do hien tai:  "+xeHoi.tocDoHienTai);
        
        }
    }
}
