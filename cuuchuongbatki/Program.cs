using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuuchuongbatki
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Nhap bang cuu chuong: ");
            //int a = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine($"{a} * {i} = {a * i}");
            //Console.ReadKey();

            //Console.Write("Nhap bang cuu chuong: ");
            //int a = int.Parse(Console.ReadLine());
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine($"{a} * {i} = {a * i}");
            //    i++;
            //}
            //Console.ReadKey();

            Console.Write("Nhap bang cuu chuong: ");
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
                i++;
            }
            while (i <= 10);
            Console.ReadKey();

        }
    }
}
