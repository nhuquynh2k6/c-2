using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuatsotu1denn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                Console.WriteLine($"Cac so tu 1 den n la: {i}");
            Console.ReadKey();
        }
    }
}
