using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tong2chuso
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Nhap vao so nguyen co 2 chu so: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 10 && n <= 99)
                Console.WriteLine($"Tong 2 chu so la: {(n / 10) + (n % 10)}");
            Console.ReadKey();
        }
    }
}
