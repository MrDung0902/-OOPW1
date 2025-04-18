using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class Nguoi_phan5
    {
        private int _tuoi;
        public int tuoi
        {
            get { return _tuoi; }
            set
            {
                if (value >= 0)
                {
                    _tuoi = value;
                }
                else
                {
                    Console.WriteLine(" so nhap vao khong hop le :");
                    _tuoi = 0;
                }

            }
        }
        public Nguoi_phan5(int tuoi) {
            this.tuoi = tuoi;
        }
        
    }
    class phan5_bai1
    {
        public static void Main_phan5_bai1()
        {
            Nguoi_phan5 nguoi1 = new Nguoi_phan5(3);
            Console.WriteLine($" Tuoi 1: {nguoi1.tuoi}");

            Nguoi_phan5 nguoi2 = new Nguoi_phan5(-1);
            Console.WriteLine($" Tuoi 2 : {nguoi2.tuoi} ");
        }

    }
}

