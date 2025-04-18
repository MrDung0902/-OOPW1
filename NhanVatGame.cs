using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class NhanVatGame
    {

        public string TenNhanVat;
        public string CapDo;
        public string Mau;
        public NhanVatGame(string tennhanvat, string capdo, string mau)
        {
            TenNhanVat = tennhanvat;
            CapDo = capdo;
            Mau = mau;
        }
        public virtual void SuDungKyNangDacBiet()
        {

        }
    }
    class Chienbinh : NhanVatGame
    {
        public string SucManh { get; set; }
        public string Giap { get; set; }
        public Chienbinh(string tennhanvat, string capdo, string mau, string sucManh, string giap) : base(tennhanvat, capdo, mau)
        {
            SucManh = sucManh;
            Giap = giap;
        }
        public override void SuDungKyNangDacBiet()
        {
            Console.WriteLine($"Gong Minh!");
        }
    }
    class Phapsu : NhanVatGame
    {
        public string tritue {  get; set; }
        public string Nangluongphep {  get; set; }
        public Phapsu(string tennhanvat, string capdo, string mau, string tritue, string nangluongphep) : base(tennhanvat, capdo, mau)
        {
            this.tritue = tritue;
            Nangluongphep = nangluongphep;
        }
        public override void SuDungKyNangDacBiet()
        {
            Console.WriteLine("Nem Chu!");
        }
    } 
    class Bai10
    {
        public static void Main_bai_10()
        {
            //Chienbinh chienbinh = new Chienbinh(" Panteon", " 60", " 600", " 500", " 101");
            //Console.WriteLine($" Ten chien binh: {chienbinh.TenNhanVat }, Cap do: {chienbinh.CapDo}, Mau: {chienbinh.Mau}, Giap: {chienbinh.Giap}, Suc manh: {chienbinh.SucManh}");

            //Phapsu phapsu = new Phapsu(" Ahri", " 65", " 500", "626", "150");
            //Console.WriteLine($" Ten phap su: {phapsu.TenNhanVat}, Cap do: {phapsu.CapDo}, Mau: {phapsu.Mau}, tri tue: {phapsu.tritue}, Nang luong phep: {phapsu.Nangluongphep}");
            List<NhanVatGame> nhanVatGames = new List<NhanVatGame> { new Chienbinh(" Panteon", " 60", " 600", " 500", " 101"), new Phapsu(" Ahri", " 65", " 500", "626", "150") };
            nhanVatGames.ForEach(nhanVatGame => {Console.WriteLine($"====Loai nhan vat :{nhanVatGame.GetType().Name}===="); nhanVatGame.SuDungKyNangDacBiet(); });
        }
    }
}
    
