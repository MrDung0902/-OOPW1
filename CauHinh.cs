using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPW1
{
    internal class CauHinh
    {
        private string _MatKhau;
        public string _tenMayChu { get; set; }
        public string _tenCSDL { get; set; }
        public string _tenNguoiDung { get; set; }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        public CauHinh() { }
        public CauHinh(string matKhau, string tenmaychu, string tencsdl, string tennguoidung)
        {
            MatKhau = matKhau;
            _tenMayChu = tenmaychu;
            _tenCSDL = tencsdl;
            _tenNguoiDung = tennguoidung;
        }

        public void SetCredential(string user, string password)
        {
            _tenNguoiDung = user;
            MatKhau = password;            
        }
        public string GetConnectionString
        {
            get
            {
                return $" Sever= {_tenCSDL};  Data Base= {_tenCSDL};  Ten nguoi dung= {_tenNguoiDung}; PassWord= {MatKhau}";

            }
        }
    }
    class Phan5Bai5
    {
        public static void Phan5bai5Main()
        {
            CauHinh cauhinh = new CauHinh()
            {
                _tenMayChu = "hostsever",
                _tenCSDL = " Test sever",
                _tenNguoiDung = "Admin",
                MatKhau = " 12221",
            };
            Console.WriteLine(" chuoi ket noi");
            Console.WriteLine(cauhinh.GetConnectionString);
        }

    }
}
