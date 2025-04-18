using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class Cho : DongVat
    {     
        public Cho(string ten, int tuoi) : base(ten, tuoi)        { }

        public void sua()
        {
            
            Console.WriteLine($"{Ten} dang sua : gau gau");
        }
        public override void An()
        {
            Console.WriteLine($" {Ten} dang an !");
        }
    }

    // Lớp Meo kế thừa từ DongVat
    internal class Meo : DongVat
    {
        public Meo(string ten,int tuoi) : base(ten,tuoi)  { }      

        public void TreoCay()
        {
            Console.WriteLine($"{Ten} đang trèo cây.");
        }
    }
    // Lớp DongVat là lớp cơ sở
}