using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT02
{
    class ChuNhat
    {
        private double rong;
        private double dai;

        public ChuNhat()
        {

        }

        public ChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public double tinhDienTich()
        {
            return dai * rong;
        }

        public double tinhChuVi()
        {
            return (dai + rong) * 2;
        }

        public virtual void xuat()
        {
            Console.WriteLine($"Chieu dai: {dai}");
            Console.WriteLine($"Chieu rong: {rong}");
            Console.WriteLine($"Dien tich: {tinhDienTich()}");
            Console.WriteLine($"Chu vi: {tinhChuVi()}");
        }
    }

    class Vuong : ChuNhat
    {
        public Vuong(double canh) : base(canh, canh)
        {

        }

        public override void xuat()
        {

            Console.WriteLine($"Dien tich: {tinhDienTich()}");
            Console.WriteLine($"Chu vi: {tinhChuVi()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai hinh chu nhat:");
            double daiCN = double.Parse(Console.ReadLine());

            Console.Write("Nhap chieu rong hinh chua nhat:");
            double rongCN = double.Parse(Console.ReadLine());

            Console.Write("Nhap canh hinh vuong:");
            double canhHV = double.Parse(Console.ReadLine());

            ChuNhat cn = new ChuNhat(daiCN, rongCN);
            ChuNhat vu = new Vuong(canhHV);

            Console.WriteLine("\nThong tin hinh chu nhat:");
            cn.xuat();

            Console.WriteLine("\nThong tin hinh vuong:");
            vu.xuat();

            Console.ReadLine();
        }
    }
}