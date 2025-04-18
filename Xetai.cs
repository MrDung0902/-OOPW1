using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class Xetai: PhuongTienGiaoThong
    {
        public Xetai(string hangsanxuat, int namsanxuat ):base(hangsanxuat,namsanxuat) { }
        public int T;
        public void TaiTrong(int t )
        {
            T = t;
        }
    }
}
