using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuattu1dennbo3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Nhap vao so nguyen: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if(i % 3 != 0 && i % 7 != 0)
            //        Console.WriteLine($"Cac so tu 1 den n khong chia het cho 3 va 7 la: {i}");
            //}
            //    Console.ReadKey();

            Console.Write("Nhap vao so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i == 3 || i == 7)
                    continue;
                Console.WriteLine("i="+i);
            }
            Console.ReadKey();
        }
        }
    }

