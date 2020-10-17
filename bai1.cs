using System;
namespace BaiTH1
{
    class DIEM
    {
        private double x, y;
        public DIEM()
        {
            x = y = 0;
        }
        public DIEM(double x, double y)
        {
            this.x = x; this.y = y;
        }
        public void nhap()
        {
            Console.Write("nhap x "); x = double.Parse(Console.ReadLine());
            Console.Write("nhap y "); y = double.Parse(Console.ReadLine());
        }
        public void hien()
        {
            Console.WriteLine("toa do la{0},{1} ", x, y);
        }
        public double khoangcach(DIEM b)
        {
            return Math.Sqrt(Math.Pow(b.x - this.x, 2) + Math.Pow(b.y - this.y, 2));
        }
        static void Main(string[] args)
        {
            DIEM a = new DIEM(); a.nhap(); a.hien();
            DIEM b = new DIEM(); b.nhap(); b.hien();
            Console.WriteLine("khoang cach la" + a.khoangcach(b));
            Console.ReadKey();
        }
    }
}