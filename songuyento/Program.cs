using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace songuyento
{
    class Program
    {
        static void Main(string[] args)
        {
            //int bienDem = 0;
            //Console.WriteLine("Nhap vao so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n / 2; i++)
            //    if (n % i == 0)
            //        bienDem++;
            //if (bienDem == 2)
            //    Console.WriteLine("So da cho la so nguyen to");
            //else
            //    Console.WriteLine("So da cho khong phai la so nguyen to");
            //Console.ReadKey();

            Console.WriteLine("Nhap vao so nguyen dau tien: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so nguyen cuoi cung: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"SNT se trong pham vi tu {n1} den {n2}");
            for (int i = n1 + 1; i <= n2; i++)
            {
                int flag_var = 0;
                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag_var = 1;
                        break;
                    }
                }
                if (flag_var == 0)
                    Console.WriteLine("i=" + i);
            }
            Console.ReadKey();
        }
    }
}
