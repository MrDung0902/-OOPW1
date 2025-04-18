using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class Oto : PhuongTienGiaoThong
    {
        public Oto(string hangsanxuat, int namsanxuat) : base(hangsanxuat, namsanxuat)
        {        }
        public int N;
        public void SoChoNgoi(int n)
        {
            N = n;
            Console.WriteLine($" SO cho ngoi {N}");
        }
        public override void Dichuyen()
        {
            Console.WriteLine(" Oto dang chay tren duong");
        }
    }    
    class Xemay : PhuongTienGiaoThong
    {
        public Xemay(string hangSanXuat, int namSanXuat) : base(hangSanXuat, namSanXuat)
        {
        }
        public override void Dichuyen()
        {
            Console.WriteLine(" Xe may dang luon lach tren duong ");
        }
    }
}
