using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class VuKhi
    {
        public string LoaiVuKhi;
        public VuKhi(string loaivukhi)
        {
            LoaiVuKhi = loaivukhi;
        }
        public virtual void TanCong()
        {

        }
    }
    class Kiem : VuKhi
    {
        public Kiem(string loaivukhi) : base(loaivukhi) { }
        public override void TanCong()
        {
            Console.WriteLine(" Chem!");
        }
    }
    class Cung : VuKhi
    {
        public Cung(string loaivukhi): base(loaivukhi) { }
        public override void TanCong()
        {
            Console.WriteLine(" Ban ten!");
        }
    }
    class Phan7bai5
    {
        public static void Phan7Bai5Main()
        {
            List<VuKhi> list = new List<VuKhi> { new Cung("Cung 14"), new Kiem(" Kiem dai"), new Cung(" Cung 9") };
            foreach (VuKhi v in list)
            {
                Console.WriteLine( $"========= Loai vu khi {v.GetType().Name}");
                v.TanCong();
                //if (v is Kiem)
                //{
                //    v.TanCong();
                //}
                //else { v.TanCong(); }
            }
        }
            
    }
}
