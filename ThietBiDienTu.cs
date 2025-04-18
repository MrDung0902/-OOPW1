using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class ThietBiDienTu
    {
        public string HangSanXuat;
        public string Model;
        public double TrongLuong;
        public ThietBiDienTu(string hangSanXuat, string model, double trongLuong)
        {
            HangSanXuat = hangSanXuat;
            Model = model;
            TrongLuong = trongLuong;
        }
    }
    class DientThoaiThongMinh : ThietBiDienTu
    {
        public DientThoaiThongMinh(string hangSanXuat, string model, double trongLuong) : base(hangSanXuat, model, trongLuong)
        {
        }
        public string KichThuocManHinh;
        public string HeDieuHanh;
        public void Thong_tin_DienThoai(string kichthuocmanhinh, string heDieuHanh)
        {
            KichThuocManHinh = kichthuocmanhinh;
            HeDieuHanh = heDieuHanh;
            Console.WriteLine($" Hang San Xuat: {HangSanXuat}, Model: {Model}, Trong Luong: {TrongLuong}, Kich thuoc man hinh: {KichThuocManHinh}, He dieu hanh{HeDieuHanh}");
        }
    }
    class MayTinhBang:ThietBiDienTu
    {
        public MayTinhBang(string hangSanXuat, string model, double trongLuong) : base(hangSanXuat, model, trongLuong)
        {

        }
        public double DungLuongPin;
        public string CoButCamUng;
        public void Thong_Tin_May_Tinh_Bang(double dungluongpin, string cobutcamung)
        {
            DungLuongPin = dungluongpin;
            CoButCamUng = cobutcamung;
            Console.WriteLine($" Hang san xuat: {HangSanXuat}, Model: {Model}, Trong Luong: {TrongLuong}, Dung Luong Pin: {DungLuongPin}");
        }
    }
}
