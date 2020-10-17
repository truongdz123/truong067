using System;

namespace BaiTH5
{
    class MaTran
    {
        private int sh, sc;
        private int[,] arr;
        private int[,] arr1;
        private int[,] arr2;

        public void nhaparr1()
        {
            Console.WriteLine("Nhap ma tran 1");
            Console.Write("Nhap so hang :"); sh = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot :"); sc = int.Parse(Console.ReadLine());
            arr = new int[sh, sc];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Nhap phan tu [{0},{1}]:", i, j); arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void nhaparr2()
        {
            Console.WriteLine("Nhap ma tran 2");
            arr1 = new int[sh, sc];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write("Nhap phan tu [{0},{1}]:", i, j); arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void congmatran()
        {
            arr2 = new int[sh, sc];
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = arr[i, j] + arr1[i, j];
                }
            }
        }
        public void Print()
        {
            Console.WriteLine("Ma Tran 1 la :");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("[{0},{1}]:{2}", i, j, arr[i, j]);
                }
            }
            Console.WriteLine("Ma Tran 2 la :");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.WriteLine("[{0},{1}]:{2}", i, j, arr1[i, j]);
                }
            }
            Console.WriteLine("Tong ma tran 1 va 2 la :");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.WriteLine("[{0},{1}]:{2}", i, j, arr2[i, j]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MaTran a = new MaTran();
            a.nhaparr1();
            a.nhaparr2();
            a.congmatran();
            a.Print();
        }
    }
}
