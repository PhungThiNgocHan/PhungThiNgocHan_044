using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    class SinhVien
    {
        private string hoten;
        private double diemtoan;
        private double diemvan;
        private double diemngoaingu;
        private char khoihoc;
        public SinhVien()
        { }
        public string HoTen
        {
            set { hoten = value; }
            get { return hoten; }
        }
        public char KhoiHoc
        {
            set { khoihoc = value; }
            get { return khoihoc; }
        }
        public double DiemToan
        {
            set { diemtoan = value; }
            get { return diemtoan; }
        }
        public double DiemVan
        {
            set { diemvan = value; }
            get { return diemvan; }
        }
        public double DiemNgoaiNgu
        {
            set { diemngoaingu = value; }
            get { return diemngoaingu; }
        }
        public double TinhTrungBinh()
        {
            double diemTrungBinh = 0;
            switch (KhoiHoc)
            {
                case 'A':
                    diemTrungBinh = (DiemToan * 2 + DiemVan) / 3;
                    break;
                case 'B':
                    diemTrungBinh = (DiemToan + DiemVan * 2) / 3;
                    break;
                case 'C':
                    diemTrungBinh = (DiemToan + DiemVan * 2) / 3;
                    break;
                default:
                    Console.WriteLine("Khoi hoc khong hop le");
                    break;
            }
            return diemTrungBinh;
        }
        public string TinhXepLoai()
        {
            double diemTrungBinh = TinhTrungBinh();

            return (diemTrungBinh >= 5) ? "DuocLenLop" : "LuuBan";
        }
        public void InThongTin()
        {
            Console.WriteLine("Ho Ten:{HoTen}");
            Console.WriteLine("Diem Trung Binh:{TinhTrungBinh()}");
            Console.WriteLine("Tinh Xep Loai:{TinhXepLoai()}");
        }
        class Program
        {
            static void Main(string[] args)
            {
                SinhVien sinhVien1 = new SinhVien();
                Console.WriteLine("Nhap thong tin cho sinh vien 1:");
                Console.Write("Ho Ten: ");
                sinhVien1.HoTen = Console.ReadLine();
                Console.Write("Diem Toan: ");
                sinhVien1.DiemToan = double.Parse(Console.ReadLine());
                Console.Write("Diem Van: ");
                sinhVien1.DiemVan = double.Parse(Console.ReadLine());
                Console.Write("Diem Ngoai Ngu: ");
                sinhVien1.DiemNgoaiNgu = double.Parse(Console.ReadLine());
                Console.Write("Khoi Hoc A, D, C: ");
                sinhVien1.KhoiHoc = char.Parse(Console.ReadLine());
                Console.WriteLine("Thong tin sinh vien 1:");
                sinhVien1.InThongTin();
                SinhVien sinhVien2 = new SinhVien();
                Console.WriteLine("Thong tin sinh vien 2:");
                sinhVien2.InThongTin();
                Console.ReadLine();
            }
        }
    }
}
