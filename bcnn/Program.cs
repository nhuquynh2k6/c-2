using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcnn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen a: ");
            int soA = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so nguyen b: ");
            int soB = int.Parse(Console.ReadLine());
            int a = Math.Abs(soA), b = Math.Abs(soB);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine($"UCLN cua {soA} va {soB} la: {a + b}");
            Console.ReadKey();
        }
    }
}
