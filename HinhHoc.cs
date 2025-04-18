using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class HinhHoc
    {
        public string Mausac;
        public HinhHoc(string Mausac ) 
        {
            this.Mausac = Mausac;
        }
        public virtual double TinhChuVi()
        {
            return 0;
        }
    }
    class Hinhtron : HinhHoc
    {
        public Hinhtron(string Mausac) : base(Mausac) { }
        public double BanKinh;
        public void BanKinh_R(int banKinh)
        {
            BanKinh = banKinh;
        }
        public double dientichhinhtron()
        {           
            return BanKinh * BanKinh * 3.14;
        }
        public override double TinhChuVi()
        {
             
            return BanKinh * 3.14 * 2;
        }


    }
    class HinhChuNhat1 : HinhHoc
    {
        public double ChieuRong;
        public double ChieuDai;
        public HinhChuNhat1(string Mausac) : base(Mausac)
        {

        }
        public void KichThuoc(double chieuRong, double chieuDai)
        {
            ChieuRong = chieuRong;
            ChieuDai = chieuDai;
        }
        public double DienTichHinhChuNhat()
        {
            return (ChieuRong * ChieuDai);
        }
        public override double TinhChuVi()
        {
         
            return (ChieuRong + ChieuDai) * 2;
        }
    }
    class Phan7bai1
    {
        public static void Phan7Bai1Main()
        {
            List<HinhHoc> hinhhoc  = new List<HinhHoc>();

            Hinhtron hinhtron = new Hinhtron("mau Xanh");
            hinhtron.BanKinh = 30;
            //hinhtron.BanKinh_R(35);
            hinhhoc.Add(hinhtron);
            //hinhtron.dientichhinhtron();
            //hinhtron.TinhChuVi();

            HinhChuNhat1 hinhchunhat = new HinhChuNhat1("mau den");
            hinhchunhat.ChieuDai = 302;
            hinhchunhat.ChieuRong = 200;
            hinhchunhat.KichThuoc(200, 300);
            hinhhoc.Add(hinhchunhat);
            foreach (var h in hinhhoc)
            {
                Console.WriteLine($" ___ Hinh Hoc : {h.GetType().Name}___");
                Console.WriteLine($" Mau sac : {h.Mausac}");
                Console.WriteLine($" Chu Vi: {h.TinhChuVi()}");
                if (h is HinhChuNhat1)
                {
                   
                    Console.WriteLine($" Dien tich la: {hinhchunhat.DienTichHinhChuNhat()}");

                }
                else
                {
                    Console.WriteLine($" Dien tich la: {hinhtron.dientichhinhtron()} ");
                }
            }

        //    hinhchunhat.DienTichHinhChuNhat();
        //    hinhchunhat.TinhChuVi();
        }
    }
}

