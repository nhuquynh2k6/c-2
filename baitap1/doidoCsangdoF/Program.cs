using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doidoCsangdoF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao do C: ");
            float doC = float.Parse(Console.ReadLine());
            Console.WriteLine($"Quy doi thanh {(doC*1.8+32)} do F");
            Console.ReadKey();
        }
    }
}
