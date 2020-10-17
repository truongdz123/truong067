using System;
namespace BaiTH4
{
    class SOTHUC
    {
        private double thuc, ao;
        public SOTHUC(double thuc, double ao)
        {
            this.thuc = thuc;
            this.ao = ao;
        }
        public SOTHUC()
        {
            thuc = 0;
            ao = 0;
        }
        public SOTHUC(SOTHUC t2)
        {
            this.thuc = t2.thuc;
            this.ao = t2.ao;
        }
        public void Nhap()
        {
            Console.Write("Nhap phan thuc:"); thuc = double.Parse(Console.ReadLine());
            Console.Write("Nhap phan ao:"); ao = double.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("{0}+{1}i", thuc, ao);
        }
        public static SOTHUC operator +(SOTHUC t1, SOTHUC t2)
        {
            SOTHUC t = new SOTHUC();
            t.thuc = t1.thuc + t2.thuc;
            t.ao = t1.ao + t2.ao;
            return t;
        }
        public static SOTHUC operator -(SOTHUC t1, SOTHUC t2)
        {
            SOTHUC t = new SOTHUC();
            t.thuc = t1.thuc - t2.thuc;
            t.ao = t1.ao - t2.ao;
            return t;
        }
    }
    class app
    {
        static void Main(string[] args)
        {
            SOTHUC t1 = new SOTHUC(1, 2);
            t1.hien();
            SOTHUC t2 = new SOTHUC(3, 4);
            t2.hien();
            Console.WriteLine("tong 2 so thuc");
            SOTHUC t3 = t1 + t2;
            t3.hien();
            Console.WriteLine("hieu 2 so thuc");
            SOTHUC t4 = t1 - t2;
            t4.hien();
            Console.ReadKey();
        }
    }
}