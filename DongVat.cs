using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
   class DongVat
    {
        public int Tuoi;
        public string Ten;
        public DongVat(string ten, int tuoi)
        {
            Ten = ten;
            Tuoi = tuoi;
        }
        public DongVat(string ten)
        {
            Ten = ten;
        }
        public virtual void An()
        {
            Console.WriteLine($"{Ten} dang an  ");
        }

    }
    class Phan7Bai2
    {
        public static void Phan7Bai2Main()
        {
            List<DongVat> dongvat = new List<DongVat>();
            Cho cho = new Cho(" Mixkey", 5);
            dongvat.Add(cho);
            
            //// Meo 
            Meo meo = new Meo("Tom",1);
            dongvat.Add(meo);
            //meo.An();
            //meo.TreoCay();
            foreach (var d in dongvat)
            {
                Console.WriteLine($" ======Loai Dong vat : {d.GetType().Name}");
                Console.WriteLine($" Ten : {d.Ten}");
                Console.WriteLine($" Tuoi : {d.Tuoi}");
                if (d is Cho)
                {
                    d.An();
                    cho.sua();
                }
                else
                {
                    meo.An()        ;
                    meo.TreoCay();
                }
            }
        }
    }
}
