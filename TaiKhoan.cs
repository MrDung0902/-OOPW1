using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class TaiKhoan
    {
        public string SoTaiKhoan;
        public double SoDu;
        public TaiKhoan(string soTaiKhoan, double soDu)         
        {
            SoTaiKhoan = soTaiKhoan;
            SoDu = soDu;
        }
        public virtual void TinhPhiHoacLaiHangThang()
        {

        }
    }
    class TaiKhoanTietKiem : TaiKhoan
    {
        public double LaiSuat;
        public double Phiduytri;
        public TaiKhoanTietKiem(string soTaiKhoan, double soDu, double laiSuat,double phiduytri) : base(soTaiKhoan, soDu)
        {
            LaiSuat = laiSuat;
            Phiduytri = phiduytri;
        }        
        public void LaiSuat_Year()
        {
            double overcome = LaiSuat / 100 * SoDu ;
            Console.WriteLine($" Lai suat tren mot Nam cua so tai khoan {SoTaiKhoan} la : {overcome}    ");
        }
        public override void TinhPhiHoacLaiHangThang()
        {
            Console.WriteLine(" Phi hang thang:" + Phiduytri);
        }
    }
    class TaiKhoanThanhToan : TaiKhoan
    {
        public double Phigiaodich;
        public double TongKhoiLuongGiaoDich;
        public TaiKhoanThanhToan(string soTaiKhoan, double soDu,double phigiaodich, double tongkhoiluonggiaodich   ) : base(soTaiKhoan, soDu)   
        {
            Phigiaodich = phigiaodich;
            TongKhoiLuongGiaoDich = tongkhoiluonggiaodich;
        }          
        public void Phigiaodich_Year()
        {
            double fee = Phigiaodich / 100 * TongKhoiLuongGiaoDich;
            Console.WriteLine($" Tong fee giao dich cua so tai khoan {SoTaiKhoan}  tren mot nam la: {fee}");
        }
        public override void TinhPhiHoacLaiHangThang()
        {
            double fee = Phigiaodich / 100 * TongKhoiLuongGiaoDich/12;
            Console.WriteLine(" Phi hang thang:" + fee);
        }
    }
    class Phan7Bai6
    {
        public static void Phan7Bai6Main()
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan> { new TaiKhoanTietKiem("Abc123", 2430030, 3, 50000), new TaiKhoanThanhToan(" 1a2b3c", 3540000, 1, 6000000), new TaiKhoanTietKiem(" haha111", 64540154, 3, 60000) };
            //foreach (var t in taiKhoans)
            //{
            //    Console.WriteLine($" =======Loai tai khoan: {t.GetType().Name}=======");
            //    Console.WriteLine($" So tai khoan:{t.SoTaiKhoan}");
            //    Console.WriteLine($" So du: {t.SoDu}");
            //    t.TinhPhiHoacLaiHangThang();
            //}
            taiKhoans.ForEach(p => { Console.WriteLine($" =======Loai tai khoan: {p.GetType().Name}======="); Console.WriteLine($" So tai khoan:{p.SoTaiKhoan}"); Console.WriteLine($" So tai khoan:{p.SoDu}"); p.TinhPhiHoacLaiHangThang(); }); 
        }
    }
}
