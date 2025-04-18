using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class MonAn
    {
        public string TenMon { get; set; }
        public string GiaTien { get; set; }

        public MonAn(string tenmon, string giatien) { }
    }
    class Pho : MonAn
    {
        public Pho(string tenmon, string giatien) : base(tenmon, giatien)
        {
        }
        private string _LoaiBanhPho;
        public string LoaiBanhPho
        {
            get { return _LoaiBanhPho; }
            set
            {
                if( value.ToLower() == "tuoi"||value.ToLower() =="kho"  )
                {
                   _LoaiBanhPho = value;
                }
                else
                {
                    Console.WriteLine(" Loi: Loai pho nhap vao khong hop le. Chi chap nhan loai 'Tuoi' hoac ' kho'");

                    _LoaiBanhPho = null;
                }
            }
        }
        private string _Loaithit;
        public string LoaiThit
        {
            get { return _Loaithit; }
            set
            {
                if (value.ToLower() == "ga" || value.ToLower() == "bo")
                {
                    _Loaithit = value;
                }
                else
                {
                    Console.WriteLine($" Lỗi : Loại thịt nhập vào không hợp lệ. Chỉ chấp nhận loại 'gà' hoặc 'bò'");
                    _Loaithit = null;
                }
            }

        }

        public void InFo_Pho(string loaibanhpho, string loaithit)
        {
            LoaiBanhPho = loaibanhpho;
            LoaiThit = loaithit;
            if (LoaiBanhPho != null|| LoaiThit!=null)
            {
                Console.WriteLine($" Ten mon: {TenMon}, Gia tien: {GiaTien}, Loai Banh: {LoaiBanhPho}, Loai Thit: {LoaiThit} ");

            }
           
        }
    }
    public class Bai9
    {
        public static void main_9()
        {
            Pho phoBo = new Pho("Phở Bò", "45000");
            phoBo.InFo_Pho("tuoi", "Bo");

            Console.WriteLine("\n---");

            Pho phoGa = new Pho("Phở Gà", "40000");
            phoGa.InFo_Pho("kho", "ga");

            Console.WriteLine("\n---");

            Pho phoChay = new Pho("Phở Chay", "35000");
            phoChay.InFo_Pho("dòn", "Nấm"); // Loại bánh phở không hợp lệ

            Console.WriteLine("\n---");
        }
    }
}
