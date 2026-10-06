using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tongsochusobatki
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, tong = 0;
            Console.Write("Nhap vao so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                m = n % 10;
                tong = tong + m;
                n = n / 10;
            }
                Console.WriteLine($"Tong cac chu so la: {tong}");
            Console.ReadKey();
        }
    }
}
