using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doih
{
    internal class Program
    {
        static void Main(string[] args)
            {
            Console.WriteLine("Nhap vao n: ");
            int n=int.Parse(Console.ReadLine());
                int hour = n / 3600;
                int minute = n % 3600 / 60;
                int second = n % 3600 % 60;
                Console.WriteLine($"Quy doi {n} giay thanh {hour}:{minute}:{second}");
                Console.ReadKey();
        }
    }
}
