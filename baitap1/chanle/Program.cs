using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chanle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so nguyen: ");
            int soNguyen = int.Parse(Console.ReadLine());
            if (soNguyen % 2 == 0)
                Console.WriteLine($"{soNguyen} la so chan");
            else
                Console.WriteLine($"{soNguyen} la so le");
            Console.ReadKey();
        }
    }
}
