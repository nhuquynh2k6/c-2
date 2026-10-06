using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Nhap vao ten cua ban: ");
            name = Console.ReadLine();
            Console.WriteLine($"Ten cua ban la {name}");
            Console.ReadKey();
        }
    }
}
