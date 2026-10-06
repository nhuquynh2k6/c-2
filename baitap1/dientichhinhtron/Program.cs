using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dientichhinhtron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao duong kinh hinh tron: ");
            double d = double.Parse(Console.ReadLine());
            if (d > 0)
                Console.WriteLine($"Dien tich hinh tron la: {Math.PI*Math.Pow((d/2),2):0.00}");
            else
                Console.WriteLine("Duong kinh hinh tron phai la so duong");
            Console.ReadKey();

        }
    }
}
