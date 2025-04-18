using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class NhietDo
    {
        private double _doC;
        public double DoC
        {
            //get { return _doC; }
            get=>_doC;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($" Kiem tra lai nhiet do nhap vao !!!. Nhiet do nhap vao hien tai la {value}");
                    _doC = value;
                  
                }

                _doC = value;
            }
            //set => _doC = value<0 ? 0 :value;
        }
        public double DoF
        {
            //get { return _doC * 9 / 5 + 32; }  
            get => _doC * 9 / 5 + 32;
        }
    }
    class Phan5Bai7
    {
        public static void Phan5Bai7Main()
        {
            NhietDo nhietdo = new NhietDo();
            nhietdo.DoC = 6;
            Console.WriteLine(" Nhiet do: " +nhietdo.DoC);
            Console.WriteLine(" Nhiet do: " + nhietdo.DoF);

            nhietdo.DoC = -2;
            Console.WriteLine(" Nhiet do: " + nhietdo.DoC);
            Console.WriteLine(" Nhiet do: " + nhietdo.DoF);
        }
    }
}
