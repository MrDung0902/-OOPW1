using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
  
   
        public class ThuVienSach
        {
            private List<Sach1> listSach = new List<Sach1>();
            public void ThemSach(Sach1 sach)
            {
              listSach.Add(sach);
            }
             public void TimSachTheoTieuDe(string tieudDe)
            {
             foreach (Sach1 sach in listSach)
                {
                    if (sach.TieuDe.Equals(tieudDe))
                        {
                            sach.Output();
                        }
                }
           
        }
        public void XoaSach(int namxuatban)
        { 
           
            //List<Sach1> ketqua = new List<Sach1>();
            //foreach (var sach in listSach)
            //{
            //    if (sach.NamSuatBan != (namxuatban))
            //    {
            //        ketqua.Add(sach);
            //    }
            //}
            //listSach = null;
            //listSach = ketqua;
            int SoLuongBiXoa = listSach.RemoveAll(sach=>sach.NamSuatBan == (namxuatban));
            Console.WriteLine($" Da xoa  {SoLuongBiXoa} sach co nam xuat ban la: {namxuatban}    ");
            Console.WriteLine(" So luong Danh sach Sach con lai : "+listSach.Count);
        }

        }

        public class Sach1
        {
            public string TieuDe { get; set; }
            public string TacGia { get; set; }
            public int NamSuatBan { get; set; }
            public Sach1(string tieuDe, string tacGia, int namSuatBan)
            {
                TieuDe = tieuDe;
                TacGia = tacGia;
                NamSuatBan = namSuatBan;
            }
            public void Output()
            {
                Console.WriteLine(TieuDe + "\t" + TacGia + "\t" + NamSuatBan);
            }
        }   
        class Phan5Bai9
        {
            public  static void Phan5Bai9Main()  
            {
            ThuVienSach thuvien = new ThuVienSach();
                thuvien.ThemSach(new Sach1("Tien", " Mr Jack", 2002));
                thuvien.ThemSach(new Sach1("Sach", " Mr Jine", 2004));
                thuvien.ThemSach(new Sach1("Nuoc va Bien", " Mr Alex", 2012));
                thuvien.ThemSach( new Sach1("Muoi", " Mr Jack", 2002));

                thuvien.XoaSach(2002);

                thuvien.TimSachTheoTieuDe("Sach");

            }      
        }
}
